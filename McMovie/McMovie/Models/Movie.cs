using System;
using System.ComponentModel.DataAnnotations;
namespace McMovie.Models
{
    public class Movie 
    {
        public int Id { get; set; } /* contiene un campo ID que la base de datos requiere para clse principal */
        public string Title { get; set; }
            [DataType(DataType.Date)] /* Especifica el tipo de dato Date*/
            /*DataType:
             -El usuario no tiene  que especificar la informacion horaria en el campo de fecha.
             -Solo se muestra la fecha no informacion horaria*/
            public DateTime ReleaseDate { get; set; }
            public string Genre { get; set; }
            public decimal Price { get; set; }
    }
}
