Console.Write("INPUT KALIMAT : ");
var kalimat = Console.ReadLine().ToUpper();
Console.Write("INPUT KATA : ");
var kata = Console.ReadLine().ToUpper();
char[] charKalimat = kalimat.ToCharArray();
char[] charKata = kata.ToCharArray();
string[,] jumlahHuruf = new string[charKalimat.Length,2];
int hitungJumlahHuruf = 0;
Console.WriteLine("OUTPUT");
var hitungKata = 0;
var jumlahKata = 0;
for (int i = 0; i < charKalimat.Length; i++)
{
    if (charKata[hitungKata] == charKalimat[i])
        hitungKata++;
    else
        hitungKata = 0;
    if (hitungKata == charKata.Length)
    {
        jumlahKata++;
        hitungKata = 0;
    }
}

Array.Sort(charKalimat);
char[] charKalimat2 = new char[charKalimat.Length+1];
for (int i = 0;i < charKalimat2.Length;i++)
{
    if (i < charKalimat.Length)
        charKalimat2[i] = charKalimat[i];
}
var hitungHuruf = 0;
var hitung = 0;
for (int i = 0;i < charKalimat2.Length;i++)
{
    var tesKalimat = i + 1;
    if (tesKalimat >= charKalimat2.Length)
        break;
    if (charKalimat2[i] == charKalimat2[tesKalimat])
        hitungHuruf++;
    else
    {
        jumlahHuruf[hitung, 0] = Convert.ToString(charKalimat2[i]);
        jumlahHuruf[hitung, 1] = Convert.ToString(hitungHuruf);
        hitungHuruf = 0;
    }
}
var counter = 1;
var counter2 = 0;
for (int i = 0; i < charKalimat2.Length; i++)
{
    for (int j = i + 1; j < charKalimat2.Length; j++)
    {
        if (charKalimat2[i] == charKalimat2[j])
        {
            counter++;
        }
        else
        {
            jumlahHuruf[counter2, 0] = Convert.ToString(charKalimat2[i]);
            jumlahHuruf[counter2, 1] = Convert.ToString(counter);
            counter = 1;
            counter2++;
            i = j - 1;
            break;
        }
    }
}
Console.WriteLine("STATISTIK HURUF :");
var counter3 = 1;
for (int i = 0;i < charKalimat.Length; i++)
{
    if (jumlahHuruf[i, 0] != " " && jumlahHuruf[i, 0] != null)
    {
        if (counter3 % 5 == 1)
            Console.WriteLine();
        Console.WriteLine($"{jumlahHuruf[i, 0]} : {jumlahHuruf[i, 1]} HURUF");
        hitungJumlahHuruf += Convert.ToInt32(jumlahHuruf[i, 1]);
        counter3++;
    }
}
Console.WriteLine($"\nSTATISTIK KATA\n{kata}: {jumlahKata} KATA ");
Console.WriteLine($"\nJUMLAH HURUF : {hitungJumlahHuruf} HURUF");