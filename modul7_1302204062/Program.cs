using System;

namespace modul7_1302204062
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Config KonfigBankTransfer = new Config();
            Console.WriteLine("Language: ");
            string bahasa = Console.ReadLine();
            int jumlahTransfer, biayaTransfer = 0, i = 0,  totalBiaya;

            if (bahasa == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
                jumlahTransfer = int.Parse(Console.ReadLine());
                if (jumlahTransfer <= KonfigBankTransfer.conf.transfer.threshold)
                {
                    biayaTransfer = KonfigBankTransfer.conf.transfer.low_fee;
                } else if (jumlahTransfer > KonfigBankTransfer.conf.transfer.threshold)
                {
                    biayaTransfer = KonfigBankTransfer.conf.transfer.high_fee;
                }
                totalBiaya = jumlahTransfer + biayaTransfer;
                Console.WriteLine("Transfer fee = " + biayaTransfer + " Total amount = " + totalBiaya);
                Console.WriteLine("Select transfer method: ");
                foreach(string metode in KonfigBankTransfer.conf.methods)
                {
                    i++;
                    Console.WriteLine(i + ". " +  metode);
                }
                int metodeTransfer = int.Parse(Console.ReadLine());
                Console.WriteLine("Please type " + KonfigBankTransfer.conf.confirmation.en + " to confirm the transaction: ");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi == KonfigBankTransfer.conf.confirmation.en)
                {
                    Console.WriteLine("The transfer is completed");
                } else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            } else if (bahasa == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
                jumlahTransfer = int.Parse(Console.ReadLine());
                if (jumlahTransfer <= KonfigBankTransfer.conf.transfer.threshold)
                {
                    biayaTransfer = KonfigBankTransfer.conf.transfer.low_fee;
                }
                else if (jumlahTransfer > KonfigBankTransfer.conf.transfer.threshold)
                {
                    biayaTransfer = KonfigBankTransfer.conf.transfer.high_fee;
                }
                totalBiaya = jumlahTransfer + biayaTransfer;
                Console.WriteLine("Biaya Transfer = " + biayaTransfer + " Total Biaya = " + totalBiaya);
                Console.WriteLine("Pilih metode transfer: ");
                foreach (string metode in KonfigBankTransfer.conf.methods)
                {
                    i++;
                    Console.WriteLine(i + ". " + metode);
                }
                int metodeTransfer = int.Parse(Console.ReadLine());
                Console.WriteLine("Ketik " + KonfigBankTransfer.conf.confirmation.id + " untuk mengonfirmasi transaksi: ");
                string konfirmasi = Console.ReadLine();
                if (konfirmasi == KonfigBankTransfer.conf.confirmation.id)
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }

        }
    }
}