/*
               File: PTBUS010
        Description: Listado de bienes de uso sin factura
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:6:44.61
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
   public class aptbus010 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV16NOMBRE_REPORTE = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV18USUARIO = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus010( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus010( IGxContext context )
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

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_USUARIO )
      {
         this.AV16NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV18USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
         aP1_USUARIO=this.AV18USUARIO;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE )
      {
         this.AV16NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV18USUARIO = aP1_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
         aP1_USUARIO=this.AV18USUARIO;
         return AV18USUARIO ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO )
      {
         aptbus010 objaptbus010;
         objaptbus010 = new aptbus010();
         objaptbus010.AV16NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus010.AV18USUARIO = aP1_USUARIO;
         objaptbus010.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus010.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
         aP1_USUARIO=this.AV18USUARIO;
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
            /* Using cursor P00152 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A37TTBUS_CodPosicion = P00152_A37TTBUS_CodPosicion[0] ;
               A14IdIdentificador = P00152_A14IdIdentificador[0] ;
               A73TTBUS_CucProveedor = P00152_A73TTBUS_CucProveedor[0] ;
               n73TTBUS_CucProveedor = P00152_n73TTBUS_CucProveedor[0] ;
               A27TTBUS_CodProveedor = P00152_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P00152_n27TTBUS_CodProveedor[0] ;
               A1BUS_RUB = P00152_A1BUS_RUB[0] ;
               n1BUS_RUB = P00152_n1BUS_RUB[0] ;
               A8BUS_EMP = P00152_A8BUS_EMP[0] ;
               n8BUS_EMP = P00152_n8BUS_EMP[0] ;
               A4BUS_PAR = P00152_A4BUS_PAR[0] ;
               n4BUS_PAR = P00152_n4BUS_PAR[0] ;
               A3BUS_COD = P00152_A3BUS_COD[0] ;
               n3BUS_COD = P00152_n3BUS_COD[0] ;
               A29TTBUS_Alquilado = P00152_A29TTBUS_Alquilado[0] ;
               A42TTBUS_NroSerie = P00152_A42TTBUS_NroSerie[0] ;
               A23TTBUS_Estado = P00152_A23TTBUS_Estado[0] ;
               A15NumeroIdentificador = P00152_A15NumeroIdentificador[0] ;
               A12TTBUS_Descripcion = P00152_A12TTBUS_Descripcion[0] ;
               A55BUS_FAD = P00152_A55BUS_FAD[0] ;
               A13TTBUS_FechaCarga = P00152_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P00152_A38TTBUS_DesPosicion[0] ;
               A11TTBUS_Id = P00152_A11TTBUS_Id[0] ;
               A37TTBUS_CodPosicion = P00152_A37TTBUS_CodPosicion[0] ;
               A73TTBUS_CucProveedor = P00152_A73TTBUS_CucProveedor[0] ;
               n73TTBUS_CucProveedor = P00152_n73TTBUS_CucProveedor[0] ;
               A27TTBUS_CodProveedor = P00152_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P00152_n27TTBUS_CodProveedor[0] ;
               A1BUS_RUB = P00152_A1BUS_RUB[0] ;
               n1BUS_RUB = P00152_n1BUS_RUB[0] ;
               A8BUS_EMP = P00152_A8BUS_EMP[0] ;
               n8BUS_EMP = P00152_n8BUS_EMP[0] ;
               A4BUS_PAR = P00152_A4BUS_PAR[0] ;
               n4BUS_PAR = P00152_n4BUS_PAR[0] ;
               A3BUS_COD = P00152_A3BUS_COD[0] ;
               n3BUS_COD = P00152_n3BUS_COD[0] ;
               A29TTBUS_Alquilado = P00152_A29TTBUS_Alquilado[0] ;
               A42TTBUS_NroSerie = P00152_A42TTBUS_NroSerie[0] ;
               A23TTBUS_Estado = P00152_A23TTBUS_Estado[0] ;
               A12TTBUS_Descripcion = P00152_A12TTBUS_Descripcion[0] ;
               A13TTBUS_FechaCarga = P00152_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P00152_A38TTBUS_DesPosicion[0] ;
               A55BUS_FAD = P00152_A55BUS_FAD[0] ;
               AV19Nro_Serie = "Nº Serie: " + StringUtil.Trim( A42TTBUS_NroSerie) ;
               if ( A23TTBUS_Estado == 1 )
               {
                  AV9estado = "ASIGNADO A UN SECTOR" ;
               }
               else if ( A23TTBUS_Estado == 2 )
               {
                  AV9estado = "CAMBIANDO DE SECTOR" ;
               }
               AV13TTBUS_Id = A11TTBUS_Id ;
               if ( A23TTBUS_Estado == 1 )
               {
                  /* Using cursor P00153 */
                  pr_default.execute(1, new Object[] {A37TTBUS_CodPosicion});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A35TTBUS7_CodResp = P00153_A35TTBUS7_CodResp[0] ;
                     A33TTBUS7_Pos = P00153_A33TTBUS7_Pos[0] ;
                     A36TTBUS7_DesResp = P00153_A36TTBUS7_DesResp[0] ;
                     n36TTBUS7_DesResp = P00153_n36TTBUS7_DesResp[0] ;
                     A36TTBUS7_DesResp = P00153_A36TTBUS7_DesResp[0] ;
                     n36TTBUS7_DesResp = P00153_n36TTBUS7_DesResp[0] ;
                     AV10TTBUS7_DesResp = A36TTBUS7_DesResp ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(1);
               }
               else
               {
                  /* Using cursor P00154 */
                  pr_default.execute(2, new Object[] {AV13TTBUS_Id});
                  while ( (pr_default.getStatus(2) != 101) )
                  {
                     A26TTBUS2_EstadoEnvio = P00154_A26TTBUS2_EstadoEnvio[0] ;
                     A22TTBUS2_IdBien = P00154_A22TTBUS2_IdBien[0] ;
                     A24TTBUS2_RespDesde = P00154_A24TTBUS2_RespDesde[0] ;
                     A25TTBUS2_RespHacia = P00154_A25TTBUS2_RespHacia[0] ;
                     A52TTBUS2_IdMovimiento = P00154_A52TTBUS2_IdMovimiento[0] ;
                     AV11TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                     AV12TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                     /* Using cursor P00155 */
                     pr_default.execute(3, new Object[] {AV11TTBUS2_RespDesde});
                     while ( (pr_default.getStatus(3) != 101) )
                     {
                        A6USU_COD = P00155_A6USU_COD[0] ;
                        A7USU_DES = P00155_A7USU_DES[0] ;
                        AV14dUSU_DES = A7USU_DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(3);
                     /* Using cursor P00156 */
                     pr_default.execute(4, new Object[] {AV12TTBUS2_RespHacia});
                     while ( (pr_default.getStatus(4) != 101) )
                     {
                        A6USU_COD = P00156_A6USU_COD[0] ;
                        A7USU_DES = P00156_A7USU_DES[0] ;
                        AV15hUSU_DES = A7USU_DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(4);
                     pr_default.readNext(2);
                  }
                  pr_default.close(2);
                  AV10TTBUS7_DesResp = StringUtil.Trim( AV14dUSU_DES) + " Y " + StringUtil.Trim( AV15hUSU_DES) ;
               }
               AV17band = 0 ;
               new ptbus007(context ).execute( ref  AV17band,  AV13TTBUS_Id,  AV18USUARIO) ;
               if ( AV17band == 1 )
               {
                  H150( false, 48) ;
                  getPrinter().GxDrawLine(175, Gx_line+40, 1142, Gx_line+40, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 825, Gx_line+0, 1067, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 550, Gx_line+0, 611, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A55BUS_FAD, "99/99/9999"), 442, Gx_line+0, 503, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 175, Gx_line+0, 436, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 108, Gx_line+0, 159, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10TTBUS7_DesResp, "@!")), 550, Gx_line+18, 811, Gx_line+34, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 642, Gx_line+0, 799, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 92, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV19Nro_Serie, "")), 825, Gx_line+17, 1034, Gx_line+33, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Responsable Actual:", 442, Gx_line+18, 545, Gx_line+33, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+48) ;
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H150( true, 0) ;
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

      protected void H150( bool bFoot ,
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
               getPrinter().GxDrawLine(8, Gx_line+118, 1150, Gx_line+118, 2, 0, 0, 0, 0) ;
               getPrinter().GxDrawBitMap(context.GetImagePath( "43ca73d8-f671-4ff8-b419-ae86171a376e", "", "Modern"), 0, Gx_line+0, 156, Gx_line+52) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1075, Gx_line+33, 1114, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText("Página:", 1000, Gx_line+33, 1039, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Fecha y Hora:", 1000, Gx_line+17, 1071, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/99 99:99"), 1075, Gx_line+17, 1155, Gx_line+33, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha Carga", 550, Gx_line+100, 615, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Fecha Adquisición", 442, Gx_line+100, 534, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Nº Bien", 108, Gx_line+100, 147, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Descripción", 175, Gx_line+100, 234, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Estado", 642, Gx_line+100, 677, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Posición Actual", 825, Gx_line+100, 902, Gx_line+115, 0+256) ;
               getPrinter().GxDrawText("Nº Etiqueta", 17, Gx_line+100, 74, Gx_line+115, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("LISTADO DE BIENES DE USO SIN FACTURA", 400, Gx_line+50, 759, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 400, Gx_line+17, 756, Gx_line+43, 0+256) ;
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
         P00152_A37TTBUS_CodPosicion = new short[1] ;
         P00152_A14IdIdentificador = new int[1] ;
         P00152_A73TTBUS_CucProveedor = new int[1] ;
         P00152_n73TTBUS_CucProveedor = new bool[] {false} ;
         P00152_A27TTBUS_CodProveedor = new int[1] ;
         P00152_n27TTBUS_CodProveedor = new bool[] {false} ;
         P00152_A1BUS_RUB = new short[1] ;
         P00152_n1BUS_RUB = new bool[] {false} ;
         P00152_A8BUS_EMP = new String[] {""} ;
         P00152_n8BUS_EMP = new bool[] {false} ;
         P00152_A4BUS_PAR = new short[1] ;
         P00152_n4BUS_PAR = new bool[] {false} ;
         P00152_A3BUS_COD = new short[1] ;
         P00152_n3BUS_COD = new bool[] {false} ;
         P00152_A29TTBUS_Alquilado = new short[1] ;
         P00152_A42TTBUS_NroSerie = new String[] {""} ;
         P00152_A23TTBUS_Estado = new short[1] ;
         P00152_A15NumeroIdentificador = new String[] {""} ;
         P00152_A12TTBUS_Descripcion = new String[] {""} ;
         P00152_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         P00152_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00152_A38TTBUS_DesPosicion = new String[] {""} ;
         P00152_A11TTBUS_Id = new int[1] ;
         A8BUS_EMP = "" ;
         A42TTBUS_NroSerie = "" ;
         A15NumeroIdentificador = "" ;
         A12TTBUS_Descripcion = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         AV19Nro_Serie = "" ;
         AV9estado = "" ;
         P00153_A35TTBUS7_CodResp = new String[] {""} ;
         P00153_A33TTBUS7_Pos = new short[1] ;
         P00153_A36TTBUS7_DesResp = new String[] {""} ;
         P00153_n36TTBUS7_DesResp = new bool[] {false} ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         AV10TTBUS7_DesResp = "" ;
         P00154_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00154_A22TTBUS2_IdBien = new int[1] ;
         P00154_A24TTBUS2_RespDesde = new String[] {""} ;
         P00154_A25TTBUS2_RespHacia = new String[] {""} ;
         P00154_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV11TTBUS2_RespDesde = "" ;
         AV12TTBUS2_RespHacia = "" ;
         P00155_A6USU_COD = new String[] {""} ;
         P00155_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV14dUSU_DES = "" ;
         P00156_A6USU_COD = new String[] {""} ;
         P00156_A7USU_DES = new String[] {""} ;
         AV15hUSU_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus010__default(),
            new Object[][] {
                new Object[] {
               P00152_A37TTBUS_CodPosicion, P00152_A14IdIdentificador, P00152_A73TTBUS_CucProveedor, P00152_n73TTBUS_CucProveedor, P00152_A27TTBUS_CodProveedor, P00152_n27TTBUS_CodProveedor, P00152_A1BUS_RUB, P00152_n1BUS_RUB, P00152_A8BUS_EMP, P00152_n8BUS_EMP,
               P00152_A4BUS_PAR, P00152_n4BUS_PAR, P00152_A3BUS_COD, P00152_n3BUS_COD, P00152_A29TTBUS_Alquilado, P00152_A42TTBUS_NroSerie, P00152_A23TTBUS_Estado, P00152_A15NumeroIdentificador, P00152_A12TTBUS_Descripcion, P00152_A55BUS_FAD,
               P00152_A13TTBUS_FechaCarga, P00152_A38TTBUS_DesPosicion, P00152_A11TTBUS_Id
               }
               , new Object[] {
               P00153_A35TTBUS7_CodResp, P00153_A33TTBUS7_Pos, P00153_A36TTBUS7_DesResp, P00153_n36TTBUS7_DesResp
               }
               , new Object[] {
               P00154_A26TTBUS2_EstadoEnvio, P00154_A22TTBUS2_IdBien, P00154_A24TTBUS2_RespDesde, P00154_A25TTBUS2_RespHacia, P00154_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00155_A6USU_COD, P00155_A7USU_DES
               }
               , new Object[] {
               P00156_A6USU_COD, P00156_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A37TTBUS_CodPosicion ;
      private short A1BUS_RUB ;
      private short A4BUS_PAR ;
      private short A3BUS_COD ;
      private short A29TTBUS_Alquilado ;
      private short A23TTBUS_Estado ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV17band ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A14IdIdentificador ;
      private int A73TTBUS_CucProveedor ;
      private int A27TTBUS_CodProveedor ;
      private int A11TTBUS_Id ;
      private int AV13TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int Gx_OldLine ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV16NOMBRE_REPORTE ;
      private String AV18USUARIO ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private String A38TTBUS_DesPosicion ;
      private String AV9estado ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String AV10TTBUS7_DesResp ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV11TTBUS2_RespDesde ;
      private String AV12TTBUS2_RespHacia ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV14dUSU_DES ;
      private String AV15hUSU_DES ;
      private DateTime AV8AHORA ;
      private DateTime A55BUS_FAD ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool n73TTBUS_CucProveedor ;
      private bool n27TTBUS_CodProveedor ;
      private bool n1BUS_RUB ;
      private bool n8BUS_EMP ;
      private bool n4BUS_PAR ;
      private bool n3BUS_COD ;
      private bool n36TTBUS7_DesResp ;
      private String A42TTBUS_NroSerie ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV19Nro_Serie ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private IDataStoreProvider pr_default ;
      private short[] P00152_A37TTBUS_CodPosicion ;
      private int[] P00152_A14IdIdentificador ;
      private int[] P00152_A73TTBUS_CucProveedor ;
      private bool[] P00152_n73TTBUS_CucProveedor ;
      private int[] P00152_A27TTBUS_CodProveedor ;
      private bool[] P00152_n27TTBUS_CodProveedor ;
      private short[] P00152_A1BUS_RUB ;
      private bool[] P00152_n1BUS_RUB ;
      private String[] P00152_A8BUS_EMP ;
      private bool[] P00152_n8BUS_EMP ;
      private short[] P00152_A4BUS_PAR ;
      private bool[] P00152_n4BUS_PAR ;
      private short[] P00152_A3BUS_COD ;
      private bool[] P00152_n3BUS_COD ;
      private short[] P00152_A29TTBUS_Alquilado ;
      private String[] P00152_A42TTBUS_NroSerie ;
      private short[] P00152_A23TTBUS_Estado ;
      private String[] P00152_A15NumeroIdentificador ;
      private String[] P00152_A12TTBUS_Descripcion ;
      private DateTime[] P00152_A55BUS_FAD ;
      private DateTime[] P00152_A13TTBUS_FechaCarga ;
      private String[] P00152_A38TTBUS_DesPosicion ;
      private int[] P00152_A11TTBUS_Id ;
      private String[] P00153_A35TTBUS7_CodResp ;
      private short[] P00153_A33TTBUS7_Pos ;
      private String[] P00153_A36TTBUS7_DesResp ;
      private bool[] P00153_n36TTBUS7_DesResp ;
      private short[] P00154_A26TTBUS2_EstadoEnvio ;
      private int[] P00154_A22TTBUS2_IdBien ;
      private String[] P00154_A24TTBUS2_RespDesde ;
      private String[] P00154_A25TTBUS2_RespHacia ;
      private long[] P00154_A52TTBUS2_IdMovimiento ;
      private String[] P00155_A6USU_COD ;
      private String[] P00155_A7USU_DES ;
      private String[] P00156_A6USU_COD ;
      private String[] P00156_A7USU_DES ;
   }

   public class aptbus010__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00152 ;
          prmP00152 = new Object[] {
          } ;
          Object[] prmP00153 ;
          prmP00153 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00154 ;
          prmP00154 = new Object[] {
          new Object[] {"@AV13TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00155 ;
          prmP00155 = new Object[] {
          new Object[] {"@AV11TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00156 ;
          prmP00156 = new Object[] {
          new Object[] {"@AV12TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00152", "SELECT T2.[TTBUS_CodPosicion], T1.[IdIdentificador], T2.[TTBUS_CucProveedor], T2.[TTBUS_CodProveedor], T2.[BUS_RUB], T2.[BUS_EMP], T2.[BUS_PAR], T2.[BUS_COD], T2.[TTBUS_Alquilado], T2.[TTBUS_NroSerie], T2.[TTBUS_Estado], T1.[NumeroIdentificador], T2.[TTBUS_Descripcion], T3.[BUS_FAD], T2.[TTBUS_FechaCarga], T2.[TTBUS_DesPosicion], T1.[TTBUS_Id] FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [BUS000] T3 WITH (NOLOCK) ON T3.[BUS_EMP] = T2.[BUS_EMP] AND T3.[BUS_RUB] = T2.[BUS_RUB] AND T3.[BUS_COD] = T2.[BUS_COD] AND T3.[BUS_PAR] = T2.[BUS_PAR]) WHERE (RTRIM(LTRIM(T2.[BUS_EMP])) = '') AND (T2.[TTBUS_CodProveedor] IS NULL or T2.[TTBUS_CodProveedor] = 0) AND (T2.[TTBUS_CucProveedor] IS NULL or T2.[TTBUS_CucProveedor] = 0) AND (T2.[TTBUS_Alquilado] = 0) AND (T2.[BUS_COD] = 0) AND (T2.[BUS_PAR] = 0) AND (T2.[BUS_RUB] = 0) AND (T1.[IdIdentificador] = 1) ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00152,100,0,true,false )
             ,new CursorDef("P00153", "SELECT T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS7_Pos], T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00153,1,0,false,true )
             ,new CursorDef("P00154", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV13TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00154,100,0,true,false )
             ,new CursorDef("P00155", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV11TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00155,1,0,false,true )
             ,new CursorDef("P00156", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV12TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00156,1,0,false,true )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((short[]) buf[6])[0] = rslt.getShort(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getString(6, 1) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((short[]) buf[10])[0] = rslt.getShort(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((short[]) buf[12])[0] = rslt.getShort(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(10) ;
                ((short[]) buf[16])[0] = rslt.getShort(11) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(13) ;
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(14) ;
                ((DateTime[]) buf[20])[0] = rslt.getGXDate(15) ;
                ((String[]) buf[21])[0] = rslt.getString(16, 50) ;
                ((int[]) buf[22])[0] = rslt.getInt(17) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 4 :
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
