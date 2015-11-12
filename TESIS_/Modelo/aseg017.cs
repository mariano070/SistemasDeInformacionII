/*
               File: SEG017
        Description: LISTADO USUARIO-PROGRAMAS POR RESPONSABLE
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:37.65
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
   public class aseg017 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Modern");
         initialize();
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
         }
         executePrivate();
         cleanup();
      }

      public aseg017( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aseg017( IGxContext context )
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
         aseg017 objaseg017;
         objaseg017 = new aseg017();
         objaseg017.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaseg017.executePrivateCatch ));
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
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 10901, 0, 1, 1, 0, 1, 1) )
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
            GxHdr2 = true ;
            /* Using cursor P002J2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK2J2 = false ;
               A366SIS_MAI = P002J2_A366SIS_MAI[0] ;
               A259SIS_DES = P002J2_A259SIS_DES[0] ;
               A116SIS_COD = P002J2_A116SIS_COD[0] ;
               A365SIS_RSP = P002J2_A365SIS_RSP[0] ;
               while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002J2_A365SIS_RSP[0], A365SIS_RSP) == 0 ) )
               {
                  BRK2J2 = false ;
                  A366SIS_MAI = P002J2_A366SIS_MAI[0] ;
                  A259SIS_DES = P002J2_A259SIS_DES[0] ;
                  A116SIS_COD = P002J2_A116SIS_COD[0] ;
                  H2J0( false, 45) ;
                  getPrinter().GxAttris("Courier New", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9")), 83, Gx_line+0, 106, Gx_line+19, 2+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), 117, Gx_line+0, 227, Gx_line+19, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A366SIS_MAI, "")), 117, Gx_line+17, 734, Gx_line+36, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("SISTEMA", 17, Gx_line+0, 74, Gx_line+15, 0+256) ;
                  getPrinter().GxDrawText("MAIL DE AVISO:", 17, Gx_line+17, 117, Gx_line+32, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+45) ;
                  /* Using cursor P002J3 */
                  pr_default.execute(1, new Object[] {A116SIS_COD});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     BRK2J5 = false ;
                     A7USU_DES = P002J3_A7USU_DES[0] ;
                     A6USU_COD = P002J3_A6USU_COD[0] ;
                     A126PRG_COD = P002J3_A126PRG_COD[0] ;
                     A117PRG_WEB = P002J3_A117PRG_WEB[0] ;
                     A290USU_CNT = P002J3_A290USU_CNT[0] ;
                     A127PRG_DES = P002J3_A127PRG_DES[0] ;
                     A7USU_DES = P002J3_A7USU_DES[0] ;
                     A117PRG_WEB = P002J3_A117PRG_WEB[0] ;
                     A127PRG_DES = P002J3_A127PRG_DES[0] ;
                     H2J0( false, 20) ;
                     getPrinter().GxAttris("Courier New", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 183, Gx_line+0, 403, Gx_line+19, 0+256) ;
                     getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9")), 131, Gx_line+0, 161, Gx_line+19, 2+256) ;
                     getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                     getPrinter().GxDrawText("PROGRAMA", 58, Gx_line+0, 132, Gx_line+15, 0+256) ;
                     Gx_OldLine = Gx_line ;
                     Gx_line = (int)(Gx_line+20) ;
                     while ( (pr_default.getStatus(1) != 101) && ( P002J3_A116SIS_COD[0] == A116SIS_COD ) && ( P002J3_A126PRG_COD[0] == A126PRG_COD ) )
                     {
                        BRK2J5 = false ;
                        A7USU_DES = P002J3_A7USU_DES[0] ;
                        A6USU_COD = P002J3_A6USU_COD[0] ;
                        A7USU_DES = P002J3_A7USU_DES[0] ;
                        H2J0( false, 19) ;
                        getPrinter().GxAttris("Courier New", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), 167, Gx_line+0, 285, Gx_line+18, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), 283, Gx_line+0, 649, Gx_line+18, 0+256) ;
                        Gx_OldLine = Gx_line ;
                        Gx_line = (int)(Gx_line+19) ;
                        BRK2J5 = true ;
                        pr_default.readNext(1);
                     }
                     if ( ! BRK2J5 )
                     {
                        BRK2J5 = true ;
                        pr_default.readNext(1);
                     }
                  }
                  pr_default.close(1);
                  BRK2J2 = true ;
                  pr_default.readNext(0);
               }
               /* Eject command */
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(P_lines+1) ;
               if ( ! BRK2J2 )
               {
                  BRK2J2 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            GxHdr2 = false ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H2J0( true, 0) ;
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

      protected void H2J0( bool bFoot ,
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
               if ( GxHdr2 )
               {
                  getPrinter().GxDrawRect(0, Gx_line+0, 724, Gx_line+50, 1, 0, 0, 0, 0, 255, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Courier New", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A365SIS_RSP, "XXXXXXXXXXXXXXXX")), 292, Gx_line+33, 410, Gx_line+52, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("LISTADO DE USUARIOS-PROGRAMAS POR RESPONSABLE", 175, Gx_line+17, 539, Gx_line+32, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+54) ;
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
         P002J2_A366SIS_MAI = new String[] {""} ;
         P002J2_A259SIS_DES = new String[] {""} ;
         P002J2_A116SIS_COD = new short[1] ;
         P002J2_A365SIS_RSP = new String[] {""} ;
         A366SIS_MAI = "" ;
         A259SIS_DES = "" ;
         A365SIS_RSP = "" ;
         P002J3_A116SIS_COD = new short[1] ;
         P002J3_A7USU_DES = new String[] {""} ;
         P002J3_A6USU_COD = new String[] {""} ;
         P002J3_A126PRG_COD = new short[1] ;
         P002J3_A117PRG_WEB = new String[] {""} ;
         P002J3_A290USU_CNT = new String[] {""} ;
         P002J3_A127PRG_DES = new String[] {""} ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A117PRG_WEB = "" ;
         A290USU_CNT = "" ;
         A127PRG_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aseg017__default(),
            new Object[][] {
                new Object[] {
               P002J2_A366SIS_MAI, P002J2_A259SIS_DES, P002J2_A116SIS_COD, P002J2_A365SIS_RSP
               }
               , new Object[] {
               P002J3_A116SIS_COD, P002J3_A7USU_DES, P002J3_A6USU_COD, P002J3_A126PRG_COD, P002J3_A117PRG_WEB, P002J3_A290USU_CNT, P002J3_A127PRG_DES
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A259SIS_DES ;
      private String A365SIS_RSP ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A117PRG_WEB ;
      private String A290USU_CNT ;
      private String A127PRG_DES ;
      private bool entryPointCalled ;
      private bool GxHdr2 ;
      private bool BRK2J2 ;
      private bool BRK2J5 ;
      private String A366SIS_MAI ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002J2_A366SIS_MAI ;
      private String[] P002J2_A259SIS_DES ;
      private short[] P002J2_A116SIS_COD ;
      private String[] P002J2_A365SIS_RSP ;
      private short[] P002J3_A116SIS_COD ;
      private String[] P002J3_A7USU_DES ;
      private String[] P002J3_A6USU_COD ;
      private short[] P002J3_A126PRG_COD ;
      private String[] P002J3_A117PRG_WEB ;
      private String[] P002J3_A290USU_CNT ;
      private String[] P002J3_A127PRG_DES ;
   }

   public class aseg017__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002J2 ;
          prmP002J2 = new Object[] {
          } ;
          Object[] prmP002J3 ;
          prmP002J3 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002J2", "SELECT [SIS_MAI], [SIS_DES], [SIS_COD], [SIS_RSP] FROM [SEG000] WITH (NOLOCK) ORDER BY [SIS_RSP], [SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002J2,100,1,true,false )
             ,new CursorDef("P002J3", "SELECT T1.[SIS_COD], T2.[USU_DES], T1.[USU_COD], T1.[PRG_COD], T3.[PRG_WEB], T1.[USU_CNT], T3.[PRG_DES] FROM (([SEG004] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[USU_COD]) INNER JOIN [SEG001] T3 WITH (NOLOCK) ON T3.[PRG_COD] = T1.[PRG_COD]) WHERE (T1.[SIS_COD] = @SIS_COD) AND (Not (T3.[PRG_WEB] = '')) ORDER BY T1.[SIS_COD], T1.[PRG_COD], T1.[USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002J3,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 1) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
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
       }
    }

 }

}
