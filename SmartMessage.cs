    public class SmartMessage
    {
        enum TypeMessage { Create = 1, Update = 2, Delete = 3, DeleteQuestion = 4 }

        /// <summary>
        /// Create nos permite crear un mensaje dinamicamente cuando se crea un registro.
        /// </summary>
        /// <param name="word">Indicamos la palabra que vamos a usar para crear el mensaje.</param>
        /// <param name="alias">Indicamos un texto que va a sustituir el texto indicado en el parametro word.</param>
        /// <param name="title">Indicamos un texto que sera mostrado en el titulo del mesaje.</param>
        public static void Create(string word, string alias = "", string title = "Aviso")
        {
            MessageBox.Show(GetMessage(word, alias, TypeMessage.Create), title, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Update nos permite crear un mensaje dinamicamente cuando se actualiza un registro.
        /// </summary>
        /// <param name="word">Indicamos la palabra que vamos a usar para crear el mensaje.</param>
        /// <param name="alias">Indicamos un texto que va a sustituir el texto indicado en el 
        /// parametro word.</param>
        /// <param name="title">Indicamos un texto que sera mostrado en el titulo del mesaje.</param>
        public static void Update(string word, string alias = "", string title = "Aviso")
        {
            MessageBox.Show(GetMessage(word, alias, TypeMessage.Update), title, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Delete nos permite crear un mensaje dinamicamente cuando se elimina un registro.
        /// </summary>
        /// <param name="word">Indicamos la palabra que vamos a usar para crear el mensaje.</param>
        /// <param name="alias">Indicamos un texto que va a sustituir el texto indicado en el parametro word.</param>
        /// <param name="title">Indicamos un texto que sera mostrado en el titulo del mesaje.</param>
        public static void Delete(string word, string alias = "", string title = "Aviso")
        {
            MessageBox.Show(GetMessage(word, alias, TypeMessage.Delete), title, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// DeleteQuestion nos permite crear un mensaje dinamicamente tipo pregunta cuando 
        /// se va a eliminar un registro.
        /// </summary>
        /// <param name="word">Indicamos la palabra que vamos a usar para crear el mensaje.</param>
        /// <param name="alias">Indicamos un texto que va a sustituir el texto indicado en el parametro word.</param>
        /// <param name="title">Indicamos un texto que sera mostrado en el titulo del mesaje.</param>
        public static bool DeleteQuestion(string word, string alias = "", string title = "Aviso")
        {
            bool bValue = false;
            DialogResult oResult = MessageBox.Show(GetMessage(word, alias, TypeMessage.DeleteQuestion), title, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (oResult == DialogResult.Yes)
                bValue = true;

            return bValue;
        }

        /// <summary>
        /// GetMessage es metodo nos permite crear la cadena de texto dinamicamente, que se mostrara
        /// en el mensaje.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="alias"></param>
        /// <param name="typeMessage"></param>
        /// <returns></returns>
        private static string GetMessage(string word, string alias, TypeMessage typeMessage)
        {
            string sMessage = String.Empty;
            string sOldWord = String.Empty;

            sOldWord = word;
            word = word.ToLower();

            if (word.EndsWith("l") || word.EndsWith("o") || word.EndsWith("n") || 
                word.EndsWith("e") || word.EndsWith("r") || word.EndsWith("s") || word.EndsWith("ma") || word.EndsWith("ta"))
            {
                if (typeMessage == TypeMessage.Create)
                    sMessage = String.Format("{0} creado correctamente.", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.Update)
                    sMessage = String.Format("{0} actualizado correctamente.", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.Delete)
                    sMessage = String.Format("{0} borrado correctamente", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.DeleteQuestion)
                    sMessage = String.Format("¿Desea Borrar este {0}?", alias == "" ? sOldWord : alias);
            }

            if (word.EndsWith("a") || word.EndsWith("d") || word.EndsWith("ón") || word.EndsWith("z") || 
                word.EndsWith("is") || word.EndsWith("ie") || word.EndsWith("umbre") || word.EndsWith("se"))
            {
                if (typeMessage == TypeMessage.Create)
                    sMessage = String.Format("{0} creada correctamente.", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.Update)
                    sMessage = String.Format("{0} actualizada correctamente.", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.Delete)
                    sMessage = String.Format("{0} borrada correctamente", alias == "" ? sOldWord : alias);
                if (typeMessage == TypeMessage.DeleteQuestion)
                    sMessage = String.Format("¿Desea Borrar esta {0}?", alias == "" ? sOldWord : alias);
            }

            return sMessage;
        }

       
    }