using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class book
    {
        public book(string bookId, string title, string author, decimal rentalprice)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.rentalprice = rentalprice;
        }

        public override string ToString()
        {
            return $"{bookId} {title} {author} {rentalprice}";
        }

        private string bookId {  get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private decimal rentalprice { get; set; }

    }

    




}
