#V 1.1.0.0
- Se agregan extenders para obtener los documentos de una carpeta
#V 1.2.0.0
	- Se agrega factory para obtener las implementaciones de las interfaces dependiendo el repositorio que se especifique
	- Se agregan constructores defacult a algunas implementaciones
	V 1.2.1.0
	- Se agrega propiedad para obtener la sesion activa del buscador, importador y exportador
	V 1.3.0.0
	- Modificaciones en el factory para aceptar sesiones ya creadas
	V 1.4.0.0
	- Modificaciones en el factory para crear operaciones de repositorio
	V 1.4.1.0
	- Se corrigió un problema cuando se buscaba un documento por Id en el Laserfiche
	V 1.4.2.0
	- Se corrigio un problema en el método de exportar documento
	V 1.5.0.0
	
	- Se agregaron métodos asincrónicos en la importación de documentos, además se agregó metodo para crear una instancia del importer en el RepositoriosFactory
	V 1.6.0.0
	- Se agregaron métodos para la búsqueda de carpetas por referencia
	V 1.7.0.0
	- Se agregaron sobrecargar en el importador para determinar si un archivo se puede sobreescribir o no
	- Se crea un método en Operaciones para obtener un archivo mediante la ruta
	V 1.7.1.0
	- Revision de los métodos de Importar documentos cuando el parametro overwrite es true
	V 1.7.2.0
	- Correcciones en las búsquedas de LaserficheRepository
	V 1.8.0.0
	- Se agrgan métodos para obtener directorios de Laserfiche
	V 1.9.0.0
	- Se agrgan métodos para crear directorios de Laserfiche
  V 2.0.0.0
  - Se agrega repositorio SIR EFile y sus métodos.
  V 2.0.2.0
  - Se agrega propiedad PlantillaId en la clase DocumentoRepositorio