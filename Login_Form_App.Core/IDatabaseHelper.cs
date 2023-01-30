using System.Collections.Generic;
using System.Data;

namespace Login_Form_App.Core
{
    public interface IDatabaseHelper
    {
        (int RowCount, bool Success, string Message) Insert(Dictionary<string, dynamic> parameters);
        (int RowCount, bool Success, string Message) InsertProduct(Dictionary<string, dynamic> parameters);
        (int RowCount, bool Success, string Message) GetLogin(Dictionary<string, dynamic> parameters);
        (int RowCount, bool Success, string Message,List<Product> db) Search(string value,int category);
        (int RowCount, bool Success, string Message) DeleteSelected(int value);

    }
}