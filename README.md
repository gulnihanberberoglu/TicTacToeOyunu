<p style="margin-bottom: 12.0pt; line-height: normal;"><span style="text-decoration: underline;"><strong><span style="font-size: 12pt; font-family: 'Segoe UI', sans-serif; color: #24292e; text-decoration: underline;">NESNEYE Y&Ouml;NELİK TİC TAC TOE</span></strong></span></p>
<p style="margin-bottom: 12.0pt; line-height: normal;"><strong><span style="font-size: 12.0pt; font-family: 'Segoe UI',sans-serif; color: #24292e;">&Ouml;zet:</span></strong></p>
<p style="margin-right: 0cm;"><span style="font-family: 'times new roman', times;"><em><span style="font-size: 10.0pt;">Tic Tac Toe, nesneye y&ouml;nelik programlama mantığını kullanarak geliştirmiş bir oyun uygulamasıdır. Projede nxn (n değeri 3,5 ya da 7) tahta &uuml;zerinde klasik tic tac toe oyunu yapıldı. Oyun 1 ya da 2 kişilik oynanabilir. Oyun 3 seviyeden oluşmaktadır. Seviyeler oyun oynanan &nbsp;tahtanın b&uuml;y&uuml;kl&uuml;ğ&uuml;n&uuml; belirlenmektedir. Oyun tahtası 3x3,5x5, 7x7 olmak &uuml;zere 3 b&uuml;y&uuml;kl&uuml;ğe sahip olabilir. Oyun eğer bir oyuncu olacak şekilde se&ccedil;ilirse kullanıcı bilgisayara karşı oynar. Oyun konsol uygulaması olarak ger&ccedil;ekleştirildi. Oyunun başlangıcında kullanıcıdan oyun tahtasının boyutu (n değeri), kullanıcının ismi alınıyor. N değerine g&ouml;re oyun tahtası a&ccedil;ılıyor. Oyunda birinin kazanması durumunda sonunda kazanan oyuncu ekrana yazıyor ve oyun duruyor.</span></em></span></p>
<p style="margin-right: 0cm;"><span style="font-family: 'times new roman', times;"><em><span style="font-size: 10.0pt;">Bu projeyi geliştirirken oyunun oynanacağı oyun tahtasını nesne olarak d&uuml;ş&uuml;n&uuml;ld&uuml; ve bu nesnenin sahip olacağı işlevler metod haline getirildi. </span></em></span></p>
<p style="margin-right: 0cm;"><span style="font-family: 'times new roman', times;"><em><span style="font-size: 10.0pt;">Oyunda tanımlanan ikinci bir nesne yapısı da oyuncu nesnesidir. Bu nesnenin hangi harfi kullandığını belirten (X mi O mu) bir &ouml;zelliği, oyuncunun bilgisayar mı yoksa insan mı olduğunu belirten ikinci bir &ouml;zelliği ve kullanıcı adını tutan bir isim &ouml;zelliği bulunuyor. Eğer 2 oyunculu bir oyun se&ccedil;ilirse kullanıcıdan 2 isim alınır fakat 1 oyunculu oyun se&ccedil;ilirse 1 isim alınır ve 2.oyuncu bilgisayar olmuş olur. Bilgisayar X ve O değerlerini random olarak atayarak oyunu oynuyor.</span></em></span></p>
<p style="margin-bottom: 12.0pt; line-height: normal;"><strong><span style="font-size: 12.0pt; font-family: 'Segoe UI',sans-serif; color: #24292e;">Geliştirilen Mimari:</span></strong></p>
<p><span style="font-family: 'times new roman', times; font-size: 10pt;">Oyunun oynanacağı oyun tahtası bir nesne olarak d&uuml;ş&uuml;n&uuml;ld&uuml;. Bu nesnenin iki boyutlu bir karakter dizisi olarak tahtayı temsil eden bir &ouml;zelliği ve oyun tahtasının başlangı&ccedil; değerlerinin atanacağı bir yapıcısı var.</span></p>
<p><span style="font-family: 'times new roman', times; font-size: 10pt;">Parametreli olan yapıcı almış olduğu iki boyutlu oyun tahtası dizisini oyun tahtası nesnesine atayacak ve oyunu bu tahta &uuml;zerinden başlatacaktır.</span></p>
<table style="border-collapse: collapse; width: 100%;" border="1">
<tbody>
<tr>
<td style="width: 100%;">
<p><span style="color: black;">public oyunTahtasi(int boyut, Action&lt;nokta&gt; buttonTiklandi)</span><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></p>
</td>
</tr>
</tbody>
</table>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Aynı zamanda oyun tahtası nesnesinin aşağıdaki işlevleri yerine getirecek metotları bulunuyor.</span></p>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;"><span style="line-height: 107%; color: black;">Oyun tahtasını d&ouml;nd&uuml;recek bir metot;</span></span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">char [][] oyunTahtasiniAl()</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;"><span style="line-height: 107%; color: black;">Oyuncu tarafından hamle yapılacak alanın boş olup olmadığını kontrol eden boş ise true d&ouml;nd&uuml;r&uuml;p boş olan alana ekleme işlevini ger&ccedil;ekleştiren, dolu ise false d&ouml;nd&uuml;ren bir metot;</span></span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">boolean hamleyiYaz(string koordinat, char oyuncu)</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyunu kazanan oyuncuyu belirleyecek bir metot.Bu metot parametre olarak oyuncu id sini alır ve yaptığı kontroller sonucunda bool olarak, oyuncu oyunu kazandıysa true aksi durumda false değerini d&ouml;nd&uuml;r&uuml;r;</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">boolean kazanan(char oyuncu) </span></li>
<li><span style="color: black;">private bool kazananYatay(char oyuncu)</span></li>
<li><span style="color: black;">private bool kazananDikey(char oyuncu)</span></li>
<li><span style="color: black;">private bool kazananCapraz(char oyuncu)</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyun berabere kaldıysa true aksi durumda false d&ouml;nd&uuml;recek bir metot;</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">boolean beraberlikKontrol() </span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Hamleyi alıp almadığını deneyen bir metot;</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">private bool TryGetButton(int satir, int sutun, out Button button)</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyunda tanımlanan ikinci bir nesne yapısı da oyuncu nesnesidir. Bu nesnenin hangi harfi kullandığını belirten (X mi O mu) bir &ouml;zelliği, oyuncunun bilgisayar mı yoksa insan mı olduğunu belirten ikinci bir &ouml;zelliği ve kullanıcı adını tutan bir isim &ouml;zelliği bulunuyor.</span></p>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Tek parametreli olan yapıcı oyun tahtasını ve karakteri alıp X&rsquo;e eşitler.Oyun tahtasınıda girilen paramatreye eşitler.</span></p>
<table style="border-collapse: collapse; width: 100%;" border="1">
<tbody>
<tr>
<td style="width: 100%;">
<p><span style="color: black;">public oyuncu(oyunTahtasi oyunTahtasi)</span></p>
<p style="text-autospace: none;"><span style="color: black;">{</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.kr = 'X';</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.oyunTahtasi = oyunTahtasi;</span></p>
<p><span style="color: black;">}</span></p>
</td>
</tr>
</tbody>
</table>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;"><span style="line-height: 107%; color: black;">İki parametreli olan yapıcı, oyun tahtasını ve karakteri alıp set eder.</span></span></p>
<table style="border-collapse: collapse; width: 100%; height: 18px;" border="1">
<tbody>
<tr style="height: 18px;">
<td style="width: 100%; height: 18px;">
<p><span style="color: black;">public oyuncu(oyunTahtasi oyunTahtasi, char kr)</span></p>
<p style="text-autospace: none;"><span style="color: black;">{</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.kr = kr;</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.oyunTahtasi = oyunTahtasi;</span></p>
<p><span style="color: black;">}</span></p>
</td>
</tr>
</tbody>
</table>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyuncu nesnesinin sahip olacağı beş temel metot bulunmaktadır. </span></p>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyuncunun hangi harf ile oynadığını d&ouml;nd&uuml;ren bir metot;</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">char karakteriAl()</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyuncunun insan mı yoksa bilgisayar mı olduğunu d&ouml;nd&uuml;ren metot;</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">boolean oyuncuTurunuAl() </span></li>
</ul>
<p><span style="color: black;">&nbsp;</span><span style="color: black;"><span style="font-size: 10pt; font-family: 'times new roman', times;">Oyuncunun hamlesinin hangi h&uuml;creye olduğunu d&ouml;nd&uuml;ren bir metot;</span></span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">public virtual hamle oyuncunnHamlesiniAl(int x, int y)</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Oyuncu olarak bilgisayar adında bir sınıf oluşturuldu. &Ccedil;&uuml;nk&uuml; oyun eğer tek kişilik ise 2.oyuncu bilgisayar olacaktır. Bilgisayar &lsquo;O&rsquo; harfini kullanır.</span></p>
<ul>
<li><span style="color: black;">public bilgisayar(oyunTahtasi oyunTahtasi):base(oyunTahtasi, 'O')</span></li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Ve bilgisayar &lsquo;O&rsquo; harfini oyun tahtasına rastgele olacak şekilde yani random fonksiyonu ile ger&ccedil;ekleştirir.</span></p>
<ul style="list-style-type: disc;">
<li><span style="color: black;">satir = rnd.Next(oynTahtasi.RowCount);</span></li>
<li>
<p><span style="color: black;">kolon = rnd.Next(oynTahtasi.ColumnCount);</span></p>
</li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Hamle adında bir sınıf oluşturuldu. Bu sınıfın yapılandırıcısı x noktası, y noktası ve karakter alıp parametreleri set eder.</span></p>
<table style="border-collapse: collapse; width: 100%;" border="1">
<tbody>
<tr>
<td style="width: 100%;">
<p style="text-autospace: none;"><span style="color: black;">&nbsp; public hamle(int x, int y, char kr)</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.nokta = new nokta(x, y);</span></p>
<p style="text-autospace: none;"><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; this.kr = kr;</span></p>
<p><span style="color: black;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</span></p>
</td>
</tr>
</tbody>
</table>
<p style="text-autospace: none;"><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;">Main() fonksiyonu ise Form2&rsquo;yi &ccedil;ağırır.</span></p>
<ul style="list-style-type: square;">
<li style="text-autospace: none;">
<h1 style="text-align: justify; text-indent: 0cm; tab-stops: 35.4pt;"><span style="font-size: 10pt;">Form2:</span></h1>
<p><span style="font-size: 10pt; font-family: 'times new roman', times;">Oyun ilk a&ccedil;ılıp karşılaşılan ilk ekrandır. Oyunun ka&ccedil; kişilik oynanacağının se&ccedil;ildiği ekrandır. Tıklanılan buttona g&ouml;re Form 3&rsquo;&uuml; a&ccedil;ar.</span></p>
<h1 style="text-align: justify; text-indent: 0cm; tab-stops: 35.4pt;">&nbsp;</h1>
</li>
<li style="text-autospace: none;">
<h1 style="text-align: justify; text-indent: 0cm; tab-stops: 35.4pt;"><span style="font-size: 10pt;">Form3:</span></h1>
<p><span style="font-size: 10pt; font-family: 'times new roman', times;">Eğer soldaki butona tıklanırsa oyun 1 kişiliktir ve sadece 1 oyuncunun ismini ister kullanıcıdan. Fakat sağdaki button tıklanırsa kullanıcıdan iki isim ister .Daha sonra kullanıcıdan seviye se&ccedil;mesi beklenir. Başla butonu ile birlikte de Forrm1 a&ccedil;ılır.</span></p>
<h1 style="text-align: justify; text-indent: 0cm; tab-stops: 35.4pt;">&nbsp;</h1>
</li>
<li style="text-autospace: none;">
<h1 style="text-align: justify; text-indent: 0cm; tab-stops: 35.4pt;"><span style="font-size: 10pt;">Form1:</span></h1>
<p><span style="font-size: 10pt; font-family: 'times new roman', times;">Form1 oyunun oynandığı oyun tahtasıdır. Oyun burada oynanır ve kazanan kişi burada ekrana yazar ve bu sayede oyun durmuş olur. Ayrıca bu kısımda men&uuml; vardır. Dosyaya tıklandığında yeni oyun yapılabilir yada oyundan &ccedil;ıkış yapılabilir. Yardm&rsquo;a tıklandığında oyun hakkında bilgi alınabilir.</span></p>
</li>
</ul>
<p><span style="color: black; font-size: 10pt; font-family: 'times new roman', times;"><strong><span style="font-size: 12.0pt; font-family: 'Segoe UI',sans-serif; color: #24292e;">Kullanıcı Kılavuzu:</span></strong></span></p>
<p><span style="font-size: 10pt; font-family: 'times new roman', times;">Kod &ccedil;alıştırıldığında karşılaşılan ilk ekranda ka&ccedil; kişi ile oyun oynanmak isteniyorsa onun girilmesi istiyor. Eğer Player1 se&ccedil;ilirse oyun oynayacak diğer oyuncu bilgisayar olacaktır. Ama Player2 se&ccedil;ilirse 2 oyuncu ile oynanılacaktır. Karşılaşılan 2. ekranda kullanıcıdan ad ve oyun seviyesi se&ccedil;ilmesi istenmektedir. Eğer tek kişi oynuyorsa diğer oyuncu bilgisayar olarak g&ouml;z&uuml;k&uuml;r. Fakat iki kişiyse iki oyuncu ismi girilmesi gerekir. Oyun seviyesi oyun tahtasının&nbsp; b&uuml;y&uuml;kl&uuml;ğ&uuml;ne g&ouml;re belirleniyor. 3x3, 5x5, 7x7 olmak &uuml;zere 3 boyut se&ccedil;eneği var. Başla butonu ile de oyun oynanacağı oyun tahtası ile karşılaşılacaktır. Burada men&uuml; bulunmaktadır. Men&uuml;den yeni oyun başlatabilir, &ccedil;ıkış yapabilir ya da oyun hakkında bilgi alınabilirmektedir. Oyunu 2 oyuncudan biri kazandığında oyun durur ve kazanan oyuncu ekranda yazar. B&ouml;ylelikle oyun bitmiş olur. Yeni oyun oynanmak istenirse men&uuml;den dosyayı se&ccedil;ip ordan da Yeni Oyun&rsquo;a tıklanmalıdır. Ya da &ccedil;ıkış yapmak isteniyorsa yine men&uuml;den dosyaya daha sonrada &Ccedil;ıkış&rsquo;a tıklanması yeterlidir.</span></p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
