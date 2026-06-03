// See https://aka.ms/new-consoConsolele-template for more information
using System;

namespace MyLMS
{
    // Class Induk
    public class User
    {
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Konstruktor
        public User(string nama, string email, string password, string role)
        {
            Nama = nama;
            Email = email;
            Password = password;
            Role = role;
        }

        // Method untuk menampilkan info
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}, Role: {Role}");
        }
    }

    // Class Turunan Guru
    public class Guru : User
    {
        public string Mapel { get; set; }

        // Konstruktor Guru
        public Guru(string nama, string email, string password, string role, string mapel)
            : base(nama, email, password, role)
        {
            Mapel = mapel;
        }

        public void NilaiTugas()
        {
            Console.WriteLine($"Guru {Nama} sedang menilai tugas untuk mata pelajaran {Mapel}.");
        }
    }

    // Class Turunan Siswa
    public class Siswa : User
    {
        public string ClassName { get; set; }

        // Konstruktor Siswa
        public Siswa(string nama, string email, string password, string role, string className)
            : base(nama, email, password, role)
        {
            ClassName = className;
        }

        public void SubmitTugas()
        {
            Console.WriteLine($"Siswa {Nama} dari kelas {ClassName} sedang mengumpulkan tugas.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Guru
            Guru guru1 = new Guru("Pak Budi", "budi@guru.com", "12345", "Guru", "Matematika");
            guru1.TampilkanInfo();
            guru1.NilaiTugas();

            Console.WriteLine();

            // Membuat objek Siswa
            Siswa siswa1 = new Siswa("Andi", "andi@siswa.com", "abcde", "Siswa", "XII IPA 1");
            siswa1.TampilkanInfo();
            siswa1.SubmitTugas();

            Console.ReadLine();
        }
    }
}

