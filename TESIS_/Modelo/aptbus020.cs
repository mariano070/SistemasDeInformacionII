/*
               File: PTBUS020
        Description: Reporte Cambio de Posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:44.3
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
   public class aptbus020 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV8NOMBRE_REPORTE = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11TTBUS20_Estacion = GetNextPar( ) ;
                  AV13USUARIO = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus020( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_TTBUS20_Estacion ,
                           ref String aP2_USUARIO )
      {
         this.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV11TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         this.AV13USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV11TTBUS20_Estacion;
         aP2_USUARIO=this.AV13USUARIO;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE ,
                                ref String aP1_TTBUS20_Estacion )
      {
         this.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV11TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         this.AV13USUARIO = aP2_USUARIO;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV11TTBUS20_Estacion;
         aP2_USUARIO=this.AV13USUARIO;
         return AV13USUARIO ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_TTBUS20_Estacion ,
                                 ref String aP2_USUARIO )
      {
         aptbus020 objaptbus020;
         objaptbus020 = new aptbus020();
         objaptbus020.AV8NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus020.AV11TTBUS20_Estacion = aP1_TTBUS20_Estacion;
         objaptbus020.AV13USUARIO = aP2_USUARIO;
         objaptbus020.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus020.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV8NOMBRE_REPORTE;
         aP1_TTBUS20_Estacion=this.AV11TTBUS20_Estacion;
         aP2_USUARIO=this.AV13USUARIO;
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
            H1F0( false, 120) ;
            getPrinter().GxDrawBitMap(context.GetImagePath( "1382f836-ea82-4658-aa27-5d13e1b4b3fb", "", "Modern"), 0, Gx_line+0, 183, Gx_line+83) ;
            getPrinter().GxDrawLine(8, Gx_line+118, 808, Gx_line+118, 2, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Descripción", 83, Gx_line+100, 154, Gx_line+115, 0+256) ;
            getPrinter().GxDrawText("Nº Etiqueta", 8, Gx_line+100, 77, Gx_line+115, 0+256) ;
            getPrinter().GxDrawText("Mensaje de Resultado", 367, Gx_line+100, 499, Gx_line+115, 0+256) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("INFORME DE CAMBIOS DE POSICIONES", 242, Gx_line+50, 575, Gx_line+70, 0+256) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 233, Gx_line+17, 589, Gx_line+43, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+120) ;
            /* Using cursor P001F2 */
            pr_default.execute(0, new Object[] {AV11TTBUS20_Estacion, AV13USUARIO});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A225TTBUS20_Usuario = P001F2_A225TTBUS20_Usuario[0] ;
               A219TTBUS20_Estacion = P001F2_A219TTBUS20_Estacion[0] ;
               A223TTBUS20_IdBien = P001F2_A223TTBUS20_IdBien[0] ;
               A224TTBUS20_Descripcion = P001F2_A224TTBUS20_Descripcion[0] ;
               A222TTBUS20_PlazoRecepcion = P001F2_A222TTBUS20_PlazoRecepcion[0] ;
               n222TTBUS20_PlazoRecepcion = P001F2_n222TTBUS20_PlazoRecepcion[0] ;
               A220TTBUS20_MotivoEnvio = P001F2_A220TTBUS20_MotivoEnvio[0] ;
               A218TTBUS20_Mensaje = P001F2_A218TTBUS20_Mensaje[0] ;
               A221TTBUS20_Observaciones = P001F2_A221TTBUS20_Observaciones[0] ;
               AV12TTBUS20_IdBien = A223TTBUS20_IdBien ;
               AV10TTBUS20_Descripcion = StringUtil.Trim( StringUtil.Str( (decimal)(A223TTBUS20_IdBien), 8, 0)) + " - " + StringUtil.Trim( A224TTBUS20_Descripcion) ;
               /* Execute user subroutine: S1134 */
               S1134 ();
               if ( returnInSub )
               {
                  pr_default.close(0);
                  this.cleanup();
                  if (true) return;
               }
               if ( ( ( StringUtil.StrCmp(StringUtil.Trim( A220TTBUS20_MotivoEnvio), "") == 0 ) ) || ( (DateTime.MinValue==A222TTBUS20_PlazoRecepcion) ) )
               {
                  H1F0( false, 21) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A218TTBUS20_Mensaje, "")), 367, Gx_line+0, 827, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9NumeroIdentificador, "")), 8, Gx_line+0, 75, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10TTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 83, Gx_line+0, 361, Gx_line+16, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+21) ;
                  H1F0( false, 18) ;
                  getPrinter().GxDrawLine(80, Gx_line+7, 800, Gx_line+7, 1, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+18) ;
               }
               else if ( ( ( StringUtil.StrCmp(StringUtil.Trim( A220TTBUS20_MotivoEnvio), "") != 0 ) ) && ( ! (DateTime.MinValue==A222TTBUS20_PlazoRecepcion) ) && ( ( StringUtil.StrCmp(StringUtil.Trim( A221TTBUS20_Observaciones), "") == 0 ) ) )
               {
                  H1F0( false, 53) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A218TTBUS20_Mensaje, "")), 367, Gx_line+0, 827, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A220TTBUS20_MotivoEnvio, "")), 367, Gx_line+17, 827, Gx_line+33, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9NumeroIdentificador, "")), 8, Gx_line+0, 75, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10TTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 83, Gx_line+0, 361, Gx_line+16, 0) ;
                  getPrinter().GxDrawText("Plazo Límite Recepción:", 367, Gx_line+33, 489, Gx_line+48, 0+256) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A222TTBUS20_PlazoRecepcion, "99/99/9999"), 492, Gx_line+33, 553, Gx_line+49, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+53) ;
                  H1F0( false, 18) ;
                  getPrinter().GxDrawLine(80, Gx_line+7, 800, Gx_line+7, 1, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+18) ;
               }
               else if ( ( StringUtil.StrCmp(StringUtil.Trim( A220TTBUS20_MotivoEnvio), "") != 0 ) && ( ! (DateTime.MinValue==A222TTBUS20_PlazoRecepcion) ) && ( StringUtil.StrCmp(StringUtil.Trim( A221TTBUS20_Observaciones), "") != 0 ) )
               {
                  H1F0( false, 71) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A218TTBUS20_Mensaje, "")), 367, Gx_line+0, 827, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A220TTBUS20_MotivoEnvio, "")), 367, Gx_line+17, 827, Gx_line+33, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A221TTBUS20_Observaciones, "")), 367, Gx_line+50, 827, Gx_line+66, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9NumeroIdentificador, "")), 8, Gx_line+0, 75, Gx_line+16, 0) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10TTBUS20_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 83, Gx_line+0, 361, Gx_line+16, 0) ;
                  getPrinter().GxDrawText("Plazo Límite Recepción:", 367, Gx_line+33, 489, Gx_line+48, 0+256) ;
                  getPrinter().GxDrawText(context.localUtil.Format( A222TTBUS20_PlazoRecepcion, "99/99/9999"), 492, Gx_line+33, 553, Gx_line+49, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+71) ;
                  H1F0( false, 18) ;
                  getPrinter().GxDrawLine(80, Gx_line+7, 800, Gx_line+7, 1, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+18) ;
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Optimized DELETE. */
            /* Using cursor P001F3 */
            pr_default.execute(1, new Object[] {AV11TTBUS20_Estacion, AV13USUARIO});
            pr_default.close(1);
            /* End optimized DELETE. */
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1F0( true, 0) ;
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

      protected void S1134( )
      {
         /* 'Nº ETIQUETA' Routine */
         AV9NumeroIdentificador = "" ;
         /* Using cursor P001F4 */
         pr_default.execute(2, new Object[] {AV12TTBUS20_IdBien});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A14IdIdentificador = P001F4_A14IdIdentificador[0] ;
            A11TTBUS_Id = P001F4_A11TTBUS_Id[0] ;
            A15NumeroIdentificador = P001F4_A15NumeroIdentificador[0] ;
            AV9NumeroIdentificador = StringUtil.Trim( A15NumeroIdentificador) ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(2);
      }

      protected void H1F0( bool bFoot ,
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
         getPrinter().setMetrics("Microsoft Sans Serif", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS020");
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
         scmdbuf = "" ;
         P001F2_A225TTBUS20_Usuario = new String[] {""} ;
         P001F2_A219TTBUS20_Estacion = new String[] {""} ;
         P001F2_A223TTBUS20_IdBien = new int[1] ;
         P001F2_A224TTBUS20_Descripcion = new String[] {""} ;
         P001F2_A222TTBUS20_PlazoRecepcion = new DateTime[] {DateTime.MinValue} ;
         P001F2_n222TTBUS20_PlazoRecepcion = new bool[] {false} ;
         P001F2_A220TTBUS20_MotivoEnvio = new String[] {""} ;
         P001F2_A218TTBUS20_Mensaje = new String[] {""} ;
         P001F2_A221TTBUS20_Observaciones = new String[] {""} ;
         A225TTBUS20_Usuario = "" ;
         A219TTBUS20_Estacion = "" ;
         A224TTBUS20_Descripcion = "" ;
         A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         A220TTBUS20_MotivoEnvio = "" ;
         A218TTBUS20_Mensaje = "" ;
         A221TTBUS20_Observaciones = "" ;
         AV10TTBUS20_Descripcion = "" ;
         AV9NumeroIdentificador = "" ;
         P001F4_A14IdIdentificador = new int[1] ;
         P001F4_A11TTBUS_Id = new int[1] ;
         P001F4_A15NumeroIdentificador = new String[] {""} ;
         A15NumeroIdentificador = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus020__default(),
            new Object[][] {
                new Object[] {
               P001F2_A225TTBUS20_Usuario, P001F2_A219TTBUS20_Estacion, P001F2_A223TTBUS20_IdBien, P001F2_A224TTBUS20_Descripcion, P001F2_A222TTBUS20_PlazoRecepcion, P001F2_n222TTBUS20_PlazoRecepcion, P001F2_A220TTBUS20_MotivoEnvio, P001F2_A218TTBUS20_Mensaje, P001F2_A221TTBUS20_Observaciones
               }
               , new Object[] {
               }
               , new Object[] {
               P001F4_A14IdIdentificador, P001F4_A11TTBUS_Id, P001F4_A15NumeroIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private int A223TTBUS20_IdBien ;
      private int AV12TTBUS20_IdBien ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private String gxfirstwebparm ;
      private String AV8NOMBRE_REPORTE ;
      private String AV11TTBUS20_Estacion ;
      private String AV13USUARIO ;
      private String scmdbuf ;
      private String A225TTBUS20_Usuario ;
      private String A219TTBUS20_Estacion ;
      private String A224TTBUS20_Descripcion ;
      private String AV10TTBUS20_Descripcion ;
      private DateTime A222TTBUS20_PlazoRecepcion ;
      private bool entryPointCalled ;
      private bool n222TTBUS20_PlazoRecepcion ;
      private bool returnInSub ;
      private String A220TTBUS20_MotivoEnvio ;
      private String A218TTBUS20_Mensaje ;
      private String A221TTBUS20_Observaciones ;
      private String AV9NumeroIdentificador ;
      private String A15NumeroIdentificador ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_TTBUS20_Estacion ;
      private String aP2_USUARIO ;
      private IDataStoreProvider pr_default ;
      private String[] P001F2_A225TTBUS20_Usuario ;
      private String[] P001F2_A219TTBUS20_Estacion ;
      private int[] P001F2_A223TTBUS20_IdBien ;
      private String[] P001F2_A224TTBUS20_Descripcion ;
      private DateTime[] P001F2_A222TTBUS20_PlazoRecepcion ;
      private bool[] P001F2_n222TTBUS20_PlazoRecepcion ;
      private String[] P001F2_A220TTBUS20_MotivoEnvio ;
      private String[] P001F2_A218TTBUS20_Mensaje ;
      private String[] P001F2_A221TTBUS20_Observaciones ;
      private int[] P001F4_A14IdIdentificador ;
      private int[] P001F4_A11TTBUS_Id ;
      private String[] P001F4_A15NumeroIdentificador ;
   }

   public class aptbus020__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001F2 ;
          prmP001F2 = new Object[] {
          new Object[] {"@AV11TTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@AV13USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001F3 ;
          prmP001F3 = new Object[] {
          new Object[] {"@AV11TTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@AV13USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001F4 ;
          prmP001F4 = new Object[] {
          new Object[] {"@AV12TTBUS20_IdBien",SqlDbType.Int,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001F2", "SELECT [TTBUS20_Usuario], [TTBUS20_Estacion], [TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_PlazoRecepcion], [TTBUS20_MotivoEnvio], [TTBUS20_Mensaje], [TTBUS20_Observaciones] FROM [TTBUS020] WITH (NOLOCK) WHERE ([TTBUS20_Estacion] = @AV11TTBUS20_Estacion) AND ([TTBUS20_Usuario] = @AV13USUARIO) ORDER BY [TTBUS20_IdBien] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001F2,100,0,true,false )
             ,new CursorDef("P001F3", "DELETE FROM [TTBUS020]  WHERE ([TTBUS20_Estacion] = @AV11TTBUS20_Estacion) AND ([TTBUS20_Usuario] = @AV13USUARIO)", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001F3)
             ,new CursorDef("P001F4", "SELECT TOP 1 [IdIdentificador], [TTBUS_Id], [NumeroIdentificador] FROM [TTBUS000Identificadores] WITH (NOLOCK) WHERE [TTBUS_Id] = @AV12TTBUS20_IdBien and [IdIdentificador] = 1 ORDER BY [TTBUS_Id], [IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001F4,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
