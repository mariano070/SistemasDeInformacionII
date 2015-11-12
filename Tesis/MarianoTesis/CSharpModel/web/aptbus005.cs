/*
               File: PTBUS005
        Description: Mail de cancelación de cambio de ubicación
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:35.22
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
   public class aptbus005 : GXProcedure
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
            String aP0_cTTBUS2_IdMovimiento = new String(' ',0)  ;
             long aP1_PRC_NRO ;
            if ( 0 < args.Length )
            {
               aP0_cTTBUS2_IdMovimiento=((String)(args[0]));
            }
            else
            {
               aP0_cTTBUS2_IdMovimiento="";
            }
            if ( 1 < args.Length )
            {
               aP1_PRC_NRO=((long)(NumberUtil.Val( (String)(args[1]), ".")));
            }
            else
            {
               aP1_PRC_NRO=0;
            }
            new aptbus005().execute(ref aP0_cTTBUS2_IdMovimiento, ref aP1_PRC_NRO);
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
         String aP0_cTTBUS2_IdMovimiento = new String(' ',0)  ;
          long aP1_PRC_NRO ;
         if ( 0 < args.Length )
         {
            aP0_cTTBUS2_IdMovimiento=((String)(args[0]));
         }
         else
         {
            aP0_cTTBUS2_IdMovimiento="";
         }
         if ( 1 < args.Length )
         {
            aP1_PRC_NRO=((long)(NumberUtil.Val( (String)(args[1]), ".")));
         }
         else
         {
            aP1_PRC_NRO=0;
         }
         execute(ref aP0_cTTBUS2_IdMovimiento, ref aP1_PRC_NRO);
      }

      public aptbus005( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus005( IGxContext context )
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

      public void execute( ref String aP0_cTTBUS2_IdMovimiento ,
                           ref long aP1_PRC_NRO )
      {
         this.AV10cTTBUS2_IdMovimiento = aP0_cTTBUS2_IdMovimiento;
         this.AV8PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS2_IdMovimiento=this.AV10cTTBUS2_IdMovimiento;
         aP1_PRC_NRO=this.AV8PRC_NRO;
      }

      public long executeUdp( ref String aP0_cTTBUS2_IdMovimiento )
      {
         this.AV10cTTBUS2_IdMovimiento = aP0_cTTBUS2_IdMovimiento;
         this.AV8PRC_NRO = aP1_PRC_NRO;
         initialize();
         executePrivate();
         aP0_cTTBUS2_IdMovimiento=this.AV10cTTBUS2_IdMovimiento;
         aP1_PRC_NRO=this.AV8PRC_NRO;
         return AV8PRC_NRO ;
      }

      public void executeSubmit( ref String aP0_cTTBUS2_IdMovimiento ,
                                 ref long aP1_PRC_NRO )
      {
         aptbus005 objaptbus005;
         objaptbus005 = new aptbus005();
         objaptbus005.AV10cTTBUS2_IdMovimiento = aP0_cTTBUS2_IdMovimiento;
         objaptbus005.AV8PRC_NRO = aP1_PRC_NRO;
         objaptbus005.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus005.executePrivateCatch ));
         aP0_cTTBUS2_IdMovimiento=this.AV10cTTBUS2_IdMovimiento;
         aP1_PRC_NRO=this.AV8PRC_NRO;
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
         AV23AHORA = DateTimeUtil.Now( ) ;
         AV22PRC_MSG = "PROCESO INICIADO..." ;
         GXt_int1 = 1 ;
         GXt_dtime2 = AV23AHORA ;
         GXt_char3 = " " ;
         new pcol001(context ).execute( ref  AV8PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV22PRC_MSG) ;
         AV23AHORA = GXt_dtime2 ;
         AV9TTBUS2_IdMovimiento = (long)(NumberUtil.Val( AV10cTTBUS2_IdMovimiento, ".")) ;
         /* Using cursor P001O2 */
         pr_default.execute(0, new Object[] {AV9TTBUS2_IdMovimiento});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A22TTBUS2_IdBien = P001O2_A22TTBUS2_IdBien[0] ;
            A25TTBUS2_RespHacia = P001O2_A25TTBUS2_RespHacia[0] ;
            A24TTBUS2_RespDesde = P001O2_A24TTBUS2_RespDesde[0] ;
            A52TTBUS2_IdMovimiento = P001O2_A52TTBUS2_IdMovimiento[0] ;
            A50TTBUS2_MotivoCancelacion = P001O2_A50TTBUS2_MotivoCancelacion[0] ;
            n50TTBUS2_MotivoCancelacion = P001O2_n50TTBUS2_MotivoCancelacion[0] ;
            AV28TTBUS2_MotivoCancelacion = A50TTBUS2_MotivoCancelacion ;
            new ptbus038(context ).execute(  A24TTBUS2_RespDesde, out  AV11dPER_MAIL) ;
            /* Using cursor P001O3 */
            pr_default.execute(1, new Object[] {A24TTBUS2_RespDesde});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = P001O3_A6USU_COD[0] ;
               A7USU_DES = P001O3_A7USU_DES[0] ;
               AV12dUSU_DES = StringUtil.Trim( A7USU_DES) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            new ptbus038(context ).execute(  A25TTBUS2_RespHacia, out  AV14hPER_MAIL) ;
            /* Using cursor P001O4 */
            pr_default.execute(2, new Object[] {A25TTBUS2_RespHacia});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A6USU_COD = P001O4_A6USU_COD[0] ;
               A7USU_DES = P001O4_A7USU_DES[0] ;
               AV13hUSU_DES = StringUtil.Trim( A7USU_DES) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Using cursor P001O5 */
            pr_default.execute(3, new Object[] {A22TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A11TTBUS_Id = P001O5_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P001O5_A12TTBUS_Descripcion[0] ;
               AV26TTBUS_Descripcion = StringUtil.Trim( A12TTBUS_Descripcion) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
            AV25link_sistema = "http://intranetamsx/HTBUS001.aspx" ;
            AV16ASUNTO = "MOVIMIENTO CANCELADO DEL BIEN DE USO " + "\"" + StringUtil.Trim( StringUtil.Upper( AV26TTBUS_Descripcion)) + "\"" ;
            AV15MENSAJE = "El envío Nº" + StringUtil.Trim( StringUtil.Str( (decimal)(AV9TTBUS2_IdMovimiento), 12, 0)) + " del bien de uso " + "\"" + StringUtil.Trim( StringUtil.Upper( AV26TTBUS_Descripcion)) + "\"" + " (bien Nº " + StringUtil.Trim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)) + ") ha sido cancelado por el responsable de envío: " + StringUtil.Trim( AV12dUSU_DES) + " (correo: " + StringUtil.Trim( AV11dPER_MAIL) + ")." + StringUtil.Chr( 13) ;
            AV15MENSAJE = AV15MENSAJE + "El motivo de cancelación es: " + StringUtil.Trim( A50TTBUS2_MotivoCancelacion) + "." + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "Para ver más detalles haga click en el siguiente link: " + StringUtil.Trim( AV25link_sistema) ;
            AV22PRC_MSG = "ENVIANDO MAIL..." ;
            GXt_int1 = 1 ;
            GXt_dtime2 = AV23AHORA ;
            GXt_char3 = " " ;
            new pcol001(context ).execute( ref  AV8PRC_NRO, ref  GXt_int1, ref  GXt_dtime2, ref  GXt_char3, ref  AV22PRC_MSG) ;
            AV23AHORA = GXt_dtime2 ;
            GXt_char4 = "Intranet" ;
            GXt_char5 = "intranet@sancorsalud.com.ar" ;
            GXt_char6 = "intra860" ;
            GXt_char7 = "" ;
            GXt_char8 = "" ;
            new pmail_html_b(context ).execute( ref  GXt_char4, ref  GXt_char5, ref  GXt_char6, ref  AV13hUSU_DES, ref  AV14hPER_MAIL, ref  GXt_char7, ref  AV16ASUNTO, ref  AV15MENSAJE, ref  AV20WebrWapp, ref  AV17SDTAttachs, ref  GXt_char8) ;
            /* Using cursor P001O6 */
            pr_default.execute(4, new Object[] {AV9TTBUS2_IdMovimiento});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A53TTBUS2_IdUsuario = P001O6_A53TTBUS2_IdUsuario[0] ;
               A52TTBUS2_IdMovimiento = P001O6_A52TTBUS2_IdMovimiento[0] ;
               A102TTBUS2_TipoResp = P001O6_A102TTBUS2_TipoResp[0] ;
               if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "R") == 0 )
               {
                  new ptbus038(context ).execute(  A53TTBUS2_IdUsuario, out  AV14hPER_MAIL) ;
                  /* Using cursor P001O7 */
                  pr_default.execute(5, new Object[] {A53TTBUS2_IdUsuario});
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A6USU_COD = P001O7_A6USU_COD[0] ;
                     A7USU_DES = P001O7_A7USU_DES[0] ;
                     AV13hUSU_DES = StringUtil.Trim( A7USU_DES) ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(5);
                  GXt_char8 = "Intranet" ;
                  GXt_char7 = "intranet@sancorsalud.com.ar" ;
                  GXt_char6 = "intra860" ;
                  GXt_char5 = "" ;
                  GXt_char4 = "" ;
                  new pmail_html_b(context ).execute( ref  GXt_char8, ref  GXt_char7, ref  GXt_char6, ref  AV13hUSU_DES, ref  AV14hPER_MAIL, ref  GXt_char5, ref  AV16ASUNTO, ref  AV15MENSAJE, ref  AV20WebrWapp, ref  AV17SDTAttachs, ref  GXt_char4) ;
               }
               pr_default.readNext(4);
            }
            pr_default.close(4);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV24PRC_SAL = "" ;
         AV23AHORA = DateTimeUtil.Now( ) ;
         AV22PRC_MSG = "PROCESO FINALIZADO CORRECTAMENTE." ;
         /* Optimized UPDATE. */
         /* Using cursor P001O8 */
         pr_default.execute(6, new Object[] {AV24PRC_SAL, AV22PRC_MSG, AV23AHORA, AV8PRC_NRO});
         pr_default.close(6);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS005");
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
         AV23AHORA = (DateTime)(DateTime.MinValue) ;
         AV22PRC_MSG = "" ;
         scmdbuf = "" ;
         P001O2_A22TTBUS2_IdBien = new int[1] ;
         P001O2_A25TTBUS2_RespHacia = new String[] {""} ;
         P001O2_A24TTBUS2_RespDesde = new String[] {""} ;
         P001O2_A52TTBUS2_IdMovimiento = new long[1] ;
         P001O2_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         P001O2_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A50TTBUS2_MotivoCancelacion = "" ;
         AV28TTBUS2_MotivoCancelacion = "" ;
         AV11dPER_MAIL = "" ;
         P001O3_A6USU_COD = new String[] {""} ;
         P001O3_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV12dUSU_DES = "" ;
         AV14hPER_MAIL = "" ;
         P001O4_A6USU_COD = new String[] {""} ;
         P001O4_A7USU_DES = new String[] {""} ;
         AV13hUSU_DES = "" ;
         P001O5_A11TTBUS_Id = new int[1] ;
         P001O5_A12TTBUS_Descripcion = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV25link_sistema = "" ;
         AV16ASUNTO = "" ;
         AV15MENSAJE = "" ;
         GXt_dtime2 = (DateTime)(DateTime.MinValue) ;
         GXt_char3 = "" ;
         AV20WebrWapp = new GxWebWrapper();
         AV17SDTAttachs = new GxObjectCollection( context, "SDTAttachs.SDTAttachsItem", "MarianoTesis", "SdtSDTAttachs_SDTAttachsItem", "GeneXus.Programs");
         P001O6_A53TTBUS2_IdUsuario = new String[] {""} ;
         P001O6_A52TTBUS2_IdMovimiento = new long[1] ;
         P001O6_A102TTBUS2_TipoResp = new String[] {""} ;
         A53TTBUS2_IdUsuario = "" ;
         A102TTBUS2_TipoResp = "" ;
         P001O7_A6USU_COD = new String[] {""} ;
         P001O7_A7USU_DES = new String[] {""} ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         AV24PRC_SAL = "" ;
         A159PRC_SAL = "" ;
         A161PRC_MSG = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus005__default(),
            new Object[][] {
                new Object[] {
               P001O2_A22TTBUS2_IdBien, P001O2_A25TTBUS2_RespHacia, P001O2_A24TTBUS2_RespDesde, P001O2_A52TTBUS2_IdMovimiento, P001O2_A50TTBUS2_MotivoCancelacion, P001O2_n50TTBUS2_MotivoCancelacion
               }
               , new Object[] {
               P001O3_A6USU_COD, P001O3_A7USU_DES
               }
               , new Object[] {
               P001O4_A6USU_COD, P001O4_A7USU_DES
               }
               , new Object[] {
               P001O5_A11TTBUS_Id, P001O5_A12TTBUS_Descripcion
               }
               , new Object[] {
               P001O6_A53TTBUS2_IdUsuario, P001O6_A52TTBUS2_IdMovimiento, P001O6_A102TTBUS2_TipoResp
               }
               , new Object[] {
               P001O7_A6USU_COD, P001O7_A7USU_DES
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short GXt_int1 ;
      private int A22TTBUS2_IdBien ;
      private int A11TTBUS_Id ;
      private long AV8PRC_NRO ;
      private long AV9TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV10cTTBUS2_IdMovimiento ;
      private String AV22PRC_MSG ;
      private String scmdbuf ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String AV11dPER_MAIL ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV12dUSU_DES ;
      private String AV14hPER_MAIL ;
      private String AV13hUSU_DES ;
      private String AV25link_sistema ;
      private String AV16ASUNTO ;
      private String GXt_char3 ;
      private String A53TTBUS2_IdUsuario ;
      private String A102TTBUS2_TipoResp ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String AV24PRC_SAL ;
      private String A159PRC_SAL ;
      private String A161PRC_MSG ;
      private DateTime AV23AHORA ;
      private DateTime GXt_dtime2 ;
      private DateTime A157PRC_FIN ;
      private bool n50TTBUS2_MotivoCancelacion ;
      private String AV15MENSAJE ;
      private String A50TTBUS2_MotivoCancelacion ;
      private String AV28TTBUS2_MotivoCancelacion ;
      private String A12TTBUS_Descripcion ;
      private String AV26TTBUS_Descripcion ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_cTTBUS2_IdMovimiento ;
      private long aP1_PRC_NRO ;
      private IDataStoreProvider pr_default ;
      private int[] P001O2_A22TTBUS2_IdBien ;
      private String[] P001O2_A25TTBUS2_RespHacia ;
      private String[] P001O2_A24TTBUS2_RespDesde ;
      private long[] P001O2_A52TTBUS2_IdMovimiento ;
      private String[] P001O2_A50TTBUS2_MotivoCancelacion ;
      private bool[] P001O2_n50TTBUS2_MotivoCancelacion ;
      private String[] P001O3_A6USU_COD ;
      private String[] P001O3_A7USU_DES ;
      private String[] P001O4_A6USU_COD ;
      private String[] P001O4_A7USU_DES ;
      private int[] P001O5_A11TTBUS_Id ;
      private String[] P001O5_A12TTBUS_Descripcion ;
      private String[] P001O6_A53TTBUS2_IdUsuario ;
      private long[] P001O6_A52TTBUS2_IdMovimiento ;
      private String[] P001O6_A102TTBUS2_TipoResp ;
      private String[] P001O7_A6USU_COD ;
      private String[] P001O7_A7USU_DES ;
      private GxWebWrapper AV20WebrWapp ;
      [ObjectCollection(ItemType=typeof( SdtSDTAttachs_SDTAttachsItem ))]
      private IGxCollection AV17SDTAttachs ;
   }

   public class aptbus005__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001O2 ;
          prmP001O2 = new Object[] {
          new Object[] {"@AV9TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP001O3 ;
          prmP001O3 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001O4 ;
          prmP001O4 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001O5 ;
          prmP001O5 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001O6 ;
          prmP001O6 = new Object[] {
          new Object[] {"@AV9TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP001O7 ;
          prmP001O7 = new Object[] {
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001O8 ;
          prmP001O8 = new Object[] {
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV8PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001O2", "SELECT [TTBUS2_IdBien], [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_IdMovimiento], [TTBUS2_MotivoCancelacion] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV9TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O2,1,0,true,true )
             ,new CursorDef("P001O3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O3,1,0,false,true )
             ,new CursorDef("P001O4", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O4,1,0,false,true )
             ,new CursorDef("P001O5", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O5,1,0,false,true )
             ,new CursorDef("P001O6", "SELECT [TTBUS2_IdUsuario], [TTBUS2_IdMovimiento], [TTBUS2_TipoResp] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV9TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O6,100,0,true,false )
             ,new CursorDef("P001O7", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_IdUsuario ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001O7,1,0,false,true )
             ,new CursorDef("P001O8", "UPDATE [COL000] SET [PRC_EST]=2, [PRC_SAL]=@PRC_SAL, [PRC_MSG]=@PRC_MSG, [PRC_FIN]=@PRC_FIN  WHERE [PRC_NRO] = @AV8PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001O8)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 1) ;
                break;
             case 5 :
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
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                break;
       }
    }

 }

}
