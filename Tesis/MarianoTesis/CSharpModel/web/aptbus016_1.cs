/*
               File: PTBUS016_1
        Description: Listado de Bienes de Uso y sus Identificadores (en pdf)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:30.27
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
   public class aptbus016_1 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
                  AV47TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV46TTBUS7_CodResp = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus016_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus016_1( IGxContext context )
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
                           ref short aP2_TTBUS7_Pos ,
                           ref String aP3_TTBUS7_CodResp )
      {
         this.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV40USUARIO = aP1_USUARIO;
         this.AV47TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV46TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
      }

      public String executeUdp( ref String aP0_NOMBRE_REPORTE ,
                                ref String aP1_USUARIO ,
                                ref short aP2_TTBUS7_Pos )
      {
         this.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV40USUARIO = aP1_USUARIO;
         this.AV47TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV46TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
         return AV46TTBUS7_CodResp ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref short aP2_TTBUS7_Pos ,
                                 ref String aP3_TTBUS7_CodResp )
      {
         aptbus016_1 objaptbus016_1;
         objaptbus016_1 = new aptbus016_1();
         objaptbus016_1.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus016_1.AV40USUARIO = aP1_USUARIO;
         objaptbus016_1.AV47TTBUS7_Pos = aP2_TTBUS7_Pos;
         objaptbus016_1.AV46TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objaptbus016_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus016_1.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV17NOMBRE_REPORTE;
         aP1_USUARIO=this.AV40USUARIO;
         aP2_TTBUS7_Pos=this.AV47TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV46TTBUS7_CodResp;
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
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 2, 256, 11909, 14112, 0, 1, 1, 0, 1, 1) )
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
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV47TTBUS7_Pos ,
                                                 A37TTBUS_CodPosicion },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            /* Using cursor P001D2 */
            pr_default.execute(0, new Object[] {AV47TTBUS7_Pos});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A35TTBUS7_CodResp = P001D2_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001D2_n35TTBUS7_CodResp[0] ;
               A37TTBUS_CodPosicion = P001D2_A37TTBUS_CodPosicion[0] ;
               A29TTBUS_Alquilado = P001D2_A29TTBUS_Alquilado[0] ;
               A12TTBUS_Descripcion = P001D2_A12TTBUS_Descripcion[0] ;
               A23TTBUS_Estado = P001D2_A23TTBUS_Estado[0] ;
               A11TTBUS_Id = P001D2_A11TTBUS_Id[0] ;
               A35TTBUS7_CodResp = P001D2_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001D2_n35TTBUS7_CodResp[0] ;
               AV24TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
               AV23TTBUS_Alquilado = A29TTBUS_Alquilado ;
               AV28TTBUS_Id = A11TTBUS_Id ;
               AV50tTTBUS_Descripcion = A12TTBUS_Descripcion ;
               if ( StringUtil.StrCmp(StringUtil.Trim( AV46TTBUS7_CodResp), "") != 0 )
               {
                  if ( A23TTBUS_Estado == 1 )
                  {
                     /* Using cursor P001D3 */
                     pr_default.execute(1, new Object[] {AV24TTBUS_CodPosicion});
                     while ( (pr_default.getStatus(1) != 101) )
                     {
                        A33TTBUS7_Pos = P001D3_A33TTBUS7_Pos[0] ;
                        if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1146 */
                           S1146 ();
                           if ( returnInSub )
                           {
                              pr_default.close(1);
                              this.cleanup();
                              if (true) return;
                           }
                        }
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(1);
                  }
                  else
                  {
                     /* Using cursor P001D4 */
                     pr_default.execute(2, new Object[] {AV28TTBUS_Id});
                     while ( (pr_default.getStatus(2) != 101) )
                     {
                        A26TTBUS2_EstadoEnvio = P001D4_A26TTBUS2_EstadoEnvio[0] ;
                        A22TTBUS2_IdBien = P001D4_A22TTBUS2_IdBien[0] ;
                        A24TTBUS2_RespDesde = P001D4_A24TTBUS2_RespDesde[0] ;
                        A25TTBUS2_RespHacia = P001D4_A25TTBUS2_RespHacia[0] ;
                        A52TTBUS2_IdMovimiento = P001D4_A52TTBUS2_IdMovimiento[0] ;
                        if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1146 */
                           S1146 ();
                           if ( returnInSub )
                           {
                              pr_default.close(2);
                              this.cleanup();
                              if (true) return;
                           }
                        }
                        else if ( StringUtil.StrCmp(A25TTBUS2_RespHacia, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1146 */
                           S1146 ();
                           if ( returnInSub )
                           {
                              pr_default.close(2);
                              this.cleanup();
                              if (true) return;
                           }
                        }
                        pr_default.readNext(2);
                     }
                     pr_default.close(2);
                  }
               }
               else
               {
                  /* Execute user subroutine: S1146 */
                  S1146 ();
                  if ( returnInSub )
                  {
                     pr_default.close(0);
                     this.cleanup();
                     if (true) return;
                  }
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1D0( true, 0) ;
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

      protected void S1146( )
      {
         /* 'INFORME' Routine */
         AV10band = 0 ;
         new ptbus007(context ).execute( ref  AV10band,  AV28TTBUS_Id,  AV40USUARIO) ;
         if ( AV10band == 1 )
         {
            AV26TTBUS_Descripcion = AV50tTTBUS_Descripcion ;
            if ( AV23TTBUS_Alquilado == 1 )
            {
               AV9alquilado = "SI" ;
            }
            else if ( AV23TTBUS_Alquilado == 0 )
            {
               AV9alquilado = "NO" ;
            }
            AV33TTBUS2_IdBien = AV28TTBUS_Id ;
            H1D0( false, 18) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28TTBUS_Id), "ZZZZZZZ9")), 0, Gx_line+0, 51, Gx_line+16, 1+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV26TTBUS_Descripcion, "@!")), 58, Gx_line+0, 319, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 317, Gx_line+0, 375, Gx_line+16, 1+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+18) ;
            /* Noskip command */
            Gx_line = Gx_OldLine ;
            /* Using cursor P001D5 */
            pr_default.execute(3, new Object[] {AV33TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A21TTBUS5_DescIdentificador = P001D5_A21TTBUS5_DescIdentificador[0] ;
               n21TTBUS5_DescIdentificador = P001D5_n21TTBUS5_DescIdentificador[0] ;
               A11TTBUS_Id = P001D5_A11TTBUS_Id[0] ;
               A15NumeroIdentificador = P001D5_A15NumeroIdentificador[0] ;
               A14IdIdentificador = P001D5_A14IdIdentificador[0] ;
               A21TTBUS5_DescIdentificador = P001D5_A21TTBUS5_DescIdentificador[0] ;
               n21TTBUS5_DescIdentificador = P001D5_n21TTBUS5_DescIdentificador[0] ;
               AV51IdIdentificador = A14IdIdentificador ;
               AV53NumeroIdentificador = A15NumeroIdentificador ;
               AV52TTBUS5_DescIdentificador = "" ;
               /* Using cursor P001D6 */
               pr_default.execute(4, new Object[] {AV51IdIdentificador});
               while ( (pr_default.getStatus(4) != 101) )
               {
                  A20TTBUS5_IdIdentificador = P001D6_A20TTBUS5_IdIdentificador[0] ;
                  AV52TTBUS5_DescIdentificador = A21TTBUS5_DescIdentificador ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(4);
               H1D0( false, 18) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV52TTBUS5_DescIdentificador, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 383, Gx_line+0, 633, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV53NumeroIdentificador, "")), 608, Gx_line+0, 975, Gx_line+16, 0) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+18) ;
               pr_default.readNext(3);
            }
            pr_default.close(3);
            H1D0( false, 19) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+19) ;
         }
      }

      protected void H1D0( bool bFoot ,
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
               getPrinter().GxDrawText("Fecha y Hora:", 808, Gx_line+17, 879, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Página:", 808, Gx_line+33, 847, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/9999 99:99"), 883, Gx_line+17, 976, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 883, Gx_line+33, 922, Gx_line+49, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("LISTADO DE BIENES DE USO Y SUS IDENTIFICADORES", 267, Gx_line+50, 724, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 308, Gx_line+17, 664, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+94) ;
               getPrinter().GxDrawLine(0, Gx_line+34, 975, Gx_line+34, 2, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Nº Bien", 0, Gx_line+17, 39, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Descripción", 58, Gx_line+17, 117, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Alquilado", 325, Gx_line+17, 371, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Tipo de Identificador", 383, Gx_line+17, 485, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Cód. de Identificador", 608, Gx_line+17, 711, Gx_line+32, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+36) ;
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
         P001D2_A35TTBUS7_CodResp = new String[] {""} ;
         P001D2_n35TTBUS7_CodResp = new bool[] {false} ;
         P001D2_A37TTBUS_CodPosicion = new short[1] ;
         P001D2_A29TTBUS_Alquilado = new short[1] ;
         P001D2_A12TTBUS_Descripcion = new String[] {""} ;
         P001D2_A23TTBUS_Estado = new short[1] ;
         P001D2_A11TTBUS_Id = new int[1] ;
         A35TTBUS7_CodResp = "" ;
         A12TTBUS_Descripcion = "" ;
         AV50tTTBUS_Descripcion = "" ;
         P001D3_A33TTBUS7_Pos = new short[1] ;
         P001D4_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001D4_A22TTBUS2_IdBien = new int[1] ;
         P001D4_A24TTBUS2_RespDesde = new String[] {""} ;
         P001D4_A25TTBUS2_RespHacia = new String[] {""} ;
         P001D4_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         P001D5_A21TTBUS5_DescIdentificador = new String[] {""} ;
         P001D5_n21TTBUS5_DescIdentificador = new bool[] {false} ;
         P001D5_A11TTBUS_Id = new int[1] ;
         P001D5_A15NumeroIdentificador = new String[] {""} ;
         P001D5_A14IdIdentificador = new int[1] ;
         A21TTBUS5_DescIdentificador = "" ;
         A15NumeroIdentificador = "" ;
         AV53NumeroIdentificador = "" ;
         AV52TTBUS5_DescIdentificador = "" ;
         P001D6_A20TTBUS5_IdIdentificador = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus016_1__default(),
            new Object[][] {
                new Object[] {
               P001D2_A35TTBUS7_CodResp, P001D2_n35TTBUS7_CodResp, P001D2_A37TTBUS_CodPosicion, P001D2_A29TTBUS_Alquilado, P001D2_A12TTBUS_Descripcion, P001D2_A23TTBUS_Estado, P001D2_A11TTBUS_Id
               }
               , new Object[] {
               P001D3_A33TTBUS7_Pos
               }
               , new Object[] {
               P001D4_A26TTBUS2_EstadoEnvio, P001D4_A22TTBUS2_IdBien, P001D4_A24TTBUS2_RespDesde, P001D4_A25TTBUS2_RespHacia, P001D4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001D5_A21TTBUS5_DescIdentificador, P001D5_n21TTBUS5_DescIdentificador, P001D5_A11TTBUS_Id, P001D5_A15NumeroIdentificador, P001D5_A14IdIdentificador
               }
               , new Object[] {
               P001D6_A20TTBUS5_IdIdentificador
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV47TTBUS7_Pos ;
      private short A37TTBUS_CodPosicion ;
      private short A29TTBUS_Alquilado ;
      private short A23TTBUS_Estado ;
      private short AV24TTBUS_CodPosicion ;
      private short AV23TTBUS_Alquilado ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV10band ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A11TTBUS_Id ;
      private int AV28TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int AV33TTBUS2_IdBien ;
      private int Gx_OldLine ;
      private int A14IdIdentificador ;
      private int AV51IdIdentificador ;
      private int A20TTBUS5_IdIdentificador ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV17NOMBRE_REPORTE ;
      private String AV40USUARIO ;
      private String AV46TTBUS7_CodResp ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV9alquilado ;
      private String A21TTBUS5_DescIdentificador ;
      private String AV52TTBUS5_DescIdentificador ;
      private DateTime AV8AHORA ;
      private bool entryPointCalled ;
      private bool n35TTBUS7_CodResp ;
      private bool returnInSub ;
      private bool n21TTBUS5_DescIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV50tTTBUS_Descripcion ;
      private String AV26TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV53NumeroIdentificador ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private IDataStoreProvider pr_default ;
      private String[] P001D2_A35TTBUS7_CodResp ;
      private bool[] P001D2_n35TTBUS7_CodResp ;
      private short[] P001D2_A37TTBUS_CodPosicion ;
      private short[] P001D2_A29TTBUS_Alquilado ;
      private String[] P001D2_A12TTBUS_Descripcion ;
      private short[] P001D2_A23TTBUS_Estado ;
      private int[] P001D2_A11TTBUS_Id ;
      private short[] P001D3_A33TTBUS7_Pos ;
      private short[] P001D4_A26TTBUS2_EstadoEnvio ;
      private int[] P001D4_A22TTBUS2_IdBien ;
      private String[] P001D4_A24TTBUS2_RespDesde ;
      private String[] P001D4_A25TTBUS2_RespHacia ;
      private long[] P001D4_A52TTBUS2_IdMovimiento ;
      private String[] P001D5_A21TTBUS5_DescIdentificador ;
      private bool[] P001D5_n21TTBUS5_DescIdentificador ;
      private int[] P001D5_A11TTBUS_Id ;
      private String[] P001D5_A15NumeroIdentificador ;
      private int[] P001D5_A14IdIdentificador ;
      private int[] P001D6_A20TTBUS5_IdIdentificador ;
   }

   public class aptbus016_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001D2( short AV47TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T2.[TTBUS7_CodResp], T1.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T1.[TTBUS_Alquilado], T1.[TTBUS_Descripcion], T1.[TTBUS_Estado], T1.[TTBUS_Id] FROM ([TTBUS000] T1 WITH (NOLOCK) INNER JOIN [TTBUS007] T2 WITH (NOLOCK) ON T2.[TTBUS7_Pos] = T1.[TTBUS_CodPosicion])" ;
         if ( AV47TTBUS7_Pos != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV47TTBUS7_Pos)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[TTBUS_CodPosicion] = @AV47TTBUS7_Pos)" ;
            }
         }
         else
         {
            GXv_int1[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id]" ;
         GXv_Object2[0] = scmdbuf ;
         GXv_Object2[1] = (Object)(GXv_int1) ;
         return GXv_Object2 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001D2( (short)dynConstraints[0] , (short)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

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
          Object[] prmP001D3 ;
          prmP001D3 = new Object[] {
          new Object[] {"@AV24TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001D4 ;
          prmP001D4 = new Object[] {
          new Object[] {"@AV28TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001D5 ;
          prmP001D5 = new Object[] {
          new Object[] {"@AV33TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001D6 ;
          prmP001D6 = new Object[] {
          new Object[] {"@AV51IdIdentificador",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001D2 ;
          prmP001D2 = new Object[] {
          new Object[] {"@AV47TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001D2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D2,100,0,true,false )
             ,new CursorDef("P001D3", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV24TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D3,1,0,true,true )
             ,new CursorDef("P001D4", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV28TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D4,100,0,true,false )
             ,new CursorDef("P001D5", "SELECT T2.[TTBUS5_DescIdentificador], T1.[TTBUS_Id], T1.[NumeroIdentificador], T1.[IdIdentificador] AS IdIdentificador FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS005] T2 WITH (NOLOCK) ON T2.[TTBUS5_IdIdentificador] = T1.[IdIdentificador]) WHERE T1.[TTBUS_Id] = @AV33TTBUS2_IdBien ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D5,100,0,true,false )
             ,new CursorDef("P001D6", "SELECT [TTBUS5_IdIdentificador] FROM [TTBUS005] WITH (NOLOCK) WHERE [TTBUS5_IdIdentificador] = @AV51IdIdentificador ORDER BY [TTBUS5_IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D6,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((int[]) buf[6])[0] = rslt.getInt(6) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 60) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
             case 0 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[1]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
