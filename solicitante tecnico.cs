namespace soporteticket.logica
public class gestor ticket{
    public List <Tecnico> LST tecnicos 
    {GET;} {set;}
    public List <solicitante> LST solicitantes  
    {GET;} {set;}
    public List <ticket>  LST tickets 
    {GET;} {set;}

    public gestor ticket() {
        LST tecnicos - NEW List <Tecnico> (),
        LST Solicitantes - NEW List <solicitante> (),
        LST ticket - NEW List < ticket> (),

        public static crearTicket { int ins numero. string
    str asunto, string sin  Descripcion, string str Categoria,
    string  sin Prioridad solicitante objsolitante )
     // validaciones
     ticket objTicket = NEW ticket (intNumero),
     strAsunto, str Descripcion, strCategoria, strPrioridad,objsolitante);
     objTicket asignar Tecnico (objtecnico);
      listtickets  add (objTicket),
      return objTicket; }
      public ticket buscarTicket(int int ticket);
      {
        ticket objTicket =
        LST ticket. find
        (t= t. intNumero == int ticket);
         if (obj ticket == null) {
            Console.WriteLine("ticket no existe");}
            return obj ticket;}}
