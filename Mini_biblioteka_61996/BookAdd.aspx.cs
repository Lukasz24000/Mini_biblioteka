using Mini_biblioteka_61996.Api;
using Mini_biblioteka_61996.mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mini_biblioteka_61996
{
    public partial class BookAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BibliotekaAPI api = new BibliotekaAPI();
            var book = new Book()
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Year = Convert.ToInt32(txtYear.Text),
            };
        api.AddBook(book);


        }
    }
}