using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Note
    {
        public string UserName { get; }
        public string Opponetname { get; set; }
        public int Result { get; }
        public int currentrating { get; } 
        public int RatingGame { get; set; }
        public int ID { get; }
        public Note(string usname, string name, int result,int currentrat, int rating, int id)
        {
            UserName = usname;
            RatingGame = rating;
            currentrating = currentrat;
            Opponetname = name;
            Result = result;
            ID = id;
        }
    }
}
