using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Model.Data
{
    interface IData
    {
        // Definir o CRUD ( Create - Read -  Update - Delete)
        // Create - Insert - | Read - select | Update - update | Delete - deleto|
        bool Create(Object objeto);
        bool Read(Object objeto); //Recebe um ID para consultar, objeto é referência
        List<Object> Read(); // vai ler uma lista e mostrar ela. Para consultar um parametro
        bool Update(Object objeto);
        bool Delete(Object objeto);



        
    }
}
