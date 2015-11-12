/*
               File: PTBUS013
        Description: Listado de Movimientos de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:25.34
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
   public class aptbus013 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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

      public aptbus013( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus013( IGxContext context )
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
         aptbus013 objaptbus013;
         objaptbus013 = new aptbus013();
         objaptbus013.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus013.AV40USUARIO = aP1_USUARIO;
         objaptbus013.AV47TTBUS7_Pos = aP2_TTBUS7_Pos;
         objaptbus013.AV46TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objaptbus013.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus013.executePrivateCatch ));
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
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV47TTBUS7_Pos ,
                                                 A37TTBUS_CodPosicion ,
                                                 A14IdIdentificador },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.INT
                                                 }
            });
            /* Using cursor P00172 */
            pr_default.execute(0, new Object[] {AV47TTBUS7_Pos});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A35TTBUS7_CodResp = P00172_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00172_n35TTBUS7_CodResp[0] ;
               A14IdIdentificador = P00172_A14IdIdentificador[0] ;
               A37TTBUS_CodPosicion = P00172_A37TTBUS_CodPosicion[0] ;
               A29TTBUS_Alquilado = P00172_A29TTBUS_Alquilado[0] ;
               A16TTBUS_FechaBaja = P00172_A16TTBUS_FechaBaja[0] ;
               n16TTBUS_FechaBaja = P00172_n16TTBUS_FechaBaja[0] ;
               A43TTBUS_MotivoBaja = P00172_A43TTBUS_MotivoBaja[0] ;
               n43TTBUS_MotivoBaja = P00172_n43TTBUS_MotivoBaja[0] ;
               A12TTBUS_Descripcion = P00172_A12TTBUS_Descripcion[0] ;
               A15NumeroIdentificador = P00172_A15NumeroIdentificador[0] ;
               A23TTBUS_Estado = P00172_A23TTBUS_Estado[0] ;
               A11TTBUS_Id = P00172_A11TTBUS_Id[0] ;
               A37TTBUS_CodPosicion = P00172_A37TTBUS_CodPosicion[0] ;
               A29TTBUS_Alquilado = P00172_A29TTBUS_Alquilado[0] ;
               A16TTBUS_FechaBaja = P00172_A16TTBUS_FechaBaja[0] ;
               n16TTBUS_FechaBaja = P00172_n16TTBUS_FechaBaja[0] ;
               A43TTBUS_MotivoBaja = P00172_A43TTBUS_MotivoBaja[0] ;
               n43TTBUS_MotivoBaja = P00172_n43TTBUS_MotivoBaja[0] ;
               A12TTBUS_Descripcion = P00172_A12TTBUS_Descripcion[0] ;
               A23TTBUS_Estado = P00172_A23TTBUS_Estado[0] ;
               A35TTBUS7_CodResp = P00172_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00172_n35TTBUS7_CodResp[0] ;
               AV24TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
               AV23TTBUS_Alquilado = A29TTBUS_Alquilado ;
               AV48TTBUS_FechaBaja = A16TTBUS_FechaBaja ;
               AV49tTTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
               AV28TTBUS_Id = A11TTBUS_Id ;
               AV50tTTBUS_Descripcion = A12TTBUS_Descripcion ;
               AV51NumeroIdentificador = A15NumeroIdentificador ;
               if ( StringUtil.StrCmp(StringUtil.Trim( AV46TTBUS7_CodResp), "") != 0 )
               {
                  if ( A23TTBUS_Estado == 1 )
                  {
                     /* Using cursor P00173 */
                     pr_default.execute(1, new Object[] {AV24TTBUS_CodPosicion});
                     while ( (pr_default.getStatus(1) != 101) )
                     {
                        A33TTBUS7_Pos = P00173_A33TTBUS7_Pos[0] ;
                        if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1149 */
                           S1149 ();
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
                     /* Using cursor P00174 */
                     pr_default.execute(2, new Object[] {AV28TTBUS_Id});
                     while ( (pr_default.getStatus(2) != 101) )
                     {
                        A26TTBUS2_EstadoEnvio = P00174_A26TTBUS2_EstadoEnvio[0] ;
                        A22TTBUS2_IdBien = P00174_A22TTBUS2_IdBien[0] ;
                        A24TTBUS2_RespDesde = P00174_A24TTBUS2_RespDesde[0] ;
                        A25TTBUS2_RespHacia = P00174_A25TTBUS2_RespHacia[0] ;
                        A52TTBUS2_IdMovimiento = P00174_A52TTBUS2_IdMovimiento[0] ;
                        if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1149 */
                           S1149 ();
                           if ( returnInSub )
                           {
                              pr_default.close(2);
                              this.cleanup();
                              if (true) return;
                           }
                        }
                        else if ( StringUtil.StrCmp(A25TTBUS2_RespHacia, AV46TTBUS7_CodResp) == 0 )
                        {
                           /* Execute user subroutine: S1149 */
                           S1149 ();
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
                  /* Execute user subroutine: S1149 */
                  S1149 ();
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
            H170( true, 0) ;
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

      protected void S1149( )
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
            if ( ! (DateTime.MinValue==AV48TTBUS_FechaBaja) )
            {
               AV41lbl_fecBaja = "Fecha Baja:" ;
               AV42lbl_MotBaja = "Motivo Baja:" ;
               AV43fecha_baja = context.localUtil.DToC( AV48TTBUS_FechaBaja, 4, "/") ;
               AV45TTBUS_MotivoBaja = AV49tTTBUS_MotivoBaja ;
            }
            else
            {
               AV41lbl_fecBaja = "" ;
               AV42lbl_MotBaja = "" ;
               AV43fecha_baja = "" ;
               AV45TTBUS_MotivoBaja = "" ;
            }
            AV33TTBUS2_IdBien = AV28TTBUS_Id ;
            H170( false, 86) ;
            getPrinter().GxDrawLine(8, Gx_line+84, 1133, Gx_line+84, 2, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28TTBUS_Id), "ZZZZZZZ9")), 83, Gx_line+0, 134, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV26TTBUS_Descripcion, "@!")), 475, Gx_line+0, 736, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 83, Gx_line+33, 141, Gx_line+49, 0+256) ;
            getPrinter().GxDrawText("Posición Envío:", 8, Gx_line+67, 87, Gx_line+82, 0+256) ;
            getPrinter().GxDrawText("Posición Recepción:", 242, Gx_line+67, 345, Gx_line+82, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV43fecha_baja, "XXXXXXXXXX")), 475, Gx_line+17, 528, Gx_line+33, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV45TTBUS_MotivoBaja, "@!")), 475, Gx_line+33, 736, Gx_line+49, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV51NumeroIdentificador, "")), 83, Gx_line+17, 225, Gx_line+33, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Nº Bien", 8, Gx_line+0, 47, Gx_line+15, 0+256) ;
            getPrinter().GxDrawText("Descripción", 367, Gx_line+0, 426, Gx_line+15, 0+256) ;
            getPrinter().GxDrawText("Alquilado", 8, Gx_line+33, 54, Gx_line+48, 0+256) ;
            getPrinter().GxDrawText("Datos del Movimiento", 475, Gx_line+67, 582, Gx_line+82, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV41lbl_fecBaja, "XXXXXXXXXXXXXXX")), 367, Gx_line+17, 446, Gx_line+33, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV42lbl_MotBaja, "XXXXXXXXXXXXXXXXXXXX")), 367, Gx_line+33, 472, Gx_line+49, 0+256) ;
            getPrinter().GxDrawText("Nº Etiqueta", 8, Gx_line+17, 65, Gx_line+32, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+86) ;
            /* Using cursor P00175 */
            pr_default.execute(3, new Object[] {AV33TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A25TTBUS2_RespHacia = P00175_A25TTBUS2_RespHacia[0] ;
               A24TTBUS2_RespDesde = P00175_A24TTBUS2_RespDesde[0] ;
               A49TTBUS2_CodPosHacia = P00175_A49TTBUS2_CodPosHacia[0] ;
               A48TTBUS2_CodPosDesde = P00175_A48TTBUS2_CodPosDesde[0] ;
               A22TTBUS2_IdBien = P00175_A22TTBUS2_IdBien[0] ;
               A47TTBUS2_MotivoEnvio = P00175_A47TTBUS2_MotivoEnvio[0] ;
               A45TTBUS2_FechaEnvio = P00175_A45TTBUS2_FechaEnvio[0] ;
               A46TTBUS2_FechaRecepcion = P00175_A46TTBUS2_FechaRecepcion[0] ;
               n46TTBUS2_FechaRecepcion = P00175_n46TTBUS2_FechaRecepcion[0] ;
               A26TTBUS2_EstadoEnvio = P00175_A26TTBUS2_EstadoEnvio[0] ;
               A50TTBUS2_MotivoCancelacion = P00175_A50TTBUS2_MotivoCancelacion[0] ;
               n50TTBUS2_MotivoCancelacion = P00175_n50TTBUS2_MotivoCancelacion[0] ;
               A52TTBUS2_IdMovimiento = P00175_A52TTBUS2_IdMovimiento[0] ;
               /* Using cursor P00176 */
               pr_default.execute(4, new Object[] {A48TTBUS2_CodPosDesde});
               while ( (pr_default.getStatus(4) != 101) )
               {
                  A33TTBUS7_Pos = P00176_A33TTBUS7_Pos[0] ;
                  A34TTBUS7_Des = P00176_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00176_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = P00176_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00176_n34TTBUS7_Des[0] ;
                  AV11dTTBUS7_Des = A34TTBUS7_Des ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(4);
               /* Using cursor P00177 */
               pr_default.execute(5, new Object[] {A49TTBUS2_CodPosHacia});
               while ( (pr_default.getStatus(5) != 101) )
               {
                  A33TTBUS7_Pos = P00177_A33TTBUS7_Pos[0] ;
                  A34TTBUS7_Des = P00177_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00177_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = P00177_A34TTBUS7_Des[0] ;
                  n34TTBUS7_Des = P00177_n34TTBUS7_Des[0] ;
                  AV14hTTBUS7_Des = A34TTBUS7_Des ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(5);
               /* Using cursor P00178 */
               pr_default.execute(6, new Object[] {A24TTBUS2_RespDesde});
               while ( (pr_default.getStatus(6) != 101) )
               {
                  A6USU_COD = P00178_A6USU_COD[0] ;
                  A7USU_DES = P00178_A7USU_DES[0] ;
                  AV12dUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(6);
               /* Using cursor P00179 */
               pr_default.execute(7, new Object[] {A25TTBUS2_RespHacia});
               while ( (pr_default.getStatus(7) != 101) )
               {
                  A6USU_COD = P00179_A6USU_COD[0] ;
                  A7USU_DES = P00179_A7USU_DES[0] ;
                  AV15hUSU_DES = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(7);
               AV35TTBUS2_MotivoEnvio = A47TTBUS2_MotivoEnvio ;
               AV31TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
               AV32TTBUS2_FechaRecepcion = A46TTBUS2_FechaRecepcion ;
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
               H170( false, 90) ;
               getPrinter().GxDrawLine(475, Gx_line+83, 1133, Gx_line+83, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Resp. Envío:", 475, Gx_line+0, 542, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText("Resp. Recepción:", 475, Gx_line+17, 566, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Motivo Envío:", 475, Gx_line+33, 546, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Fecha Envío:", 868, Gx_line+0, 937, Gx_line+15, 0+256) ;
               getPrinter().GxDrawText("Fecha Recepción:", 868, Gx_line+17, 961, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Estado Envío:", 475, Gx_line+50, 547, Gx_line+65, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV16lbl_motivoBaja, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 475, Gx_line+67, 592, Gx_line+83, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV11dTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 8, Gx_line+0, 233, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14hTTBUS7_Des, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 242, Gx_line+0, 467, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV12dUSU_DES, "@!")), 600, Gx_line+0, 861, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV15hUSU_DES, "@!")), 600, Gx_line+17, 861, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV35TTBUS2_MotivoEnvio, "@!")), 600, Gx_line+33, 1122, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV13estado, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 600, Gx_line+50, 757, Gx_line+66, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV34TTBUS2_MotivoCancelacion, "@!")), 600, Gx_line+67, 1122, Gx_line+83, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV31TTBUS2_FechaEnvio, "99/99/9999 99:99"), 968, Gx_line+0, 1061, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV32TTBUS2_FechaRecepcion, "99/99/99 99:99"), 968, Gx_line+17, 1048, Gx_line+33, 2+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+90) ;
               pr_default.readNext(3);
            }
            pr_default.close(3);
         }
         H170( false, 25) ;
         getPrinter().GxDrawRect(8, Gx_line+5, 1133, Gx_line+15, 1, 255, 255, 255, 1, 192, 192, 192, 0, 0, 0, 0, 0, 0, 0, 0) ;
         Gx_OldLine = Gx_line ;
         Gx_line = (int)(Gx_line+25) ;
      }

      protected void H170( bool bFoot ,
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
               Gx_line = (int)(Gx_line+99) ;
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
         P00172_A35TTBUS7_CodResp = new String[] {""} ;
         P00172_n35TTBUS7_CodResp = new bool[] {false} ;
         P00172_A14IdIdentificador = new int[1] ;
         P00172_A37TTBUS_CodPosicion = new short[1] ;
         P00172_A29TTBUS_Alquilado = new short[1] ;
         P00172_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         P00172_n16TTBUS_FechaBaja = new bool[] {false} ;
         P00172_A43TTBUS_MotivoBaja = new String[] {""} ;
         P00172_n43TTBUS_MotivoBaja = new bool[] {false} ;
         P00172_A12TTBUS_Descripcion = new String[] {""} ;
         P00172_A15NumeroIdentificador = new String[] {""} ;
         P00172_A23TTBUS_Estado = new short[1] ;
         P00172_A11TTBUS_Id = new int[1] ;
         A35TTBUS7_CodResp = "" ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A43TTBUS_MotivoBaja = "" ;
         A12TTBUS_Descripcion = "" ;
         A15NumeroIdentificador = "" ;
         AV48TTBUS_FechaBaja = DateTime.MinValue ;
         AV49tTTBUS_MotivoBaja = "" ;
         AV50tTTBUS_Descripcion = "" ;
         AV51NumeroIdentificador = "" ;
         P00173_A33TTBUS7_Pos = new short[1] ;
         P00174_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00174_A22TTBUS2_IdBien = new int[1] ;
         P00174_A24TTBUS2_RespDesde = new String[] {""} ;
         P00174_A25TTBUS2_RespHacia = new String[] {""} ;
         P00174_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         AV41lbl_fecBaja = "" ;
         AV42lbl_MotBaja = "" ;
         AV43fecha_baja = "" ;
         AV45TTBUS_MotivoBaja = "" ;
         P00175_A25TTBUS2_RespHacia = new String[] {""} ;
         P00175_A24TTBUS2_RespDesde = new String[] {""} ;
         P00175_A49TTBUS2_CodPosHacia = new short[1] ;
         P00175_A48TTBUS2_CodPosDesde = new short[1] ;
         P00175_A22TTBUS2_IdBien = new int[1] ;
         P00175_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         P00175_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P00175_A46TTBUS2_FechaRecepcion = new DateTime[] {DateTime.MinValue} ;
         P00175_n46TTBUS2_FechaRecepcion = new bool[] {false} ;
         P00175_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00175_A50TTBUS2_MotivoCancelacion = new String[] {""} ;
         P00175_n50TTBUS2_MotivoCancelacion = new bool[] {false} ;
         P00175_A52TTBUS2_IdMovimiento = new long[1] ;
         A47TTBUS2_MotivoEnvio = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A46TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         A50TTBUS2_MotivoCancelacion = "" ;
         P00176_A33TTBUS7_Pos = new short[1] ;
         P00176_A34TTBUS7_Des = new String[] {""} ;
         P00176_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         AV11dTTBUS7_Des = "" ;
         P00177_A33TTBUS7_Pos = new short[1] ;
         P00177_A34TTBUS7_Des = new String[] {""} ;
         P00177_n34TTBUS7_Des = new bool[] {false} ;
         AV14hTTBUS7_Des = "" ;
         P00178_A6USU_COD = new String[] {""} ;
         P00178_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         AV12dUSU_DES = "" ;
         P00179_A6USU_COD = new String[] {""} ;
         P00179_A7USU_DES = new String[] {""} ;
         AV15hUSU_DES = "" ;
         AV35TTBUS2_MotivoEnvio = "" ;
         AV31TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV32TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         AV13estado = "" ;
         AV16lbl_motivoBaja = "" ;
         AV34TTBUS2_MotivoCancelacion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus013__default(),
            new Object[][] {
                new Object[] {
               P00172_A35TTBUS7_CodResp, P00172_n35TTBUS7_CodResp, P00172_A14IdIdentificador, P00172_A37TTBUS_CodPosicion, P00172_A29TTBUS_Alquilado, P00172_A16TTBUS_FechaBaja, P00172_n16TTBUS_FechaBaja, P00172_A43TTBUS_MotivoBaja, P00172_n43TTBUS_MotivoBaja, P00172_A12TTBUS_Descripcion,
               P00172_A15NumeroIdentificador, P00172_A23TTBUS_Estado, P00172_A11TTBUS_Id
               }
               , new Object[] {
               P00173_A33TTBUS7_Pos
               }
               , new Object[] {
               P00174_A26TTBUS2_EstadoEnvio, P00174_A22TTBUS2_IdBien, P00174_A24TTBUS2_RespDesde, P00174_A25TTBUS2_RespHacia, P00174_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00175_A25TTBUS2_RespHacia, P00175_A24TTBUS2_RespDesde, P00175_A49TTBUS2_CodPosHacia, P00175_A48TTBUS2_CodPosDesde, P00175_A22TTBUS2_IdBien, P00175_A47TTBUS2_MotivoEnvio, P00175_A45TTBUS2_FechaEnvio, P00175_A46TTBUS2_FechaRecepcion, P00175_n46TTBUS2_FechaRecepcion, P00175_A26TTBUS2_EstadoEnvio,
               P00175_A50TTBUS2_MotivoCancelacion, P00175_n50TTBUS2_MotivoCancelacion, P00175_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00176_A33TTBUS7_Pos, P00176_A34TTBUS7_Des, P00176_n34TTBUS7_Des
               }
               , new Object[] {
               P00177_A33TTBUS7_Pos, P00177_A34TTBUS7_Des, P00177_n34TTBUS7_Des
               }
               , new Object[] {
               P00178_A6USU_COD, P00178_A7USU_DES
               }
               , new Object[] {
               P00179_A6USU_COD, P00179_A7USU_DES
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
      private short A49TTBUS2_CodPosHacia ;
      private short A48TTBUS2_CodPosDesde ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int AV28TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private int AV33TTBUS2_IdBien ;
      private int Gx_OldLine ;
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
      private String AV41lbl_fecBaja ;
      private String AV42lbl_MotBaja ;
      private String AV43fecha_baja ;
      private String A34TTBUS7_Des ;
      private String AV11dTTBUS7_Des ;
      private String AV14hTTBUS7_Des ;
      private String A6USU_COD ;
      private String A7USU_DES ;
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
      private DateTime AV48TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n35TTBUS7_CodResp ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool returnInSub ;
      private bool n46TTBUS2_FechaRecepcion ;
      private bool n50TTBUS2_MotivoCancelacion ;
      private bool n34TTBUS7_Des ;
      private String A43TTBUS_MotivoBaja ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV49tTTBUS_MotivoBaja ;
      private String AV50tTTBUS_Descripcion ;
      private String AV51NumeroIdentificador ;
      private String AV26TTBUS_Descripcion ;
      private String AV45TTBUS_MotivoBaja ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A50TTBUS2_MotivoCancelacion ;
      private String AV35TTBUS2_MotivoEnvio ;
      private String AV34TTBUS2_MotivoCancelacion ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private IDataStoreProvider pr_default ;
      private String[] P00172_A35TTBUS7_CodResp ;
      private bool[] P00172_n35TTBUS7_CodResp ;
      private int[] P00172_A14IdIdentificador ;
      private short[] P00172_A37TTBUS_CodPosicion ;
      private short[] P00172_A29TTBUS_Alquilado ;
      private DateTime[] P00172_A16TTBUS_FechaBaja ;
      private bool[] P00172_n16TTBUS_FechaBaja ;
      private String[] P00172_A43TTBUS_MotivoBaja ;
      private bool[] P00172_n43TTBUS_MotivoBaja ;
      private String[] P00172_A12TTBUS_Descripcion ;
      private String[] P00172_A15NumeroIdentificador ;
      private short[] P00172_A23TTBUS_Estado ;
      private int[] P00172_A11TTBUS_Id ;
      private short[] P00173_A33TTBUS7_Pos ;
      private short[] P00174_A26TTBUS2_EstadoEnvio ;
      private int[] P00174_A22TTBUS2_IdBien ;
      private String[] P00174_A24TTBUS2_RespDesde ;
      private String[] P00174_A25TTBUS2_RespHacia ;
      private long[] P00174_A52TTBUS2_IdMovimiento ;
      private String[] P00175_A25TTBUS2_RespHacia ;
      private String[] P00175_A24TTBUS2_RespDesde ;
      private short[] P00175_A49TTBUS2_CodPosHacia ;
      private short[] P00175_A48TTBUS2_CodPosDesde ;
      private int[] P00175_A22TTBUS2_IdBien ;
      private String[] P00175_A47TTBUS2_MotivoEnvio ;
      private DateTime[] P00175_A45TTBUS2_FechaEnvio ;
      private DateTime[] P00175_A46TTBUS2_FechaRecepcion ;
      private bool[] P00175_n46TTBUS2_FechaRecepcion ;
      private short[] P00175_A26TTBUS2_EstadoEnvio ;
      private String[] P00175_A50TTBUS2_MotivoCancelacion ;
      private bool[] P00175_n50TTBUS2_MotivoCancelacion ;
      private long[] P00175_A52TTBUS2_IdMovimiento ;
      private short[] P00176_A33TTBUS7_Pos ;
      private String[] P00176_A34TTBUS7_Des ;
      private bool[] P00176_n34TTBUS7_Des ;
      private short[] P00177_A33TTBUS7_Pos ;
      private String[] P00177_A34TTBUS7_Des ;
      private bool[] P00177_n34TTBUS7_Des ;
      private String[] P00178_A6USU_COD ;
      private String[] P00178_A7USU_DES ;
      private String[] P00179_A6USU_COD ;
      private String[] P00179_A7USU_DES ;
   }

   public class aptbus013__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00172( short AV47TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion ,
                                             int A14IdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T3.[TTBUS7_CodResp], T1.[IdIdentificador], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T2.[TTBUS_Alquilado], T2.[TTBUS_FechaBaja], T2.[TTBUS_MotivoBaja], T2.[TTBUS_Descripcion], T1.[NumeroIdentificador], T2.[TTBUS_Estado], T1.[TTBUS_Id] FROM (([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) INNER JOIN [TTBUS007] T3 WITH (NOLOCK) ON T3.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[IdIdentificador] = 1)" ;
         if ( AV47TTBUS7_Pos != 0 )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_CodPosicion] = @AV47TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int1[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador]" ;
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
                     return conditional_P00172( (short)dynConstraints[0] , (short)dynConstraints[1] , (int)dynConstraints[2] );
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
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00173 ;
          prmP00173 = new Object[] {
          new Object[] {"@AV24TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00174 ;
          prmP00174 = new Object[] {
          new Object[] {"@AV28TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00175 ;
          prmP00175 = new Object[] {
          new Object[] {"@AV33TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00176 ;
          prmP00176 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00177 ;
          prmP00177 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00178 ;
          prmP00178 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00179 ;
          prmP00179 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP00172 ;
          prmP00172 = new Object[] {
          new Object[] {"@AV47TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00172", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00172,100,0,true,false )
             ,new CursorDef("P00173", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV24TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00173,1,0,true,true )
             ,new CursorDef("P00174", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV28TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00174,100,0,true,false )
             ,new CursorDef("P00175", "SELECT [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_IdBien], [TTBUS2_MotivoEnvio], [TTBUS2_FechaEnvio], [TTBUS2_FechaRecepcion], [TTBUS2_EstadoEnvio], [TTBUS2_MotivoCancelacion], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_IdBien] = @AV33TTBUS2_IdBien ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00175,100,0,true,false )
             ,new CursorDef("P00176", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosDesde ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00176,1,0,false,true )
             ,new CursorDef("P00177", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE T1.[TTBUS7_Pos] = @TTBUS2_CodPosHacia ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00177,1,0,false,true )
             ,new CursorDef("P00178", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00178,1,0,false,true )
             ,new CursorDef("P00179", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00179,1,0,false,true )
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((short[]) buf[3])[0] = rslt.getShort(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(8) ;
                ((short[]) buf[11])[0] = rslt.getShort(9) ;
                ((int[]) buf[12])[0] = rslt.getInt(10) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(8);
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(10);
                ((long[]) buf[12])[0] = rslt.getLong(11) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
