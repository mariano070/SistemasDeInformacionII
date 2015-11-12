/*
               File: PTBUS014_4
        Description: Listado de bienes por responsable (en pdf)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:29.44
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
   public class aptbus014_4 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV15NOMBRE_REPORTE = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV37USUARIO = GetNextPar( ) ;
                  AV34TTBUS7_CodResp = GetNextPar( ) ;
                  AV20TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus014_4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus014_4( IGxContext context )
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
                           ref String aP2_TTBUS7_CodResp ,
                           ref short aP3_TTBUS_RubroBien )
      {
         this.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV37USUARIO = aP1_USUARIO;
         this.AV34TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV37USUARIO;
         aP2_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_NOMBRE_REPORTE ,
                               ref String aP1_USUARIO ,
                               ref String aP2_TTBUS7_CodResp )
      {
         this.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV37USUARIO = aP1_USUARIO;
         this.AV34TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV37USUARIO;
         aP2_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
         return AV20TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref String aP2_TTBUS7_CodResp ,
                                 ref short aP3_TTBUS_RubroBien )
      {
         aptbus014_4 objaptbus014_4;
         objaptbus014_4 = new aptbus014_4();
         objaptbus014_4.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus014_4.AV37USUARIO = aP1_USUARIO;
         objaptbus014_4.AV34TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         objaptbus014_4.AV20TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         objaptbus014_4.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus014_4.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV37USUARIO;
         aP2_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
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
            new ptbus015(context ).execute( ref  AV34TTBUS7_CodResp) ;
            GxHdr3 = true ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV20TTBUS_RubroBien ,
                                                 A214TTBUS14_CodRubro },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            });
            /* Using cursor P001A2 */
            pr_default.execute(0, new Object[] {AV20TTBUS_RubroBien});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK1A3 = false ;
               A208TTBUS14_Estado = P001A2_A208TTBUS14_Estado[0] ;
               A216TTBUS14_NroSerie = P001A2_A216TTBUS14_NroSerie[0] ;
               A215TTBUS14_CodEtiqueta = P001A2_A215TTBUS14_CodEtiqueta[0] ;
               A210TTBUS14_PosDesde = P001A2_A210TTBUS14_PosDesde[0] ;
               n210TTBUS14_PosDesde = P001A2_n210TTBUS14_PosDesde[0] ;
               A204TTBUS14_Proveedor = P001A2_A204TTBUS14_Proveedor[0] ;
               A206TTBUS14_FechaAdquisicion = P001A2_A206TTBUS14_FechaAdquisicion[0] ;
               A205TTBUS14_FechaCarga = P001A2_A205TTBUS14_FechaCarga[0] ;
               A203TTBUS14_Rubro = P001A2_A203TTBUS14_Rubro[0] ;
               A202TTBUS14_Descripcion = P001A2_A202TTBUS14_Descripcion[0] ;
               A211TTBUS14_PosHacia = P001A2_A211TTBUS14_PosHacia[0] ;
               n211TTBUS14_PosHacia = P001A2_n211TTBUS14_PosHacia[0] ;
               A207TTBUS14_FechaEnvio = P001A2_A207TTBUS14_FechaEnvio[0] ;
               n207TTBUS14_FechaEnvio = P001A2_n207TTBUS14_FechaEnvio[0] ;
               A201TTBUS14_IdBien = P001A2_A201TTBUS14_IdBien[0] ;
               A213TTBUS14_CodResponsable = P001A2_A213TTBUS14_CodResponsable[0] ;
               A212TTBUS14_MarcaEnvio = P001A2_A212TTBUS14_MarcaEnvio[0] ;
               A214TTBUS14_CodRubro = P001A2_A214TTBUS14_CodRubro[0] ;
               A209TTBUS14_Responsable = P001A2_A209TTBUS14_Responsable[0] ;
               while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001A2_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) )
               {
                  BRK1A3 = false ;
                  A208TTBUS14_Estado = P001A2_A208TTBUS14_Estado[0] ;
                  A216TTBUS14_NroSerie = P001A2_A216TTBUS14_NroSerie[0] ;
                  A215TTBUS14_CodEtiqueta = P001A2_A215TTBUS14_CodEtiqueta[0] ;
                  A210TTBUS14_PosDesde = P001A2_A210TTBUS14_PosDesde[0] ;
                  n210TTBUS14_PosDesde = P001A2_n210TTBUS14_PosDesde[0] ;
                  A204TTBUS14_Proveedor = P001A2_A204TTBUS14_Proveedor[0] ;
                  A206TTBUS14_FechaAdquisicion = P001A2_A206TTBUS14_FechaAdquisicion[0] ;
                  A205TTBUS14_FechaCarga = P001A2_A205TTBUS14_FechaCarga[0] ;
                  A203TTBUS14_Rubro = P001A2_A203TTBUS14_Rubro[0] ;
                  A202TTBUS14_Descripcion = P001A2_A202TTBUS14_Descripcion[0] ;
                  A211TTBUS14_PosHacia = P001A2_A211TTBUS14_PosHacia[0] ;
                  n211TTBUS14_PosHacia = P001A2_n211TTBUS14_PosHacia[0] ;
                  A207TTBUS14_FechaEnvio = P001A2_A207TTBUS14_FechaEnvio[0] ;
                  n207TTBUS14_FechaEnvio = P001A2_n207TTBUS14_FechaEnvio[0] ;
                  A201TTBUS14_IdBien = P001A2_A201TTBUS14_IdBien[0] ;
                  A212TTBUS14_MarcaEnvio = P001A2_A212TTBUS14_MarcaEnvio[0] ;
                  if ( A212TTBUS14_MarcaEnvio == 1 )
                  {
                     AV38MarcaEnvio = "BIENES QUE ENVÍA" ;
                  }
                  else if ( A212TTBUS14_MarcaEnvio == 2 )
                  {
                     AV38MarcaEnvio = "BIENES QUE RECIBE" ;
                  }
                  else if ( A212TTBUS14_MarcaEnvio == 3 )
                  {
                     AV38MarcaEnvio = "BIENES QUE TIENE ASIGNADO" ;
                  }
                  H1A0( false, 55) ;
                  getPrinter().GxDrawLine(0, Gx_line+51, 1150, Gx_line+51, 2, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Otros Datos", 467, Gx_line+33, 526, Gx_line+48, 0) ;
                  getPrinter().GxDrawText("Descripción", 200, Gx_line+33, 259, Gx_line+48, 0) ;
                  getPrinter().GxDrawText("Nº Bien", 125, Gx_line+33, 164, Gx_line+48, 0) ;
                  getPrinter().GxDrawText("Nº Etiqueta", 17, Gx_line+33, 74, Gx_line+48, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV38MarcaEnvio, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 0, Gx_line+0, 189, Gx_line+18, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+55) ;
                  while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001A2_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( P001A2_A212TTBUS14_MarcaEnvio[0] == A212TTBUS14_MarcaEnvio ) )
                  {
                     BRK1A3 = false ;
                     A208TTBUS14_Estado = P001A2_A208TTBUS14_Estado[0] ;
                     A216TTBUS14_NroSerie = P001A2_A216TTBUS14_NroSerie[0] ;
                     A215TTBUS14_CodEtiqueta = P001A2_A215TTBUS14_CodEtiqueta[0] ;
                     A210TTBUS14_PosDesde = P001A2_A210TTBUS14_PosDesde[0] ;
                     n210TTBUS14_PosDesde = P001A2_n210TTBUS14_PosDesde[0] ;
                     A204TTBUS14_Proveedor = P001A2_A204TTBUS14_Proveedor[0] ;
                     A206TTBUS14_FechaAdquisicion = P001A2_A206TTBUS14_FechaAdquisicion[0] ;
                     A205TTBUS14_FechaCarga = P001A2_A205TTBUS14_FechaCarga[0] ;
                     A203TTBUS14_Rubro = P001A2_A203TTBUS14_Rubro[0] ;
                     A202TTBUS14_Descripcion = P001A2_A202TTBUS14_Descripcion[0] ;
                     A211TTBUS14_PosHacia = P001A2_A211TTBUS14_PosHacia[0] ;
                     n211TTBUS14_PosHacia = P001A2_n211TTBUS14_PosHacia[0] ;
                     A207TTBUS14_FechaEnvio = P001A2_A207TTBUS14_FechaEnvio[0] ;
                     n207TTBUS14_FechaEnvio = P001A2_n207TTBUS14_FechaEnvio[0] ;
                     A201TTBUS14_IdBien = P001A2_A201TTBUS14_IdBien[0] ;
                     AV19TTBUS_Id = A201TTBUS14_IdBien ;
                     AV9band = 0 ;
                     new ptbus007(context ).execute( ref  AV9band,  AV19TTBUS_Id,  AV37USUARIO) ;
                     if ( AV9band == 1 )
                     {
                        if ( A208TTBUS14_Estado == 1 )
                        {
                           H1A0( false, 72) ;
                           getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                           getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A201TTBUS14_IdBien), "ZZZZZZZ9")), 125, Gx_line+0, 176, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A202TTBUS14_Descripcion, "")), 200, Gx_line+0, 450, Gx_line+16, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A203TTBUS14_Rubro, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+0, 707, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(context.localUtil.Format( A205TTBUS14_FechaCarga, "99/99/9999"), 817, Gx_line+0, 878, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(context.localUtil.Format( A206TTBUS14_FechaAdquisicion, "99/99/9999"), 1033, Gx_line+0, 1094, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A204TTBUS14_Proveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+17, 707, Gx_line+33, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A210TTBUS14_PosDesde, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+33, 811, Gx_line+49, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A215TTBUS14_CodEtiqueta, "")), 17, Gx_line+0, 117, Gx_line+16, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A216TTBUS14_NroSerie, "")), 817, Gx_line+17, 922, Gx_line+33, 0+256) ;
                           getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                           getPrinter().GxDrawText("Proveedor:", 467, Gx_line+17, 522, Gx_line+32, 0+256) ;
                           getPrinter().GxDrawText("Fecha Adquisición", 933, Gx_line+0, 1025, Gx_line+15, 0+256) ;
                           getPrinter().GxDrawText("Fecha Carga", 742, Gx_line+0, 807, Gx_line+15, 0+256) ;
                           getPrinter().GxDrawText("Posición Actual", 467, Gx_line+33, 544, Gx_line+48, 0+256) ;
                           getPrinter().GxDrawText("Rubro", 467, Gx_line+0, 498, Gx_line+15, 0) ;
                           getPrinter().GxDrawText("Nº Serie", 742, Gx_line+17, 784, Gx_line+32, 0) ;
                           Gx_OldLine = Gx_line ;
                           Gx_line = (int)(Gx_line+72) ;
                        }
                        else
                        {
                           H1A0( false, 70) ;
                           getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                           getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A201TTBUS14_IdBien), "ZZZZZZZ9")), 125, Gx_line+0, 176, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A202TTBUS14_Descripcion, "")), 200, Gx_line+0, 450, Gx_line+16, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A203TTBUS14_Rubro, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+0, 707, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(context.localUtil.Format( A205TTBUS14_FechaCarga, "99/99/9999"), 817, Gx_line+0, 878, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(context.localUtil.Format( A206TTBUS14_FechaAdquisicion, "99/99/9999"), 1033, Gx_line+0, 1094, Gx_line+16, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A204TTBUS14_Proveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+17, 707, Gx_line+33, 0+256) ;
                           getPrinter().GxDrawText(context.localUtil.Format( A207TTBUS14_FechaEnvio, "99/99/9999"), 1033, Gx_line+17, 1094, Gx_line+33, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A210TTBUS14_PosDesde, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+33, 735, Gx_line+49, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A211TTBUS14_PosHacia, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 817, Gx_line+33, 1078, Gx_line+49, 0+256) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A215TTBUS14_CodEtiqueta, "")), 17, Gx_line+0, 117, Gx_line+16, 0) ;
                           getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A216TTBUS14_NroSerie, "")), 817, Gx_line+17, 922, Gx_line+33, 0+256) ;
                           getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                           getPrinter().GxDrawText("Fecha Carga", 742, Gx_line+0, 807, Gx_line+15, 0+256) ;
                           getPrinter().GxDrawText("Fecha Adquisición", 933, Gx_line+0, 1025, Gx_line+15, 0+256) ;
                           getPrinter().GxDrawText("Proveedor:", 467, Gx_line+17, 522, Gx_line+32, 0+256) ;
                           getPrinter().GxDrawText("Pos. Desde:", 467, Gx_line+33, 528, Gx_line+48, 0+256) ;
                           getPrinter().GxDrawText("Pos. Hacia:", 742, Gx_line+33, 800, Gx_line+48, 0+256) ;
                           getPrinter().GxDrawText("Fecha Envio", 933, Gx_line+17, 997, Gx_line+32, 0+256) ;
                           getPrinter().GxDrawText("Rubro", 467, Gx_line+0, 498, Gx_line+15, 0) ;
                           getPrinter().GxDrawText("Nº Serie", 742, Gx_line+17, 784, Gx_line+32, 0) ;
                           Gx_OldLine = Gx_line ;
                           Gx_line = (int)(Gx_line+70) ;
                        }
                     }
                     BRK1A3 = true ;
                     pr_default.readNext(0);
                  }
                  if ( ! BRK1A3 )
                  {
                     BRK1A3 = true ;
                     pr_default.readNext(0);
                  }
               }
               /* Eject command */
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(P_lines+1) ;
               if ( ! BRK1A3 )
               {
                  BRK1A3 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            GxHdr3 = false ;
            /* Optimized DELETE. */
            /* Using cursor P001A3 */
            pr_default.execute(1);
            pr_default.close(1);
            /* End optimized DELETE. */
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1A0( true, 0) ;
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

      protected void H1A0( bool bFoot ,
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
               getPrinter().GxDrawText("Fecha y Hora:", 1000, Gx_line+17, 1071, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/99 99:99"), 1075, Gx_line+17, 1155, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText("Página:", 1000, Gx_line+33, 1039, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1075, Gx_line+33, 1114, Gx_line+49, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("LISTADO DE BIENES DE USO POR RESPONSABLE", 380, Gx_line+50, 797, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 400, Gx_line+17, 756, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+91) ;
               if ( GxHdr3 )
               {
                  getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Responsable:", 0, Gx_line+17, 102, Gx_line+35, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A209TTBUS14_Responsable, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 92, Gx_line+17, 458, Gx_line+36, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+50) ;
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
         context.CommitDataStores("PTBUS014_4");
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
         P001A2_A208TTBUS14_Estado = new short[1] ;
         P001A2_A216TTBUS14_NroSerie = new String[] {""} ;
         P001A2_A215TTBUS14_CodEtiqueta = new String[] {""} ;
         P001A2_A210TTBUS14_PosDesde = new String[] {""} ;
         P001A2_n210TTBUS14_PosDesde = new bool[] {false} ;
         P001A2_A204TTBUS14_Proveedor = new String[] {""} ;
         P001A2_A206TTBUS14_FechaAdquisicion = new DateTime[] {DateTime.MinValue} ;
         P001A2_A205TTBUS14_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001A2_A203TTBUS14_Rubro = new String[] {""} ;
         P001A2_A202TTBUS14_Descripcion = new String[] {""} ;
         P001A2_A211TTBUS14_PosHacia = new String[] {""} ;
         P001A2_n211TTBUS14_PosHacia = new bool[] {false} ;
         P001A2_A207TTBUS14_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001A2_n207TTBUS14_FechaEnvio = new bool[] {false} ;
         P001A2_A201TTBUS14_IdBien = new int[1] ;
         P001A2_A213TTBUS14_CodResponsable = new String[] {""} ;
         P001A2_A212TTBUS14_MarcaEnvio = new short[1] ;
         P001A2_A214TTBUS14_CodRubro = new short[1] ;
         P001A2_A209TTBUS14_Responsable = new String[] {""} ;
         A216TTBUS14_NroSerie = "" ;
         A215TTBUS14_CodEtiqueta = "" ;
         A210TTBUS14_PosDesde = "" ;
         A204TTBUS14_Proveedor = "" ;
         A206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
         A205TTBUS14_FechaCarga = DateTime.MinValue ;
         A203TTBUS14_Rubro = "" ;
         A202TTBUS14_Descripcion = "" ;
         A211TTBUS14_PosHacia = "" ;
         A207TTBUS14_FechaEnvio = DateTime.MinValue ;
         A213TTBUS14_CodResponsable = "" ;
         A209TTBUS14_Responsable = "" ;
         AV38MarcaEnvio = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus014_4__default(),
            new Object[][] {
                new Object[] {
               P001A2_A208TTBUS14_Estado, P001A2_A216TTBUS14_NroSerie, P001A2_A215TTBUS14_CodEtiqueta, P001A2_A210TTBUS14_PosDesde, P001A2_n210TTBUS14_PosDesde, P001A2_A204TTBUS14_Proveedor, P001A2_A206TTBUS14_FechaAdquisicion, P001A2_A205TTBUS14_FechaCarga, P001A2_A203TTBUS14_Rubro, P001A2_A202TTBUS14_Descripcion,
               P001A2_A211TTBUS14_PosHacia, P001A2_n211TTBUS14_PosHacia, P001A2_A207TTBUS14_FechaEnvio, P001A2_n207TTBUS14_FechaEnvio, P001A2_A201TTBUS14_IdBien, P001A2_A213TTBUS14_CodResponsable, P001A2_A212TTBUS14_MarcaEnvio, P001A2_A214TTBUS14_CodRubro, P001A2_A209TTBUS14_Responsable
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV20TTBUS_RubroBien ;
      private short A214TTBUS14_CodRubro ;
      private short A208TTBUS14_Estado ;
      private short A212TTBUS14_MarcaEnvio ;
      private short AV9band ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A201TTBUS14_IdBien ;
      private int Gx_OldLine ;
      private int AV19TTBUS_Id ;
      private String gxfirstwebparm ;
      private String AV15NOMBRE_REPORTE ;
      private String AV37USUARIO ;
      private String AV34TTBUS7_CodResp ;
      private String scmdbuf ;
      private String A210TTBUS14_PosDesde ;
      private String A204TTBUS14_Proveedor ;
      private String A203TTBUS14_Rubro ;
      private String A211TTBUS14_PosHacia ;
      private String A213TTBUS14_CodResponsable ;
      private String A209TTBUS14_Responsable ;
      private String AV38MarcaEnvio ;
      private DateTime AV8AHORA ;
      private DateTime A206TTBUS14_FechaAdquisicion ;
      private DateTime A205TTBUS14_FechaCarga ;
      private DateTime A207TTBUS14_FechaEnvio ;
      private bool entryPointCalled ;
      private bool GxHdr3 ;
      private bool BRK1A3 ;
      private bool n210TTBUS14_PosDesde ;
      private bool n211TTBUS14_PosHacia ;
      private bool n207TTBUS14_FechaEnvio ;
      private String A216TTBUS14_NroSerie ;
      private String A215TTBUS14_CodEtiqueta ;
      private String A202TTBUS14_Descripcion ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private String aP2_TTBUS7_CodResp ;
      private short aP3_TTBUS_RubroBien ;
      private IDataStoreProvider pr_default ;
      private short[] P001A2_A208TTBUS14_Estado ;
      private String[] P001A2_A216TTBUS14_NroSerie ;
      private String[] P001A2_A215TTBUS14_CodEtiqueta ;
      private String[] P001A2_A210TTBUS14_PosDesde ;
      private bool[] P001A2_n210TTBUS14_PosDesde ;
      private String[] P001A2_A204TTBUS14_Proveedor ;
      private DateTime[] P001A2_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] P001A2_A205TTBUS14_FechaCarga ;
      private String[] P001A2_A203TTBUS14_Rubro ;
      private String[] P001A2_A202TTBUS14_Descripcion ;
      private String[] P001A2_A211TTBUS14_PosHacia ;
      private bool[] P001A2_n211TTBUS14_PosHacia ;
      private DateTime[] P001A2_A207TTBUS14_FechaEnvio ;
      private bool[] P001A2_n207TTBUS14_FechaEnvio ;
      private int[] P001A2_A201TTBUS14_IdBien ;
      private String[] P001A2_A213TTBUS14_CodResponsable ;
      private short[] P001A2_A212TTBUS14_MarcaEnvio ;
      private short[] P001A2_A214TTBUS14_CodRubro ;
      private String[] P001A2_A209TTBUS14_Responsable ;
   }

   public class aptbus014_4__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001A2( short AV20TTBUS_RubroBien ,
                                             short A214TTBUS14_CodRubro )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [TTBUS14_Estado], [TTBUS14_NroSerie], [TTBUS14_CodEtiqueta], [TTBUS14_PosDesde], [TTBUS14_Proveedor], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaCarga], [TTBUS14_Rubro], [TTBUS14_Descripcion], [TTBUS14_PosHacia], [TTBUS14_FechaEnvio], [TTBUS14_IdBien], [TTBUS14_CodResponsable], [TTBUS14_MarcaEnvio], [TTBUS14_CodRubro], [TTBUS14_Responsable] FROM [TTBUS014_1] WITH (NOLOCK)" ;
         if ( ! (0==AV20TTBUS_RubroBien) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([TTBUS14_CodRubro] = @AV20TTBUS_RubroBien)" ;
            }
            else
            {
               sWhereString = sWhereString + " ([TTBUS14_CodRubro] = @AV20TTBUS_RubroBien)" ;
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
         scmdbuf = scmdbuf + " ORDER BY [TTBUS14_CodResponsable], [TTBUS14_MarcaEnvio], [TTBUS14_IdBien]" ;
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
                     return conditional_P001A2( (short)dynConstraints[0] , (short)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001A3 ;
          prmP001A3 = new Object[] {
          } ;
          Object[] prmP001A2 ;
          prmP001A2 = new Object[] {
          new Object[] {"@AV20TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001A2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001A2,100,0,true,false )
             ,new CursorDef("P001A3", "DELETE FROM [TTBUS014_1] ", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001A3)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(6) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[8])[0] = rslt.getString(8, 30) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[10])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((int[]) buf[14])[0] = rslt.getInt(12) ;
                ((String[]) buf[15])[0] = rslt.getString(13, 15) ;
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((short[]) buf[17])[0] = rslt.getShort(15) ;
                ((String[]) buf[18])[0] = rslt.getString(16, 50) ;
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
       }
    }

 }

}
