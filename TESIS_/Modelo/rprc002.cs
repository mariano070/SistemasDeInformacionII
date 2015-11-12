/*
               File: RPRC002
        Description: CONTROL TOPES PROCESOS ACTIVOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:15.67
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
   public class rprc002 : GXProcedure
   {
      public rprc002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public rprc002( IGxContext context )
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

      public void execute( ref String aP0_PRC_NOM ,
                           ref String aP1_USUARIO ,
                           ref short aP2_OK ,
                           ref String aP3_MENSAJE )
      {
         this.AV8PRC_NOM = aP0_PRC_NOM;
         this.AV10USUARIO = aP1_USUARIO;
         this.AV9OK = aP2_OK;
         this.AV11MENSAJE = aP3_MENSAJE;
         initialize();
         executePrivate();
         aP0_PRC_NOM=this.AV8PRC_NOM;
         aP1_USUARIO=this.AV10USUARIO;
         aP2_OK=this.AV9OK;
         aP3_MENSAJE=this.AV11MENSAJE;
      }

      public String executeUdp( ref String aP0_PRC_NOM ,
                                ref String aP1_USUARIO ,
                                ref short aP2_OK )
      {
         this.AV8PRC_NOM = aP0_PRC_NOM;
         this.AV10USUARIO = aP1_USUARIO;
         this.AV9OK = aP2_OK;
         this.AV11MENSAJE = aP3_MENSAJE;
         initialize();
         executePrivate();
         aP0_PRC_NOM=this.AV8PRC_NOM;
         aP1_USUARIO=this.AV10USUARIO;
         aP2_OK=this.AV9OK;
         aP3_MENSAJE=this.AV11MENSAJE;
         return AV11MENSAJE ;
      }

      public void executeSubmit( ref String aP0_PRC_NOM ,
                                 ref String aP1_USUARIO ,
                                 ref short aP2_OK ,
                                 ref String aP3_MENSAJE )
      {
         rprc002 objrprc002;
         objrprc002 = new rprc002();
         objrprc002.AV8PRC_NOM = aP0_PRC_NOM;
         objrprc002.AV10USUARIO = aP1_USUARIO;
         objrprc002.AV9OK = aP2_OK;
         objrprc002.AV11MENSAJE = aP3_MENSAJE;
         objrprc002.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objrprc002.executePrivateCatch ));
         aP0_PRC_NOM=this.AV8PRC_NOM;
         aP1_USUARIO=this.AV10USUARIO;
         aP2_OK=this.AV9OK;
         aP3_MENSAJE=this.AV11MENSAJE;
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
         new rprc003(context ).execute( ) ;
         AV9OK = 1 ;
         AV12ACTIVOS_TOT = 0 ;
         AV13ACTIVOS_PRC = 0 ;
         /* Using cursor P000V2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A160PRC_INV = P000V2_A160PRC_INV[0] ;
            A158PRC_EST = P000V2_A158PRC_EST[0] ;
            A93PRC_NOM = P000V2_A93PRC_NOM[0] ;
            A79PRC_NRO = P000V2_A79PRC_NRO[0] ;
            if ( ( A158PRC_EST == 1 ) || ( A158PRC_EST == 4 ) || ( A158PRC_EST == 5 ) )
            {
               AV12ACTIVOS_TOT = (int)(AV12ACTIVOS_TOT+1) ;
               if ( StringUtil.StrCmp(A93PRC_NOM, AV8PRC_NOM) == 0 )
               {
                  AV13ACTIVOS_PRC = (int)(AV13ACTIVOS_PRC+1) ;
               }
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV12ACTIVOS_TOT > 3 )
         {
            AV9OK = 0 ;
            AV11MENSAJE = "Se ha superado el TOPE GENERAL de " + "3" + "Procesos Simultaneos." ;
         }
         else
         {
            if ( AV13ACTIVOS_PRC > 2 )
            {
               AV9OK = 0 ;
               AV11MENSAJE = "Se ha superado el TOPE de " + "2" + " Procesos Simultáneos para el proceso seleccionado." ;
            }
            else
            {
            }
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
         scmdbuf = "" ;
         P000V2_A160PRC_INV = new String[] {""} ;
         P000V2_A158PRC_EST = new short[1] ;
         P000V2_A93PRC_NOM = new String[] {""} ;
         P000V2_A79PRC_NRO = new long[1] ;
         A160PRC_INV = "" ;
         A93PRC_NOM = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.rprc002__default(),
            new Object[][] {
                new Object[] {
               P000V2_A160PRC_INV, P000V2_A158PRC_EST, P000V2_A93PRC_NOM, P000V2_A79PRC_NRO
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV9OK ;
      private short A158PRC_EST ;
      private int AV12ACTIVOS_TOT ;
      private int AV13ACTIVOS_PRC ;
      private long A79PRC_NRO ;
      private String AV8PRC_NOM ;
      private String AV10USUARIO ;
      private String AV11MENSAJE ;
      private String scmdbuf ;
      private String A160PRC_INV ;
      private String A93PRC_NOM ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_PRC_NOM ;
      private String aP1_USUARIO ;
      private short aP2_OK ;
      private String aP3_MENSAJE ;
      private IDataStoreProvider pr_default ;
      private String[] P000V2_A160PRC_INV ;
      private short[] P000V2_A158PRC_EST ;
      private String[] P000V2_A93PRC_NOM ;
      private long[] P000V2_A79PRC_NRO ;
   }

   public class rprc002__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000V2 ;
          prmP000V2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P000V2", "SELECT [PRC_INV], [PRC_EST], [PRC_NOM], [PRC_NRO] FROM [COL000] WITH (NOLOCK) WHERE [PRC_INV] <> 'X' ORDER BY [PRC_NRO] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V2,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
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
