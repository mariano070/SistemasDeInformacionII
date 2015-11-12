/*
               File: PTBUS012
        Description: Listado de Movimientos de un Bien de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:57.45
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
   public class aptbus012 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV17NOMBRE_REPORTE = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV40USUARIO = GetNextPar( ) ;
                  AV28TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus012( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus012( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_USUARIO ,
                           ref int aP2_TTBUS_Id )
      {
         this.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV40USUARIO = aP1_USUARIO;
         this.AV28TTBUS_Id = aP2_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS_Id=this.AV28TTBUS_Id;
      }

      public int executeUdp( ref String aP0_NOMBRE_REPORTE ,
                             ref String aP1_USUARIO )
      {
         this.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV40USUARIO = aP1_USUARIO;
         this.AV28TTBUS_Id = aP2_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS_Id=this.AV28TTBUS_Id;
         return AV28TTBUS_Id ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref int aP2_TTBUS_Id )
      {
         aptbus012 objaptbus012;
         objaptbus012 = new aptbus012();
         objaptbus012.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus012.AV40USUARIO = aP1_USUARIO;
         objaptbus012.AV28TTBUS_Id = aP2_TTBUS_Id;
         objaptbus012.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus012.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS_Id=this.AV28TTBUS_Id;
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
            /* Using cursor P000I2 */
            pr_default.execute(0, new Object[] {AV28TTBUS_Id});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A11TTBUS_Id = P000I2_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P000I2_A12TTBUS_Descripcion[0] ;
               A29TTBUS_Alquilado = P000I2_A29TTBUS_Alquilado[0] ;
               A16TTBUS_FechaBaja = P000I2_A16TTBUS_FechaBaja[0] ;
               n16TTBUS_FechaBaja = P000I2_n16TTBUS_FechaBaja[0] ;
               A43TTBUS_MotivoBaja = P000I2_A43TTBUS_MotivoBaja[0] ;
               n43TTBUS_MotivoBaja = P000I2_n43TTBUS_MotivoBaja[0] ;
               AV26TTBUS_Descripcion = A12TTBUS_Descripcion ;
               if ( A29TTBUS_Alquilado == 1 )
               {
                  AV9alquilado = "SI" ;
               }
               else if ( A29TTBUS_Alquilado == 0 )
               {
                  AV9alquilado = "NO" ;
               }
               if ( ! (DateTime.MinValue==A16TTBUS_FechaBaja) )
               {
                  AV41lbl_fecBaja = "Fecha Baja:" ;
                  AV42lbl_MotBaja = "Motivo Baja:" ;
                  AV43fecha_baja = context.localUtil.DToC( A16TTBUS_FechaBaja, 4, "/") ;
                  AV45TTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
               }
               else
               {
                  AV41lbl_fecBaja = "" ;
                  AV42lbl_MotBaja = "" ;
                  AV43fecha_baja = "" ;
                  AV45TTBUS_MotivoBaja = "" ;
               }
               AV33TTBUS2_IdBien = A11TTBUS_Id ;
               /* Using cursor P000I3 */
               pr_default.execute(1, new Object[] {AV33TTBUS2_IdBien});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A22TTBUS2_IdBien = P000I3_A22TTBUS2_IdBien[0] ;
                  A48TTBUS2_CodPosDesde = P000I3_A48TTBUS2_CodPosDesde[0] ;
                  A49TTBUS2_CodPosHacia = P000I3_A49TTBUS2_CodPosHacia[0] ;
                  A24TTBUS2_RespDesde = P000I3_A24TTBUS2_RespDesde[0] ;
                  A25TTBUS2_RespHacia = P000I3_A25TTBUS2_RespHacia[0] ;
                  A47TTBUS2_MotivoEnvio = P000I3_A47TTBUS2_MotivoEnvio[0] ;
                  A45TTBUS2_FechaEnvio = P000I3_A45TTBUS2_FechaEnvio[0] ;
                  A46TTBUS2_FechaRecepcion = P000I3_A46TTBUS2_FechaRecepcion[0] ;
                  n46TTBUS2_FechaRecepcion = P000I3_n46TTBUS2_FechaRecepcion[0] ;
                  A87TTBUS2_Observaciones = P000I3_A87TTBUS2_Observaciones[0] ;
                  n87TTBUS2_Observaciones = P000I3_n87TTBUS2_Observaciones[0] ;
                  A26TTBUS2_EstadoEnvio = P000I3_A26TTBUS2_EstadoEnvio[0] ;
                  A50TTBUS2_MotivoCancelacion = P000I3_A50TTBUS2_MotivoCancelacion[0] ;
                  n50TTBUS2_MotivoCancelacion = P000I3_n50TTBUS2_MotivoCancelacion[0] ;
                  A52TTBUS2_IdMovimiento = P000I3_A52TTBUS2_IdMovimiento[0] ;
                  new ptbus020_b(context ).execute(  A48TTBUS2_CodPosDesde, out  AV11dTTBUS7_Des) ;
                  new ptbus020_b(context ).execute(  A49TTBUS2_CodPosHacia, out  AV14hTTBUS7_Des) ;
                  new ptbus012_a(context ).execute(  A24TTBUS2_RespDesde, out  AV12dUSU_DES) ;
                  new ptbus012_a(context ).execute(  A25TTBUS2_RespHacia, out  AV15hUSU_DES) ;
                  AV35TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
                  AV31TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                  AV32TTBUS2_FechaRecepcion = A46TTBUS2_FechaRecepcion ;
                  AV46TTBUS2_Observaciones = StringUtil.Trim( A87TTBUS2_Observaciones) ;
                  if ( A26TTBUS2_EstadoEnvio == 1 )
                  {
                     AV13estado = "NO FINALIZADO" ;
                     AV16lbl_motivoBaja = "" ;
                     AV34TTBUS2_MotivoCancelacion = "" ;
                  }
                  else if ( A26TTBUS2_EstadoEnvio == 2 )
                  {
                     AV13estado = "FINALIZADO" ;
                     AV16lbl_motivoBaja = "" ;
                     AV34TTBUS2_MotivoCancelacion = "" ;
                  }
                  else if ( A26TTBUS2_EstadoEnvio == 3 )
                  {
                     AV13estado = "CANCELADO" ;
                     AV16lbl_motivoBaja = "Motivo Cancelación:" ;
                     AV34TTBUS2_MotivoCancelacion = A50TTBUS2_MotivoCancelacion ;
                  }
                  AV10band = 0 ;
                  new ptbus007(context ).execute( ref  AV10band,  AV28TTBUS_Id,  AV40USUARIO) ;
                  if ( AV10band == 1 )
                  {
                     H0I0( false, 112) ;
                     getPrinter().GxDrawLine(475, Gx_line+103, 1142, Gx_line+103, 1, 0, 0, 0, 0) ;
                     getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText("Resp. Envío:", 475, Gx_line+0, 542, Gx_line+15, 0+256) ;
                     getPrinter().GxDrawText("Resp. Recepción:", 475, Gx_line+17, 566, Gx_line+32, 0+256) ;
                     getPrinter().GxDrawText("Motivo Envío:", 475, Gx_line+33, 546, Gx_line+48, 0+256) ;
                     getPrinter().GxDrawText("Fecha Envío:", 867, Gx_line+0, 936, Gx_line+15, 0) ;
                     getPrinter().GxDrawText("Fecha Recepción:", 867, Gx_line+17, 960, Gx_line+32, 0+256) ;
                     getPrinter().GxDrawText("Estado Envío:", 475, Gx_line+50, 547, Gx_line+65, 0+256) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV16lbl_motivoBaja, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 475, Gx_line+85, 592, Gx_line+101, 0) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV11dTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 8, Gx_line+0, 233, Gx_line+16, 0) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14hTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 242, Gx_line+0, 467, Gx_line+16, 0) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12dUSU_DES, "@!")), 600, Gx_line+0, 861, Gx_line+16, 0) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15hUSU_DES, "@!")), 600, Gx_line+17, 861, Gx_line+33, 0) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV35TTBUS2_MotivoEnvio, "@!")), 600, Gx_line+33, 1122, Gx_line+49, 0+256) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV13estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 600, Gx_line+50, 757, Gx_line+66, 0+256) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV34TTBUS2_MotivoCancelacion, "@!")), 600, Gx_line+85, 1122, Gx_line+101, 0+256) ;
                     getPrinter().GxDrawText(context.localUtil.Format( AV31TTBUS2_FechaEnvio, "99/99/9999 99:99"), 967, Gx_line+0, 1060, Gx_line+16, 2+256) ;
                     getPrinter().GxDrawText(context.localUtil.Format( AV32TTBUS2_FechaRecepcion, "99/99/99 99:99"), 967, Gx_line+17, 1047, Gx_line+33, 2+256) ;
                     getPrinter().GxDrawText("Observaciones:", 475, Gx_line+67, 553, Gx_line+82, 0+256) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV46TTBUS2_Observaciones, "@!")), 600, Gx_line+67, 1122, Gx_line+83, 0) ;
                     Gx_OldLine = Gx_line ;
                     Gx_line = (int)(Gx_line+112) ;
                  }
                  pr_default.readNext(1);
               }
               pr_default.close(1);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0I0( true, 0) ;
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

      protected void H0I0( bool bFoot ,
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
               getPrinter().GxDrawBitMap(context.GetImagePath( "1382f836-ea82-4658-aa27-5d13e1b4b3fb", "", "Modern"), 0, Gx_line+0, 183, Gx_line+83) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha y Hora:", 967, Gx_line+17, 1038, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Página:", 967, Gx_line+33, 1006, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/9999 99:99"), 1042, Gx_line+17, 1135, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1042, Gx_line+33, 1081, Gx_line+49, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("LISTADO DE MOVIMIENTOS DE BIEN DE USO", 400, Gx_line+50, 774, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 408, Gx_line+17, 764, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+96) ;
               getPrinter().GxDrawLine(8, Gx_line+84, 1141, Gx_line+84, 2, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28TTBUS_Id), "ZZZZZZZ9")), 83, Gx_line+0, 134, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV26TTBUS_Descripcion, "@!")), 83, Gx_line+17, 344, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 83, Gx_line+33, 141, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText("Posición Envío:", 8, Gx_line+67, 87, Gx_line+82, 0+256) ;
               getPrinter().GxDrawText("Posición Recepción:", 242, Gx_line+67, 345, Gx_line+82, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV43fecha_baja, "XXXXXXXXXX")), 475, Gx_line+0, 528, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV45TTBUS_MotivoBaja, "@!")), 475, Gx_line+17, 736, Gx_line+33, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Nº Bien", 8, Gx_line+0, 47, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText("Descripción", 8, Gx_line+17, 67, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Alquilado", 8, Gx_line+33, 54, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Datos del Movimiento", 475, Gx_line+67, 582, Gx_line+82, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV41lbl_fecBaja, "XXXXXXXXXXXXXXX")), 367, Gx_line+0, 446, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV42lbl_MotBaja, "XXXXXXXXXXXXXXXXXXXX")), 367, Gx_line+17, 472, Gx_line+33, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+86) ;
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
         P000I2_A11TTBUS_Id = new int[1] ;
         P000I2_A12TTBUS_Descripcion = new String[] {""} ;
         P000I2_A29TTBUS_Alquilado = new short[1] ;
         P000I2_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         P000I2_n16TTBUS_FechaBaja = new bool[] {false} ;
         P000I2_A43TTBUS_MotivoBaja = new String[] {""} ;
         P000I2_n43TTBUS_MotivoBaja = new bool[] {false} ;
         A12TTBUS_Descripcion = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A43TTBUS_MotivoBaja = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         AV41lbl_fecBaja = "" ;
         AV42lbl_MotBaja = "" ;
         AV43fecha_baja = "" ;
         AV45TTBUS_MotivoBaja = "" ;
         P000I3_A22TTBUS2_IdBien = new int[1] ;
         P000I3_A48TTBUS2_CodPosDesde = new short[1] ;
         P000I3_A49TTBUS2_CodPosHacia = new short[1] ;
         P000I3_A24TTBUS2_RespDesde = new String[] {""} ;
         P000I3_A25TTBUS2_RespHacia = new String[] {""} ;
         P000I3_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         P000I3_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P000I3_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         P000I3_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         P000I3_A87TTBUS2_Observaciones = new String[] {""} ;
         P000I3_n87TTBUS2_Observaciones = new bool[] {false} ;
         P000I3_A26TTBUS2_EstadoEnvio = new short[1] ;
         P000I3_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         P000I3_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         P000I3_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         A87TTBUS2_Observaciones = "" ;
         A50TTBUS2_MotivoCancelacion = "" ;
         AV11dTTBUS7_Des = "" ;
         AV14hTTBUS7_Des = "" ;
         AV12dUSU_DES = "" ;
         AV15hUSU_DES = "" ;
         AV35TTBUS2_MotivoEnvio = "" ;
         AV31TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV32TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         AV46TTBUS2_Observaciones = "" ;
         AV13estado = "" ;
         AV16lbl_motivoBaja = "" ;
         AV34TTBUS2_MotivoCancelacion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus012__default(),
            new Object[][] {
                new Object[] {
               P000I2_A11TTBUS_Id, P000I2_A12TTBUS_Descripcion, P000I2_A29TTBUS_Alquilado, P000I2_A16TTBUS_FechaBaja, P000I2_n16TTBUS_FechaBaja, P000I2_A43TTBUS_MotivoBaja, P000I2_n43TTBUS_MotivoBaja
               }
               , new Object[] {
               P000I3_A22TTBUS2_IdBien, P000I3_A48TTBUS2_CodPosDesde, P000I3_A49TTBUS2_CodPosHacia, P000I3_A24TTBUS2_RespDesde, P000I3_A25TTBUS2_RespHacia, P000I3_A47TTBUS2_MotivoEnvio, P000I3_A45TTBUS2_FechaEnvio, P000I3_A46TTBUS2_FechaRecepcion, P000I3_n46TTBUS2_FechaRecepcion, P000I3_A87TTBUS2_Observaciones,
               P000I3_n87TTBUS2_Observaciones, P000I3_A26TTBUS2_EstadoEnvio, P000I3_A50TTBUS2_MotivoCancelacion, P000I3_n50TTBUS2_MotivoCancelacion, P000I3_A52TTBUS2_IdMovimiento
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A29TTBUS_Alquilado ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV10band ;
      private int AV28TTBUS_Id ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A11TTBUS_Id ;
      private int AV33TTBUS2_IdBien ;
      private int A22TTBUS2_IdBien ;
      private int Gx_OldLine ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV17NOMBRE_REPORTE ;
      private String AV40USUARIO ;
      private String scmdbuf ;
      private String AV9alquilado ;
      private String AV41lbl_fecBaja ;
      private String AV42lbl_MotBaja ;
      private String AV43fecha_baja ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV11dTTBUS7_Des ;
      private String AV14hTTBUS7_Des ;
      private String AV12dUSU_DES ;
      private String AV15hUSU_DES ;
      private String AV13estado ;
      private String AV16lbl_motivoBaja ;
      private DateTime AV8AHORA ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A46TTBUS2_FechaRecepcion ;
      private DateTime AV31TTBUS2_FechaEnvio ;
      private DateTime AV32TTBUS2_FechaRecepcion ;
      private DateTime A16TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n87TTBUS2_Observaciones ;
      private bool n50TTBUS2_MotivoCancelacion ;
      private String A12TTBUS_Descripcion ;
      private String A43TTBUS_MotivoBaja ;
      private String AV26TTBUS_Descripcion ;
      private String AV45TTBUS_MotivoBaja ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String A50TTBUS2_MotivoCancelacion ;
      private String AV35TTBUS2_MotivoEnvio ;
      private String AV46TTBUS2_Observaciones ;
      private String AV34TTBUS2_MotivoCancelacion ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private int aP2_TTBUS_Id ;
      private IDataStoreProvider pr_default ;
      private int[] P000I2_A11TTBUS_Id ;
      private String[] P000I2_A12TTBUS_Descripcion ;
      private short[] P000I2_A29TTBUS_Alquilado ;
      private DateTime[] P000I2_A16TTBUS_FechaBaja ;
      private bool[] P000I2_n16TTBUS_FechaBaja ;
      private String[] P000I2_A43TTBUS_MotivoBaja ;
      private bool[] P000I2_n43TTBUS_MotivoBaja ;
      private int[] P000I3_A22TTBUS2_IdBien ;
      private short[] P000I3_A48TTBUS2_CodPosDesde ;
      private short[] P000I3_A49TTBUS2_CodPosHacia ;
      private String[] P000I3_A24TTBUS2_RespDesde ;
      private String[] P000I3_A25TTBUS2_RespHacia ;
      private String[] P000I3_A47TTBUS2_MotivoEnvio ;
      private DateTime[] P000I3_A45TTBUS2_FechaEnvio ;
      private DateTime[] P000I3_A46TTBUS2_FechaRecepcion ;
      private bool[] P000I3_n46TTBUS2_FechaRecepcion ;
      private String[] P000I3_A87TTBUS2_Observaciones ;
      private bool[] P000I3_n87TTBUS2_Observaciones ;
      private short[] P000I3_A26TTBUS2_EstadoEnvio ;
      private String[] P000I3_A50TTBUS2_MotivoCancelacion ;
      private bool[] P000I3_n50TTBUS2_MotivoCancelacion ;
      private long[] P000I3_A52TTBUS2_IdMovimiento ;
   }

   public class aptbus012__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000I2 ;
          prmP000I2 = new Object[] {
          new Object[] {"@AV28TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000I3 ;
          prmP000I3 = new Object[] {
          new Object[] {"@AV33TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000I2", "SELECT [TTBUS_Id], [TTBUS_Descripcion], [TTBUS_Alquilado], [TTBUS_FechaBaja], [TTBUS_MotivoBaja] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV28TTBUS_Id ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000I2,1,0,true,true )
             ,new CursorDef("P000I3", "SELECT [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_MotivoEnvio], [TTBUS2_FechaEnvio], [TTBUS2_FechaRecepcion], [TTBUS2_Observaciones], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoCancelacion], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdBien] = @AV33TTBUS2_IdBien ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000I3,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((String[]) buf[9])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(9);
                ((short[]) buf[11])[0] = rslt.getShort(10) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((long[]) buf[14])[0] = rslt.getLong(12) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
