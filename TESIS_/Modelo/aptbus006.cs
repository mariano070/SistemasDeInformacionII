/*
               File: PTBUS006
        Description: Informe de bienes no relacionados con ningún sistema
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:6:43.47
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
   public class aptbus006 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV19Tipo_informe = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV28USUARIO = GetNextPar( ) ;
                  AV14NOMBRE_REPORTE = GetNextPar( ) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus006( IGxContext context )
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

      public void execute( ref short aP0_Tipo_informe ,
                           ref String aP1_USUARIO ,
                           ref String aP2_NOMBRE_REPORTE )
      {
         this.AV19Tipo_informe = aP0_Tipo_informe;
         this.AV28USUARIO = aP1_USUARIO;
         this.AV14NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_Tipo_informe=this.AV19Tipo_informe;
         aP1_USUARIO=this.AV28USUARIO;
         aP2_NOMBRE_REPORTE=this.AV14NOMBRE_REPORTE;
      }

      public String executeUdp( ref short aP0_Tipo_informe ,
                                ref String aP1_USUARIO )
      {
         this.AV19Tipo_informe = aP0_Tipo_informe;
         this.AV28USUARIO = aP1_USUARIO;
         this.AV14NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         initialize();
         executePrivate();
         aP0_Tipo_informe=this.AV19Tipo_informe;
         aP1_USUARIO=this.AV28USUARIO;
         aP2_NOMBRE_REPORTE=this.AV14NOMBRE_REPORTE;
         return AV14NOMBRE_REPORTE ;
      }

      public void executeSubmit( ref short aP0_Tipo_informe ,
                                 ref String aP1_USUARIO ,
                                 ref String aP2_NOMBRE_REPORTE )
      {
         aptbus006 objaptbus006;
         objaptbus006 = new aptbus006();
         objaptbus006.AV19Tipo_informe = aP0_Tipo_informe;
         objaptbus006.AV28USUARIO = aP1_USUARIO;
         objaptbus006.AV14NOMBRE_REPORTE = aP2_NOMBRE_REPORTE;
         objaptbus006.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus006.executePrivateCatch ));
         aP0_Tipo_informe=this.AV19Tipo_informe;
         aP1_USUARIO=this.AV28USUARIO;
         aP2_NOMBRE_REPORTE=this.AV14NOMBRE_REPORTE;
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
            if ( AV19Tipo_informe == 1 )
            {
               /* Execute user subroutine: S1130 */
               S1130 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               /* Eject command */
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(P_lines+1) ;
               /* Execute user subroutine: S1358 */
               S1358 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
               /* Eject command */
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(P_lines+1) ;
               /* Execute user subroutine: S1483 */
               S1483 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( AV19Tipo_informe == 2 )
            {
               /* Execute user subroutine: S1358 */
               S1358 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( AV19Tipo_informe == 3 )
            {
               /* Execute user subroutine: S1483 */
               S1483 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( AV19Tipo_informe == 4 )
            {
               /* Execute user subroutine: S1130 */
               S1130 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H140( true, 0) ;
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

      protected void S1130( )
      {
         /* 'NI HW. NI CONT.' Routine */
         AV18subtitulo = "Bienes no relacionados ni a contabilidad ni a hardware" ;
         /* Using cursor P00142 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A3BUS_COD = P00142_A3BUS_COD[0] ;
            n3BUS_COD = P00142_n3BUS_COD[0] ;
            A1BUS_RUB = P00142_A1BUS_RUB[0] ;
            n1BUS_RUB = P00142_n1BUS_RUB[0] ;
            A8BUS_EMP = P00142_A8BUS_EMP[0] ;
            n8BUS_EMP = P00142_n8BUS_EMP[0] ;
            A4BUS_PAR = P00142_A4BUS_PAR[0] ;
            n4BUS_PAR = P00142_n4BUS_PAR[0] ;
            A10HARDWARE_ID = P00142_A10HARDWARE_ID[0] ;
            n10HARDWARE_ID = P00142_n10HARDWARE_ID[0] ;
            A14IdIdentificador = P00142_A14IdIdentificador[0] ;
            A11TTBUS_Id = P00142_A11TTBUS_Id[0] ;
            A27TTBUS_CodProveedor = P00142_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = P00142_n27TTBUS_CodProveedor[0] ;
            A29TTBUS_Alquilado = P00142_A29TTBUS_Alquilado[0] ;
            A23TTBUS_Estado = P00142_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00142_A42TTBUS_NroSerie[0] ;
            A15NumeroIdentificador = P00142_A15NumeroIdentificador[0] ;
            A55BUS_FAD = P00142_A55BUS_FAD[0] ;
            A38TTBUS_DesPosicion = P00142_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00142_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00142_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00142_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00142_A37TTBUS_CodPosicion[0] ;
            A3BUS_COD = P00142_A3BUS_COD[0] ;
            n3BUS_COD = P00142_n3BUS_COD[0] ;
            A1BUS_RUB = P00142_A1BUS_RUB[0] ;
            n1BUS_RUB = P00142_n1BUS_RUB[0] ;
            A8BUS_EMP = P00142_A8BUS_EMP[0] ;
            n8BUS_EMP = P00142_n8BUS_EMP[0] ;
            A4BUS_PAR = P00142_A4BUS_PAR[0] ;
            n4BUS_PAR = P00142_n4BUS_PAR[0] ;
            A10HARDWARE_ID = P00142_A10HARDWARE_ID[0] ;
            n10HARDWARE_ID = P00142_n10HARDWARE_ID[0] ;
            A27TTBUS_CodProveedor = P00142_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = P00142_n27TTBUS_CodProveedor[0] ;
            A29TTBUS_Alquilado = P00142_A29TTBUS_Alquilado[0] ;
            A23TTBUS_Estado = P00142_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00142_A42TTBUS_NroSerie[0] ;
            A38TTBUS_DesPosicion = P00142_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00142_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00142_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00142_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00142_A37TTBUS_CodPosicion[0] ;
            A55BUS_FAD = P00142_A55BUS_FAD[0] ;
            OV23TTBUS_Estado = AV23TTBUS_Estado ;
            AV24TTBUS_Id = A11TTBUS_Id ;
            AV22TTBUS_CodProveedor = A27TTBUS_CodProveedor ;
            AV20TTBUS_Alquilado = A29TTBUS_Alquilado ;
            AV23TTBUS_Estado = A23TTBUS_Estado ;
            AV21TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            AV29Nro_Serie = "Nº Serie: " + StringUtil.Trim( A42TTBUS_NroSerie) ;
            /* Execute user subroutine: S123 */
            S123 ();
            if ( returnInSub )
            {
               pr_default.close(0);
               returnInSub = true;
               if (true) return;
            }
            AV10band = 0 ;
            new ptbus007(context ).execute( ref  AV10band,  AV24TTBUS_Id,  AV28USUARIO) ;
            if ( AV10band == 1 )
            {
               H140( false, 66) ;
               getPrinter().GxDrawLine(158, Gx_line+55, 1110, Gx_line+55, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 100, Gx_line+0, 151, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 158, Gx_line+0, 419, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 550, Gx_line+0, 611, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV17SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 433, Gx_line+33, 694, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+0, 857, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+33, 857, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 867, Gx_line+0, 1128, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A55BUS_FAD, "99/99/9999"), 433, Gx_line+0, 494, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV29Nro_Serie, "")), 158, Gx_line+17, 368, Gx_line+35, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 92, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 625, Gx_line+0, 683, Gx_line+16, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Responsable Actual", 433, Gx_line+17, 533, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Proveedor", 700, Gx_line+17, 752, Gx_line+32, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+66) ;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void S1358( )
      {
         /* 'NO RELACIONADOS A HW.' Routine */
         AV18subtitulo = "Bienes no relacionados a hardware" ;
         /* Using cursor P00143 */
         pr_default.execute(1);
         while ( (pr_default.getStatus(1) != 101) )
         {
            A8BUS_EMP = P00143_A8BUS_EMP[0] ;
            n8BUS_EMP = P00143_n8BUS_EMP[0] ;
            A1BUS_RUB = P00143_A1BUS_RUB[0] ;
            n1BUS_RUB = P00143_n1BUS_RUB[0] ;
            A3BUS_COD = P00143_A3BUS_COD[0] ;
            n3BUS_COD = P00143_n3BUS_COD[0] ;
            A4BUS_PAR = P00143_A4BUS_PAR[0] ;
            n4BUS_PAR = P00143_n4BUS_PAR[0] ;
            A10HARDWARE_ID = P00143_A10HARDWARE_ID[0] ;
            n10HARDWARE_ID = P00143_n10HARDWARE_ID[0] ;
            A14IdIdentificador = P00143_A14IdIdentificador[0] ;
            A11TTBUS_Id = P00143_A11TTBUS_Id[0] ;
            A27TTBUS_CodProveedor = P00143_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = P00143_n27TTBUS_CodProveedor[0] ;
            A29TTBUS_Alquilado = P00143_A29TTBUS_Alquilado[0] ;
            A23TTBUS_Estado = P00143_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00143_A42TTBUS_NroSerie[0] ;
            A15NumeroIdentificador = P00143_A15NumeroIdentificador[0] ;
            A55BUS_FAD = P00143_A55BUS_FAD[0] ;
            A38TTBUS_DesPosicion = P00143_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00143_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00143_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00143_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00143_A37TTBUS_CodPosicion[0] ;
            A8BUS_EMP = P00143_A8BUS_EMP[0] ;
            n8BUS_EMP = P00143_n8BUS_EMP[0] ;
            A1BUS_RUB = P00143_A1BUS_RUB[0] ;
            n1BUS_RUB = P00143_n1BUS_RUB[0] ;
            A3BUS_COD = P00143_A3BUS_COD[0] ;
            n3BUS_COD = P00143_n3BUS_COD[0] ;
            A4BUS_PAR = P00143_A4BUS_PAR[0] ;
            n4BUS_PAR = P00143_n4BUS_PAR[0] ;
            A10HARDWARE_ID = P00143_A10HARDWARE_ID[0] ;
            n10HARDWARE_ID = P00143_n10HARDWARE_ID[0] ;
            A27TTBUS_CodProveedor = P00143_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = P00143_n27TTBUS_CodProveedor[0] ;
            A29TTBUS_Alquilado = P00143_A29TTBUS_Alquilado[0] ;
            A23TTBUS_Estado = P00143_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00143_A42TTBUS_NroSerie[0] ;
            A38TTBUS_DesPosicion = P00143_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00143_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00143_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00143_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00143_A37TTBUS_CodPosicion[0] ;
            A55BUS_FAD = P00143_A55BUS_FAD[0] ;
            OV23TTBUS_Estado = AV23TTBUS_Estado ;
            AV24TTBUS_Id = A11TTBUS_Id ;
            AV22TTBUS_CodProveedor = A27TTBUS_CodProveedor ;
            AV20TTBUS_Alquilado = A29TTBUS_Alquilado ;
            AV23TTBUS_Estado = A23TTBUS_Estado ;
            AV21TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            AV29Nro_Serie = "Nº Serie: " + StringUtil.Trim( A42TTBUS_NroSerie) ;
            /* Execute user subroutine: S123 */
            S123 ();
            if ( returnInSub )
            {
               pr_default.close(1);
               returnInSub = true;
               if (true) return;
            }
            AV10band = 0 ;
            new ptbus007(context ).execute( ref  AV10band,  AV24TTBUS_Id,  AV28USUARIO) ;
            if ( AV10band == 1 )
            {
               H140( false, 66) ;
               getPrinter().GxDrawLine(158, Gx_line+55, 1110, Gx_line+55, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 100, Gx_line+0, 151, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 158, Gx_line+0, 419, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 550, Gx_line+0, 611, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV17SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 433, Gx_line+33, 694, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+0, 857, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+33, 857, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 867, Gx_line+0, 1128, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A55BUS_FAD, "99/99/9999"), 433, Gx_line+0, 494, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV29Nro_Serie, "")), 158, Gx_line+17, 368, Gx_line+35, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 92, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 625, Gx_line+0, 683, Gx_line+16, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Responsable Actual", 433, Gx_line+17, 533, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Proveedor", 700, Gx_line+17, 752, Gx_line+32, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+66) ;
            }
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void S1483( )
      {
         /* 'NO RELACIONADOS A CONT.' Routine */
         AV18subtitulo = "Bienes no relacionados a contabilidad" ;
         /* Using cursor P00144 */
         pr_default.execute(2);
         while ( (pr_default.getStatus(2) != 101) )
         {
            A3BUS_COD = P00144_A3BUS_COD[0] ;
            n3BUS_COD = P00144_n3BUS_COD[0] ;
            A1BUS_RUB = P00144_A1BUS_RUB[0] ;
            n1BUS_RUB = P00144_n1BUS_RUB[0] ;
            A8BUS_EMP = P00144_A8BUS_EMP[0] ;
            n8BUS_EMP = P00144_n8BUS_EMP[0] ;
            A4BUS_PAR = P00144_A4BUS_PAR[0] ;
            n4BUS_PAR = P00144_n4BUS_PAR[0] ;
            A14IdIdentificador = P00144_A14IdIdentificador[0] ;
            A29TTBUS_Alquilado = P00144_A29TTBUS_Alquilado[0] ;
            A11TTBUS_Id = P00144_A11TTBUS_Id[0] ;
            A23TTBUS_Estado = P00144_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00144_A42TTBUS_NroSerie[0] ;
            A15NumeroIdentificador = P00144_A15NumeroIdentificador[0] ;
            A55BUS_FAD = P00144_A55BUS_FAD[0] ;
            A38TTBUS_DesPosicion = P00144_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00144_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00144_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00144_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00144_A37TTBUS_CodPosicion[0] ;
            A3BUS_COD = P00144_A3BUS_COD[0] ;
            n3BUS_COD = P00144_n3BUS_COD[0] ;
            A1BUS_RUB = P00144_A1BUS_RUB[0] ;
            n1BUS_RUB = P00144_n1BUS_RUB[0] ;
            A8BUS_EMP = P00144_A8BUS_EMP[0] ;
            n8BUS_EMP = P00144_n8BUS_EMP[0] ;
            A4BUS_PAR = P00144_A4BUS_PAR[0] ;
            n4BUS_PAR = P00144_n4BUS_PAR[0] ;
            A29TTBUS_Alquilado = P00144_A29TTBUS_Alquilado[0] ;
            A23TTBUS_Estado = P00144_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00144_A42TTBUS_NroSerie[0] ;
            A38TTBUS_DesPosicion = P00144_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00144_A30TTBUS_DesProveedor[0] ;
            A13TTBUS_FechaCarga = P00144_A13TTBUS_FechaCarga[0] ;
            A12TTBUS_Descripcion = P00144_A12TTBUS_Descripcion[0] ;
            A37TTBUS_CodPosicion = P00144_A37TTBUS_CodPosicion[0] ;
            A55BUS_FAD = P00144_A55BUS_FAD[0] ;
            OV23TTBUS_Estado = AV23TTBUS_Estado ;
            AV24TTBUS_Id = A11TTBUS_Id ;
            AV20TTBUS_Alquilado = A29TTBUS_Alquilado ;
            AV23TTBUS_Estado = A23TTBUS_Estado ;
            AV21TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            AV29Nro_Serie = "Nº Serie: " + StringUtil.Trim( A42TTBUS_NroSerie) ;
            /* Execute user subroutine: S123 */
            S123 ();
            if ( returnInSub )
            {
               pr_default.close(2);
               returnInSub = true;
               if (true) return;
            }
            AV10band = 0 ;
            new ptbus007(context ).execute( ref  AV10band,  AV24TTBUS_Id,  AV28USUARIO) ;
            if ( AV10band == 1 )
            {
               H140( false, 66) ;
               getPrinter().GxDrawLine(158, Gx_line+55, 1110, Gx_line+55, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 100, Gx_line+0, 151, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 158, Gx_line+0, 419, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 550, Gx_line+0, 611, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV17SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 433, Gx_line+33, 694, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+0, 857, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 700, Gx_line+33, 857, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A38TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 867, Gx_line+0, 1128, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A55BUS_FAD, "99/99/9999"), 433, Gx_line+0, 494, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV29Nro_Serie, "")), 158, Gx_line+17, 368, Gx_line+35, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 92, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 625, Gx_line+0, 683, Gx_line+16, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Responsable Actual", 433, Gx_line+17, 533, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Proveedor", 700, Gx_line+17, 752, Gx_line+32, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+66) ;
            }
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void S123( )
      {
         /* 'BUSCA DATOS' Routine */
         if ( AV20TTBUS_Alquilado == 1 )
         {
            AV9alquilado = "SI" ;
         }
         else if ( AV20TTBUS_Alquilado == 0 )
         {
            AV9alquilado = "NO" ;
         }
         if ( AV23TTBUS_Estado == 1 )
         {
            /* Using cursor P00145 */
            pr_default.execute(3, new Object[] {AV21TTBUS_CodPosicion});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A35TTBUS7_CodResp = P00145_A35TTBUS7_CodResp[0] ;
               A33TTBUS7_Pos = P00145_A33TTBUS7_Pos[0] ;
               A36TTBUS7_DesResp = P00145_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00145_n36TTBUS7_DesResp[0] ;
               A36TTBUS7_DesResp = P00145_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00145_n36TTBUS7_DesResp[0] ;
               AV17SEC_DRE = A36TTBUS7_DesResp ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(3);
         }
         else
         {
            /* Using cursor P00146 */
            pr_default.execute(4, new Object[] {AV24TTBUS_Id});
            while ( (pr_default.getStatus(4) != 101) )
            {
               A26TTBUS2_EstadoEnvio = P00146_A26TTBUS2_EstadoEnvio[0] ;
               A22TTBUS2_IdBien = P00146_A22TTBUS2_IdBien[0] ;
               A24TTBUS2_RespDesde = P00146_A24TTBUS2_RespDesde[0] ;
               A25TTBUS2_RespHacia = P00146_A25TTBUS2_RespHacia[0] ;
               A52TTBUS2_IdMovimiento = P00146_A52TTBUS2_IdMovimiento[0] ;
               AV26TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
               AV27TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
               /* Using cursor P00147 */
               pr_default.execute(5, new Object[] {AV26TTBUS2_RespDesde});
               while ( (pr_default.getStatus(5) != 101) )
               {
                  A6USU_COD = P00147_A6USU_COD[0] ;
                  A7USU_DES = P00147_A7USU_DES[0] ;
                  AV11dUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(5);
               /* Using cursor P00148 */
               pr_default.execute(6, new Object[] {AV27TTBUS2_RespHacia});
               while ( (pr_default.getStatus(6) != 101) )
               {
                  A6USU_COD = P00148_A6USU_COD[0] ;
                  A7USU_DES = P00148_A7USU_DES[0] ;
                  AV13hUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(6);
               pr_default.readNext(4);
            }
            pr_default.close(4);
            AV17SEC_DRE = StringUtil.Trim( AV11dUSU_DES) + " Y " + StringUtil.Trim( AV13hUSU_DES) ;
         }
         if ( AV23TTBUS_Estado == 1 )
         {
            AV12estado = "ASIGNADO A UN SECTOR" ;
         }
         else if ( AV23TTBUS_Estado == 2 )
         {
            AV12estado = "CAMBIANDO DE SECTOR" ;
         }
      }

      protected void H140( bool bFoot ,
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
               getPrinter().GxDrawBitMap(context.GetImagePath( "43ca73d8-f671-4ff8-b419-ae86171a376e", "", "Modern"), 0, Gx_line+0, 156, Gx_line+52) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha y Hora:", 967, Gx_line+17, 1038, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Página:", 967, Gx_line+33, 1006, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/9999 99:99"), 1042, Gx_line+17, 1135, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1042, Gx_line+33, 1081, Gx_line+49, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("INFORME DE BIENES RELACIONADOS CON OTROS SISTEMAS", 333, Gx_line+50, 851, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 408, Gx_line+17, 764, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+80) ;
               getPrinter().GxDrawLine(8, Gx_line+51, 1141, Gx_line+51, 2, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Descripción", 158, Gx_line+33, 217, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Nº Bien", 100, Gx_line+33, 139, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Fecha Adquisición", 433, Gx_line+33, 525, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Fecha Carga", 550, Gx_line+33, 615, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Estado", 700, Gx_line+33, 735, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Posición Actual", 867, Gx_line+33, 944, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Nº Etiqueta", 17, Gx_line+33, 74, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Alquilado", 625, Gx_line+33, 671, Gx_line+48, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV18subtitulo, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 5, Gx_line+0, 381, Gx_line+18, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+53) ;
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
         AV18subtitulo = "" ;
         scmdbuf = "" ;
         P00142_A3BUS_COD = new short[1] ;
         P00142_n3BUS_COD = new bool[] {false} ;
         P00142_A1BUS_RUB = new short[1] ;
         P00142_n1BUS_RUB = new bool[] {false} ;
         P00142_A8BUS_EMP = new String[] {""} ;
         P00142_n8BUS_EMP = new bool[] {false} ;
         P00142_A4BUS_PAR = new short[1] ;
         P00142_n4BUS_PAR = new bool[] {false} ;
         P00142_A10HARDWARE_ID = new short[1] ;
         P00142_n10HARDWARE_ID = new bool[] {false} ;
         P00142_A14IdIdentificador = new int[1] ;
         P00142_A11TTBUS_Id = new int[1] ;
         P00142_A27TTBUS_CodProveedor = new int[1] ;
         P00142_n27TTBUS_CodProveedor = new bool[] {false} ;
         P00142_A29TTBUS_Alquilado = new short[1] ;
         P00142_A23TTBUS_Estado = new short[1] ;
         P00142_A42TTBUS_NroSerie = new String[] {""} ;
         P00142_A15NumeroIdentificador = new String[] {""} ;
         P00142_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         P00142_A38TTBUS_DesPosicion = new String[] {""} ;
         P00142_A30TTBUS_DesProveedor = new String[] {""} ;
         P00142_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00142_A12TTBUS_Descripcion = new String[] {""} ;
         P00142_A37TTBUS_CodPosicion = new short[1] ;
         A8BUS_EMP = "" ;
         A42TTBUS_NroSerie = "" ;
         A15NumeroIdentificador = "" ;
         A55BUS_FAD = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         A30TTBUS_DesProveedor = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A12TTBUS_Descripcion = "" ;
         AV23TTBUS_Estado = 1 ;
         AV29Nro_Serie = "" ;
         AV17SEC_DRE = "" ;
         AV12estado = "" ;
         AV9alquilado = "" ;
         P00143_A8BUS_EMP = new String[] {""} ;
         P00143_n8BUS_EMP = new bool[] {false} ;
         P00143_A1BUS_RUB = new short[1] ;
         P00143_n1BUS_RUB = new bool[] {false} ;
         P00143_A3BUS_COD = new short[1] ;
         P00143_n3BUS_COD = new bool[] {false} ;
         P00143_A4BUS_PAR = new short[1] ;
         P00143_n4BUS_PAR = new bool[] {false} ;
         P00143_A10HARDWARE_ID = new short[1] ;
         P00143_n10HARDWARE_ID = new bool[] {false} ;
         P00143_A14IdIdentificador = new int[1] ;
         P00143_A11TTBUS_Id = new int[1] ;
         P00143_A27TTBUS_CodProveedor = new int[1] ;
         P00143_n27TTBUS_CodProveedor = new bool[] {false} ;
         P00143_A29TTBUS_Alquilado = new short[1] ;
         P00143_A23TTBUS_Estado = new short[1] ;
         P00143_A42TTBUS_NroSerie = new String[] {""} ;
         P00143_A15NumeroIdentificador = new String[] {""} ;
         P00143_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         P00143_A38TTBUS_DesPosicion = new String[] {""} ;
         P00143_A30TTBUS_DesProveedor = new String[] {""} ;
         P00143_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00143_A12TTBUS_Descripcion = new String[] {""} ;
         P00143_A37TTBUS_CodPosicion = new short[1] ;
         P00144_A3BUS_COD = new short[1] ;
         P00144_n3BUS_COD = new bool[] {false} ;
         P00144_A1BUS_RUB = new short[1] ;
         P00144_n1BUS_RUB = new bool[] {false} ;
         P00144_A8BUS_EMP = new String[] {""} ;
         P00144_n8BUS_EMP = new bool[] {false} ;
         P00144_A4BUS_PAR = new short[1] ;
         P00144_n4BUS_PAR = new bool[] {false} ;
         P00144_A14IdIdentificador = new int[1] ;
         P00144_A29TTBUS_Alquilado = new short[1] ;
         P00144_A11TTBUS_Id = new int[1] ;
         P00144_A23TTBUS_Estado = new short[1] ;
         P00144_A42TTBUS_NroSerie = new String[] {""} ;
         P00144_A15NumeroIdentificador = new String[] {""} ;
         P00144_A55BUS_FAD = new DateTime[] {DateTime.MinValue} ;
         P00144_A38TTBUS_DesPosicion = new String[] {""} ;
         P00144_A30TTBUS_DesProveedor = new String[] {""} ;
         P00144_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00144_A12TTBUS_Descripcion = new String[] {""} ;
         P00144_A37TTBUS_CodPosicion = new short[1] ;
         P00145_A35TTBUS7_CodResp = new String[] {""} ;
         P00145_A33TTBUS7_Pos = new short[1] ;
         P00145_A36TTBUS7_DesResp = new String[] {""} ;
         P00145_n36TTBUS7_DesResp = new bool[] {false} ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         P00146_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00146_A22TTBUS2_IdBien = new int[1] ;
         P00146_A24TTBUS2_RespDesde = new String[] {""} ;
         P00146_A25TTBUS2_RespHacia = new String[] {""} ;
         P00146_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV26TTBUS2_RespDesde = "" ;
         AV27TTBUS2_RespHacia = "" ;
         P00147_A6USU_COD = new String[] {""} ;
         P00147_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV11dUSU_DES = "" ;
         P00148_A6USU_COD = new String[] {""} ;
         P00148_A7USU_DES = new String[] {""} ;
         AV13hUSU_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus006__default(),
            new Object[][] {
                new Object[] {
               P00142_A3BUS_COD, P00142_n3BUS_COD, P00142_A1BUS_RUB, P00142_n1BUS_RUB, P00142_A8BUS_EMP, P00142_n8BUS_EMP, P00142_A4BUS_PAR, P00142_n4BUS_PAR, P00142_A10HARDWARE_ID, P00142_n10HARDWARE_ID,
               P00142_A14IdIdentificador, P00142_A11TTBUS_Id, P00142_A27TTBUS_CodProveedor, P00142_n27TTBUS_CodProveedor, P00142_A29TTBUS_Alquilado, P00142_A23TTBUS_Estado, P00142_A42TTBUS_NroSerie, P00142_A15NumeroIdentificador, P00142_A55BUS_FAD, P00142_A38TTBUS_DesPosicion,
               P00142_A30TTBUS_DesProveedor, P00142_A13TTBUS_FechaCarga, P00142_A12TTBUS_Descripcion, P00142_A37TTBUS_CodPosicion
               }
               , new Object[] {
               P00143_A8BUS_EMP, P00143_n8BUS_EMP, P00143_A1BUS_RUB, P00143_n1BUS_RUB, P00143_A3BUS_COD, P00143_n3BUS_COD, P00143_A4BUS_PAR, P00143_n4BUS_PAR, P00143_A10HARDWARE_ID, P00143_n10HARDWARE_ID,
               P00143_A14IdIdentificador, P00143_A11TTBUS_Id, P00143_A27TTBUS_CodProveedor, P00143_n27TTBUS_CodProveedor, P00143_A29TTBUS_Alquilado, P00143_A23TTBUS_Estado, P00143_A42TTBUS_NroSerie, P00143_A15NumeroIdentificador, P00143_A55BUS_FAD, P00143_A38TTBUS_DesPosicion,
               P00143_A30TTBUS_DesProveedor, P00143_A13TTBUS_FechaCarga, P00143_A12TTBUS_Descripcion, P00143_A37TTBUS_CodPosicion
               }
               , new Object[] {
               P00144_A3BUS_COD, P00144_n3BUS_COD, P00144_A1BUS_RUB, P00144_n1BUS_RUB, P00144_A8BUS_EMP, P00144_n8BUS_EMP, P00144_A4BUS_PAR, P00144_n4BUS_PAR, P00144_A14IdIdentificador, P00144_A29TTBUS_Alquilado,
               P00144_A11TTBUS_Id, P00144_A23TTBUS_Estado, P00144_A42TTBUS_NroSerie, P00144_A15NumeroIdentificador, P00144_A55BUS_FAD, P00144_A38TTBUS_DesPosicion, P00144_A30TTBUS_DesProveedor, P00144_A13TTBUS_FechaCarga, P00144_A12TTBUS_Descripcion, P00144_A37TTBUS_CodPosicion
               }
               , new Object[] {
               P00145_A35TTBUS7_CodResp, P00145_A33TTBUS7_Pos, P00145_A36TTBUS7_DesResp, P00145_n36TTBUS7_DesResp
               }
               , new Object[] {
               P00146_A26TTBUS2_EstadoEnvio, P00146_A22TTBUS2_IdBien, P00146_A24TTBUS2_RespDesde, P00146_A25TTBUS2_RespHacia, P00146_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00147_A6USU_COD, P00147_A7USU_DES
               }
               , new Object[] {
               P00148_A6USU_COD, P00148_A7USU_DES
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV19Tipo_informe ;
      private short A3BUS_COD ;
      private short A1BUS_RUB ;
      private short A4BUS_PAR ;
      private short A10HARDWARE_ID ;
      private short A29TTBUS_Alquilado ;
      private short A23TTBUS_Estado ;
      private short A37TTBUS_CodPosicion ;
      private short OV23TTBUS_Estado ;
      private short AV23TTBUS_Estado ;
      private short AV20TTBUS_Alquilado ;
      private short AV21TTBUS_CodPosicion ;
      private short AV10band ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int AV24TTBUS_Id ;
      private int AV22TTBUS_CodProveedor ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV28USUARIO ;
      private String AV14NOMBRE_REPORTE ;
      private String AV18subtitulo ;
      private String scmdbuf ;
      private String A8BUS_EMP ;
      private String A38TTBUS_DesPosicion ;
      private String A30TTBUS_DesProveedor ;
      private String AV17SEC_DRE ;
      private String AV12estado ;
      private String AV9alquilado ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV26TTBUS2_RespDesde ;
      private String AV27TTBUS2_RespHacia ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String AV11dUSU_DES ;
      private String AV13hUSU_DES ;
      private DateTime AV8AHORA ;
      private DateTime A55BUS_FAD ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool returnInSub ;
      private bool n3BUS_COD ;
      private bool n1BUS_RUB ;
      private bool n8BUS_EMP ;
      private bool n4BUS_PAR ;
      private bool n10HARDWARE_ID ;
      private bool n27TTBUS_CodProveedor ;
      private bool n36TTBUS7_DesResp ;
      private String A42TTBUS_NroSerie ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private String AV29Nro_Serie ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private short aP0_Tipo_informe ;
      private String aP1_USUARIO ;
      private String aP2_NOMBRE_REPORTE ;
      private IDataStoreProvider pr_default ;
      private short[] P00142_A3BUS_COD ;
      private bool[] P00142_n3BUS_COD ;
      private short[] P00142_A1BUS_RUB ;
      private bool[] P00142_n1BUS_RUB ;
      private String[] P00142_A8BUS_EMP ;
      private bool[] P00142_n8BUS_EMP ;
      private short[] P00142_A4BUS_PAR ;
      private bool[] P00142_n4BUS_PAR ;
      private short[] P00142_A10HARDWARE_ID ;
      private bool[] P00142_n10HARDWARE_ID ;
      private int[] P00142_A14IdIdentificador ;
      private int[] P00142_A11TTBUS_Id ;
      private int[] P00142_A27TTBUS_CodProveedor ;
      private bool[] P00142_n27TTBUS_CodProveedor ;
      private short[] P00142_A29TTBUS_Alquilado ;
      private short[] P00142_A23TTBUS_Estado ;
      private String[] P00142_A42TTBUS_NroSerie ;
      private String[] P00142_A15NumeroIdentificador ;
      private DateTime[] P00142_A55BUS_FAD ;
      private String[] P00142_A38TTBUS_DesPosicion ;
      private String[] P00142_A30TTBUS_DesProveedor ;
      private DateTime[] P00142_A13TTBUS_FechaCarga ;
      private String[] P00142_A12TTBUS_Descripcion ;
      private short[] P00142_A37TTBUS_CodPosicion ;
      private String[] P00143_A8BUS_EMP ;
      private bool[] P00143_n8BUS_EMP ;
      private short[] P00143_A1BUS_RUB ;
      private bool[] P00143_n1BUS_RUB ;
      private short[] P00143_A3BUS_COD ;
      private bool[] P00143_n3BUS_COD ;
      private short[] P00143_A4BUS_PAR ;
      private bool[] P00143_n4BUS_PAR ;
      private short[] P00143_A10HARDWARE_ID ;
      private bool[] P00143_n10HARDWARE_ID ;
      private int[] P00143_A14IdIdentificador ;
      private int[] P00143_A11TTBUS_Id ;
      private int[] P00143_A27TTBUS_CodProveedor ;
      private bool[] P00143_n27TTBUS_CodProveedor ;
      private short[] P00143_A29TTBUS_Alquilado ;
      private short[] P00143_A23TTBUS_Estado ;
      private String[] P00143_A42TTBUS_NroSerie ;
      private String[] P00143_A15NumeroIdentificador ;
      private DateTime[] P00143_A55BUS_FAD ;
      private String[] P00143_A38TTBUS_DesPosicion ;
      private String[] P00143_A30TTBUS_DesProveedor ;
      private DateTime[] P00143_A13TTBUS_FechaCarga ;
      private String[] P00143_A12TTBUS_Descripcion ;
      private short[] P00143_A37TTBUS_CodPosicion ;
      private short[] P00144_A3BUS_COD ;
      private bool[] P00144_n3BUS_COD ;
      private short[] P00144_A1BUS_RUB ;
      private bool[] P00144_n1BUS_RUB ;
      private String[] P00144_A8BUS_EMP ;
      private bool[] P00144_n8BUS_EMP ;
      private short[] P00144_A4BUS_PAR ;
      private bool[] P00144_n4BUS_PAR ;
      private int[] P00144_A14IdIdentificador ;
      private short[] P00144_A29TTBUS_Alquilado ;
      private int[] P00144_A11TTBUS_Id ;
      private short[] P00144_A23TTBUS_Estado ;
      private String[] P00144_A42TTBUS_NroSerie ;
      private String[] P00144_A15NumeroIdentificador ;
      private DateTime[] P00144_A55BUS_FAD ;
      private String[] P00144_A38TTBUS_DesPosicion ;
      private String[] P00144_A30TTBUS_DesProveedor ;
      private DateTime[] P00144_A13TTBUS_FechaCarga ;
      private String[] P00144_A12TTBUS_Descripcion ;
      private short[] P00144_A37TTBUS_CodPosicion ;
      private String[] P00145_A35TTBUS7_CodResp ;
      private short[] P00145_A33TTBUS7_Pos ;
      private String[] P00145_A36TTBUS7_DesResp ;
      private bool[] P00145_n36TTBUS7_DesResp ;
      private short[] P00146_A26TTBUS2_EstadoEnvio ;
      private int[] P00146_A22TTBUS2_IdBien ;
      private String[] P00146_A24TTBUS2_RespDesde ;
      private String[] P00146_A25TTBUS2_RespHacia ;
      private long[] P00146_A52TTBUS2_IdMovimiento ;
      private String[] P00147_A6USU_COD ;
      private String[] P00147_A7USU_DES ;
      private String[] P00148_A6USU_COD ;
      private String[] P00148_A7USU_DES ;
   }

   public class aptbus006__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00142 ;
          prmP00142 = new Object[] {
          } ;
          Object[] prmP00143 ;
          prmP00143 = new Object[] {
          } ;
          Object[] prmP00144 ;
          prmP00144 = new Object[] {
          } ;
          Object[] prmP00145 ;
          prmP00145 = new Object[] {
          new Object[] {"@AV21TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00146 ;
          prmP00146 = new Object[] {
          new Object[] {"@AV24TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00147 ;
          prmP00147 = new Object[] {
          new Object[] {"@AV26TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00148 ;
          prmP00148 = new Object[] {
          new Object[] {"@AV27TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00142", "SELECT T2.[BUS_COD], T2.[BUS_RUB], T2.[BUS_EMP], T2.[BUS_PAR], T2.[HARDWARE_ID], T1.[IdIdentificador], T1.[TTBUS_Id], T2.[TTBUS_CodProveedor], T2.[TTBUS_Alquilado], T2.[TTBUS_Estado], T2.[TTBUS_NroSerie], T1.[NumeroIdentificador], T3.[BUS_FAD], T2.[TTBUS_DesPosicion], T2.[TTBUS_DesProveedor], T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T2.[TTBUS_CodPosicion] FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [BUS000] T3 WITH (NOLOCK) ON T3.[BUS_EMP] = T2.[BUS_EMP] AND T3.[BUS_RUB] = T2.[BUS_RUB] AND T3.[BUS_COD] = T2.[BUS_COD] AND T3.[BUS_PAR] = T2.[BUS_PAR]) WHERE (T2.[BUS_COD] = 0) AND (T2.[BUS_RUB] = 0) AND (T2.[BUS_EMP] = '') AND (T2.[BUS_PAR] = 0) AND (T2.[HARDWARE_ID] = 0) AND (T1.[IdIdentificador] = 1) ORDER BY T2.[TTBUS_CodPosicion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00142,100,0,true,false )
             ,new CursorDef("P00143", "SELECT T2.[BUS_EMP], T2.[BUS_RUB], T2.[BUS_COD], T2.[BUS_PAR], T2.[HARDWARE_ID], T1.[IdIdentificador], T1.[TTBUS_Id], T2.[TTBUS_CodProveedor], T2.[TTBUS_Alquilado], T2.[TTBUS_Estado], T2.[TTBUS_NroSerie], T1.[NumeroIdentificador], T3.[BUS_FAD], T2.[TTBUS_DesPosicion], T2.[TTBUS_DesProveedor], T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T2.[TTBUS_CodPosicion] FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [BUS000] T3 WITH (NOLOCK) ON T3.[BUS_EMP] = T2.[BUS_EMP] AND T3.[BUS_RUB] = T2.[BUS_RUB] AND T3.[BUS_COD] = T2.[BUS_COD] AND T3.[BUS_PAR] = T2.[BUS_PAR]) WHERE (T2.[HARDWARE_ID] = 0) AND (T1.[IdIdentificador] = 1) ORDER BY T2.[TTBUS_CodPosicion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00143,100,0,true,false )
             ,new CursorDef("P00144", "SELECT T2.[BUS_COD], T2.[BUS_RUB], T2.[BUS_EMP], T2.[BUS_PAR], T1.[IdIdentificador], T2.[TTBUS_Alquilado], T1.[TTBUS_Id], T2.[TTBUS_Estado], T2.[TTBUS_NroSerie], T1.[NumeroIdentificador], T3.[BUS_FAD], T2.[TTBUS_DesPosicion], T2.[TTBUS_DesProveedor], T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T2.[TTBUS_CodPosicion] FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [BUS000] T3 WITH (NOLOCK) ON T3.[BUS_EMP] = T2.[BUS_EMP] AND T3.[BUS_RUB] = T2.[BUS_RUB] AND T3.[BUS_COD] = T2.[BUS_COD] AND T3.[BUS_PAR] = T2.[BUS_PAR]) WHERE (T2.[BUS_COD] = 0) AND (T2.[BUS_RUB] = 0) AND (T2.[BUS_EMP] = '') AND (T2.[BUS_PAR] = 0) AND (T1.[IdIdentificador] = 1) AND (T2.[TTBUS_Alquilado] = 0) ORDER BY T2.[TTBUS_CodPosicion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00144,100,0,true,false )
             ,new CursorDef("P00145", "SELECT T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS7_Pos], T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV21TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00145,1,0,false,true )
             ,new CursorDef("P00146", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV24TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00146,100,0,true,false )
             ,new CursorDef("P00147", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV26TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00147,1,0,false,true )
             ,new CursorDef("P00148", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV27TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00148,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(12) ;
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(13) ;
                ((String[]) buf[19])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[20])[0] = rslt.getString(15, 30) ;
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(16) ;
                ((String[]) buf[22])[0] = rslt.getVarchar(17) ;
                ((short[]) buf[23])[0] = rslt.getShort(18) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((int[]) buf[10])[0] = rslt.getInt(6) ;
                ((int[]) buf[11])[0] = rslt.getInt(7) ;
                ((int[]) buf[12])[0] = rslt.getInt(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((short[]) buf[14])[0] = rslt.getShort(9) ;
                ((short[]) buf[15])[0] = rslt.getShort(10) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(12) ;
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(13) ;
                ((String[]) buf[19])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[20])[0] = rslt.getString(15, 30) ;
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(16) ;
                ((String[]) buf[22])[0] = rslt.getVarchar(17) ;
                ((short[]) buf[23])[0] = rslt.getShort(18) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 1) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((int[]) buf[8])[0] = rslt.getInt(5) ;
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((int[]) buf[10])[0] = rslt.getInt(7) ;
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(10) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDate(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 50) ;
                ((String[]) buf[16])[0] = rslt.getString(13, 30) ;
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(14) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(15) ;
                ((short[]) buf[19])[0] = rslt.getShort(16) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 6 :
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
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
