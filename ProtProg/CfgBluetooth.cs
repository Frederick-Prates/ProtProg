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

        // Configura Combo Boxes para um estado inicial e desabilita o botão "Conectar"
        void Estado_inicial()
        {
            Cb_BaudRate.Items.AddRange(new string[] { "4800", "9600", "14400", "19200", "38400" });
            Cb_BaudRate.SelectedItem = "9600";
            Cb_COM.Items.Add("Nenhuma");
            Cb_COM.SelectedItem = "Nenhuma";
            Bt_Conectar.Enabled = false;
        }

        // Botão para conectar a serial 
        private void Bt_Conectar_Click(object sender, EventArgs e)
        {
            // Se conexão já estiver aberta...
            if (Principal.ProtBT.IsOpen)
            {
                try
                {
                    Principal.ProtBT.Close(); // Encerrra conexão
                    Bt_Conectar.Text = "Conectar"; // Muda texto do botão novamente para Conetar
                    this.Hide(); //Esconde janela
                    MessageBox.Show("Desconectou com sucesso"); // Exibe msg de sucesso na desconexão.
                }
                //Se algo der errado...
                catch (Exception e1)
                {
                    MessageBox.Show("Não foi possível desconectar." + e1);
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
                catch (Exception e2)
                {
                    MessageBox.Show("Algo deu errado... Verifique se a porta e o BR estao corretos." + e2);
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
                BluetoothDeviceInfo selected = dialog.SelectedDevice;
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
                bool pair = Pareamento(selected);
                AtualizaStatus(selected, pair);
            }
        }

        // Atualiza labels com o status da conexão bluetooth
        private void AtualizaStatus(BluetoothDeviceInfo selected, bool pair)
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
            Lb_DispRes.Text = selected.DeviceName; //Nome do Dispositivo
            Lb_EndeRes.Text = Convert.ToString(selected.DeviceAddress); // Endereço do dispositivo (MAC Adress)
        }

        // Incia pareamento com o Protótipo
        bool Pareamento(BluetoothDeviceInfo selected)
        {
            //Realiza autenticação com o PIN
            bool pareado = BluetoothSecurity.PairRequest(selected.DeviceAddress, "1234");
            // O segundo argumento do PairRequest é o PIN.
            if (pareado)
            {
                // Feedback para o usuário informando que o dispositivo foi pareado.
                MessageBox.Show(selected.DeviceName + ": Dispositivo pareado!");
                return (true);
            }
            else
            {
                // Feedback para o usuário informando que algum problema aconteceu e não foi pareado.
                MessageBox.Show(selected.DeviceName + ": Algum problema ocorreu. Dispositivo não pareado.");
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
            Cb_COM.Items.Clear();
            Cb_COM.Items.AddRange(SerialPort.GetPortNames());
            Cb_COM.SelectedItem = Cb_COM.Items[0];
        }
    }
}
