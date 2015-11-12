/*
               File: RPRC003
        Description: PRC003
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:15.86
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class rprc003 : GXProcedure
   {
      public rprc003( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public rprc003( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         rprc003 objrprc003;
         objrprc003 = new rprc003();
         objrprc003.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrprc003.executePrivateCatch ));
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV9OK = 1 ;
         AV12ACTIVOS_TOT = 0 ;
         AV13ACTIVOS_PRC = 0 ;
         AV14AHORA = DateTimeUtil.ServerNow( context, "DEFAULT") ;
         AV15AHORANUL = (DateTime)(DateTime.MinValue) ;
         AV17PRC_NRO = 0 ;
         AV16PRC_EST = 0 ;
         /* Using cursor P000W2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A160PRC_INV = P000W2_A160PRC_INV[0] ;
            A158PRC_EST = P000W2_A158PRC_EST[0] ;
            A157PRC_FIN = P000W2_A157PRC_FIN[0] ;
            A97PRC_EML = P000W2_A97PRC_EML[0] ;
            A161PRC_MSG = P000W2_A161PRC_MSG[0] ;
            A94PRC_USR = P000W2_A94PRC_USR[0] ;
            A79PRC_NRO = P000W2_A79PRC_NRO[0] ;
            if ( ( A158PRC_EST == 1 ) || ( A158PRC_EST == 4 ) )
            {
               if ( DateTimeUtil.TDiff( AV14AHORA, A157PRC_FIN) > 600 )
               {
                  if ( DateTimeUtil.TDiff( AV14AHORA, A157PRC_FIN) > 1200 )
                  {
                  }
                  else
                  {
                     if ( ( DateTimeUtil.TDiff( AV14AHORA, A97PRC_EML) > 300 ) || (DateTime.MinValue==A97PRC_EML) )
                     {
                        AV11MENSAJE = "Proceso Nro. " + StringUtil.Str( (decimal)(A79PRC_NRO), 10, 0) + " demorado en cola. Sistema: Obras Sociales. Usuario: " + A94PRC_USR + " Verificar Cola de procesos. MENSJAJE:" + A161PRC_MSG ;
                        GXt_char1 = "INTRANET: Proceso demorado.(Solicitud Usuario)" ;
                        new pmail_soporte(context ).execute( ref  GXt_char1, ref  AV11MENSAJE) ;
                        AV11MENSAJE = "Incidente informado a Soporte Sistemas " + context.localUtil.Format( AV14AHORA, "99/99/99 99:99") ;
                        new pcol001m(context ).execute( ref  A79PRC_NRO, ref  AV14AHORA, ref  AV11MENSAJE) ;
                     }
                  }
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ! (0==AV17PRC_NRO) )
         {
            new pprc001(context ).execute( ref  AV17PRC_NRO) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         AV14AHORA = (DateTime)(DateTime.MinValue) ;
         AV15AHORANUL = (DateTime)(DateTime.MinValue) ;
         scmdbuf = "" ;
         P000W2_A160PRC_INV = new String[] {""} ;
         P000W2_A158PRC_EST = new short[1] ;
         P000W2_A157PRC_FIN = new DateTime[] {DateTime.MinValue} ;
         P000W2_A97PRC_EML = new DateTime[] {DateTime.MinValue} ;
         P000W2_A161PRC_MSG = new String[] {""} ;
         P000W2_A94PRC_USR = new String[] {""} ;
         P000W2_A79PRC_NRO = new long[1] ;
         A160PRC_INV = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         A97PRC_EML = (DateTime)(DateTime.MinValue) ;
         A161PRC_MSG = "" ;
         A94PRC_USR = "" ;
         AV11MENSAJE = "" ;
         GXt_char1 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rprc003__default(),
            new Object[][] {
                new Object[] {
               P000W2_A160PRC_INV, P000W2_A158PRC_EST, P000W2_A157PRC_FIN, P000W2_A97PRC_EML, P000W2_A161PRC_MSG, P000W2_A94PRC_USR, P000W2_A79PRC_NRO
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9OK ;
      private short AV16PRC_EST ;
      private short A158PRC_EST ;
      private int AV12ACTIVOS_TOT ;
      private int AV13ACTIVOS_PRC ;
      private long AV17PRC_NRO ;
      private long A79PRC_NRO ;
      private String scmdbuf ;
      private String A160PRC_INV ;
      private String A161PRC_MSG ;
      private String A94PRC_USR ;
      private String AV11MENSAJE ;
      private String GXt_char1 ;
      private DateTime AV14AHORA ;
      private DateTime AV15AHORANUL ;
      private DateTime A157PRC_FIN ;
      private DateTime A97PRC_EML ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000W2_A160PRC_INV ;
      private short[] P000W2_A158PRC_EST ;
      private DateTime[] P000W2_A157PRC_FIN ;
      private DateTime[] P000W2_A97PRC_EML ;
      private String[] P000W2_A161PRC_MSG ;
      private String[] P000W2_A94PRC_USR ;
      private long[] P000W2_A79PRC_NRO ;
   }

   public class rprc003__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000W2 ;
          prmP000W2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000W2", "SELECT [PRC_INV], [PRC_EST], [PRC_FIN], [PRC_EML], [PRC_MSG], [PRC_USR], [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_INV] <> 'X' ORDER BY [PRC_NRO] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W2,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 75) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 16) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
