# Flappy Bird 
Bu proje **C# Windows Forma** kullanılarak geliştirilmiş bir Flappy Bird oyunudur.
Kullanıcı , kuşu ** Space TUŞU VE mouse tıklaması ** ile zıplatabilmektedir. Oyunun amacı : borulara çarpmadan en yüksek koru elde etmektir.


## Özellikler
-**C# Windows Forms** ile geliştirilmiştir.  
- Kuşu **Space** tuşu veya **Mouse tıklaması** ile kontrol edebilme.  
- **Skor sistemi**: Geçilen borulara göre skor artar.  
- Kuş herhangi bir boruya veya yere çarptığında **Game Over** olur.  
- Oyun bittiğinde **New Game** butonu ile yeniden başlatılabilir.  
- **Access veya SQL kullanılmamıştır**


## Kurulum ve çalıştırma 
1. Bu projeyi bilgisayarınıza indirin.  
2. Visual Studio ile açın.  
3. `Form1.cs` üzerinden projeyi başlatın.  
4. Projeye gerekli resimler (`Resources`) eklenmiş olmalıdır (ör. **FlappyBird1**, **FlappyBird2**, **PipeHead**, **PipeBody**).

SPACE TUŞU zıplamasını sağlayan örnek kod parçası 
private void Form1_KeyDown(object sender, KeyEventArgs e)
{
    if (!isGameOver && e.KeyCode == Keys.Space)
    {
        int jumpHeight = 80;
        int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;
        Target_Y_Location = newTarget < 0 ? 0 : newTarget;
    }
}

NOT: DevExpress deneme sürümü indirilmiş fakat kurulmamıştır ; proje tamamen Windows Forms ile geliştirilmiştir .
    Görsel açıdan objelerin büyük olduğunun farkında olup ilk projem olduğu için küçültme veya da büyütme işlemine risk alınamamıştır.
    
