/*
               File: PBUS021
        Description: Cargo valores de último registro guardado
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:52.75
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
   public class pbus021 : GXProcedure
   {
      public pbus021( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pbus021( IGxContext context )
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

      public void execute( out short aP0_BUS_RUB ,
                           out String aP1_BUS_DES ,
                           out DateTime aP2_BUS_FAL ,
                           out DateTime aP3_BUS_FAD ,
                           out String aP4_BUS_NCO ,
                           out String aP5_BUS_COM )
      {
         this.AV13BUS_RUB = 0 ;
         this.AV9BUS_DES = "" ;
         this.AV11BUS_FAL = DateTime.MinValue ;
         this.AV10BUS_FAD = DateTime.MinValue ;
         this.AV12BUS_NCO = "" ;
         this.AV8BUS_COM = "" ;
         initialize();
         executePrivate();
         aP0_BUS_RUB=this.AV13BUS_RUB;
         aP1_BUS_DES=this.AV9BUS_DES;
         aP2_BUS_FAL=this.AV11BUS_FAL;
         aP3_BUS_FAD=this.AV10BUS_FAD;
         aP4_BUS_NCO=this.AV12BUS_NCO;
         aP5_BUS_COM=this.AV8BUS_COM;
      }

      public String executeUdp( out short aP0_BUS_RUB ,
                                out String aP1_BUS_DES ,
                                out DateTime aP2_BUS_FAL ,
                                out DateTime aP3_BUS_FAD ,
                                out String aP4_BUS_NCO )
      {
         this.AV13BUS_RUB = 0 ;
         this.AV9BUS_DES = "" ;
         this.AV11BUS_FAL = DateTime.MinValue ;
         this.AV10BUS_FAD = DateTime.MinValue ;
         this.AV12BUS_NCO = "" ;
         this.AV8BUS_COM = "" ;
         initialize();
         executePrivate();
         aP0_BUS_RUB=this.AV13BUS_RUB;
         aP1_BUS_DES=this.AV9BUS_DES;
         aP2_BUS_FAL=this.AV11BUS_FAL;
         aP3_BUS_FAD=this.AV10BUS_FAD;
         aP4_BUS_NCO=this.AV12BUS_NCO;
         aP5_BUS_COM=this.AV8BUS_COM;
         return AV8BUS_COM ;
      }

      public void executeSubmit( out short aP0_BUS_RUB ,
                                 out String aP1_BUS_DES ,
                                 out DateTime aP2_BUS_FAL ,
                                 out DateTime aP3_BUS_FAD ,
                                 out String aP4_BUS_NCO ,
                                 out String aP5_BUS_COM )
      {
         pbus021 objpbus021;
         objpbus021 = new pbus021();
         objpbus021.AV13BUS_RUB = 0 ;
         objpbus021.AV9BUS_DES = "" ;
         objpbus021.AV11BUS_FAL = DateTime.MinValue ;
         objpbus021.AV10BUS_FAD = DateTime.MinValue ;
         objpbus021.AV12BUS_NCO = "" ;
         objpbus021.AV8BUS_COM = "" ;
         objpbus021.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpbus021.executePrivateCatch ));
         aP0_BUS_RUB=this.AV13BUS_RUB;
         aP1_BUS_DES=this.AV9BUS_DES;
         aP2_BUS_FAL=this.AV11BUS_FAL;
         aP3_BUS_FAD=this.AV10BUS_FAD;
         aP4_BUS_NCO=this.AV12BUS_NCO;
         aP5_BUS_COM=this.AV8BUS_COM;
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
         /* Using cursor P00242 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A353BUS_AUX_RUB = P00242_A353BUS_AUX_RUB[0] ;
            A354BUS_AUX_DES = P00242_A354BUS_AUX_DES[0] ;
            A355BUS_AUX_FAL = P00242_A355BUS_AUX_FAL[0] ;
            A356BUS_AUX_FAD = P00242_A356BUS_AUX_FAD[0] ;
            A357BUS_AUX_NCO = P00242_A357BUS_AUX_NCO[0] ;
            A358BUS_AUX_COM = P00242_A358BUS_AUX_COM[0] ;
            A352BUS_AUX_ID = P00242_A352BUS_AUX_ID[0] ;
            AV13BUS_RUB = A353BUS_AUX_RUB ;
            AV9BUS_DES = A354BUS_AUX_DES ;
            AV11BUS_FAL = A355BUS_AUX_FAL ;
            AV10BUS_FAD = A356BUS_AUX_FAD ;
            AV12BUS_NCO = A357BUS_AUX_NCO ;
            AV8BUS_COM = A358BUS_AUX_COM ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV14nro_lectura = (short)(NumberUtil.Val( AV15SESION.Get("nro_lectura"), ".")) ;
         AV14nro_lectura = (short)(AV14nro_lectura+1) ;
         AV15SESION.Set("nro_lectura", StringUtil.Trim( StringUtil.Str( (decimal)(AV14nro_lectura), 1, 0)));
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
         scmdbuf = "" ;
         P00242_A353BUS_AUX_RUB = new short[1] ;
         P00242_A354BUS_AUX_DES = new String[] {""} ;
         P00242_A355BUS_AUX_FAL = new DateTime[] {DateTime.MinValue} ;
         P00242_A356BUS_AUX_FAD = new DateTime[] {DateTime.MinValue} ;
         P00242_A357BUS_AUX_NCO = new String[] {""} ;
         P00242_A358BUS_AUX_COM = new String[] {""} ;
         P00242_A352BUS_AUX_ID = new short[1] ;
         A354BUS_AUX_DES = "" ;
         A355BUS_AUX_FAL = DateTime.MinValue ;
         A356BUS_AUX_FAD = DateTime.MinValue ;
         A357BUS_AUX_NCO = "" ;
         A358BUS_AUX_COM = "" ;
         AV15SESION = new GxWebSession( context);
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pbus021__default(),
            new Object[][] {
                new Object[] {
               P00242_A353BUS_AUX_RUB, P00242_A354BUS_AUX_DES, P00242_A355BUS_AUX_FAL, P00242_A356BUS_AUX_FAD, P00242_A357BUS_AUX_NCO, P00242_A358BUS_AUX_COM, P00242_A352BUS_AUX_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A353BUS_AUX_RUB ;
      private short A352BUS_AUX_ID ;
      private short AV13BUS_RUB ;
      private short AV14nro_lectura ;
      private String AV8BUS_COM ;
      private String scmdbuf ;
      private String A354BUS_AUX_DES ;
      private String A357BUS_AUX_NCO ;
      private String A358BUS_AUX_COM ;
      private String AV9BUS_DES ;
      private String AV12BUS_NCO ;
      private DateTime A355BUS_AUX_FAL ;
      private DateTime A356BUS_AUX_FAD ;
      private DateTime AV11BUS_FAL ;
      private DateTime AV10BUS_FAD ;
      private GxWebSession AV15SESION ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00242_A353BUS_AUX_RUB ;
      private String[] P00242_A354BUS_AUX_DES ;
      private DateTime[] P00242_A355BUS_AUX_FAL ;
      private DateTime[] P00242_A356BUS_AUX_FAD ;
      private String[] P00242_A357BUS_AUX_NCO ;
      private String[] P00242_A358BUS_AUX_COM ;
      private short[] P00242_A352BUS_AUX_ID ;
      private short aP0_BUS_RUB ;
      private String aP1_BUS_DES ;
      private DateTime aP2_BUS_FAL ;
      private DateTime aP3_BUS_FAD ;
      private String aP4_BUS_NCO ;
      private String aP5_BUS_COM ;
   }

   public class pbus021__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00242 ;
          prmP00242 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00242", "SELECT [BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM], [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) ORDER BY [BUS_AUX_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00242,100,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 12) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 2) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
