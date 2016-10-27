# SmartMessage
SmartMessage no permite crear mensajes dinamicamente, en formularios de Mantenimientos en las acciones (Guardar, Actualizar, Eliminar)

En vez de hacerlo de este manera:

      MessageBox.Show("Banco creado correctamente.", "Aviso", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);

Con SmartMessage lo harías de la siguiente manera y te daría el mismo resultado:

      SmartMessage.Create("Banco");
      
      
SmartMessage identifica la palabra pasada como parametro, para crear los sustantivos (Creando, Actualizado o Eliminado) 
masculinos o femeninos, para generar el mensaje dinamicamente.
