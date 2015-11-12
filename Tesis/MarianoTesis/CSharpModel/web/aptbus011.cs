/*
               File: PTBUS011
        Description: Informe de envíos pendientes de recepción
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:24.80
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
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class aptbus011 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Modern");
         initialize();
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               AV36USUARIO = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV16NOMBRE_REPORTE = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus011( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus011( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref String aP1_NOMBRE_REPORTE )
      {
         this.AV36USUARIO = aP0_USUARIO;
         this.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV36USUARIO;
         aP1_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
      }

      public String executeUdp( ref String aP0_USUARIO )
      {
         this.AV36USUARIO = aP0_USUARIO;
         this.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV36USUARIO;
         aP1_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
         return AV16NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref String aP1_NOMBRE_REPORTE )
      {
         aptbus011 objaptbus011;
         objaptbus011 = new aptbus011();
         objaptbus011.AV36USUARIO = aP0_USUARIO;
         objaptbus011.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         objaptbus011.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus011.executePrivateCatch ));
         aP0_USUARIO=this.AV36USUARIO;
         aP1_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
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
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 2, 9, 11909, 16834, 0, 1, 1, 0, 1, 1) )
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
            AV8AHORA = DateTimeUtil.Now( ) ;
            /* Using cursor P00162 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A25TTBUS2_RespHacia = P00162_A25TTBUS2_RespHacia[0] ;
               A24TTBUS2_RespDesde = P00162_A24TTBUS2_RespDesde[0] ;
               A49TTBUS2_CodPosHacia = P00162_A49TTBUS2_CodPosHacia[0] ;
               A48TTBUS2_CodPosDesde = P00162_A48TTBUS2_CodPosDesde[0] ;
               A26TTBUS2_EstadoEnvio = P00162_A26TTBUS2_EstadoEnvio[0] ;
               A22TTBUS2_IdBien = P00162_A22TTBUS2_IdBien[0] ;
               A47TTBUS2_MotivoEnvio = P00162_A47TTBUS2_MotivoEnvio[0] ;
               A45TTBUS2_FechaEnvio = P00162_A45TTBUS2_FechaEnvio[0] ;
               A52TTBUS2_IdMovimiento = P00162_A52TTBUS2_IdMovimiento[0] ;
               AV30TTBUS2_IdBien = A22TTBUS2_IdBien ;
               new ptbus009(context ).execute(  A22TTBUS2_IdBien,  1, out  AV37NumeroIdentificador) ;
               /* Using cursor P00163 */
               pr_default.execute(1, new Object[] {A48TTBUS2_CodPosDesde});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A33TTBUS7_Pos = P00163_A33TTBUS7_Pos[0] ;
                  A34TTBUS7_Des = P00163_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00163_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = P00163_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00163_n34TTBUS7_Des[0] ;
                  AV11dTTBUS7_Des = A34TTBUS7_Des ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(1);
               /* Using cursor P00164 */
               pr_default.execute(2, new Object[] {A49TTBUS2_CodPosHacia});
               while ( (pr_default.getStatus(2) != 101) )
               {
                  A33TTBUS7_Pos = P00164_A33TTBUS7_Pos[0] ;
                  A34TTBUS7_Des = P00164_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00164_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = P00164_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00164_n34TTBUS7_Des[0] ;
                  AV14hTTBUS7_Des = A34TTBUS7_Des ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(2);
               /* Using cursor P00165 */
               pr_default.execute(3, new Object[] {A24TTBUS2_RespDesde});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A6USU_COD = P00165_A6USU_COD[0] ;
                  A7USU_DES = P00165_A7USU_DES[0] ;
                  AV12dUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(3);
               /* Using cursor P00166 */
               pr_default.execute(4, new Object[] {A25TTBUS2_RespHacia});
               while ( (pr_default.getStatus(4) != 101) )
               {
                  A6USU_COD = P00166_A6USU_COD[0] ;
                  A7USU_DES = P00166_A7USU_DES[0] ;
                  AV15hUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(4);
               /* Using cursor P00167 */
               pr_default.execute(5, new Object[] {AV30TTBUS2_IdBien});
               while ( (pr_default.getStatus(5) != 101) )
               {
                  A11TTBUS_Id = P00167_A11TTBUS_Id[0] ;
                  A12TTBUS_Descripcion = P00167_A12TTBUS_Descripcion[0] ;
                  A29TTBUS_Alquilado = P00167_A29TTBUS_Alquilado[0] ;
                  AV27TTBUS_Id = A11TTBUS_Id ;
                  AV25TTBUS_Descripcion = A12TTBUS_Descripcion ;
                  if ( A29TTBUS_Alquilado == 1 )
                  {
                     AV9alquilado = "SI" ;
                  }
                  else if ( A29TTBUS_Alquilado == 0 )
                  {
                     AV9alquilado = "NO" ;
                  }
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(5);
               AV31TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
               AV29TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
               AV10band = 0 ;
               new ptbus007(context ).execute( ref  AV10band,  AV27TTBUS_Id,  AV36USUARIO) ;
               if ( AV10band == 1 )
               {
                  H160( false, 54) ;
                  getPrinter().GxDrawLine(150, Gx_line+50, 1150, Gx_line+50, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 7, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV11dTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 483, Gx_line+0, 692, Gx_line+15, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12dUSU_DES, "@!")), 483, Gx_line+17, 692, Gx_line+32, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14hTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 858, Gx_line+0, 1067, Gx_line+15, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15hUSU_DES, "@!")), 858, Gx_line+17, 1067, Gx_line+32, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV31TTBUS2_MotivoEnvio, "@!")), 650, Gx_line+33, 1164, Gx_line+48, 0) ;
                  getPrinter().GxDrawText(context.localUtil.Format( AV29TTBUS2_FechaEnvio, "99/99/9999 99:99"), 483, Gx_line+33, 558, Gx_line+48, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 7, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Posición Envío:", 400, Gx_line+0, 483, Gx_line+14, 0+256) ;
                  getPrinter().GxDrawText("Resp. Envío:", 400, Gx_line+17, 470, Gx_line+31, 0+256) ;
                  getPrinter().GxDrawText("Posición Recepción:", 750, Gx_line+0, 858, Gx_line+14, 0+256) ;
                  getPrinter().GxDrawText("Resp. Recepción:", 750, Gx_line+17, 845, Gx_line+31, 0+256) ;
                  getPrinter().GxDrawText("Fecha Envío:", 400, Gx_line+33, 471, Gx_line+47, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27TTBUS_Id), "ZZZZZZZ9")), 92, Gx_line+0, 143, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV25TTBUS_Descripcion, "@!")), 150, Gx_line+0, 392, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV37NumeroIdentificador, "")), 8, Gx_line+0, 83, Gx_line+16, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Motivo Envío:", 567, Gx_line+33, 651, Gx_line+48, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+54) ;
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H160( true, 0) ;
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
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void H160( bool bFoot ,
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
               getPrinter().GxDrawLine(0, Gx_line+118, 1142, Gx_line+118, 2, 0, 0, 0, 0) ;
               getPrinter().GxDrawBitMap(context.GetImagePath( "1382f836-ea82-4658-aa27-5d13e1b4b3fb", "", "Modern"), 0, Gx_line+0, 183, Gx_line+83) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha y Hora:", 967, Gx_line+17, 1038, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Página:", 967, Gx_line+33, 1006, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/9999 99:99"), 1042, Gx_line+17, 1135, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1042, Gx_line+33, 1081, Gx_line+49, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Nº Bien", 92, Gx_line+100, 138, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Descripción", 150, Gx_line+100, 221, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Datos del Envío", 400, Gx_line+100, 497, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Nº Etiqueta", 8, Gx_line+100, 77, Gx_line+115, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("INFORME DE ENVÍOS PENDIENTES DE RECEPCIÓN", 370, Gx_line+50, 799, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 408, Gx_line+17, 764, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+120) ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0 ;
               context.skipLines( 1 );
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
         if (IsMain)	waitPrinterEnd();
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
         gxfirstwebparm = "" ;
         AV8AHORA = (DateTime)(DateTime.MinValue) ;
         scmdbuf = "" ;
         P00162_A25TTBUS2_RespHacia = new String[] {""} ;
         P00162_A24TTBUS2_RespDesde = new String[] {""} ;
         P00162_A49TTBUS2_CodPosHacia = new short[1] ;
         P00162_A48TTBUS2_CodPosDesde = new short[1] ;
         P00162_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00162_A22TTBUS2_IdBien = new int[1] ;
         P00162_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         P00162_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P00162_A52TTBUS2_IdMovimiento = new long[1] ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV37NumeroIdentificador = "" ;
         P00163_A33TTBUS7_Pos = new short[1] ;
         P00163_A34TTBUS7_Des = new String[] {""} ;
         P00163_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         AV11dTTBUS7_Des = "" ;
         P00164_A33TTBUS7_Pos = new short[1] ;
         P00164_A34TTBUS7_Des = new String[] {""} ;
         P00164_n34TTBUS7_Des = new bool[] {false} ;
         AV14hTTBUS7_Des = "" ;
         P00165_A6USU_COD = new String[] {""} ;
         P00165_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV12dUSU_DES = "" ;
         P00166_A6USU_COD = new String[] {""} ;
         P00166_A7USU_DES = new String[] {""} ;
         AV15hUSU_DES = "" ;
         P00167_A11TTBUS_Id = new int[1] ;
         P00167_A12TTBUS_Descripcion = new String[] {""} ;
         P00167_A29TTBUS_Alquilado = new short[1] ;
         A12TTBUS_Descripcion = "" ;
         AV25TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         AV31TTBUS2_MotivoEnvio = "" ;
         AV29TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus011__default(),
            new Object[][] {
                new Object[] {
               P00162_A25TTBUS2_RespHacia, P00162_A24TTBUS2_RespDesde, P00162_A49TTBUS2_CodPosHacia, P00162_A48TTBUS2_CodPosDesde, P00162_A26TTBUS2_EstadoEnvio, P00162_A22TTBUS2_IdBien, P00162_A47TTBUS2_MotivoEnvio, P00162_A45TTBUS2_FechaEnvio, P00162_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00163_A33TTBUS7_Pos, P00163_A34TTBUS7_Des, P00163_n34TTBUS7_Des
               }
               , new Object[] {
               P00164_A33TTBUS7_Pos, P00164_A34TTBUS7_Des, P00164_n34TTBUS7_Des
               }
               , new Object[] {
               P00165_A6USU_COD, P00165_A7USU_DES
               }
               , new Object[] {
               P00166_A6USU_COD, P00166_A7USU_DES
               }
               , new Object[] {
               P00167_A11TTBUS_Id, P00167_A12TTBUS_Descripcion, P00167_A29TTBUS_Alquilado
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A49TTBUS2_CodPosHacia ;
      private short A48TTBUS2_CodPosDesde ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A33TTBUS7_Pos ;
      private short A29TTBUS_Alquilado ;
      private short AV10band ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A22TTBUS2_IdBien ;
      private int AV30TTBUS2_IdBien ;
      private int A11TTBUS_Id ;
      private int AV27TTBUS_Id ;
      private int Gx_OldLine ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV36USUARIO ;
      private String AV16NOMBRE_REPORTE ;
      private String scmdbuf ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String A34TTBUS7_Des ;
      private String AV11dTTBUS7_Des ;
      private String AV14hTTBUS7_Des ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV12dUSU_DES ;
      private String AV15hUSU_DES ;
      private String AV9alquilado ;
      private DateTime AV8AHORA ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV29TTBUS2_FechaEnvio ;
      private bool entryPointCalled ;
      private bool n34TTBUS7_Des ;
      private String A47TTBUS2_MotivoEnvio ;
      private String AV37NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV25TTBUS_Descripcion ;
      private String AV31TTBUS2_MotivoEnvio ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_NOMBRE_REPORTE ;
      private IDataStoreProvider pr_default ;
      private String[] P00162_A25TTBUS2_RespHacia ;
      private String[] P00162_A24TTBUS2_RespDesde ;
      private short[] P00162_A49TTBUS2_CodPosHacia ;
      private short[] P00162_A48TTBUS2_CodPosDesde ;
      private short[] P00162_A26TTBUS2_EstadoEnvio ;
      private int[] P00162_A22TTBUS2_IdBien ;
      private String[] P00162_A47TTBUS2_MotivoEnvio ;
      private DateTime[] P00162_A45TTBUS2_FechaEnvio ;
      private long[] P00162_A52TTBUS2_IdMovimiento ;
      private short[] P00163_A33TTBUS7_Pos ;
      private String[] P00163_A34TTBUS7_Des ;
      private bool[] P00163_n34TTBUS7_Des ;
      private short[] P00164_A33TTBUS7_Pos ;
      private String[] P00164_A34TTBUS7_Des ;
      private bool[] P00164_n34TTBUS7_Des ;
      private String[] P00165_A6USU_COD ;
      private String[] P00165_A7USU_DES ;
      private String[] P00166_A6USU_COD ;
      private String[] P00166_A7USU_DES ;
      private int[] P00167_A11TTBUS_Id ;
      private String[] P00167_A12TTBUS_Descripcion ;
      private short[] P00167_A29TTBUS_Alquilado ;
   }

   public class aptbus011__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00162 ;
          prmP00162 = new Object[] {
          } ;
          Object[] prmP00163 ;
          prmP00163 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00164 ;
          prmP00164 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00165 ;
          prmP00165 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00166 ;
          prmP00166 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00167 ;
          prmP00167 = new Object[] {
          new Object[] {"@AV30TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00162", "SELECT [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_MotivoEnvio], [TTBUS2_FechaEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_EstadoEnvio] = 1 ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00162,100,0,true,false )
             ,new CursorDef("P00163", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00163,1,0,false,true )
             ,new CursorDef("P00164", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00164,1,0,false,true )
             ,new CursorDef("P00165", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00165,1,0,false,true )
             ,new CursorDef("P00166", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00166,1,0,false,true )
             ,new CursorDef("P00167", "SELECT [TTBUS_Id], [TTBUS_Descripcion], [TTBUS_Alquilado] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV30TTBUS2_IdBien ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00167,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((long[]) buf[8])[0] = rslt.getLong(9) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
