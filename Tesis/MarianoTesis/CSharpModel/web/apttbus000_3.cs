/*
               File: PTTBUS000_3
        Description: Mail de remito de cambio de ubicación
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:36.96
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
   public class apttbus000_3 : GXProcedure
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
            new apttbus000_3().execute(ref aP0_cTTBUS2_IdMovimiento, ref aP1_PRC_NRO);
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

      public apttbus000_3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public apttbus000_3( IGxContext context )
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
         apttbus000_3 objapttbus000_3;
         objapttbus000_3 = new apttbus000_3();
         objapttbus000_3.AV10cTTBUS2_IdMovimiento = aP0_cTTBUS2_IdMovimiento;
         objapttbus000_3.AV8PRC_NRO = aP1_PRC_NRO;
         objapttbus000_3.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objapttbus000_3.executePrivateCatch ));
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
         /* Using cursor P001Z2 */
         pr_default.execute(0, new Object[] {AV9TTBUS2_IdMovimiento});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A22TTBUS2_IdBien = P001Z2_A22TTBUS2_IdBien[0] ;
            A25TTBUS2_RespHacia = P001Z2_A25TTBUS2_RespHacia[0] ;
            A24TTBUS2_RespDesde = P001Z2_A24TTBUS2_RespDesde[0] ;
            A52TTBUS2_IdMovimiento = P001Z2_A52TTBUS2_IdMovimiento[0] ;
            A48TTBUS2_CodPosDesde = P001Z2_A48TTBUS2_CodPosDesde[0] ;
            A49TTBUS2_CodPosHacia = P001Z2_A49TTBUS2_CodPosHacia[0] ;
            A47TTBUS2_MotivoEnvio = P001Z2_A47TTBUS2_MotivoEnvio[0] ;
            A77TTBUS2_PlazoRecepcion = P001Z2_A77TTBUS2_PlazoRecepcion[0] ;
            n77TTBUS2_PlazoRecepcion = P001Z2_n77TTBUS2_PlazoRecepcion[0] ;
            AV33TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
            AV34TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
            AV37TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
            new ptbus038(context ).execute(  A24TTBUS2_RespDesde, out  AV11dPER_MAIL) ;
            /* Using cursor P001Z3 */
            pr_default.execute(1, new Object[] {A24TTBUS2_RespDesde});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A6USU_COD = P001Z3_A6USU_COD[0] ;
               A7USU_DES = P001Z3_A7USU_DES[0] ;
               AV12dUSU_DES = StringUtil.Trim( A7USU_DES) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            new ptbus038(context ).execute(  A25TTBUS2_RespHacia, out  AV14hPER_MAIL) ;
            /* Using cursor P001Z4 */
            pr_default.execute(2, new Object[] {A25TTBUS2_RespHacia});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A6USU_COD = P001Z4_A6USU_COD[0] ;
               A7USU_DES = P001Z4_A7USU_DES[0] ;
               AV13hUSU_DES = StringUtil.Trim( A7USU_DES) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            new pttbus000_7(context ).execute(  AV33TTBUS2_CodPosDesde,  AV34TTBUS2_CodPosHacia, out  AV30dTTBUS7_Des, out  AV31hTTBUS7_Des) ;
            /* Using cursor P001Z5 */
            pr_default.execute(3, new Object[] {A22TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A11TTBUS_Id = P001Z5_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P001Z5_A12TTBUS_Descripcion[0] ;
               AV26TTBUS_Descripcion = StringUtil.Trim( A12TTBUS_Descripcion) ;
               AV27TTBUS_Id = A11TTBUS_Id ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
            AV25link_sistema = "http://intranetamsx/HTBUS001.aspx" ;
            AV16ASUNTO = "MOVIMIENTO DEL BIEN DE USO " + "\"" + StringUtil.Trim( StringUtil.Upper( AV26TTBUS_Descripcion)) + "\"" ;
            AV15MENSAJE = "El bien de uso Nº" + StringUtil.Trim( StringUtil.Str( (decimal)(AV27TTBUS_Id), 8, 0)) + ": \"" + StringUtil.Trim( AV26TTBUS_Descripcion) + "\"" + " ha sido trasladado de " + StringUtil.Trim( AV30dTTBUS7_Des) + " a " + StringUtil.Trim( AV31hTTBUS7_Des) + " por " + StringUtil.Trim( AV12dUSU_DES) + " (correo: " + StringUtil.Trim( AV11dPER_MAIL) + ")." + StringUtil.Chr( 13) ;
            AV15MENSAJE = AV15MENSAJE + "El motivo de envío es: " + StringUtil.Trim( A47TTBUS2_MotivoEnvio) + "." + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "Los identificadores del bien son los siguientes: " + StringUtil.Chr( 13) ;
            /* Execute user subroutine: S11120 */
            S11120 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               this.cleanup();
               if (true) return;
            }
            AV15MENSAJE = AV15MENSAJE + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "El plazo límite para confirmar la recepción del bien es: " + context.localUtil.DToC( A77TTBUS2_PlazoRecepcion, 4, "/") + "." + StringUtil.Chr( 13) ;
            AV15MENSAJE = AV15MENSAJE + StringUtil.Chr( 13) ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + "Para ver más detalles haga click en el siguiente hipervínculo: " ;
            AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + " " + StringUtil.Trim( AV25link_sistema) ;
            AV17SDTAttachs.Clear();
            AV18NOMBRE_REPORTE = "REMITO DE MOVIMIENTO DE BIEN DE USO.PDF" ;
            AV19SDTAttachsItem.gxTpr_Nombrearchivo = AV18NOMBRE_REPORTE ;
            AV17SDTAttachs.Add(AV19SDTAttachsItem, 0);
            AV19SDTAttachsItem = new SdtSDTAttachs_SDTAttachsItem(context) ;
            AV18NOMBRE_REPORTE = "E:\\INTRANET\\RPT\\" + AV18NOMBRE_REPORTE ;
            new pttbus000_4(context ).execute( ref  AV9TTBUS2_IdMovimiento, ref  AV18NOMBRE_REPORTE) ;
            AV22PRC_MSG = "ENVIANDO MAIL REMITO" ;
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
            /* Using cursor P001Z6 */
            pr_default.execute(4, new Object[] {AV9TTBUS2_IdMovimiento});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A53TTBUS2_IdUsuario = P001Z6_A53TTBUS2_IdUsuario[0] ;
               A52TTBUS2_IdMovimiento = P001Z6_A52TTBUS2_IdMovimiento[0] ;
               A102TTBUS2_TipoResp = P001Z6_A102TTBUS2_TipoResp[0] ;
               if ( StringUtil.StrCmp(A102TTBUS2_TipoResp, "R") == 0 )
               {
                  new ptbus038(context ).execute(  A53TTBUS2_IdUsuario, out  AV14hPER_MAIL) ;
                  /* Using cursor P001Z7 */
                  pr_default.execute(5, new Object[] {A53TTBUS2_IdUsuario});
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A6USU_COD = P001Z7_A6USU_COD[0] ;
                     A7USU_DES = P001Z7_A7USU_DES[0] ;
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
         AV24PRC_SAL = StringUtil.Trim( AV18NOMBRE_REPORTE) ;
         AV23AHORA = DateTimeUtil.Now( ) ;
         AV22PRC_MSG = "PROCESO FINALIZADO CORRECTAMENTE." ;
         /* Optimized UPDATE. */
         /* Using cursor P001Z8 */
         pr_default.execute(6, new Object[] {AV24PRC_SAL, AV22PRC_MSG, AV23AHORA, AV8PRC_NRO});
         pr_default.close(6);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void S11120( )
      {
         /* 'IDENTIFICADORES' Routine */
         /* Using cursor P001Z9 */
         pr_default.execute(7, new Object[] {AV27TTBUS_Id});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A14IdIdentificador = P001Z9_A14IdIdentificador[0] ;
            A11TTBUS_Id = P001Z9_A11TTBUS_Id[0] ;
            A15NumeroIdentificador = P001Z9_A15NumeroIdentificador[0] ;
            AV32NumeroIdentificador = StringUtil.Trim( A15NumeroIdentificador) ;
            /* Using cursor P001Z10 */
            pr_default.execute(8, new Object[] {A14IdIdentificador});
            while ( (pr_default.getStatus(8) != 101) )
            {
               A20TTBUS5_IdIdentificador = P001Z10_A20TTBUS5_IdIdentificador[0] ;
               A21TTBUS5_DescIdentificador = P001Z10_A21TTBUS5_DescIdentificador[0] ;
               AV15MENSAJE = StringUtil.Trim( AV15MENSAJE) + " -  " + StringUtil.Trim( A21TTBUS5_DescIdentificador) + ": " + StringUtil.Trim( AV32NumeroIdentificador) + StringUtil.Chr( 13) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(8);
            pr_default.readNext(7);
         }
         pr_default.close(7);
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTTBUS000_3");
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
         P001Z2_A22TTBUS2_IdBien = new int[1] ;
         P001Z2_A25TTBUS2_RespHacia = new String[] {""} ;
         P001Z2_A24TTBUS2_RespDesde = new String[] {""} ;
         P001Z2_A52TTBUS2_IdMovimiento = new long[1] ;
         P001Z2_A48TTBUS2_CodPosDesde = new short[1] ;
         P001Z2_A49TTBUS2_CodPosHacia = new short[1] ;
         P001Z2_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         P001Z2_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         P001Z2_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV37TTBUS2_MotivoEnvio = "" ;
         AV11dPER_MAIL = "" ;
         P001Z3_A6USU_COD = new String[] {""} ;
         P001Z3_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV12dUSU_DES = "" ;
         AV14hPER_MAIL = "" ;
         P001Z4_A6USU_COD = new String[] {""} ;
         P001Z4_A7USU_DES = new String[] {""} ;
         AV13hUSU_DES = "" ;
         AV30dTTBUS7_Des = "" ;
         AV31hTTBUS7_Des = "" ;
         P001Z5_A11TTBUS_Id = new int[1] ;
         P001Z5_A12TTBUS_Descripcion = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV25link_sistema = "" ;
         AV16ASUNTO = "" ;
         AV15MENSAJE = "" ;
         AV17SDTAttachs = new GxObjectCollection( context, "SDTAttachs.SDTAttachsItem", "MarianoTesis", "SdtSDTAttachs_SDTAttachsItem", "GeneXus.Programs");
         AV18NOMBRE_REPORTE = "" ;
         AV19SDTAttachsItem = new SdtSDTAttachs_SDTAttachsItem(context);
         GXt_dtime2 = (DateTime)(DateTime.MinValue) ;
         GXt_char3 = "" ;
         AV20WebrWapp = new GxWebWrapper();
         P001Z6_A53TTBUS2_IdUsuario = new String[] {""} ;
         P001Z6_A52TTBUS2_IdMovimiento = new long[1] ;
         P001Z6_A102TTBUS2_TipoResp = new String[] {""} ;
         A53TTBUS2_IdUsuario = "" ;
         A102TTBUS2_TipoResp = "" ;
         P001Z7_A6USU_COD = new String[] {""} ;
         P001Z7_A7USU_DES = new String[] {""} ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         AV24PRC_SAL = "" ;
         A159PRC_SAL = "" ;
         A161PRC_MSG = "" ;
         A157PRC_FIN = (DateTime)(DateTime.MinValue) ;
         P001Z9_A14IdIdentificador = new int[1] ;
         P001Z9_A11TTBUS_Id = new int[1] ;
         P001Z9_A15NumeroIdentificador = new String[] {""} ;
         A15NumeroIdentificador = "" ;
         AV32NumeroIdentificador = "" ;
         P001Z10_A20TTBUS5_IdIdentificador = new int[1] ;
         P001Z10_A21TTBUS5_DescIdentificador = new String[] {""} ;
         A21TTBUS5_DescIdentificador = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.apttbus000_3__default(),
            new Object[][] {
                new Object[] {
               P001Z2_A22TTBUS2_IdBien, P001Z2_A25TTBUS2_RespHacia, P001Z2_A24TTBUS2_RespDesde, P001Z2_A52TTBUS2_IdMovimiento, P001Z2_A48TTBUS2_CodPosDesde, P001Z2_A49TTBUS2_CodPosHacia, P001Z2_A47TTBUS2_MotivoEnvio, P001Z2_A77TTBUS2_PlazoRecepcion, P001Z2_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               P001Z3_A6USU_COD, P001Z3_A7USU_DES
               }
               , new Object[] {
               P001Z4_A6USU_COD, P001Z4_A7USU_DES
               }
               , new Object[] {
               P001Z5_A11TTBUS_Id, P001Z5_A12TTBUS_Descripcion
               }
               , new Object[] {
               P001Z6_A53TTBUS2_IdUsuario, P001Z6_A52TTBUS2_IdMovimiento, P001Z6_A102TTBUS2_TipoResp
               }
               , new Object[] {
               P001Z7_A6USU_COD, P001Z7_A7USU_DES
               }
               , new Object[] {
               }
               , new Object[] {
               P001Z9_A14IdIdentificador, P001Z9_A11TTBUS_Id, P001Z9_A15NumeroIdentificador
               }
               , new Object[] {
               P001Z10_A20TTBUS5_IdIdentificador, P001Z10_A21TTBUS5_DescIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV33TTBUS2_CodPosDesde ;
      private short AV34TTBUS2_CodPosHacia ;
      private short GXt_int1 ;
      private int A22TTBUS2_IdBien ;
      private int A11TTBUS_Id ;
      private int AV27TTBUS_Id ;
      private int A14IdIdentificador ;
      private int A20TTBUS5_IdIdentificador ;
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
      private String AV30dTTBUS7_Des ;
      private String AV31hTTBUS7_Des ;
      private String AV25link_sistema ;
      private String AV16ASUNTO ;
      private String AV18NOMBRE_REPORTE ;
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
      private String A21TTBUS5_DescIdentificador ;
      private DateTime AV23AHORA ;
      private DateTime GXt_dtime2 ;
      private DateTime A157PRC_FIN ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private bool returnInSub ;
      private String AV15MENSAJE ;
      private String A47TTBUS2_MotivoEnvio ;
      private String AV37TTBUS2_MotivoEnvio ;
      private String A12TTBUS_Descripcion ;
      private String AV26TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV32NumeroIdentificador ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_cTTBUS2_IdMovimiento ;
      private long aP1_PRC_NRO ;
      private IDataStoreProvider pr_default ;
      private int[] P001Z2_A22TTBUS2_IdBien ;
      private String[] P001Z2_A25TTBUS2_RespHacia ;
      private String[] P001Z2_A24TTBUS2_RespDesde ;
      private long[] P001Z2_A52TTBUS2_IdMovimiento ;
      private short[] P001Z2_A48TTBUS2_CodPosDesde ;
      private short[] P001Z2_A49TTBUS2_CodPosHacia ;
      private String[] P001Z2_A47TTBUS2_MotivoEnvio ;
      private DateTime[] P001Z2_A77TTBUS2_PlazoRecepcion ;
      private bool[] P001Z2_n77TTBUS2_PlazoRecepcion ;
      private String[] P001Z3_A6USU_COD ;
      private String[] P001Z3_A7USU_DES ;
      private String[] P001Z4_A6USU_COD ;
      private String[] P001Z4_A7USU_DES ;
      private int[] P001Z5_A11TTBUS_Id ;
      private String[] P001Z5_A12TTBUS_Descripcion ;
      private String[] P001Z6_A53TTBUS2_IdUsuario ;
      private long[] P001Z6_A52TTBUS2_IdMovimiento ;
      private String[] P001Z6_A102TTBUS2_TipoResp ;
      private String[] P001Z7_A6USU_COD ;
      private String[] P001Z7_A7USU_DES ;
      private int[] P001Z9_A14IdIdentificador ;
      private int[] P001Z9_A11TTBUS_Id ;
      private String[] P001Z9_A15NumeroIdentificador ;
      private int[] P001Z10_A20TTBUS5_IdIdentificador ;
      private String[] P001Z10_A21TTBUS5_DescIdentificador ;
      private GxWebWrapper AV20WebrWapp ;
      [ObjectCollection(ItemType=typeof( SdtSDTAttachs_SDTAttachsItem ))]
      private IGxCollection AV17SDTAttachs ;
      private SdtSDTAttachs_SDTAttachsItem AV19SDTAttachsItem ;
   }

   public class apttbus000_3__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001Z2 ;
          prmP001Z2 = new Object[] {
          new Object[] {"@AV9TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP001Z3 ;
          prmP001Z3 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001Z4 ;
          prmP001Z4 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001Z5 ;
          prmP001Z5 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001Z6 ;
          prmP001Z6 = new Object[] {
          new Object[] {"@AV9TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP001Z7 ;
          prmP001Z7 = new Object[] {
          new Object[] {"@TTBUS2_IdUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001Z8 ;
          prmP001Z8 = new Object[] {
          new Object[] {"@PRC_SAL",SqlDbType.Char,100,0} ,
          new Object[] {"@PRC_MSG",SqlDbType.Char,75,0} ,
          new Object[] {"@PRC_FIN",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV8PRC_NRO",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmP001Z9 ;
          prmP001Z9 = new Object[] {
          new Object[] {"@AV27TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001Z10 ;
          prmP001Z10 = new Object[] {
          new Object[] {"@IdIdentificador",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001Z2", "SELECT [TTBUS2_IdBien], [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_IdMovimiento], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia], [TTBUS2_MotivoEnvio], [TTBUS2_PlazoRecepcion] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV9TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z2,1,0,true,true )
             ,new CursorDef("P001Z3", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z3,1,0,false,true )
             ,new CursorDef("P001Z4", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z4,1,0,false,true )
             ,new CursorDef("P001Z5", "SELECT [TTBUS_Id], [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z5,1,0,false,true )
             ,new CursorDef("P001Z6", "SELECT [TTBUS2_IdUsuario], [TTBUS2_IdMovimiento], [TTBUS2_TipoResp] FROM [TTBUS002_Det] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV9TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento], [TTBUS2_IdUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z6,100,0,true,false )
             ,new CursorDef("P001Z7", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_IdUsuario ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z7,1,0,false,true )
             ,new CursorDef("P001Z8", "UPDATE [COL000] SET [PRC_EST]=2, [PRC_SAL]=@PRC_SAL, [PRC_MSG]=@PRC_MSG, [PRC_FIN]=@PRC_FIN  WHERE [PRC_NRO] = @AV8PRC_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001Z8)
             ,new CursorDef("P001Z9", "SELECT [IdIdentificador], [TTBUS_Id], [NumeroIdentificador] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV27TTBUS_Id ORDER BY [TTBUS_Id], [IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z9,100,0,true,false )
             ,new CursorDef("P001Z10", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @IdIdentificador ORDER BY [TTBUS5_IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Z10,1,0,false,true )
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
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
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
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
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
