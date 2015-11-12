/*
               File: PTBUS021
        Description: Envía mails recordatorios de bienes no recibidos luego del plazo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:35.79
       Program type: Main program
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
   public class aptbus021 : GXProcedure
   {
      public static int Main( String[] args )
      {
         try
         {
            ArrayList args1 =  new ArrayList();
            foreach( string arg in args) {
                if (arg.StartsWith("\\config:"))
                    GeneXus.Configuration.Config.ConfigFileName = arg.Substring( 8) ;
                else
                    args1.Add( arg);
            }
            args = (string[])(args1.ToArray( typeof(string)));
            new aptbus021().execute();
            return 0 ;
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            Console.WriteLine( e .ToString());
            return 1 ;
         }
      }

      public void executeCmdLine( String[] args )
      {
         execute();
      }

      public aptbus021( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus021( IGxContext context )
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
         aptbus021 objaptbus021;
         objaptbus021 = new aptbus021();
         objaptbus021.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus021.executePrivateCatch ));
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
            Console.WriteLine( e .ToString());
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV11AHORA = DateTimeUtil.Now( ) ;
         if ( AV13PRC_NRO == 0 )
         {
            AV13PRC_NRO = 48 ;
         }
         AV12PRC_MSG = "PROCESO INICIADO..." ;
         GXt_int1 = 1 ;
         GXt_dtime2 = AV11AHORA ;
         GXt_char3 = " " ;
         new pcol001(context ).execute( ref  AV13PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV12PRC_MSG) ;
         AV11AHORA = GXt_dtime2 ;
         AV31REGISTROS = 0 ;
         /* Using cursor P001P2 */
         pr_default.execute(0, new Object[] {Gx_date});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A25TTBUS2_RespHacia = P001P2_A25TTBUS2_RespHacia[0] ;
            A77TTBUS2_PlazoRecepcion = P001P2_A77TTBUS2_PlazoRecepcion[0] ;
            n77TTBUS2_PlazoRecepcion = P001P2_n77TTBUS2_PlazoRecepcion[0] ;
            A26TTBUS2_EstadoEnvio = P001P2_A26TTBUS2_EstadoEnvio[0] ;
            AV29ASUNTO = "BIENES DE USO PENDIENTES DE RECEPCIONAR" ;
            AV14MENSAJE = "" ;
            new ptbus038(context ).execute(  A25TTBUS2_RespHacia, out  AV21hPER_MAIL) ;
            /* Using cursor P001P3 */
            pr_default.execute(1, new Object[] {A25TTBUS2_RespHacia});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = P001P3_A6USU_COD[0] ;
               A7USU_DES = P001P3_A7USU_DES[0] ;
               AV22hUSU_DES = StringUtil.Trim( A7USU_DES) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            AV23link_sistema = "http://intranetamsx/HTBUS001.aspx" ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + "En el archivo adjunto se informan los bienes de uso que están pendientes de recepción." + StringUtil.Chr( 13) ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + "Favor de confirmarlos a la brevedad." + StringUtil.Chr( 13) ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + StringUtil.Chr( 13) ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + "Para ver más detalles haga click en el siguiente hipervínculo: " ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + " " + StringUtil.Trim( AV23link_sistema) + StringUtil.Chr( 13) ;
            AV14MENSAJE = StringUtil.Trim( AV14MENSAJE) + StringUtil.Chr( 13) ;
            AV14MENSAJE = AV14MENSAJE + "Saludos Cordiales." ;
            AV25SDTAttachs.Clear();
            AV24NOMBRE_REPORTE = "LISTADO DE BIENES DE USO PENDIENTES DE RECEPCIÓN.PDF" ;
            AV26SDTAttachsItem.gxTpr_Nombrearchivo = AV24NOMBRE_REPORTE ;
            AV25SDTAttachs.Add(AV26SDTAttachsItem, 0);
            AV26SDTAttachsItem = new SdtSDTAttachs_SDTAttachsItem(context) ;
            AV24NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + AV24NOMBRE_REPORTE ;
            new ptbus022(context ).execute( ref  A25TTBUS2_RespHacia, ref  AV24NOMBRE_REPORTE) ;
            AV31REGISTROS = (long)(AV31REGISTROS+1) ;
            AV12PRC_MSG = "RECORDATORIO BIENES DE USO. " + StringUtil.Trim( StringUtil.Str( (decimal)(AV31REGISTROS), 10, 0)) + " CORREOS ENVIADOS." ;
            GXt_int1 = 1 ;
            GXt_dtime2 = AV11AHORA ;
            GXt_char3 = " " ;
            new pcol001(context ).execute( ref  AV13PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV12PRC_MSG) ;
            AV11AHORA = GXt_dtime2 ;
            GXt_char4 = "Intranet" ;
            GXt_char5 = "intranet@sancorsalud.com.ar" ;
            GXt_char6 = "intra860" ;
            GXt_char7 = "" ;
            GXt_char8 = "" ;
            new pmail_html_b(context ).execute( ref  GXt_char4, ref  GXt_char5, ref  GXt_char6, ref  AV22hUSU_DES, ref  AV21hPER_MAIL, ref  GXt_char7, ref  AV29ASUNTO, ref  AV14MENSAJE, ref  AV28WebrWapp, ref  AV25SDTAttachs, ref  GXt_char8) ;
            /* Using cursor P001P4 */
            pr_default.execute(2, new Object[] {AV27TTBUS2_IdMovimiento});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A53TTBUS2_IdUsuario = P001P4_A53TTBUS2_IdUsuario[0] ;
               A52TTBUS2_IdMovimiento = P001P4_A52TTBUS2_IdMovimiento[0] ;
               A102TTBUS2_TipoResp = P001P4_A102TTBUS2_TipoResp[0] ;
               if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "R") == 0 )
               {
                  new ptbus038(context ).execute(  A53TTBUS2_IdUsuario, out  AV21hPER_MAIL) ;
                  /* Using cursor P001P5 */
                  pr_default.execute(3, new Object[] {A53TTBUS2_IdUsuario});
                  while ( (pr_default.getStatus(3) != 101) )
                  {
                     A6USU_COD = P001P5_A6USU_COD[0] ;
                     A7USU_DES = P001P5_A7USU_DES[0] ;
                     AV22hUSU_DES = StringUtil.Trim( A7USU_DES) ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(3);
                  GXt_char8 = "Intranet" ;
                  GXt_char7 = "intranet@sancorsalud.com.ar" ;
                  GXt_char6 = "intra860" ;
                  GXt_char5 = "" ;
                  GXt_char4 = "" ;
                  new pmail_html_b(context ).execute( ref  GXt_char8, ref  GXt_char7, ref  GXt_char6, ref  AV22hUSU_DES, ref  AV21hPER_MAIL, ref  GXt_char5, ref  AV29ASUNTO, ref  AV14MENSAJE, ref  AV28WebrWapp, ref  AV25SDTAttachs, ref  GXt_char4) ;
               }
               pr_default.readNext(2);
            }
            pr_default.close(2);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV30PRC_SAL = StringUtil.Trim( AV24NOMBRE_REPORTE) ;
         AV11AHORA = DateTimeUtil.Now( ) ;
         AV12PRC_MSG = "PROCESO FINALIZADO CORRECTAMENTE." ;
         /* Optimized UPDATE. */
         /* Using cursor P001P6 */
         pr_default.execute(4, new Object[] {AV30PRC_SAL, AV12PRC_MSG, AV11AHORA, AV13PRC_NRO});
         pr_default.close(4);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS021");
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
         AV11AHORA = (DateTime)(DateTime.MinValue) ;
         AV12PRC_MSG = "" ;
         scmdbuf = "" ;
         Gx_date = DateTime.MinValue ;
         P001P2_A25TTBUS2_RespHacia = new String[] {""} ;
         P001P2_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         P001P2_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         P001P2_A26TTBUS2_EstadoEnvio = new short[1] ;
         A25TTBUS2_RespHacia = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV29ASUNTO = "" ;
         AV14MENSAJE = "" ;
         AV21hPER_MAIL = "" ;
         P001P3_A6USU_COD = new String[] {""} ;
         P001P3_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV22hUSU_DES = "" ;
         AV23link_sistema = "" ;
         AV25SDTAttachs = new GxObjectCollection( context, "SDTAttachs.SDTAttachsItem", "MarianoTesis", "SdtSDTAttachs_SDTAttachsItem", "GeneXus.Programs");
         AV24NOMBRE_REPORTE = "" ;
         AV26SDTAttachsItem = new SdtSDTAttachs_SDTAttachsItem(context);
         GXt_dtime2 = (DateTime)(DateTime.MinValue) ;
         GXt_char3 = "" ;
         AV28WebrWapp = new GxWebWrapper();
         P001P4_A53TTBUS2_IdUsuario = new String[] {""} ;
         P001P4_A52TTBUS2_IdMovimiento = new long[1] ;
         P001P4_A102TTBUS2_TipoResp = new String[] {""} ;
         A53TTBUS2_IdUsuario = "" ;
         A102TTBUS2_TipoResp = "" ;
         P001P5_A6USU_COD = new String[] {""} ;
         P001P5_A7USU_DES = new String[] {""} ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         AV30PRC_SAL = "" ;
         A159PRC_SAL = "" ;
         A161PRC_MSG = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus021__default(),
            new Object[][] {
                new Object[] {
               P001P2_A25TTBUS2_RespHacia, P001P2_A77TTBUS2_PlazoRecepcion, P001P2_n77TTBUS2_PlazoRecepcion, P001P2_A26TTBUS2_EstadoEnvio
               }
               , new Object[] {
               P001P3_A6USU_COD, P001P3_A7USU_DES
               }
               , new Object[] {
               P001P4_A53TTBUS2_IdUsuario, P001P4_A52TTBUS2_IdMovimiento, P001P4_A102TTBUS2_TipoResp
               }
               , new Object[] {
               P001P5_A6USU_COD, P001P5_A7USU_DES
               }
               , new Object[] {
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short A26TTBUS2_EstadoEnvio ;
      private short GXt_int1 ;
      private long AV13PRC_NRO ;
      private long AV31REGISTROS ;
      private long AV27TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV12PRC_MSG ;
      private String scmdbuf ;
      private String A25TTBUS2_RespHacia ;
      private String AV29ASUNTO ;
      private String AV21hPER_MAIL ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV22hUSU_DES ;
      private String AV23link_sistema ;
      private String AV24NOMBRE_REPORTE ;
      private String GXt_char3 ;
      private String A53TTBUS2_IdUsuario ;
      private String A102TTBUS2_TipoResp ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String AV30PRC_SAL ;
      private String A159PRC_SAL ;
      private String A161PRC_MSG ;
      private DateTime AV11AHORA ;
      private DateTime GXt_dtime2 ;
      private DateTime A157PRC_FIN ;
      private DateTime Gx_date ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private String AV14MENSAJE ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P001P2_A25TTBUS2_RespHacia ;
      private DateTime[] P001P2_A77TTBUS2_PlazoRecepcion ;
      private bool[] P001P2_n77TTBUS2_PlazoRecepcion ;
      private short[] P001P2_A26TTBUS2_EstadoEnvio ;
      private String[] P001P3_A6USU_COD ;
      private String[] P001P3_A7USU_DES ;
      private String[] P001P4_A53TTBUS2_IdUsuario ;
      private long[] P001P4_A52TTBUS2_IdMovimiento ;
      private String[] P001P4_A102TTBUS2_TipoResp ;
      private String[] P001P5_A6USU_COD ;
      private String[] P001P5_A7USU_DES ;
      private GxWebWrapper AV28WebrWapp ;
      [ObjectCollection(ItemType=typeof( SdtSDTAttachs_SDTAttachsItem ))]
      private IGxCollection AV25SDTAttachs ;
      private SdtSDTAttachs_SDTAttachsItem AV26SDTAttachsItem ;
   }

   public class aptbus021__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001P2 ;
          prmP001P2 = new Object[] {
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001P3 ;
          prmP001P3 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001P4 ;
          prmP001P4 = new Object[] {
          new Object[] {"@AV27TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP001P5 ;
          prmP001P5 = new Object[] {
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001P6 ;
          prmP001P6 = new Object[] {
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV13PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001P2", "SELECT DISTINCT [TTBUS2_RespHacia], [TTBUS2_PlazoRecepcion], [TTBUS2_EstadoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_PlazoRecepcion] < @Gx_date) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_RespHacia] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001P2,100,0,true,false )
             ,new CursorDef("P001P3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001P3,1,0,false,true )
             ,new CursorDef("P001P4", "SELECT [TTBUS2_IdUsuario], [TTBUS2_IdMovimiento], [TTBUS2_TipoResp] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV27TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001P4,100,0,true,false )
             ,new CursorDef("P001P5", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_IdUsuario ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001P5,1,0,false,true )
             ,new CursorDef("P001P6", "UPDATE [COL000] SET [PRC_EST]=2, [PRC_SAL]=@PRC_SAL, [PRC_MSG]=@PRC_MSG, [PRC_FIN]=@PRC_FIN  WHERE [PRC_NRO] = @AV13PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001P6)
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                break;
       }
    }

 }

}
