/*
               File: PTTBUS000_4
        Description: Remito por cambio ubicación bien de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:58.13
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
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pttbus000_4 : GXProcedure
   {
      public pttbus000_4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public pttbus000_4( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_TTBUS2_IdMovimiento ,
                           ref String aP1_NOMBRE_REPORTE )
      {
         this.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV11NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_NOMBRE_REPORTE=this.AV11NOMBRE_REPORTE;
      }

      public String executeUdp( ref long aP0_TTBUS2_IdMovimiento )
      {
         this.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         this.AV11NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_NOMBRE_REPORTE=this.AV11NOMBRE_REPORTE;
         return AV11NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref long aP0_TTBUS2_IdMovimiento ,
                                 ref String aP1_NOMBRE_REPORTE )
      {
         pttbus000_4 objpttbus000_4;
         objpttbus000_4 = new pttbus000_4();
         objpttbus000_4.AV12TTBUS2_IdMovimiento = aP0_TTBUS2_IdMovimiento;
         objpttbus000_4.AV11NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         objpttbus000_4.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objpttbus000_4.executePrivateCatch ));
         aP0_TTBUS2_IdMovimiento=this.AV12TTBUS2_IdMovimiento;
         aP1_NOMBRE_REPORTE=this.AV11NOMBRE_REPORTE;
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
         M_top = 0 ;
         M_bot = 6 ;
         P_lines = (int)(66-M_bot) ;
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15 ;
         PrtOffset = 0 ;
         gxXPage = 100 ;
         gxYPage = 100 ;
         getPrinter().GxSetDocName(AV11NOMBRE_REPORTE) ;
         getPrinter().GxSetDocFormat("PDF") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 9, 16834, 11909, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            AV8ahora = DateTimeUtil.Now( ) ;
            AV21LOGO = "imagenes/LOGO_SANCORSALUD.bmp" ;
            /* Using cursor P00212 */
            pr_default.execute(0, new Object[] {AV12TTBUS2_IdMovimiento});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A22TTBUS2_IdBien = P00212_A22TTBUS2_IdBien[0] ;
               A25TTBUS2_RespHacia = P00212_A25TTBUS2_RespHacia[0] ;
               A24TTBUS2_RespDesde = P00212_A24TTBUS2_RespDesde[0] ;
               A52TTBUS2_IdMovimiento = P00212_A52TTBUS2_IdMovimiento[0] ;
               A48TTBUS2_CodPosDesde = P00212_A48TTBUS2_CodPosDesde[0] ;
               A49TTBUS2_CodPosHacia = P00212_A49TTBUS2_CodPosHacia[0] ;
               A47TTBUS2_MotivoEnvio = P00212_A47TTBUS2_MotivoEnvio[0] ;
               A77TTBUS2_PlazoRecepcion = P00212_A77TTBUS2_PlazoRecepcion[0] ;
               n77TTBUS2_PlazoRecepcion = P00212_n77TTBUS2_PlazoRecepcion[0] ;
               AV15TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
               AV16TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
               AV20TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
               AV23TTBUS2_PlazoRecepcion = A77TTBUS2_PlazoRecepcion ;
               new pttbus000_7(context ).execute(  AV15TTBUS2_CodPosDesde,  AV16TTBUS2_CodPosHacia, out  AV14dTTBUS7_Des, out  AV13hTTBUS7_Des) ;
               /* Using cursor P00213 */
               pr_default.execute(1, new Object[] {A24TTBUS2_RespDesde});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A6USU_COD = P00213_A6USU_COD[0] ;
                  A7USU_DES = P00213_A7USU_DES[0] ;
                  AV9dUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(1);
               /* Using cursor P00214 */
               pr_default.execute(2, new Object[] {A25TTBUS2_RespHacia});
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A6USU_COD = P00214_A6USU_COD[0] ;
                  A7USU_DES = P00214_A7USU_DES[0] ;
                  AV10hUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(2);
               /* Using cursor P00215 */
               pr_default.execute(3, new Object[] {A22TTBUS2_IdBien});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A17TTBUS_RubroBien = P00215_A17TTBUS_RubroBien[0] ;
                  A11TTBUS_Id = P00215_A11TTBUS_Id[0] ;
                  A14IdIdentificador = P00215_A14IdIdentificador[0] ;
                  A15NumeroIdentificador = P00215_A15NumeroIdentificador[0] ;
                  A12TTBUS_Descripcion = P00215_A12TTBUS_Descripcion[0] ;
                  A18TTBUS_RubroDesc = P00215_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P00215_n18TTBUS_RubroDesc[0] ;
                  A17TTBUS_RubroBien = P00215_A17TTBUS_RubroBien[0] ;
                  A12TTBUS_Descripcion = P00215_A12TTBUS_Descripcion[0] ;
                  A18TTBUS_RubroDesc = P00215_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P00215_n18TTBUS_RubroDesc[0] ;
                  AV22NumeroIdentificador = A15NumeroIdentificador ;
                  AV17TTBUS_Descripcion = A12TTBUS_Descripcion ;
                  AV18TTBUS_Id = A11TTBUS_Id ;
                  AV19TTBUS_RubroDesc = A18TTBUS_RubroDesc ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(3);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            H210( false, 452) ;
            getPrinter().GxDrawRect(8, Gx_line+100, 800, Gx_line+217, 1, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0) ;
            getPrinter().GxDrawRect(8, Gx_line+233, 800, Gx_line+316, 1, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0) ;
            getPrinter().GxDrawRect(8, Gx_line+333, 800, Gx_line+416, 1, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(context.localUtil.Format( AV8ahora, "99/99/9999 99:99:99"), 164, Gx_line+150, 272, Gx_line+166, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9dUSU_DES, "@!")), 163, Gx_line+283, 424, Gx_line+299, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10hUSU_DES, "@!")), 200, Gx_line+383, 461, Gx_line+399, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14dTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 133, Gx_line+250, 394, Gx_line+266, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV13hTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 156, Gx_line+350, 417, Gx_line+366, 0+256) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TTBUS_Id), "ZZZZZZZ9")), 358, Gx_line+117, 409, Gx_line+133, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV17TTBUS_Descripcion, "@!")), 533, Gx_line+117, 794, Gx_line+133, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV20TTBUS2_MotivoEnvio, "@!")), 121, Gx_line+183, 643, Gx_line+199, 0+256) ;
            getPrinter().GxDrawBitMap(AV21LOGO, 8, Gx_line+8, 175, Gx_line+50) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV22NumeroIdentificador, "")), 133, Gx_line+117, 258, Gx_line+133, 0) ;
            getPrinter().GxDrawText(context.localUtil.Format( AV23TTBUS2_PlazoRecepcion, "99/99/9999"), 625, Gx_line+350, 686, Gx_line+366, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV19TTBUS_RubroDesc, "@!")), 500, Gx_line+150, 657, Gx_line+166, 0+256) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Fecha y Hora Envío:", 25, Gx_line+150, 158, Gx_line+167, 0+256) ;
            getPrinter().GxDrawText("Nº de Bien:", 275, Gx_line+117, 351, Gx_line+134, 0+256) ;
            getPrinter().GxDrawText("Descripción:", 450, Gx_line+117, 534, Gx_line+134, 0+256) ;
            getPrinter().GxDrawText("Posición Envío:", 25, Gx_line+250, 128, Gx_line+267, 0+256) ;
            getPrinter().GxDrawText("Posición Recepción:", 25, Gx_line+350, 150, Gx_line+367, 0) ;
            getPrinter().GxDrawText("Responsable Envío:", 25, Gx_line+283, 158, Gx_line+300, 0+256) ;
            getPrinter().GxDrawText("Responsable Recepción:", 25, Gx_line+383, 193, Gx_line+400, 0+256) ;
            getPrinter().GxDrawText("Motivo Envío:", 25, Gx_line+183, 115, Gx_line+200, 0+256) ;
            getPrinter().GxDrawText("Nº de Etiqueta:", 25, Gx_line+117, 126, Gx_line+134, 0+256) ;
            getPrinter().GxDrawText("Plazo Límite Recepción:", 450, Gx_line+350, 614, Gx_line+367, 0+256) ;
            getPrinter().GxDrawText("Rubro:", 450, Gx_line+150, 496, Gx_line+167, 0+256) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Remito Cambio Ubicación", 300, Gx_line+50, 506, Gx_line+70, 0+256) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 233, Gx_line+17, 589, Gx_line+43, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+452) ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H210( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         this.cleanup();
      }

      protected void H210( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines ;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0 ;
               Gx_line = 0 ;
               Gx_page = (int)(Gx_page+1) ;
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight)) ;
               /* Print headers */
               getPrinter().GxStartPage() ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0 ;
               Gx_line = (int)(Gx_line+1) ;
            }
            ToSkip = (int)(ToSkip-1) ;
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
         add_metrics1( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
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
         AV8ahora = (DateTime)(DateTime.MinValue) ;
         AV21LOGO = "" ;
         scmdbuf = "" ;
         P00212_A22TTBUS2_IdBien = new int[1] ;
         P00212_A25TTBUS2_RespHacia = new String[] {""} ;
         P00212_A24TTBUS2_RespDesde = new String[] {""} ;
         P00212_A52TTBUS2_IdMovimiento = new long[1] ;
         P00212_A48TTBUS2_CodPosDesde = new short[1] ;
         P00212_A49TTBUS2_CodPosHacia = new short[1] ;
         P00212_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         P00212_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         P00212_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV20TTBUS2_MotivoEnvio = "" ;
         AV23TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV14dTTBUS7_Des = "" ;
         AV13hTTBUS7_Des = "" ;
         P00213_A6USU_COD = new String[] {""} ;
         P00213_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV9dUSU_DES = "" ;
         P00214_A6USU_COD = new String[] {""} ;
         P00214_A7USU_DES = new String[] {""} ;
         AV10hUSU_DES = "" ;
         P00215_A17TTBUS_RubroBien = new short[1] ;
         P00215_A11TTBUS_Id = new int[1] ;
         P00215_A14IdIdentificador = new int[1] ;
         P00215_A15NumeroIdentificador = new String[] {""} ;
         P00215_A12TTBUS_Descripcion = new String[] {""} ;
         P00215_A18TTBUS_RubroDesc = new String[] {""} ;
         P00215_n18TTBUS_RubroDesc = new bool[] {false} ;
         A15NumeroIdentificador = "" ;
         A12TTBUS_Descripcion = "" ;
         A18TTBUS_RubroDesc = "" ;
         AV22NumeroIdentificador = "" ;
         AV17TTBUS_Descripcion = "" ;
         AV19TTBUS_RubroDesc = "" ;
         AV21LOGO = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pttbus000_4__default(),
            new Object[][] {
                new Object[] {
               P00212_A22TTBUS2_IdBien, P00212_A25TTBUS2_RespHacia, P00212_A24TTBUS2_RespDesde, P00212_A52TTBUS2_IdMovimiento, P00212_A48TTBUS2_CodPosDesde, P00212_A49TTBUS2_CodPosHacia, P00212_A47TTBUS2_MotivoEnvio, P00212_A77TTBUS2_PlazoRecepcion, P00212_n77TTBUS2_PlazoRecepcion
               }
               , new Object[] {
               P00213_A6USU_COD, P00213_A7USU_DES
               }
               , new Object[] {
               P00214_A6USU_COD, P00214_A7USU_DES
               }
               , new Object[] {
               P00215_A17TTBUS_RubroBien, P00215_A11TTBUS_Id, P00215_A14IdIdentificador, P00215_A15NumeroIdentificador, P00215_A12TTBUS_Descripcion, P00215_A18TTBUS_RubroDesc, P00215_n18TTBUS_RubroDesc
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV15TTBUS2_CodPosDesde ;
      private short AV16TTBUS2_CodPosHacia ;
      private short A17TTBUS_RubroBien ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A22TTBUS2_IdBien ;
      private int A11TTBUS_Id ;
      private int A14IdIdentificador ;
      private int AV18TTBUS_Id ;
      private int Gx_OldLine ;
      private long AV12TTBUS2_IdMovimiento ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV11NOMBRE_REPORTE ;
      private String scmdbuf ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String AV14dTTBUS7_Des ;
      private String AV13hTTBUS7_Des ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV9dUSU_DES ;
      private String AV10hUSU_DES ;
      private String A18TTBUS_RubroDesc ;
      private String AV19TTBUS_RubroDesc ;
      private DateTime AV8ahora ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private DateTime AV23TTBUS2_PlazoRecepcion ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private bool n18TTBUS_RubroDesc ;
      private String A47TTBUS2_MotivoEnvio ;
      private String AV20TTBUS2_MotivoEnvio ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV22NumeroIdentificador ;
      private String AV17TTBUS_Descripcion ;
      private String AV21LOGO ;
      private String Logo ;
      private IGxDataStore dsDefault ;
      private long aP0_TTBUS2_IdMovimiento ;
      private String aP1_NOMBRE_REPORTE ;
      private IDataStoreProvider pr_default ;
      private int[] P00212_A22TTBUS2_IdBien ;
      private String[] P00212_A25TTBUS2_RespHacia ;
      private String[] P00212_A24TTBUS2_RespDesde ;
      private long[] P00212_A52TTBUS2_IdMovimiento ;
      private short[] P00212_A48TTBUS2_CodPosDesde ;
      private short[] P00212_A49TTBUS2_CodPosHacia ;
      private String[] P00212_A47TTBUS2_MotivoEnvio ;
      private DateTime[] P00212_A77TTBUS2_PlazoRecepcion ;
      private bool[] P00212_n77TTBUS2_PlazoRecepcion ;
      private String[] P00213_A6USU_COD ;
      private String[] P00213_A7USU_DES ;
      private String[] P00214_A6USU_COD ;
      private String[] P00214_A7USU_DES ;
      private short[] P00215_A17TTBUS_RubroBien ;
      private int[] P00215_A11TTBUS_Id ;
      private int[] P00215_A14IdIdentificador ;
      private String[] P00215_A15NumeroIdentificador ;
      private String[] P00215_A12TTBUS_Descripcion ;
      private String[] P00215_A18TTBUS_RubroDesc ;
      private bool[] P00215_n18TTBUS_RubroDesc ;
   }

   public class pttbus000_4__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00212 ;
          prmP00212 = new Object[] {
          new Object[] {"@AV12TTBUS2_IdMovimiento",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmP00213 ;
          prmP00213 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00214 ;
          prmP00214 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00215 ;
          prmP00215 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00212", "SELECT [TTBUS2_IdBien], [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_IdMovimiento], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia], [TTBUS2_MotivoEnvio], [TTBUS2_PlazoRecepcion] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdMovimiento] = @AV12TTBUS2_IdMovimiento ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00212,1,0,true,true )
             ,new CursorDef("P00213", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00213,1,0,false,true )
             ,new CursorDef("P00214", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00214,1,0,false,true )
             ,new CursorDef("P00215", "SELECT T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T1.[TTBUS_Id], T1.[IdIdentificador], T1.[NumeroIdentificador], T2.[TTBUS_Descripcion], T3.[RBR_DES] AS TTBUS_RubroDesc FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) INNER JOIN [BUS002] T3 WITH (NOLOCK) ON T3.[RBR_COD] = T2.[TTBUS_RubroBien]) WHERE T1.[TTBUS_Id] = @TTBUS2_IdBien and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00215,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
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
       }
    }

 }

}
