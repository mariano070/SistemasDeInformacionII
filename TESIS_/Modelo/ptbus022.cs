/*
               File: PTBUS022
        Description: Reporte de bienes pendiente de recepción
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:12.21
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
   public class ptbus022 : GXProcedure
   {
      public ptbus022( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus022( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_TTBUS2_RespHacia ,
                           ref String aP1_NOMBRE_REPORTE )
      {
         this.AV8TTBUS2_RespHacia = aP0_TTBUS2_RespHacia;
         this.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_TTBUS2_RespHacia=this.AV8TTBUS2_RespHacia;
         aP1_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
      }

      public String executeUdp( ref String aP0_TTBUS2_RespHacia )
      {
         this.AV8TTBUS2_RespHacia = aP0_TTBUS2_RespHacia;
         this.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_TTBUS2_RespHacia=this.AV8TTBUS2_RespHacia;
         aP1_NOMBRE_REPORTE=this.AV16NOMBRE_REPORTE;
         return AV16NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref String aP0_TTBUS2_RespHacia ,
                                 ref String aP1_NOMBRE_REPORTE )
      {
         ptbus022 objptbus022;
         objptbus022 = new ptbus022();
         objptbus022.AV8TTBUS2_RespHacia = aP0_TTBUS2_RespHacia;
         objptbus022.AV16NOMBRE_REPORTE = aP1_NOMBRE_REPORTE;
         objptbus022.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus022.executePrivateCatch ));
         aP0_TTBUS2_RespHacia=this.AV8TTBUS2_RespHacia;
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
         getPrinter().GxSetDocName(AV16NOMBRE_REPORTE) ;
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
            AV10ahora = DateTimeUtil.Now( ) ;
            AV9LOGO = "imagenes/LOGO_SANCORSALUD.bmp" ;
            /* Using cursor P001Q2 */
            pr_default.execute(0, new Object[] {AV8TTBUS2_RespHacia, Gx_date});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK1Q3 = false ;
               A22TTBUS2_IdBien = P001Q2_A22TTBUS2_IdBien[0] ;
               A48TTBUS2_CodPosDesde = P001Q2_A48TTBUS2_CodPosDesde[0] ;
               A45TTBUS2_FechaEnvio = P001Q2_A45TTBUS2_FechaEnvio[0] ;
               A25TTBUS2_RespHacia = P001Q2_A25TTBUS2_RespHacia[0] ;
               A77TTBUS2_PlazoRecepcion = P001Q2_A77TTBUS2_PlazoRecepcion[0] ;
               n77TTBUS2_PlazoRecepcion = P001Q2_n77TTBUS2_PlazoRecepcion[0] ;
               A26TTBUS2_EstadoEnvio = P001Q2_A26TTBUS2_EstadoEnvio[0] ;
               A52TTBUS2_IdMovimiento = P001Q2_A52TTBUS2_IdMovimiento[0] ;
               while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001Q2_A25TTBUS2_RespHacia[0], A25TTBUS2_RespHacia) == 0 ) )
               {
                  BRK1Q3 = false ;
                  A22TTBUS2_IdBien = P001Q2_A22TTBUS2_IdBien[0] ;
                  A48TTBUS2_CodPosDesde = P001Q2_A48TTBUS2_CodPosDesde[0] ;
                  A45TTBUS2_FechaEnvio = P001Q2_A45TTBUS2_FechaEnvio[0] ;
                  A52TTBUS2_IdMovimiento = P001Q2_A52TTBUS2_IdMovimiento[0] ;
                  AV14TTBUS_Id = A22TTBUS2_IdBien ;
                  AV11TTBUS7_Pos = A48TTBUS2_CodPosDesde ;
                  /* Execute user subroutine: S1128 */
                  S1128 ();
                  if ( returnInSub )
                  {
                     pr_default.close(0);
                     this.cleanup();
                     if (true) return;
                  }
                  H1Q0( false, 24) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV13NumeroIdentificador, "")), 8, Gx_line+0, 116, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12TTBUS_Descripcion, "@!")), 133, Gx_line+0, 394, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15TTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 408, Gx_line+0, 669, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A45TTBUS2_FechaEnvio, "99/99/9999 99:99"), 683, Gx_line+0, 776, Gx_line+16, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+24) ;
                  BRK1Q3 = true ;
                  pr_default.readNext(0);
               }
               if ( ! BRK1Q3 )
               {
                  BRK1Q3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1Q0( true, 0) ;
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

      protected void S1128( )
      {
         /* 'DATOS BIEN DE USO' Routine */
         /* Using cursor P001Q3 */
         pr_default.execute(1, new Object[] {AV14TTBUS_Id});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A14IdIdentificador = P001Q3_A14IdIdentificador[0] ;
            A11TTBUS_Id = P001Q3_A11TTBUS_Id[0] ;
            A12TTBUS_Descripcion = P001Q3_A12TTBUS_Descripcion[0] ;
            A15NumeroIdentificador = P001Q3_A15NumeroIdentificador[0] ;
            A12TTBUS_Descripcion = P001Q3_A12TTBUS_Descripcion[0] ;
            AV12TTBUS_Descripcion = StringUtil.Trim( A12TTBUS_Descripcion) ;
            AV13NumeroIdentificador = StringUtil.Trim( A15NumeroIdentificador) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         /* Using cursor P001Q4 */
         pr_default.execute(2, new Object[] {AV11TTBUS7_Pos});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A33TTBUS7_Pos = P001Q4_A33TTBUS7_Pos[0] ;
            A34TTBUS7_Des = P001Q4_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P001Q4_n34TTBUS7_Des[0] ;
            A34TTBUS7_Des = P001Q4_A34TTBUS7_Des[0] ;
            n34TTBUS7_Des = P001Q4_n34TTBUS7_Des[0] ;
            AV15TTBUS7_Des = StringUtil.Trim( A34TTBUS7_Des) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void H1Q0( bool bFoot ,
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
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(context.localUtil.Format( AV10ahora, "99/99/9999 99:99"), 100, Gx_line+0, 193, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText("Fecha de Listado:", 8, Gx_line+0, 98, Gx_line+15, 0+256) ;
                  getPrinter().GxDrawText("Página:", 708, Gx_line+0, 747, Gx_line+15, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 750, Gx_line+0, 789, Gx_line+16, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+19) ;
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
               getPrinter().GxDrawLine(0, Gx_line+117, 808, Gx_line+117, 1, 0, 0, 0, 0) ;
               getPrinter().GxDrawBitMap(AV9LOGO, 8, Gx_line+8, 175, Gx_line+50) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Nº Etiqueta", 8, Gx_line+100, 84, Gx_line+117, 0+256) ;
               getPrinter().GxDrawText("Descripción del bien", 133, Gx_line+100, 272, Gx_line+117, 0+256) ;
               getPrinter().GxDrawText("Sector de origen", 408, Gx_line+100, 519, Gx_line+117, 0+256) ;
               getPrinter().GxDrawText("Fecha de Envío", 683, Gx_line+100, 786, Gx_line+117, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Listado de Bienes Pendientes de Recepción", 245, Gx_line+50, 590, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 233, Gx_line+17, 589, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+122) ;
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
         AV10ahora = (DateTime)(DateTime.MinValue) ;
         AV9LOGO = "" ;
         scmdbuf = "" ;
         Gx_date = DateTime.MinValue ;
         P001Q2_A22TTBUS2_IdBien = new int[1] ;
         P001Q2_A48TTBUS2_CodPosDesde = new short[1] ;
         P001Q2_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001Q2_A25TTBUS2_RespHacia = new String[] {""} ;
         P001Q2_A77TTBUS2_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         P001Q2_n77TTBUS2_PlazoRecepcion = new bool[] {false} ;
         P001Q2_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001Q2_A52TTBUS2_IdMovimiento = new long[1] ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A25TTBUS2_RespHacia = "" ;
         A77TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV13NumeroIdentificador = "" ;
         AV12TTBUS_Descripcion = "" ;
         AV15TTBUS7_Des = "" ;
         P001Q3_A14IdIdentificador = new int[1] ;
         P001Q3_A11TTBUS_Id = new int[1] ;
         P001Q3_A12TTBUS_Descripcion = new String[] {""} ;
         P001Q3_A15NumeroIdentificador = new String[] {""} ;
         A12TTBUS_Descripcion = "" ;
         A15NumeroIdentificador = "" ;
         P001Q4_A33TTBUS7_Pos = new short[1] ;
         P001Q4_A34TTBUS7_Des = new String[] {""} ;
         P001Q4_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         AV9LOGO = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus022__default(),
            new Object[][] {
                new Object[] {
               P001Q2_A22TTBUS2_IdBien, P001Q2_A48TTBUS2_CodPosDesde, P001Q2_A45TTBUS2_FechaEnvio, P001Q2_A25TTBUS2_RespHacia, P001Q2_A77TTBUS2_PlazoRecepcion, P001Q2_n77TTBUS2_PlazoRecepcion, P001Q2_A26TTBUS2_EstadoEnvio, P001Q2_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001Q3_A14IdIdentificador, P001Q3_A11TTBUS_Id, P001Q3_A12TTBUS_Descripcion, P001Q3_A15NumeroIdentificador
               }
               , new Object[] {
               P001Q4_A33TTBUS7_Pos, P001Q4_A34TTBUS7_Des, P001Q4_n34TTBUS7_Des
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_line = 0 ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short A48TTBUS2_CodPosDesde ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV11TTBUS7_Pos ;
      private short A33TTBUS7_Pos ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A22TTBUS2_IdBien ;
      private int AV14TTBUS_Id ;
      private int Gx_OldLine ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV8TTBUS2_RespHacia ;
      private String AV16NOMBRE_REPORTE ;
      private String scmdbuf ;
      private String A25TTBUS2_RespHacia ;
      private String AV15TTBUS7_Des ;
      private String A34TTBUS7_Des ;
      private DateTime AV10ahora ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime Gx_date ;
      private DateTime A77TTBUS2_PlazoRecepcion ;
      private bool BRK1Q3 ;
      private bool n77TTBUS2_PlazoRecepcion ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private String AV13NumeroIdentificador ;
      private String AV12TTBUS_Descripcion ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV9LOGO ;
      private String Logo ;
      private IGxDataStore dsDefault ;
      private String aP0_TTBUS2_RespHacia ;
      private String aP1_NOMBRE_REPORTE ;
      private IDataStoreProvider pr_default ;
      private int[] P001Q2_A22TTBUS2_IdBien ;
      private short[] P001Q2_A48TTBUS2_CodPosDesde ;
      private DateTime[] P001Q2_A45TTBUS2_FechaEnvio ;
      private String[] P001Q2_A25TTBUS2_RespHacia ;
      private DateTime[] P001Q2_A77TTBUS2_PlazoRecepcion ;
      private bool[] P001Q2_n77TTBUS2_PlazoRecepcion ;
      private short[] P001Q2_A26TTBUS2_EstadoEnvio ;
      private long[] P001Q2_A52TTBUS2_IdMovimiento ;
      private int[] P001Q3_A14IdIdentificador ;
      private int[] P001Q3_A11TTBUS_Id ;
      private String[] P001Q3_A12TTBUS_Descripcion ;
      private String[] P001Q3_A15NumeroIdentificador ;
      private short[] P001Q4_A33TTBUS7_Pos ;
      private String[] P001Q4_A34TTBUS7_Des ;
      private bool[] P001Q4_n34TTBUS7_Des ;
   }

   public class ptbus022__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001Q2 ;
          prmP001Q2 = new Object[] {
          new Object[] {"@AV8TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@Gx_date",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001Q3 ;
          prmP001Q3 = new Object[] {
          new Object[] {"@AV14TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001Q4 ;
          prmP001Q4 = new Object[] {
          new Object[] {"@AV11TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001Q2", "SELECT [TTBUS2_IdBien], [TTBUS2_CodPosDesde], [TTBUS2_FechaEnvio], [TTBUS2_RespHacia], [TTBUS2_PlazoRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_RespHacia] = @AV8TTBUS2_RespHacia) AND ([TTBUS2_PlazoRecepcion] < @Gx_date) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_RespHacia] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q2,100,0,true,false )
             ,new CursorDef("P001Q3", "SELECT T1.[IdIdentificador], T1.[TTBUS_Id], T2.[TTBUS_Descripcion], T1.[NumeroIdentificador] FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) WHERE T1.[TTBUS_Id] = @AV14TTBUS_Id and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q3,1,0,false,true )
             ,new CursorDef("P001Q4", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @AV11TTBUS7_Pos ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Q4,1,0,false,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((long[]) buf[7])[0] = rslt.getLong(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
