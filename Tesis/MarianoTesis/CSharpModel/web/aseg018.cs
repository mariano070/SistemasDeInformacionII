/*
               File: SEG018
        Description: LISTADO USUARIO-PROGRAMAS POR VERSION
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:37.92
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
   public class aseg018 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV9TIPO = gxfirstwebparm ;
            }
         }
         executePrivate();
         cleanup();
      }

      public aseg018( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aseg018( IGxContext context )
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

      public void execute( ref String aP0_TIPO )
      {
         this.AV9TIPO = aP0_TIPO;
         initialize();
         executePrivate();
         aP0_TIPO=this.AV9TIPO;
      }

      public String executeUdp( )
      {
         this.AV9TIPO = aP0_TIPO;
         initialize();
         executePrivate();
         aP0_TIPO=this.AV9TIPO;
         return AV9TIPO ;
      }

      public void executeSubmit( ref String aP0_TIPO )
      {
         aseg018 objaseg018;
         objaseg018 = new aseg018();
         objaseg018.AV9TIPO = aP0_TIPO;
         objaseg018.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaseg018.executePrivateCatch ));
         aP0_TIPO=this.AV9TIPO;
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
         M_bot = 2 ;
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
            Gx_out = "SCR" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 10901, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*2)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            GxHdr3 = true ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV9TIPO ,
                                                 A128PRG_EXT ,
                                                 A117PRG_WEB },
                                                 new int[] {
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                                 }
            });
            /* Using cursor P002K2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK2K3 = false ;
               A117PRG_WEB = P002K2_A117PRG_WEB[0] ;
               A128PRG_EXT = P002K2_A128PRG_EXT[0] ;
               A127PRG_DES = P002K2_A127PRG_DES[0] ;
               A126PRG_COD = P002K2_A126PRG_COD[0] ;
               A164PRG_SIS = P002K2_A164PRG_SIS[0] ;
               A366SIS_MAI = P002K2_A366SIS_MAI[0] ;
               n366SIS_MAI = P002K2_n366SIS_MAI[0] ;
               A259SIS_DES = P002K2_A259SIS_DES[0] ;
               n259SIS_DES = P002K2_n259SIS_DES[0] ;
               A366SIS_MAI = P002K2_A366SIS_MAI[0] ;
               n366SIS_MAI = P002K2_n366SIS_MAI[0] ;
               A259SIS_DES = P002K2_A259SIS_DES[0] ;
               n259SIS_DES = P002K2_n259SIS_DES[0] ;
               H2K0( false, 65) ;
               getPrinter().GxDrawLine(9, Gx_line+9, 719, Gx_line+9, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Courier New", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A164PRG_SIS), "ZZ9")), 80, Gx_line+19, 103, Gx_line+38, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), 114, Gx_line+19, 224, Gx_line+38, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A366SIS_MAI, "")), 105, Gx_line+35, 722, Gx_line+54, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("SISTEMA", 5, Gx_line+19, 62, Gx_line+34, 0+256) ;
               getPrinter().GxDrawText("MAIL DE AVISO:", 5, Gx_line+35, 105, Gx_line+50, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+65) ;
               while ( (pr_default.getStatus(0) != 101) && ( P002K2_A164PRG_SIS[0] == A164PRG_SIS ) )
               {
                  BRK2K3 = false ;
                  A117PRG_WEB = P002K2_A117PRG_WEB[0] ;
                  A128PRG_EXT = P002K2_A128PRG_EXT[0] ;
                  A127PRG_DES = P002K2_A127PRG_DES[0] ;
                  A126PRG_COD = P002K2_A126PRG_COD[0] ;
                  AV8usuarios = 0 ;
                  /* Optimized group. */
                  /* Using cursor P002K3 */
                  pr_default.execute(1, new Object[] {A164PRG_SIS, A126PRG_COD});
                  cV8usuarios = P002K3_AV8usuarios[0] ;
                  pr_default.close(1);
                  AV8usuarios = (short)(AV8usuarios+cV8usuarios*1) ;
                  /* End optimized group. */
                  H2K0( false, 20) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A128PRG_EXT, "XXX")), 709, Gx_line+0, 732, Gx_line+18, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A117PRG_WEB, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 496, Gx_line+1, 716, Gx_line+19, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A128PRG_EXT, "XXX")), 766, Gx_line+0, 789, Gx_line+18, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8usuarios), "ZZZ9")), 404, Gx_line+1, 434, Gx_line+19, 2+256) ;
                  getPrinter().GxAttris("Courier New", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 131, Gx_line+1, 351, Gx_line+20, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9")), 97, Gx_line+0, 127, Gx_line+19, 2+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Versión: \"", 656, Gx_line+2, 705, Gx_line+17, 0+256) ;
                  getPrinter().GxDrawText("OBJETO:", 446, Gx_line+1, 494, Gx_line+16, 0+256) ;
                  getPrinter().GxDrawText("\"", 723, Gx_line+2, 729, Gx_line+17, 0+256) ;
                  getPrinter().GxDrawText("Usuarios:", 356, Gx_line+2, 403, Gx_line+17, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("PROGRAMA", 19, Gx_line+0, 93, Gx_line+15, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+20) ;
                  BRK2K3 = true ;
                  pr_default.readNext(0);
               }
               if ( ! BRK2K3 )
               {
                  BRK2K3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            GxHdr3 = false ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H2K0( true, 0) ;
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

      protected void H2K0( bool bFoot ,
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
                  getPrinter().GxDrawLine(19, Gx_line+2, 726, Gx_line+2, 1, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 680, Gx_line+0, 725, Gx_line+18, 2+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Pag.", 651, Gx_line+3, 675, Gx_line+18, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+23) ;
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
               if ( GxHdr3 )
               {
                  getPrinter().GxDrawRect(0, Gx_line+0, 732, Gx_line+50, 1, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("LISTADO DE PROGRAMAS POR VERSION", 225, Gx_line+17, 481, Gx_line+32, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+51) ;
               }
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
         add_metrics2( ) ;
         add_metrics3( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Courier New", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics2( )
      {
         getPrinter().setMetrics("Courier New", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics3( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
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
         scmdbuf = "" ;
         A128PRG_EXT = "" ;
         A117PRG_WEB = "" ;
         P002K2_A117PRG_WEB = new String[] {""} ;
         P002K2_A128PRG_EXT = new String[] {""} ;
         P002K2_A127PRG_DES = new String[] {""} ;
         P002K2_A126PRG_COD = new short[1] ;
         P002K2_A164PRG_SIS = new short[1] ;
         P002K2_A366SIS_MAI = new String[] {""} ;
         P002K2_n366SIS_MAI = new bool[] {false} ;
         P002K2_A259SIS_DES = new String[] {""} ;
         P002K2_n259SIS_DES = new bool[] {false} ;
         A127PRG_DES = "" ;
         A366SIS_MAI = "" ;
         A259SIS_DES = "" ;
         P002K3_AV8usuarios = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aseg018__default(),
            new Object[][] {
                new Object[] {
               P002K2_A117PRG_WEB, P002K2_A128PRG_EXT, P002K2_A127PRG_DES, P002K2_A126PRG_COD, P002K2_A164PRG_SIS, P002K2_A366SIS_MAI, P002K2_n366SIS_MAI, P002K2_A259SIS_DES, P002K2_n259SIS_DES
               }
               , new Object[] {
               P002K3_AV8usuarios
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A126PRG_COD ;
      private short A164PRG_SIS ;
      private short AV8usuarios ;
      private short cV8usuarios ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private String gxfirstwebparm ;
      private String AV9TIPO ;
      private String scmdbuf ;
      private String A128PRG_EXT ;
      private String A117PRG_WEB ;
      private String A127PRG_DES ;
      private String A259SIS_DES ;
      private bool entryPointCalled ;
      private bool GxHdr3 ;
      private bool BRK2K3 ;
      private bool n366SIS_MAI ;
      private bool n259SIS_DES ;
      private String A366SIS_MAI ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_TIPO ;
      private IDataStoreProvider pr_default ;
      private String[] P002K2_A117PRG_WEB ;
      private String[] P002K2_A128PRG_EXT ;
      private String[] P002K2_A127PRG_DES ;
      private short[] P002K2_A126PRG_COD ;
      private short[] P002K2_A164PRG_SIS ;
      private String[] P002K2_A366SIS_MAI ;
      private bool[] P002K2_n366SIS_MAI ;
      private String[] P002K2_A259SIS_DES ;
      private bool[] P002K2_n259SIS_DES ;
      private short[] P002K3_AV8usuarios ;
   }

   public class aseg018__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002K2( String AV9TIPO ,
                                             String A128PRG_EXT ,
                                             String A117PRG_WEB )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object1 ;
         GXv_Object1 = new Object [2] ;
         scmdbuf = "SELECT T1.[PRG_WEB], T1.[PRG_EXT], T1.[PRG_DES], T1.[PRG_COD], T1.[PRG_SIS] AS PRG_SIS, T2.[SIS_MAI], T2.[SIS_DES] FROM ([SEG001] T1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = T1.[PRG_SIS])" ;
         scmdbuf = scmdbuf + " WHERE (Not (T1.[PRG_WEB] = ''))" ;
         if ( StringUtil.StrCmp(AV9TIPO, "A") == 0 )
         {
            sWhereString = sWhereString + " and (T1.[PRG_EXT] <> 'B')" ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[PRG_SIS], T1.[PRG_COD]" ;
         GXv_Object1[0] = scmdbuf ;
         return GXv_Object1 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P002K2( (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmP002K3 ;
          prmP002K3 = new Object[] {
          new Object[] {"@PRG_SIS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP002K2 ;
          prmP002K2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P002K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002K2,100,1,true,false )
             ,new CursorDef("P002K3", "SELECT COUNT(*) FROM [SEG004] WITH (NOLOCK) WHERE [SIS_COD] = @PRG_SIS and [PRG_COD] = @PRG_COD ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002K3,1,1,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 3) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 15) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
       }
    }

 }

}
