// See https://aka.ms/new-consoConsolele-template for more information
Siswa siswaObj = new Siswa("Arroyana", "arroyana@gmail.com", "oya", "siswa", "XPG1");
Guru guruObj = new Guru("Raisyah", "raisyah@gmail.com", "ungke", "guru", "IPAS");

siswaObj.Tampilkaninfo();
siswaObj.SubmitTugas();

Console.WriteLine();

guruObj.Tampilkaninfo();
guruObj.NilaiTugas();

public class user
{
    public string nama;
    public string email;
    public string password;
    public string role;

    public user(string nama, string email, string password, string role)
    {
        this.nama = nama;
        this.email = email;
        this.password = password;
        this.role = role;
    }

    public void Tampilkaninfo()
    {
        Console.WriteLine($"Nama: {nama} | Role: {role}");
    }
}

class Siswa : user
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string className) : base(nama, email, password, role)
    {
        ClassName = className;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"{nama} dari kelas {ClassName} sudah mengumpulkan tugas");
    }
}

class Guru : user
{
    public string Mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {nama} telah menilai semua tugas mapel {Mapel}");
    }
}