using System;
using System.Windows.Forms;
using System.IO.Ports;
using InTheHand.Net.Sockets;
using InTheHand.Windows.Forms;
using InTheHand.Net.Bluetooth;

namespace ProtProg
{
    public partial class CfgBluetooth : Form
    {
        public CfgBluetooth()
        {
            InitializeComponent();
            Estado_inicial();
        }

        private bool enviar_Principal; // Variavel booleana usada como intermediária para modificar o valor de Bt_Enviar.Enabled 
        // da janela Principal.

        // Instancia para enviar valor de enviar_Principal para janela Principal
        public bool Enviar_Principal { get => enviar_Principal; set => enviar_Principal = value; }

        // Configura Combo Boxes para um estado inicial e desabilita o botão "Conectar"
        void Estado_inicial()
        {
            Cb_BaudRate.Items.AddRange(new string[] { "4800", "9600", "14400", "19200", "38400" });
            Cb_BaudRate.SelectedItem = "9600";
            Cb_COM.Items.Add("Nenhuma");
            Cb_COM.SelectedItem = "Nenhuma";
            Bt_Conectar.Enabled = false;
        }
        
        // Verifica o status do Bluetooth
        private void DisplayBluetoothRadio()
        {
            BluetoothRadio myRadio = BluetoothRadio.PrimaryRadio;
            // Se igual a null então dispositivo está desligado.
            if (myRadio == null)
            {
                Lb_StatusBT1.Text = "Desativado"; // Mostra status como desativado
                Lb_StatusBT1.ForeColor = System.Drawing.Color.Red; // Mostra desativado na cor vermelha
                Lb_EndBT1.Text = ""; // Limpa endereço
                Lb_NomeBT1.Text = ""; // Limpa Nome 
                Lb_ModoBT1.Text = ""; // Limpa Modo
                Lb_ClasseBT1.Text = ""; // Limpa Classe
                MessageBox.Show("Bluetooth desativado. É necessário que você o ative pelo Windows."); // Mostra mensagem alertando usuário.
            }
            // Se estiver ligado então..
            else
            {
                RadioMode mode = myRadio.Mode; //Verifica modo do Bluetooth
                // myRadio.Mode = RadioMode.Discoverable; // Configura modo para Discoverable
                Lb_StatusBT1.Text = "Ativado"; //Atualiza status como Ativado
                Lb_StatusBT1.ForeColor = System.Drawing.Color.Green; // Muda cor de ativado para verde
                Lb_EndBT1.Text = Convert.ToString(myRadio.LocalAddress); // Exibe mac address local
                Lb_NomeBT1.Text = myRadio.Name; // Exibe nome do dispositivo local
                Lb_ModoBT1.Text = mode.ToString(); // Exibe modo do Bluetooth
                Lb_ClasseBT1.Text = myRadio.ClassOfDevice.ToString(); // Exibe classe do dispositivo local
            }
        }

        // Botão para conectar a serial 
        public void Bt_Conectar_Click(object sender, EventArgs e)
        {
            // Se conexão já estiver aberta...
            if (Principal.ProtBT.IsOpen)
            {
                try
                {
                    Principal.ProtBT.Close(); // Encerra conexão
                    Bt_Conectar.Text = "Conectar"; // Muda texto do botão novamente para Conectar
                    this.Hide(); //Esconde janela
                    MessageBox.Show("Desconectou com sucesso"); // Exibe mensagem de sucesso na desconexão.
                    Enviar_Principal = true; //Habilita botão de Envio da janela Principal.
                }
                //Se algo der errado...
                catch (Exception c1)
                {
                    MessageBox.Show("Não foi possível desconectar.");
                    Console.WriteLine(c1);
                }
            }
            // Se conexão não estiver aberta...
            else
            {
                try
                {
                    Principal.ProtBT.BaudRate = Convert.ToInt32(Cb_BaudRate.SelectedItem); // Copia BaudRate
                    Principal.ProtBT.PortName = Convert.ToString(Cb_COM.SelectedItem);  // Copia COM
                    Principal.ProtBT.Open(); // Abre conexão serial
                    MessageBox.Show("Conectou com sucesso"); // Exibe msg de sucesso na conexão.
                    Bt_Conectar.Text = "Desconectar"; // Altera texto do botão para Desconectar.
                    this.Hide(); //Esconde janela
                }
                //Se algo der errado...
                catch (Exception c2)
                {
                    MessageBox.Show("Algo deu errado... Verifique se a porta está correta.");
                    Console.WriteLine(c2);
                }
            }
        }
        private void Bt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha janela
        }

        // A dialog da 32Feet permite enchergar e selecionar dispositivos bluetooth que já estiveram conectados
        // e também aqueles que estão dentro do alcance.
        void Dialog32feet()
        {
            SelectBluetoothDeviceDialog dialog = new SelectBluetoothDeviceDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BluetoothDeviceInfo Selecionado = dialog.SelectedDevice;
                // O BluetoothDeviceInfo contem:
                // DeviceName - Nome do dispositivo
                // DeviceAddress - Endereço do dispositivo
                // Connected - Boleano que informa o estado da conexão se está ativa ou não.
                // Authenticated - Boleano que informa se o dispositivo foi autenticado.
                // ClassOfDevice - Determina o tipo de dispositivo(PC, smartphone,Fones de ouvido)
                // (...)device.ClassOfDevice.MajorDevice.ToString() retornará o tipo de dispositivo como string
                // InstalledServices - Retorna uma lista de serviços do bluetooth em execução.
                // LastSeen - Armazena a data e hora em que o dispositivo foi visto pela ultima vez.
                // LastUsed - Armazena a data e hora em que o dispositivo foi utilizado pela ultima vez.
                // Remembered - Boleano que especifica se o dispositivo ficou salvo no sistema.
                // Rssi - Retorna a força do sinal da conexão. Suportado apenas em algumas plataformas.
                bool pair = Pareamento(Selecionado);
                // Atualiza informações do dispositivo
                AtualizaStatus(Selecionado, pair);
                // Cria serial
                Cria_BTSerialCOM(Selecionado);
            }
        }

        // Cria serial para o dispositivo pareado
        private void Cria_BTSerialCOM(BluetoothDeviceInfo Selecionado)
        {
            bool Estado = true;
            try
            {
                Selecionado.SetServiceState(BluetoothService.SerialPort, Estado, true);
                AtualizarListaCOM();
            }
            catch (Exception c3)
            {
                AtualizarListaCOM();
                Console.WriteLine(c3);
            }
        }

        // Atualiza labels com o status da conexão bluetooth
        private void AtualizaStatus(BluetoothDeviceInfo Selecionado, bool pair)
        {
            //Verifica se está pareado
            if (pair)
            {
                Lb_ParRes.Text = "Sim";
                Lb_ParRes.ForeColor = System.Drawing.Color.Green;
                Bt_Conectar.Enabled = true;
            }
            else
            {
                Lb_ParRes.Text = "Não";
                Lb_ParRes.ForeColor = System.Drawing.Color.Red;
                Bt_Conectar.Enabled = false;
            }
            Lb_DispRes.Text = Selecionado.DeviceName; //Nome do Dispositivo
            Lb_EndeRes.Text = Convert.ToString(Selecionado.DeviceAddress); // Endereço do dispositivo (MAC Adress)
            Lb_TipoRes.Text = Selecionado.ClassOfDevice.MajorDevice.ToString(); // Tipo de dispositivo
        }

        // Incia pareamento com o Protótipo
        bool Pareamento(BluetoothDeviceInfo Selecionado)
        {
            //Realiza autenticação com o PIN
            bool pareado = BluetoothSecurity.PairRequest(Selecionado.DeviceAddress, "1234");
            // O segundo argumento do PairRequest é o PIN.
            if (pareado)
            {
                // Feedback para o usuário informando que o dispositivo foi pareado.
                MessageBox.Show(" Dispositivo " + Selecionado.DeviceName + " pareado!");
                return (true);
            }
            else
            {
                // Feedback para o usuário informando que algum problema aconteceu e não foi pareado.
                MessageBox.Show("Algum problema ocorreu. Dispositivo " + Selecionado.DeviceName + " não pareado.");
                return (false);
            }
        }

        // Abre dialog da 32feet para o usuário selecionar o dispositivo bluetooth
        // É o botão Localizar da UI
        private void Bt_Dialog_Click(object sender, EventArgs e)
        {
            Dialog32feet();
        }

        // Atualiza lista de Portas COM disponíveis 
        private void Bt_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaCOM();
        }

        private void AtualizarListaCOM()
        {
            Cb_COM.Items.Clear(); // Limpa a lista de COMs
            Cb_COM.Items.AddRange(SerialPort.GetPortNames()); // Adiciona lista de COMs disponíveis
            Cb_COM.Items.Add("Nenhuma"); // Adiciona item "Nenhuma"
            try
            {
                Cb_COM.SelectedItem = Cb_COM.Items[0]; // Seleciona segundo item da lista
            }
            catch (Exception c4) { Console.WriteLine(c4); }
        }

        // Quando clickar no Botão Atualizar Status ele verifica o status do bluetooth local
        private void Bt_AtualizarStatusBT_Click(object sender, EventArgs e)
        {
            DisplayBluetoothRadio();
        }

        // Quando a janela de configuração de conexão é aberta pela primeira vez, é verificado o status do bluetooth
        private void CfgBluetooth_Shown(object sender, EventArgs e)
        {
            DisplayBluetoothRadio();
        }
    }
}
