# apiTry
Asp.net + MSSQL 
React Native ile geliştirilen mobil uygulama'nın veri tabanı ile bağlantısını sağlayabilmek amacıyla geliştirilmiştir.
Asp.net Web Api teknolojisi kullanılmıştır.
Model kullanımı;
        public int book_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string book_choise { get; set; }
        public string book_name { get; set; }
        public string writer_name { get; set; }
Controller kullanımı;
        public IEnumerable<Book> Get()
                {
                    IEnumerable<Book> model;
                    using (MadalyonContext dbContext = new MadalyonContext())
                    {
                        List<Book_Table> deneme = dbContext.Book_Table.ToList();
                        List<Book> aktar = new List<Book>();
                        foreach (Book_Table item in deneme)
                        {
                            Book t = new Book();
                            t.book_id = item.book_id;
                            t.user_id = item.user_id;
                            t.book_choise = item.book_choise;
                            t.book_name = item.book_name;
                            t.writer_name = item.writer_name;
                            aktar.Add(t);
                        }
                        model = aktar;
                    }
                    return model;
                }
