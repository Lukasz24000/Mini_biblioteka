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
    public partial class BorrowingAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitBook();
                InitBorrows();
                InitReaders();
                //TextBox1.Text = "Rower";
            }
            

        }

        protected void InitBook()
        {
            BibliotekaAPI api = new BibliotekaAPI();
            var Books = api.GetBooks();
            
            ddlBook.DataSource = Books;
            ddlBook.DataTextField = "Title";
            ddlBook.DataValueField = "Id";
            ddlBook.DataBind();
        }

        protected void InitReaders()
        {
            BibliotekaAPI api = new BibliotekaAPI();
            var Reader = api.GetReaders();
            ddlReader.DataSource = Reader;
            ddlReader.DataTextField = "All";
            ddlReader.DataValueField = "Id";
            ddlReader.DataBind();

         }

        protected void InitBorrows()
        {
            BibliotekaAPI api = new BibliotekaAPI();
            var Boorrows = api.GetBorrows();

            BorrowsView.DataSource = Boorrows;
            //ddlBoorrows.DataTextField = "Reader" ;
            //ddlBoorrows.DataValueField = "Id";
            BorrowsView.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BibliotekaAPI api = new BibliotekaAPI();
            var Borrow = new Borrowing()
            {
                Book = new Book { Id = Convert.ToInt32(ddlBook.SelectedValue) },
                Reader = new Reader { Id = Convert.ToInt32(ddlReader.SelectedValue) },
                BorrowDate = cldBorrowDate.SelectedDate,
                ReturnDate = cldReturnDate.SelectedDate,
            };
            api.AddBorrowing(Borrow);
        }
    }
}
