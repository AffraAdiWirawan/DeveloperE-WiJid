using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;

namespace insert_read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.Write("\nKetik K untuk Terhubung ke Database atau E untuk keluar dari Aplikasi: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                Console.Clear();
                                Console.WriteLine("Masukkan Database yang dituju kemudian klik enter: ");
                                string db = Console.ReadLine();

                                // Autentikasi pengguna
                                string username, password;
                                do
                                {
                                    Console.WriteLine("Masukkan Username:");
                                    username = Console.ReadLine();
                                    Console.WriteLine("Masukkan Password:");
                                    password = Console.ReadLine();
                                } while (username != "ADM01" || password != "ADMINADMIN");

                                SqlConnection conn = null;
                                string strKoneksi = "Data source = DESKTOP-O0EE9MU\\AFFRAADIWIRAWAN;" +
                                    "initial catalog = {0}; " +
                                    "User ID = sa; password = 1234567890";
                                conn = new SqlConnection(string.Format(strKoneksi, db));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Kelola Infaq");
                                        Console.WriteLine("2. Kelola Aktivitas");
                                        Console.WriteLine("3. Kelola Transaksi");
                                        Console.WriteLine("4. Cari Data Berdasarkan Rentang Tanggal");
                                        Console.WriteLine("5. Keluar");
                                        Console.WriteLine("\nEnter your choice (1-4): ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    while (true)
                                                    {
                                                        Console.WriteLine("Menu Infaq");
                                                        Console.WriteLine("1. Lihat Data Infaq");
                                                        Console.WriteLine("2. Tambah Data Infaq");
                                                        Console.WriteLine("3. Hapus Data Infaq");
                                                        Console.WriteLine("4. Edit Data Infaq");
                                                        Console.WriteLine("\nENTER. Kembali ke Menu Utama");
                                                        Console.WriteLine("\nEnter your choice (1-5): ");
                                                        char choice = Convert.ToChar(Console.ReadLine());
                                                        switch (choice)
                                                        {
                                                            case '1':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Data Infaq\n");
                                                                    pr.viewInfaq(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            case '2':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Tambah Data Infaq\n");
                                                                    pr.addInfaq(conn);
                                                                }
                                                                break;
                                                            case '3':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Hapus Data Infaq\n");
                                                                    pr.deleteInfaq(conn);
                                                                }
                                                                break;
                                                            case '4':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Edit Data Infaq\n");
                                                                    pr.editInfaq(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            default:
                                                                Console.Clear();
                                                                Console.WriteLine("\nInvalid option");
                                                                break;
                                                        }
                                                    }
                                                }
                                                break;
                                            case '2':
                                                {
                                                    Console.Clear();
                                                    while (true)
                                                    {
                                                        Console.WriteLine("Menu Aktivitas");
                                                        Console.WriteLine("1. Lihat Data Aktivitas");
                                                        Console.WriteLine("2. Tambah Data Aktivitas");
                                                        Console.WriteLine("3. Hapus Data Aktivitas");
                                                        Console.WriteLine("4. Edit Data Aktivitas");
                                                        Console.WriteLine("\nENTER. Kembali ke Menu Utama");
                                                        Console.WriteLine("\nEnter your choice (1-5) or Enter: ");
                                                        char choice = Convert.ToChar(Console.ReadLine());
                                                        switch (choice)
                                                        {
                                                            case '1':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Data Aktivitas\n");
                                                                    pr.viewAktivitas(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            case '2':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Tambah Data Aktivitas\n");
                                                                    pr.addAktivitas(conn);
                                                                }
                                                                break;
                                                            case '3':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Hapus Data Aktivitas\n");
                                                                    pr.deleteAktivitas(conn);
                                                                }
                                                                break;
                                                            case '4':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Edit Data Aktivitas\n");
                                                                    pr.editAktivitas(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            default:
                                                                Console.Clear();
                                                                Console.WriteLine("\nInvalid option");
                                                                break;
                                                        }
                                                    }
                                                }
                                                break;
                                            case '3':
                                                {
                                                    Console.Clear();
                                                    while (true)
                                                    {
                                                        Console.WriteLine("Menu Transaksi");
                                                        Console.WriteLine("1. Lihat Data Transaksi");
                                                        Console.WriteLine("2. Tambah Data Transaksi");
                                                        Console.WriteLine("3. Hapus Data Transaksi");
                                                        Console.WriteLine("4. Edit Data Transaksi");
                                                        Console.WriteLine("\nENTER. Kembali ke Menu Utama");
                                                        Console.WriteLine("\nEnter your choice (1-4) or Enter: ");
                                                        char choice = Convert.ToChar(Console.ReadLine());
                                                        switch (choice)
                                                        {
                                                            case '1':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Data Transaksi\n");
                                                                    pr.viewTransaksi(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            case '2':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Tambah Data Transaksi\n");
                                                                    pr.addTransaksi(conn);
                                                                }
                                                                break;
                                                            case '3':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Hapus Data Transaksi\n");
                                                                    pr.deleteTransaksi(conn);
                                                                }
                                                                break;
                                                            case '4':
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Edit Data Transaksi\n");
                                                                    pr.editTransaksi(conn);
                                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                                    Console.ReadKey();
                                                                }
                                                                break;
                                                            default:
                                                                Console.Clear();
                                                                Console.WriteLine("\nInvalid option");
                                                                break;
                                                        }
                                                    }
                                                }
                                                break;
                                            case '4':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Data Saldo\n");
                                                    pr.CalculateSaldo(conn);
                                                    Console.WriteLine("\nTekan tombol apapun untuk melanjutkan...");
                                                    Console.ReadKey();
                                                }
                                                break;
                                            case '5':
                                                return;
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\nInvalid option");
                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }

                            }
                        case 'E':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid Option");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak Dapat Mengakses Database Tersebut\n");
                    Console.ResetColor();
                }
            }
        }



        //==================================================================================================================================//
        //==================================================================================================================================//
        //==================================================================================================================================//

        public void CalculateSaldo(SqlConnection con)
        {
            // Tampilkan tanggal yang ada
            Console.WriteLine("Tanggal yang tersedia untuk DATA INFAQ:");
            SqlCommand cmdTanggal = new SqlCommand("SELECT DISTINCT Tanggal_aktivitas FROM Aktivitas ORDER BY Tanggal_aktivitas", con);
            SqlDataReader readerTanggal = cmdTanggal.ExecuteReader();
            while (readerTanggal.Read())
            {
                Console.WriteLine("- " + readerTanggal.GetDateTime(0).ToString("yyyy-MM-dd"));
            }
            readerTanggal.Close();

            // Meminta pengguna untuk memilih tanggal
            Console.Write("Masukkan tanggal (yyyy-MM-dd): ");
            string tanggalInput = Console.ReadLine();

            // Query untuk memilih data berdasarkan tanggal yang dimasukkan pengguna
            SqlCommand cmd = new SqlCommand("SELECT Tanggal_aktivitas, Pemasukan, Pengeluaran FROM Aktivitas WHERE Tanggal_aktivitas = @tanggal", con);
            cmd.Parameters.AddWithValue("@tanggal", tanggalInput);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-10} |", "Tanggal_aktivitas", "Pemasukan", "Pengeluaran", "Sisa Saldo");
                Console.WriteLine(new string('-', 55)); // Garis pemisah

                decimal saldo = 0;

                while (reader.Read())
                {
                    decimal pemasukan = reader.GetSqlMoney(1).ToDecimal();
                    decimal pengeluaran = reader.GetSqlMoney(2).ToDecimal();
                    saldo += pemasukan - pengeluaran;

                    Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-10} |",
                        reader.GetDateTime(0).ToString("yyyy-MM-dd"),
                        pemasukan,
                        pengeluaran,
                        saldo);
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data aktivitas untuk tanggal tersebut.");
            }
            reader.Close();
        }



        //==================================================================================================================================//
        //==================================================================================================================================//
        //==================================================================================================================================//


        // LIHAT INFAQ
        public void viewInfaq(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Infaq", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} |", "kd_infaq", "tanggal_infaq", "saldo_infaq");
                Console.WriteLine(new string('-', 44)); // Garis pemisah

                while (reader.Read())
                {
                    Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} |",
                        reader.GetInt32(0),
                        reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        reader.GetSqlMoney(2));
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data infaq.");
            }
            reader.Close();
        }

        // LIHAT AKTIVITAS
        public void viewAktivitas(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Aktivitas", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("| {0,-10} | {1,-20} | {2,-10} | {3,-12} | {4,-15} | {5,-10} |", "kd_aktivitas", "nama_aktivitas", "Pemasukan", "Pengeluaran", "Tanggal_aktivitas", "kd_infaq");
                Console.WriteLine(new string('-', 77)); // Garis pemisah

                while (reader.Read())
                {
                    Console.WriteLine("| {0,-10} | {1,-20} | {2,-10} | {3,-12} | {4,-15} | {5,-10} |",
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetSqlMoney(2),
                        reader.GetSqlMoney(3),
                        reader.GetDateTime(4).ToString("yyyy-MM-dd"),
                        reader.GetInt32(5));
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data aktivitas.");
            }
            reader.Close();
        }

        // LIHAT TRANSAKSI
        public void viewTransaksi(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Transaksi", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} | {3,-20} | {4,-10} |", "kd_Transaksi", "tanggal_transaksi", "nominal_transaksi", "jenis_transaksi", "kd_infaq");
                Console.WriteLine(new string('-', 75)); // Garis pemisah

                while (reader.Read())
                {
                    Console.WriteLine("| {0,-10} | {1,-15} | {2,-15} | {3,-20} | {4,-10} |",
                        reader.GetInt32(0),
                        reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        reader.GetDecimal(2),
                        reader.GetString(3),
                        reader.GetInt32(4));
                }
            }
            else
            {
                Console.WriteLine("Tidak ada data transaksi.");
            }
            reader.Close();
        }


        //==================================================================================================================================//
        //==================================================================================================================================//
        //==================================================================================================================================//

        // ADD INFAQ
        public void addInfaq(SqlConnection con)
        {
            Console.WriteLine("Tekan 'E' untuk keluar atau lanjutkan dengan memasukkan Tanggal Infaq (yyyy-MM-dd): ");

            string input = Console.ReadLine();
            if (input.ToUpper() == "E")
            {
                Console.WriteLine("Keluar dari penambahan data infaq.");
                return;
            }

            DateTime tanggal_infaq;
            while (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal_infaq))
            {
                Console.WriteLine("Format tanggal tidak valid. Masukkan kembali (yyyy-MM-dd), atau tekan 'e' untuk keluar: ");
                input = Console.ReadLine();
                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Keluar dari penambahan data infaq.");
                    return;
                }
            }

            Console.WriteLine("Masukkan Saldo Infaq: ");
            decimal saldo_infaq;
            while (!decimal.TryParse(Console.ReadLine(), out saldo_infaq))
            {
                Console.WriteLine("Saldo Infaq tidak valid. Masukkan kembali: ");
            }

            // Menampilkan data yang baru saja dimasukkan
            Console.WriteLine("Data yang akan disimpan:");
            Console.WriteLine("Tanggal Infaq: " + tanggal_infaq.ToString("yyyy-MM-dd"));
            Console.WriteLine("Saldo Infaq: " + saldo_infaq.ToString());

            Console.WriteLine("Apakah data yang dimasukkan sudah benar? (Y/N): ");
            string confirmation = Console.ReadLine();
            if (confirmation.ToUpper() == "Y")
            {
                string query = "INSERT INTO infaq (tanggal_infaq, saldo_infaq) " +
                                "VALUES (@tanggal_infaq, @saldo_infaq)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tanggal_infaq", tanggal_infaq);
                cmd.Parameters.AddWithValue("@saldo_infaq", saldo_infaq); // Tidak perlu SqlDbType.Money di sini
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data Infaq berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Infaq.");
                }
            }
            else
            {
                Console.WriteLine("Data Infaq tidak disimpan.");
            }
        }

        // TAMBAH AKTIVITAS
        public void addAktivitas(SqlConnection con)
        {
            string nama_aktivitas;
            decimal pemasukan;
            decimal pengeluaran;
            DateTime tanggal_aktivitas;
            int kd_infaq;

            // Input Nama Aktivitas
            do
            {
                Console.WriteLine("Masukkan Nama Aktivitas atau tekan 'E' untuk keluar: ");
                nama_aktivitas = Console.ReadLine();

                if (nama_aktivitas.ToUpper() == "E")
                {
                    Console.WriteLine("Keluar dari pengisian aktivitas.");
                    return; // Keluar dari metode jika pengguna memilih untuk keluar
                }

                if (string.IsNullOrWhiteSpace(nama_aktivitas))
                {
                    Console.WriteLine("Nama Aktivitas tidak boleh kosong. Silakan masukkan lagi.");
                }
            } while (string.IsNullOrWhiteSpace(nama_aktivitas));

            // Input Pemasukan
            do
            {
                Console.WriteLine("Masukkan Pemasukan: ");
                string inputPemasukan = Console.ReadLine();
                if (!decimal.TryParse(inputPemasukan, out pemasukan))
                {
                    Console.WriteLine("Pemasukan tidak valid. Masukkan angka yang benar.");
                }
            } while (pemasukan <= 0);

            // Input Pengeluaran
            do
            {
                Console.WriteLine("Masukkan Pengeluaran: ");
                string inputPengeluaran = Console.ReadLine();
                if (!decimal.TryParse(inputPengeluaran, out pengeluaran))
                {
                    Console.WriteLine("Pengeluaran tidak valid. Masukkan angka yang benar.");
                }
            } while (pengeluaran <= 0);

            // Input Tanggal Aktivitas
            do
            {
                Console.WriteLine("Masukkan Tanggal Aktivitas (yyyy-MM-dd): ");
                string inputTanggal = Console.ReadLine();
                if (!DateTime.TryParseExact(inputTanggal, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal_aktivitas))
                {
                    Console.WriteLine("Format tanggal tidak valid. Masukkan kembali (yyyy-MM-dd).");
                }
            } while (tanggal_aktivitas == DateTime.MinValue);

            // Input Kode Infaq
            do
            {
                Console.WriteLine("Masukkan Kode Infaq: ");
                string inputKodeInfaq = Console.ReadLine();
                if (!int.TryParse(inputKodeInfaq, out kd_infaq))
                {
                    Console.WriteLine("Kode Infaq tidak valid. Masukkan angka yang benar.");
                }
            } while (kd_infaq <= 0);

            // Menampilkan data yang baru saja dimasukkan
            Console.WriteLine("Data yang akan disimpan:");
            Console.WriteLine("Nama Aktivitas: " + nama_aktivitas);
            Console.WriteLine("Pemasukan: " + pemasukan);
            Console.WriteLine("Pengeluaran: " + pengeluaran);
            Console.WriteLine("Tanggal Aktivitas: " + tanggal_aktivitas.ToString("yyyy-MM-dd"));
            Console.WriteLine("Kode Infaq: " + kd_infaq);

            Console.WriteLine("Apakah data yang dimasukkan sudah benar? (Y/N): ");
            string confirmation = Console.ReadLine();
            if (confirmation.ToUpper() == "Y")
            {
                string query = "INSERT INTO Aktivitas (nama_aktivitas, Pemasukan, Pengeluaran, Tanggal_aktivitas, kd_infaq) " +
                                "VALUES (@nama_aktivitas, @pemasukan, @pengeluaran, @tanggal_aktivitas, @kd_infaq)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nama_aktivitas", nama_aktivitas);
                cmd.Parameters.AddWithValue("@pemasukan", pemasukan);
                cmd.Parameters.AddWithValue("@pengeluaran", pengeluaran);
                cmd.Parameters.AddWithValue("@tanggal_aktivitas", tanggal_aktivitas);
                cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data Aktivitas berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Aktivitas.");
                }
            }
            else
            {
                Console.WriteLine("Data Aktivitas tidak disimpan.");
            }
        }



        // ADD TRANSAKSI
        public void addTransaksi(SqlConnection con)
        {
            string input;

            // Masukkan Tanggal Transaksi
            Console.WriteLine("Masukkan Tanggal Transaksi (yyyy-MM-dd) atau tekan 'E' untuk keluar: ");
            input = Console.ReadLine();

            // Check if the input is 'e' to exit
            if (input.ToUpper() == "E")
            {
                Console.WriteLine("Keluar dari pengisian transaksi.");
                return; // Exit the method
            }

            DateTime tanggal_transaksi;
            while (string.IsNullOrWhiteSpace(input) || !DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal_transaksi))
            {
                Console.WriteLine("Input tidak boleh kosong dan harus berformat (yyyy-MM-dd). Masukkan kembali: ");
                input = Console.ReadLine();
            }

            // Masukkan Nominal Transaksi
            Console.WriteLine("Masukkan Nominal Transaksi: ");
            decimal nominal_transaksi;
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !decimal.TryParse(input, out nominal_transaksi))
            {
                Console.WriteLine("Input tidak boleh kosong dan harus berupa angka. Masukkan kembali: ");
                input = Console.ReadLine();
            }

            // Masukkan Jenis Transaksi
            Console.WriteLine("Masukkan Jenis Transaksi (Pemasukan/Pengeluaran): ");
            string jenis_transaksi;
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || (!input.Equals("Pemasukan", StringComparison.OrdinalIgnoreCase) && !input.Equals("Pengeluaran", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Input tidak boleh kosong dan harus di antara 'Pemasukan' atau 'Pengeluaran'. Masukkan kembali: ");
                input = Console.ReadLine();
            }
            jenis_transaksi = input.Trim();

            // Masukkan kd_infaq
            Console.WriteLine("Masukkan kd_infaq: ");
            int kd_infaq;
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out kd_infaq))
            {
                Console.WriteLine("Input tidak boleh kosong dan harus berupa angka. Masukkan kembali: ");
                input = Console.ReadLine();
            }

            // Masukkan kd_aktivitas
            Console.WriteLine("Masukkan kd_aktivitas: ");
            int kd_aktivitas;
            input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out kd_aktivitas))
            {
                Console.WriteLine("Input tidak boleh kosong dan harus berupa angka. Masukkan kembali: ");
                input = Console.ReadLine();
            }

            // Menampilkan data yang baru saja dimasukkan
            Console.WriteLine("Data yang akan disimpan:");
            Console.WriteLine("Tanggal Transaksi: " + tanggal_transaksi.ToString("yyyy-MM-dd"));
            Console.WriteLine("Nominal Transaksi: " + nominal_transaksi.ToString());
            Console.WriteLine("Jenis Transaksi: " + jenis_transaksi);
            Console.WriteLine("kd_infaq: " + kd_infaq.ToString());
            Console.WriteLine("kd_aktivitas: " + kd_aktivitas.ToString());

            // Konfirmasi penyimpanan data
            Console.WriteLine("Apakah data yang dimasukkan sudah benar? (Y/N): ");
            string confirmation = Console.ReadLine();

            if (confirmation.ToUpper() == "Y")
            {
                string query = "INSERT INTO Transaksi (tanggal_transaksi, nominal_transaksi, jenis_transaksi, kd_infaq, kd_aktivitas) " +
                                "VALUES (@tanggal_transaksi, @nominal_transaksi, @jenis_transaksi, @kd_infaq, @kd_aktivitas)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@tanggal_transaksi", tanggal_transaksi);
                cmd.Parameters.AddWithValue("@nominal_transaksi", nominal_transaksi);
                cmd.Parameters.AddWithValue("@jenis_transaksi", jenis_transaksi);
                cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data Infaq berhasil ditambahkan.");
                }
                else
                {
                    Console.WriteLine("Gagal menambahkan data Infaq.");
                }
            }
            else
            {
                Console.WriteLine("Data Infaq tidak disimpan.");
            }
        }


        //==================================================================================================================================//
        //==================================================================================================================================//
        //==================================================================================================================================//

        // HAPUS INFAQ
        public void deleteInfaq(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Infaq sebelum menghapus
                Console.WriteLine("Data Infaq sebelum dihapus:");
                viewInfaq(con);

                Console.WriteLine("Masukkan kd Infaq yang ingin dihapus atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Batal menghapus data Infaq.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk kembali
                }

                int kd_infaq;
                if (!int.TryParse(input, out kd_infaq))
                {
                    Console.WriteLine("Kode Infaq tidak valid.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_infaq yang valid
                }

                // Validasi apakah kd_infaq yang dipilih benar-benar ada di database
                if (!IsKdInfaqExists(con, kd_infaq))
                {
                    Console.WriteLine("Kode Infaq tidak ditemukan.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_infaq yang valid
                }

                Console.WriteLine($"Apakah Anda yakin ingin menghapus data Infaq dengan kd {kd_infaq}? (Y/N): ");
                string confirmation = Console.ReadLine().ToUpper();
                if (confirmation == "Y")
                {
                    string query = "DELETE FROM Infaq WHERE kd_infaq = @kd_infaq";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data Infaq berhasil dihapus.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data Infaq.");
                    }
                    break; // Keluar dari loop setelah penghapusan berhasil atau gagal
                }
                else if (confirmation == "N")
                {
                    Console.WriteLine("Batal menghapus data Infaq.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk membatalkan penghapusan
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
        }


        // HAPUS AKTIVITAS
        private bool IsKdAktivitasExists(SqlConnection con, int kd_aktivitas)
        {
            string query = "SELECT COUNT(*) FROM Aktivitas WHERE kd_aktivitas = @kd_aktivitas";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // Method untuk menghapus aktivitas
        public void deleteAktivitas(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Aktivitas sebelum menghapus
                Console.WriteLine("Data Aktivitas sebelum dihapus:");
                viewAktivitas(con);

                Console.WriteLine("Masukkan kd Aktivitas yang ingin dihapus atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Batal menghapus data Aktivitas.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk kembali
                }

                int kd_aktivitas;
                if (!int.TryParse(input, out kd_aktivitas))
                {
                    Console.WriteLine("Kode Aktivitas tidak valid.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_aktivitas yang valid
                }

                // Validasi apakah kd_aktivitas yang dipilih benar-benar ada di database
                if (!IsKdAktivitasExists(con, kd_aktivitas))
                {
                    Console.WriteLine("Kode Aktivitas tidak ditemukan.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_aktivitas yang valid
                }

                Console.WriteLine($"Apakah Anda yakin ingin menghapus data Aktivitas dengan kd {kd_aktivitas}? (Y/N): ");
                string confirmation = Console.ReadLine().ToUpper();
                if (confirmation == "Y")
                {
                    string query = "DELETE FROM Aktivitas WHERE kd_aktivitas = @kd_aktivitas";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data Aktivitas berhasil dihapus.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data Aktivitas.");
                    }
                    break; // Keluar dari loop setelah penghapusan berhasil atau gagal
                }
                else if (confirmation == "N")
                {
                    Console.WriteLine("Batal menghapus data Aktivitas.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk membatalkan penghapusan
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
        }


        // HAPUS TRANSAKSI
        public void deleteTransaksi(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Transaksi sebelum menghapus
                Console.WriteLine("Data Transaksi sebelum dihapus:");
                viewTransaksi(con);

                Console.WriteLine("Masukkan kd transaksi yang ingin dihapus atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Batal menghapus data Transaksi.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk kembali
                }

                int kd_transaksi;
                if (!int.TryParse(input, out kd_transaksi))
                {
                    Console.WriteLine("Kode transaksi tidak valid. Masukkan kembali.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_transaki yang valid
                }

                // Validasi apakah kd_transaksi yang dipilih benar-benar ada di database
                if (!IsKdTransaksiExists(con, kd_transaksi))
                {
                    Console.WriteLine("Kode transaksi tidak ditemukan.");
                    continue; // Melanjutkan iterasi loop untuk meminta input kd_transaksi yang valid
                }

                Console.WriteLine($"Apakah Anda yakin ingin menghapus data Transaksi dengan kd {kd_transaksi}? (Y/N): ");
                string confirmation = Console.ReadLine().ToUpper();
                if (confirmation == "Y")
                {
                    string query = "DELETE FROM Transaksi WHERE kd_Transaksi = @kd_Transaksi";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@kd_Transaksi", kd_transaksi);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data Transaksi berhasil dihapus.");
                    }
                    else
                    {
                        Console.WriteLine("Gagal menghapus data Transaksi.");
                    }
                    break; // Keluar dari loop setelah penghapusan berhasil atau gagal
                }
                else if (confirmation == "N")
                {
                    Console.WriteLine("Batal menghapus data Transaksi.");
                    return; // Mengembalikan eksekusi method jika pengguna memilih untuk membatalkan penghapusan
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid.");
                }
            }
        }

        // Metode untuk memeriksa apakah kode transaksi ada di dalam database
        public bool IsKdTransaksiExists(SqlConnection con, int kd_transaksi)
        {
            string query = "SELECT COUNT(*) FROM Transaksi WHERE kd_Transaksi = @kd_Transaksi";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kd_Transaksi", kd_transaksi);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }


        //==================================================================================================================================//
        //==================================================================================================================================//
        //==================================================================================================================================//

        // Edit Infaq method
        public void editInfaq(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Infaq sebelum melakukan edit
                Console.WriteLine("Data Infaq sebelum diedit:");
                viewInfaq(con);

                Console.WriteLine("Pilih kd infaq yang ingin diedit atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                // Validasi input tidak boleh kosong
                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input tidak boleh kosong. Silakan masukkan kembali:");
                    input = Console.ReadLine();
                }

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Kembali ke menu sebelumnya.");
                    return; // Keluar dari metode jika pengguna memilih untuk kembali
                }

                int kd_infaq;
                if (!int.TryParse(input, out kd_infaq))
                {
                    Console.WriteLine("Kode infaq tidak valid.");
                    continue;
                }

                // Validasi apakah kd_infaq yang dipilih benar-benar ada di database
                if (!IsKdInfaqExists(con, kd_infaq))
                {
                    Console.WriteLine("Kode infaq tidak ditemukan.");
                    continue;
                }

                // Menampilkan opsi untuk memilih edit tanggal atau edit jumlah nominal
                Console.WriteLine("Pilih opsi yang ingin diedit:");
                Console.WriteLine("1. Edit tanggal");
                Console.WriteLine("2. Edit jumlah nominal");
                Console.WriteLine("Masukkan pilihan (1/2) atau ketik 'E' untuk kembali: ");
                string option = Console.ReadLine().ToUpper();

                // Validasi input tidak boleh kosong
                while (string.IsNullOrWhiteSpace(option))
                {
                    Console.WriteLine("Input tidak boleh kosong. Silakan masukkan kembali:");
                    option = Console.ReadLine().ToUpper();
                }

                switch (option)
                {
                    case "1":
                        editTanggalInfaq(con, kd_infaq);
                        break;
                    case "2":
                        editNominalInfaq(con, kd_infaq);
                        break;
                    case "E":
                        return;
                    default:
                        Console.WriteLine("Opsi tidak valid.");
                        break;
                }
            }
        }


        // Method untuk memeriksa apakah kd_infaq sudah ada di database
        private bool IsKdInfaqExists(SqlConnection con, int kd_infaq)
        {
            string query = "SELECT COUNT(*) FROM Infaq WHERE kd_infaq = @kd_infaq";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // Method untuk memvalidasi apakah pengguna yakin dengan perubahan
        private bool IsUserSure()
        {
            Console.WriteLine("Apakah Anda yakin ingin menyimpan perubahan? (Y/N): ");
            string confirmation = Console.ReadLine().ToUpper();
            return confirmation == "Y";
        }

        // Method untuk mengedit tanggal infaq
        public void editTanggalInfaq(SqlConnection con, int kd_infaq)
        {
            while (true)
            {
                Console.WriteLine("Masukkan tanggal baru (yyyy-MM-dd) atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (input.ToUpper() == "E")
                    return;

                DateTime newTanggal;
                if (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out newTanggal))
                {
                    Console.WriteLine("Format tanggal tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Infaq SET tanggal_infaq = @newTanggal WHERE kd_infaq = @kd_infaq";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newTanggal", newTanggal);
                cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Tanggal Infaq berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah tanggal Infaq.");
                }
                break;
            }
        }

        // Method untuk mengedit jumlah nominal infaq
        public void editNominalInfaq(SqlConnection con, int kd_infaq)
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah nominal baru atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (input.ToUpper() == "E")
                    return;

                decimal newNominal;
                if (!decimal.TryParse(input, out newNominal))
                {
                    Console.WriteLine("Jumlah nominal tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Infaq SET saldo_infaq = @newNominal WHERE kd_infaq = @kd_infaq";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newNominal", newNominal);
                cmd.Parameters.AddWithValue("@kd_infaq", kd_infaq);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Jumlah Nominal Infaq berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah jumlah Nominal Infaq.");
                }
                break;
            }
        }







        // Metode untuk mengedit aktivitas
        public void editAktivitas(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Aktivitas sebelum melakukan edit
                Console.WriteLine("Data Aktivitas sebelum diedit:");
                viewAktivitas(con);

                Console.WriteLine("Pilih Kd aktivitas yang ingin diedit atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Kembali ke menu sebelumnya.");
                    return; // Keluar dari metode jika pengguna memilih untuk kembali
                }

                int kd_aktivitas;
                if (!int.TryParse(input, out kd_aktivitas))
                {
                    Console.WriteLine("KD aktivitas tidak valid.");
                    continue;
                }

                // Validasi apakah kd_aktivitas yang dipilih benar-benar ada di database
                if (!IsIdAktivitasExists(con, kd_aktivitas))
                {
                    Console.WriteLine("KD aktivitas tidak ditemukan.");
                    continue;
                }

                // Menampilkan opsi untuk memilih edit nama, pemasukan, pengeluaran, tanggal, atau kode infaq
                Console.WriteLine("Pilih opsi yang ingin diedit:");
                Console.WriteLine("1. Edit nama");
                Console.WriteLine("2. Edit pemasukan");
                Console.WriteLine("3. Edit pengeluaran");
                Console.WriteLine("4. Edit tanggal");
                Console.WriteLine("5. Edit kode infaq");
                Console.WriteLine("Masukkan pilihan (1/2/3/4/5) atau ketik 'E' untuk kembali: ");
                string option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "1":
                        editNamaAktivitas(con, kd_aktivitas);
                        break;
                    case "2":
                        editPemasukanAktivitas(con, kd_aktivitas);
                        break;
                    case "3":
                        editPengeluaranAktivitas(con, kd_aktivitas);
                        break;
                    case "4":
                        editTanggalAktivitas(con, kd_aktivitas);
                        break;
                    case "5":
                        editKodeInfaqAktivitas(con, kd_aktivitas);
                        break;
                    case "E":
                        return;
                    default:
                        Console.WriteLine("Opsi tidak valid.");
                        break;
                }
            }
        }

        // Method untuk memeriksa apakah kd_aktivitas sudah ada di database
        private bool IsIdAktivitasExists(SqlConnection con, int kd_aktivitas)
        {
            string query = "SELECT COUNT(*) FROM Aktivitas WHERE kd_aktivitas = @kd_aktivitas";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // Method untuk mengedit nama aktivitas
        public void editNamaAktivitas(SqlConnection con, int kd_aktivitas)
        {
            while (true)
            {
                Console.WriteLine("Masukkan nama baru atau ketik 'E' untuk kembali: ");
                string newNama = Console.ReadLine();
                if (!IsInputNotEmpty(newNama))
                {
                    Console.WriteLine("Nama tidak boleh kosong.");
                    continue;
                }
                if (newNama.ToUpper() == "E")
                    return;

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Aktivitas SET nama_aktivitas = @newNama WHERE kd_aktivitas = @kd_aktivitas";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newNama", newNama);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Nama Aktivitas berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah nama Aktivitas.");
                }
                break;
            }
        }

        // Method untuk mengedit pemasukan aktivitas
        public void editPemasukanAktivitas(SqlConnection con, int kd_aktivitas)
        {
            while (true)
            {
                Console.WriteLine("Masukkan pemasukan baru atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (!IsInputNotEmpty(input))
                {
                    Console.WriteLine("Pemasukan tidak boleh kosong.");
                    continue;
                }
                if (input.ToUpper() == "E")
                    return;

                decimal newPemasukan;
                if (!decimal.TryParse(input, out newPemasukan))
                {
                    Console.WriteLine("Pemasukan tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Aktivitas SET Pemasukan = @newPemasukan WHERE kd_aktivitas = @kd_aktivitas";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newPemasukan", newPemasukan);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pemasukan Aktivitas berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah pemasukan Aktivitas.");
                }
                break;
            }
        }

        // Method untuk mengedit pengeluaran aktivitas
        public void editPengeluaranAktivitas(SqlConnection con, int kd_aktivitas)
        {
            while (true)
            {
                Console.WriteLine("Masukkan pengeluaran baru atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (!IsInputNotEmpty(input))
                {
                    Console.WriteLine("Pengeluaran tidak boleh kosong.");
                    continue;
                }
                if (input.ToUpper() == "E")
                    return;

                decimal newPengeluaran;
                if (!decimal.TryParse(input, out newPengeluaran))
                {
                    Console.WriteLine("Pengeluaran tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Aktivitas SET Pengeluaran = @newPengeluaran WHERE kd_aktivitas = @kd_aktivitas";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newPengeluaran", newPengeluaran);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Pengeluaran Aktivitas berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah pengeluaran Aktivitas.");
                }
                break;
            }
        }

        // Method untuk mengedit tanggal aktivitas
        public void editTanggalAktivitas(SqlConnection con, int kd_aktivitas)
        {
            while (true)
            {
                Console.WriteLine("Masukkan tanggal baru (yyyy-MM-dd) atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (!IsInputNotEmpty(input))
                {
                    Console.WriteLine("Tanggal tidak boleh kosong.");
                    continue;
                }
                if (input.ToUpper() == "E")
                    return;

                DateTime newTanggal;
                if (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out newTanggal))
                {
                    Console.WriteLine("Format tanggal tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Aktivitas SET Tanggal_aktivitas = @newTanggal WHERE kd_aktivitas = @kd_aktivitas";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newTanggal", newTanggal);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Tanggal Aktivitas berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah tanggal Aktivitas.");
                }
                break;
            }
        }

        // Method untuk mengedit kode infaq pada aktivitas
        public void editKodeInfaqAktivitas(SqlConnection con, int kd_aktivitas)
        {
            while (true)
            {
                Console.WriteLine("Masukkan kode infaq baru atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();
                if (!IsInputNotEmpty(input))
                {
                    Console.WriteLine("Kode infaq tidak boleh kosong.");
                    continue;
                }
                if (input.ToUpper() == "E")
                    return;

                int newKdInfaq;
                if (!int.TryParse(input, out newKdInfaq))
                {
                    Console.WriteLine("Kode infaq tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Aktivitas SET kd_infaq = @newKdInfaq WHERE kd_aktivitas = @kd_aktivitas";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newKdInfaq", newKdInfaq);
                cmd.Parameters.AddWithValue("@kd_aktivitas", kd_aktivitas);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Kode Infaq pada Aktivitas berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah Kode Infaq pada Aktivitas.");
                }
                break;
            }
        }

        // Method untuk memeriksa apakah input string kosong
        private bool IsInputNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Method untuk menanyakan ke pengguna apakah yakin akan menyimpan perubahan
        public bool c()
        {
            while (true)
            {
                Console.WriteLine("Are you sure? (Y/N): ");
                string response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    return true;
                }
                else if (response == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }
            }
        }





        // Edit Transaksi
        public void editTransaksi(SqlConnection con)
        {
            while (true)
            {
                // Menampilkan data Transaksi sebelum melakukan edit
                Console.WriteLine("Data Transaksi sebelum diedit:");
                viewTransaksi(con);

                Console.WriteLine("Pilih kd transaksi yang ingin diedit atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "E")
                {
                    Console.WriteLine("Kembali ke menu sebelumnya.");
                    return; // Keluar dari metode jika pengguna memilih untuk kembali
                }

                int kd_transaksi;
                if (!int.TryParse(input, out kd_transaksi))
                {
                    Console.WriteLine("Kode transaksi tidak valid.");
                    continue;
                }

                // Validasi apakah kd_transaksi yang dipilih benar-benar ada di database
                if (!IsKdTransaksiExists(con, kd_transaksi))
                {
                    Console.WriteLine("Kode transaksi tidak ditemukan.");
                    continue;
                }

                // Menampilkan opsi untuk memilih edit tanggal, edit nominal, atau edit jenis transaksi
                Console.WriteLine("Pilih opsi yang ingin diedit:");
                Console.WriteLine("1. Edit tanggal");
                Console.WriteLine("2. Edit jumlah nominal");
                Console.WriteLine("3. Edit jenis transaksi");
                Console.WriteLine("Masukkan pilihan (1/2/3) atau ketik 'E' untuk kembali: ");
                string option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "1":
                        editTanggalTransaksi(con, kd_transaksi);
                        break;
                    case "2":
                        editNominalTransaksi(con, kd_transaksi);
                        break;
                    case "3":
                        editJenisTransaksi(con, kd_transaksi);
                        break;
                    case "E":
                        return;
                    default:
                        Console.WriteLine("Opsi tidak valid.");
                        break;
                }
            }
        }

        // Method untuk mengedit tanggal transaksi
        public void editTanggalTransaksi(SqlConnection con, int kd_transaksi)
        {
            while (true)
            {
                Console.WriteLine("Masukkan tanggal baru (yyyy-MM-dd) atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                // Validasi input tidak boleh kosong
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input tidak boleh kosong. Mohon masukkan tanggal atau 'E' untuk kembali.");
                    continue;
                }

                if (input.ToUpper() == "E")
                    return;

                DateTime newTanggal;
                if (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out newTanggal))
                {
                    Console.WriteLine("Format tanggal tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Transaksi SET tanggal_transaksi = @newTanggal WHERE kd_Transaksi = @kd_Transaksi";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newTanggal", newTanggal);
                cmd.Parameters.AddWithValue("@kd_Transaksi", kd_transaksi);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Tanggal Transaksi berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah tanggal Transaksi.");
                }
                break;
            }
        }

        // Metode untuk meminta konfirmasi dari pengguna
        public bool CEK()
        {
            Console.WriteLine("Apakah Anda yakin ingin menyimpan perubahan? (Y/N)");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }


        public void editNominalTransaksi(SqlConnection con, int kd_transaksi)
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah nominal baru atau ketik 'E' untuk kembali: ");
                string input = Console.ReadLine();

                // Validasi input tidak boleh kosong
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input tidak boleh kosong. Mohon masukkan jumlah nominal atau 'E' untuk kembali.");
                    continue;
                }

                if (input.ToUpper() == "E")
                    return;

                decimal newNominal;
                if (!decimal.TryParse(input, out newNominal))
                {
                    Console.WriteLine("Jumlah nominal tidak valid.");
                    continue;
                }

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Transaksi SET nominal_transaksi = @newNominal WHERE kd_Transaksi = @kd_Transaksi";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newNominal", newNominal);
                cmd.Parameters.AddWithValue("@kd_Transaksi", kd_transaksi);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Nominal Transaksi berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah nominal Transaksi.");
                }
                break;
            }
        }

        public bool CEK1()
        {
            Console.WriteLine("Apakah Anda yakin ingin menyimpan perubahan? (Y/N)");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }


        public void editJenisTransaksi(SqlConnection con, int kd_transaksi)
        {
            while (true)
            {
                Console.WriteLine("Masukkan jenis transaksi baru atau ketik 'E' untuk kembali: ");
                string newJenis = Console.ReadLine();

                // Validasi input tidak boleh kosong
                if (string.IsNullOrWhiteSpace(newJenis))
                {
                    Console.WriteLine("Input tidak boleh kosong. Mohon masukkan jenis transaksi atau 'E' untuk kembali.");
                    continue;
                }

                if (newJenis.ToUpper() == "E")
                    return;

                // Validasi apakah pengguna yakin ingin menyimpan perubahan
                if (!IsUserSure())
                {
                    Console.WriteLine("Batal menyimpan perubahan.");
                    return;
                }

                string query = "UPDATE Transaksi SET jenis_transaksi = @newJenis WHERE kd_Transaksi = @kd_Transaksi";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newJenis", newJenis);
                cmd.Parameters.AddWithValue("@kd_Transaksi", kd_transaksi);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Jenis Transaksi berhasil diubah.");
                }
                else
                {
                    Console.WriteLine("Gagal mengubah jenis Transaksi.");
                }
                break;
            }
        }

        public bool CEK2()
        {
            Console.WriteLine("Apakah Anda yakin ingin menyimpan perubahan? (Y/N)");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }

    }
}