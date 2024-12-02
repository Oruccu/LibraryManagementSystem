namespace LibraryManagementSystem.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public static List<Quote> GetQuotes()
        {
            return new List<Quote>
            {
                new Quote { Id = 1, Text = "Bir kitap, bir hayal ülkesine açılan kapıdır. Her sayfada yeni dünyalar keşfederiz. Kitaplar, bizi bilmediğimiz yerlere götüren sihirli araçlardır." },
                new Quote { Id = 2, Text = "Kitaplar, ruhun en iyi dostlarıdır. Yalnız kaldığınızda size eşlik eder, sıkıldığınızda eğlendirir. Onlar, iç dünyamızın derinliklerine ışık tutar." },
                new Quote { Id = 3, Text = "Kitaplar, zihnimizin kanatlarıdır. Onlarla uzak diyarlara seyahat eder, keşfedilmemiş topraklara ayak basarız. Her kitap, yeni bir maceraya açılan kapıdır." },
                new Quote { Id = 4, Text = "Bir kitap, yaşamdan daha fazla hayat verir bize. Karakterlerin hikayelerinde kendimizi bulur, onların sevinç ve üzüntülerini paylaşırız. Kitaplar, bizi daha anlayışlı ve empatik bireyler yapar." },
                new Quote { Id = 5, Text = "Her kitap, yeni bir dünya keşfetmenin anahtarıdır. Ufkumuzu açar, farklı perspektifler kazandırır. Kitaplar, dünyayı daha geniş bir pencereden görmemizi sağlar." },
                new Quote { Id = 6, Text = "Kitaplar, sessiz öğretmenlerdir. Onlarla bilgi ve bilgelik kazanır, dünyayı ve kendimizi daha iyi anlarız. Her kitap, öğrenmeye açılan bir kapıdır." },
                new Quote { Id = 7, Text = "Bir kitap okuduğunda, her şey mümkündür. Hayal gücünün sınırlarını zorlar, imkansız görünen şeyleri mümkün kılar. Kitaplar, bizi başka diyarlara götürür." },
                new Quote { Id = 8, Text = "Kitaplar, düşüncelerimizin bahçesindeki çiçeklerdir. Her biri farklı bir renk ve kokuda, benzersiz ve eşsizdir. Onları okudukça, zihnimizde yeni düşünceler filizlenir." },
                new Quote { Id = 9, Text = "Kitaplar, kalbin ve zihnin aynalarıdır. İç dünyamıza ışık tutar, kendi duygularımızı ve düşüncelerimizi yansıtır. Kitaplar, kendimizi daha iyi anlamamıza yardımcı olur." },
                new Quote { Id = 10, Text = "Her kitap, yeni bir maceraya açılan kapıdır. Hayal gücümüzü geliştirir, bizi başka dünyalara götürür. Kitaplarla, denizlerin derinliklerine dalar, yüksek dağların zirvesine tırmanırız." }
            };
        }
    }
}
