/*
               File: PTBUS035
        Description: Listado de Asociaciones de Bienes de Uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:23.70
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
   public class aptbus035 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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

      public aptbus035( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus035( IGxContext context )
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
         aptbus035 objaptbus035;
         objaptbus035 = new aptbus035();
         objaptbus035.AV17NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus035.AV40USUARIO = aP1_USUARIO;
         objaptbus035.AV47TTBUS7_Pos = aP2_TTBUS7_Pos;
         objaptbus035.AV46TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objaptbus035.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus035.executePrivateCatch ));
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
            /* Using cursor P001H2 */
            pr_default.execute(0, new Object[] {AV47TTBUS7_Pos});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A14IdIdentificador = P001H2_A14IdIdentificador[0] ;
               A37TTBUS_CodPosicion = P001H2_A37TTBUS_CodPosicion[0] ;
               A29TTBUS_Alquilado = P001H2_A29TTBUS_Alquilado[0] ;
               A16TTBUS_FechaBaja = P001H2_A16TTBUS_FechaBaja[0] ;
               n16TTBUS_FechaBaja = P001H2_n16TTBUS_FechaBaja[0] ;
               A43TTBUS_MotivoBaja = P001H2_A43TTBUS_MotivoBaja[0] ;
               n43TTBUS_MotivoBaja = P001H2_n43TTBUS_MotivoBaja[0] ;
               A12TTBUS_Descripcion = P001H2_A12TTBUS_Descripcion[0] ;
               A15NumeroIdentificador = P001H2_A15NumeroIdentificador[0] ;
               A23TTBUS_Estado = P001H2_A23TTBUS_Estado[0] ;
               A11TTBUS_Id = P001H2_A11TTBUS_Id[0] ;
               A37TTBUS_CodPosicion = P001H2_A37TTBUS_CodPosicion[0] ;
               A29TTBUS_Alquilado = P001H2_A29TTBUS_Alquilado[0] ;
               A16TTBUS_FechaBaja = P001H2_A16TTBUS_FechaBaja[0] ;
               n16TTBUS_FechaBaja = P001H2_n16TTBUS_FechaBaja[0] ;
               A43TTBUS_MotivoBaja = P001H2_A43TTBUS_MotivoBaja[0] ;
               n43TTBUS_MotivoBaja = P001H2_n43TTBUS_MotivoBaja[0] ;
               A12TTBUS_Descripcion = P001H2_A12TTBUS_Descripcion[0] ;
               A23TTBUS_Estado = P001H2_A23TTBUS_Estado[0] ;
               AV24TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
               AV23TTBUS_Alquilado = A29TTBUS_Alquilado ;
               AV48TTBUS_FechaBaja = A16TTBUS_FechaBaja ;
               AV49tTTBUS_MotivoBaja = A43TTBUS_MotivoBaja ;
               AV28TTBUS_Id = A11TTBUS_Id ;
               AV50tTTBUS_Descripcion = A12TTBUS_Descripcion ;
               AV62NumeroIdentificador = A15NumeroIdentificador ;
               if ( StringUtil.StrCmp(StringUtil.Trim( AV46TTBUS7_CodResp), "") != 0 )
               {
                  if ( A23TTBUS_Estado == 1 )
                  {
                     /* Using cursor P001H3 */
                     pr_default.execute(1, new Object[] {AV24TTBUS_CodPosicion});
                     while ( (pr_default.getStatus(1) != 101) )
                     {
                        A33TTBUS7_Pos = P001H3_A33TTBUS7_Pos[0] ;
                        A35TTBUS7_CodResp = P001H3_A35TTBUS7_CodResp[0] ;
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
                     /* Using cursor P001H4 */
                     pr_default.execute(2, new Object[] {AV28TTBUS_Id});
                     while ( (pr_default.getStatus(2) != 101) )
                     {
                        A26TTBUS2_EstadoEnvio = P001H4_A26TTBUS2_EstadoEnvio[0] ;
                        A22TTBUS2_IdBien = P001H4_A22TTBUS2_IdBien[0] ;
                        A24TTBUS2_RespDesde = P001H4_A24TTBUS2_RespDesde[0] ;
                        A25TTBUS2_RespHacia = P001H4_A25TTBUS2_RespHacia[0] ;
                        A52TTBUS2_IdMovimiento = P001H4_A52TTBUS2_IdMovimiento[0] ;
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
            H1H0( true, 0) ;
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
            H1H0( false, 110) ;
            getPrinter().GxDrawLine(8, Gx_line+100, 1150, Gx_line+100, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28TTBUS_Id), "ZZZZZZZ9")), 83, Gx_line+0, 134, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV26TTBUS_Descripcion, "@!")), 83, Gx_line+17, 344, Gx_line+33, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV9alquilado, "XXXXX")), 83, Gx_line+33, 141, Gx_line+49, 0+256) ;
            getPrinter().GxDrawText("Cod. Emp.", 275, Gx_line+83, 327, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV43fecha_baja, "XXXXXXXXXX")), 475, Gx_line+0, 528, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV45TTBUS_MotivoBaja, "@!")), 475, Gx_line+17, 736, Gx_line+33, 0+256) ;
            getPrinter().GxDrawText("Cod. Rubro", 342, Gx_line+83, 399, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Cod. Bien", 417, Gx_line+83, 466, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Nº Partida", 483, Gx_line+83, 534, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Nº Asociación", 25, Gx_line+83, 96, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Sistema", 108, Gx_line+83, 148, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Id. Hardware", 550, Gx_line+83, 615, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Usuario", 633, Gx_line+83, 672, Gx_line+98, 0+256) ;
            getPrinter().GxDrawText("Fecha Asociación", 900, Gx_line+67, 990, Gx_line+82, 0+256) ;
            getPrinter().GxDrawText("Máq. Asociación", 1017, Gx_line+67, 1100, Gx_line+82, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV62NumeroIdentificador, "")), 83, Gx_line+50, 200, Gx_line+66, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Nº Bien", 8, Gx_line+0, 47, Gx_line+15, 0+256) ;
            getPrinter().GxDrawText("Descripción", 8, Gx_line+17, 67, Gx_line+32, 0+256) ;
            getPrinter().GxDrawText("Alquilado", 8, Gx_line+33, 54, Gx_line+48, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV41lbl_fecBaja, "XXXXXXXXXXXXXXX")), 367, Gx_line+0, 446, Gx_line+16, 0+256) ;
            getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV42lbl_MotBaja, "XXXXXXXXXXXXXXXXXXXX")), 367, Gx_line+17, 472, Gx_line+33, 0+256) ;
            getPrinter().GxDrawText("Nº Etiqueta", 8, Gx_line+50, 65, Gx_line+65, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+110) ;
            /* Using cursor P001H5 */
            pr_default.execute(3, new Object[] {AV33TTBUS2_IdBien});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A105TTBUS3_IdBien = P001H5_A105TTBUS3_IdBien[0] ;
               A106TTBUS3_NroAsoc = P001H5_A106TTBUS3_NroAsoc[0] ;
               A107TTBUS3_Sist = P001H5_A107TTBUS3_Sist[0] ;
               A108TTBUS3_HdwId = P001H5_A108TTBUS3_HdwId[0] ;
               n108TTBUS3_HdwId = P001H5_n108TTBUS3_HdwId[0] ;
               A109TTBUS3_BusEmp = P001H5_A109TTBUS3_BusEmp[0] ;
               n109TTBUS3_BusEmp = P001H5_n109TTBUS3_BusEmp[0] ;
               A110TTBUS3_BusRub = P001H5_A110TTBUS3_BusRub[0] ;
               n110TTBUS3_BusRub = P001H5_n110TTBUS3_BusRub[0] ;
               A111TTBUS3_BusCod = P001H5_A111TTBUS3_BusCod[0] ;
               n111TTBUS3_BusCod = P001H5_n111TTBUS3_BusCod[0] ;
               A112TTBUS3_BusPar = P001H5_A112TTBUS3_BusPar[0] ;
               n112TTBUS3_BusPar = P001H5_n112TTBUS3_BusPar[0] ;
               A113TTBUS3_Usuario = P001H5_A113TTBUS3_Usuario[0] ;
               A114TTBUS3_FechaAsoc = P001H5_A114TTBUS3_FechaAsoc[0] ;
               A115TTBUS3_MaquinaAsoc = P001H5_A115TTBUS3_MaquinaAsoc[0] ;
               AV60TTBUS3_NroAsoc = A106TTBUS3_NroAsoc ;
               if ( A107TTBUS3_Sist == 1 )
               {
                  AV51desc_sist = "Trazabilidad Bs. Uso" ;
               }
               else if ( A107TTBUS3_Sist == 2 )
               {
                  AV51desc_sist = "Bienes de Uso - Contabilidad" ;
               }
               else if ( A107TTBUS3_Sist == 3 )
               {
                  AV51desc_sist = "Hardware" ;
               }
               AV52TTBUS3_HdwId = A108TTBUS3_HdwId ;
               AV53TTBUS3_BusEmp = A109TTBUS3_BusEmp ;
               AV54TTBUS3_BusRub = A110TTBUS3_BusRub ;
               AV55TTBUS3_BusCod = A111TTBUS3_BusCod ;
               AV56TTBUS3_BusPar = A112TTBUS3_BusPar ;
               AV57TTBUS3_Usuario = A113TTBUS3_Usuario ;
               /* Execute user subroutine: S126 */
               S126 ();
               if ( returnInSub )
               {
                  pr_default.close(3);
                  returnInSub = true;
                  if (true) return;
               }
               AV58TTBUS3_FechaAsoc = A114TTBUS3_FechaAsoc ;
               AV59TTBUS3_MaquinaAsoc = A115TTBUS3_MaquinaAsoc ;
               H1H0( false, 19) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV52TTBUS3_HdwId), "ZZZ9")), 567, Gx_line+0, 593, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV53TTBUS3_BusEmp, "X")), 292, Gx_line+0, 304, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV54TTBUS3_BusRub), "ZZZ9")), 358, Gx_line+0, 384, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV55TTBUS3_BusCod), "ZZZ9")), 425, Gx_line+0, 451, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV56TTBUS3_BusPar), "Z9")), 500, Gx_line+0, 514, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV58TTBUS3_FechaAsoc, "99/99/9999 99:99"), 900, Gx_line+0, 993, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV59TTBUS3_MaquinaAsoc, "XXXXXXXXXXXXXXXXXXXX")), 1017, Gx_line+0, 1122, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV60TTBUS3_NroAsoc), "ZZZZZZZ9")), 33, Gx_line+0, 84, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV51desc_sist, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 108, Gx_line+0, 265, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV61USU_DES, "@!")), 633, Gx_line+0, 894, Gx_line+16, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+19) ;
               pr_default.readNext(3);
            }
            pr_default.close(3);
            H1H0( false, 36) ;
            getPrinter().GxDrawLine(33, Gx_line+17, 1125, Gx_line+17, 1, 0, 0, 0, 0) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+36) ;
         }
      }

      protected void S126( )
      {
         /* 'USUARIO' Routine */
         AV61USU_DES = "" ;
         /* Using cursor P001H6 */
         pr_default.execute(4, new Object[] {AV57TTBUS3_Usuario});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A6USU_COD = P001H6_A6USU_COD[0] ;
            A7USU_DES = P001H6_A7USU_DES[0] ;
            AV61USU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
      }

      protected void H1H0( bool bFoot ,
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
               getPrinter().GxDrawText("LISTADO DE MOVIMIENTOS DE BIEN DE USO", 400, Gx_line+50, 774, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 408, Gx_line+17, 764, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+85) ;
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
         P001H2_A14IdIdentificador = new int[1] ;
         P001H2_A37TTBUS_CodPosicion = new short[1] ;
         P001H2_A29TTBUS_Alquilado = new short[1] ;
         P001H2_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         P001H2_n16TTBUS_FechaBaja = new bool[] {false} ;
         P001H2_A43TTBUS_MotivoBaja = new String[] {""} ;
         P001H2_n43TTBUS_MotivoBaja = new bool[] {false} ;
         P001H2_A12TTBUS_Descripcion = new String[] {""} ;
         P001H2_A15NumeroIdentificador = new String[] {""} ;
         P001H2_A23TTBUS_Estado = new short[1] ;
         P001H2_A11TTBUS_Id = new int[1] ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A43TTBUS_MotivoBaja = "" ;
         A12TTBUS_Descripcion = "" ;
         A15NumeroIdentificador = "" ;
         AV48TTBUS_FechaBaja = DateTime.MinValue ;
         AV49tTTBUS_MotivoBaja = "" ;
         AV50tTTBUS_Descripcion = "" ;
         AV62NumeroIdentificador = "" ;
         P001H3_A33TTBUS7_Pos = new short[1] ;
         P001H3_A35TTBUS7_CodResp = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         P001H4_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001H4_A22TTBUS2_IdBien = new int[1] ;
         P001H4_A24TTBUS2_RespDesde = new String[] {""} ;
         P001H4_A25TTBUS2_RespHacia = new String[] {""} ;
         P001H4_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         AV26TTBUS_Descripcion = "" ;
         AV9alquilado = "" ;
         AV41lbl_fecBaja = "" ;
         AV42lbl_MotBaja = "" ;
         AV43fecha_baja = "" ;
         AV45TTBUS_MotivoBaja = "" ;
         P001H5_A105TTBUS3_IdBien = new int[1] ;
         P001H5_A106TTBUS3_NroAsoc = new int[1] ;
         P001H5_A107TTBUS3_Sist = new short[1] ;
         P001H5_A108TTBUS3_HdwId = new short[1] ;
         P001H5_n108TTBUS3_HdwId = new bool[] {false} ;
         P001H5_A109TTBUS3_BusEmp = new String[] {""} ;
         P001H5_n109TTBUS3_BusEmp = new bool[] {false} ;
         P001H5_A110TTBUS3_BusRub = new short[1] ;
         P001H5_n110TTBUS3_BusRub = new bool[] {false} ;
         P001H5_A111TTBUS3_BusCod = new short[1] ;
         P001H5_n111TTBUS3_BusCod = new bool[] {false} ;
         P001H5_A112TTBUS3_BusPar = new short[1] ;
         P001H5_n112TTBUS3_BusPar = new bool[] {false} ;
         P001H5_A113TTBUS3_Usuario = new String[] {""} ;
         P001H5_A114TTBUS3_FechaAsoc = new DateTime[] {DateTime.MinValue} ;
         P001H5_A115TTBUS3_MaquinaAsoc = new String[] {""} ;
         A109TTBUS3_BusEmp = "" ;
         A113TTBUS3_Usuario = "" ;
         A114TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         A115TTBUS3_MaquinaAsoc = "" ;
         AV51desc_sist = "" ;
         AV53TTBUS3_BusEmp = "" ;
         AV57TTBUS3_Usuario = "" ;
         AV58TTBUS3_FechaAsoc = (DateTime)(DateTime.MinValue) ;
         AV59TTBUS3_MaquinaAsoc = "" ;
         AV61USU_DES = "" ;
         P001H6_A6USU_COD = new String[] {""} ;
         P001H6_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus035__default(),
            new Object[][] {
                new Object[] {
               P001H2_A14IdIdentificador, P001H2_A37TTBUS_CodPosicion, P001H2_A29TTBUS_Alquilado, P001H2_A16TTBUS_FechaBaja, P001H2_n16TTBUS_FechaBaja, P001H2_A43TTBUS_MotivoBaja, P001H2_n43TTBUS_MotivoBaja, P001H2_A12TTBUS_Descripcion, P001H2_A15NumeroIdentificador, P001H2_A23TTBUS_Estado,
               P001H2_A11TTBUS_Id
               }
               , new Object[] {
               P001H3_A33TTBUS7_Pos, P001H3_A35TTBUS7_CodResp
               }
               , new Object[] {
               P001H4_A26TTBUS2_EstadoEnvio, P001H4_A22TTBUS2_IdBien, P001H4_A24TTBUS2_RespDesde, P001H4_A25TTBUS2_RespHacia, P001H4_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001H5_A105TTBUS3_IdBien, P001H5_A106TTBUS3_NroAsoc, P001H5_A107TTBUS3_Sist, P001H5_A108TTBUS3_HdwId, P001H5_n108TTBUS3_HdwId, P001H5_A109TTBUS3_BusEmp, P001H5_n109TTBUS3_BusEmp, P001H5_A110TTBUS3_BusRub, P001H5_n110TTBUS3_BusRub, P001H5_A111TTBUS3_BusCod,
               P001H5_n111TTBUS3_BusCod, P001H5_A112TTBUS3_BusPar, P001H5_n112TTBUS3_BusPar, P001H5_A113TTBUS3_Usuario, P001H5_A114TTBUS3_FechaAsoc, P001H5_A115TTBUS3_MaquinaAsoc
               }
               , new Object[] {
               P001H6_A6USU_COD, P001H6_A7USU_DES
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
      private short A107TTBUS3_Sist ;
      private short A108TTBUS3_HdwId ;
      private short A110TTBUS3_BusRub ;
      private short A111TTBUS3_BusCod ;
      private short A112TTBUS3_BusPar ;
      private short AV52TTBUS3_HdwId ;
      private short AV54TTBUS3_BusRub ;
      private short AV55TTBUS3_BusCod ;
      private short AV56TTBUS3_BusPar ;
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
      private int A105TTBUS3_IdBien ;
      private int A106TTBUS3_NroAsoc ;
      private int AV60TTBUS3_NroAsoc ;
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
      private String A109TTBUS3_BusEmp ;
      private String A113TTBUS3_Usuario ;
      private String A115TTBUS3_MaquinaAsoc ;
      private String AV51desc_sist ;
      private String AV53TTBUS3_BusEmp ;
      private String AV57TTBUS3_Usuario ;
      private String AV59TTBUS3_MaquinaAsoc ;
      private String AV61USU_DES ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private DateTime AV8AHORA ;
      private DateTime A114TTBUS3_FechaAsoc ;
      private DateTime AV58TTBUS3_FechaAsoc ;
      private DateTime A16TTBUS_FechaBaja ;
      private DateTime AV48TTBUS_FechaBaja ;
      private bool entryPointCalled ;
      private bool n16TTBUS_FechaBaja ;
      private bool n43TTBUS_MotivoBaja ;
      private bool returnInSub ;
      private bool n108TTBUS3_HdwId ;
      private bool n109TTBUS3_BusEmp ;
      private bool n110TTBUS3_BusRub ;
      private bool n111TTBUS3_BusCod ;
      private bool n112TTBUS3_BusPar ;
      private String A43TTBUS_MotivoBaja ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV49tTTBUS_MotivoBaja ;
      private String AV50tTTBUS_Descripcion ;
      private String AV62NumeroIdentificador ;
      private String AV26TTBUS_Descripcion ;
      private String AV45TTBUS_MotivoBaja ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private IDataStoreProvider pr_default ;
      private int[] P001H2_A14IdIdentificador ;
      private short[] P001H2_A37TTBUS_CodPosicion ;
      private short[] P001H2_A29TTBUS_Alquilado ;
      private DateTime[] P001H2_A16TTBUS_FechaBaja ;
      private bool[] P001H2_n16TTBUS_FechaBaja ;
      private String[] P001H2_A43TTBUS_MotivoBaja ;
      private bool[] P001H2_n43TTBUS_MotivoBaja ;
      private String[] P001H2_A12TTBUS_Descripcion ;
      private String[] P001H2_A15NumeroIdentificador ;
      private short[] P001H2_A23TTBUS_Estado ;
      private int[] P001H2_A11TTBUS_Id ;
      private short[] P001H3_A33TTBUS7_Pos ;
      private String[] P001H3_A35TTBUS7_CodResp ;
      private short[] P001H4_A26TTBUS2_EstadoEnvio ;
      private int[] P001H4_A22TTBUS2_IdBien ;
      private String[] P001H4_A24TTBUS2_RespDesde ;
      private String[] P001H4_A25TTBUS2_RespHacia ;
      private long[] P001H4_A52TTBUS2_IdMovimiento ;
      private int[] P001H5_A105TTBUS3_IdBien ;
      private int[] P001H5_A106TTBUS3_NroAsoc ;
      private short[] P001H5_A107TTBUS3_Sist ;
      private short[] P001H5_A108TTBUS3_HdwId ;
      private bool[] P001H5_n108TTBUS3_HdwId ;
      private String[] P001H5_A109TTBUS3_BusEmp ;
      private bool[] P001H5_n109TTBUS3_BusEmp ;
      private short[] P001H5_A110TTBUS3_BusRub ;
      private bool[] P001H5_n110TTBUS3_BusRub ;
      private short[] P001H5_A111TTBUS3_BusCod ;
      private bool[] P001H5_n111TTBUS3_BusCod ;
      private short[] P001H5_A112TTBUS3_BusPar ;
      private bool[] P001H5_n112TTBUS3_BusPar ;
      private String[] P001H5_A113TTBUS3_Usuario ;
      private DateTime[] P001H5_A114TTBUS3_FechaAsoc ;
      private String[] P001H5_A115TTBUS3_MaquinaAsoc ;
      private String[] P001H6_A6USU_COD ;
      private String[] P001H6_A7USU_DES ;
   }

   public class aptbus035__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001H2( short AV47TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion ,
                                             int A14IdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T1.[IdIdentificador], T2.[TTBUS_CodPosicion], T2.[TTBUS_Alquilado], T2.[TTBUS_FechaBaja], T2.[TTBUS_MotivoBaja], T2.[TTBUS_Descripcion], T1.[NumeroIdentificador], T2.[TTBUS_Estado], T1.[TTBUS_Id] FROM ([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id])" ;
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
                     return conditional_P001H2( (short)dynConstraints[0] , (short)dynConstraints[1] , (int)dynConstraints[2] );
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
          Object[] prmP001H3 ;
          prmP001H3 = new Object[] {
          new Object[] {"@AV24TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001H4 ;
          prmP001H4 = new Object[] {
          new Object[] {"@AV28TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001H5 ;
          prmP001H5 = new Object[] {
          new Object[] {"@AV33TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001H6 ;
          prmP001H6 = new Object[] {
          new Object[] {"@AV57TTBUS3_Usuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001H2 ;
          prmP001H2 = new Object[] {
          new Object[] {"@AV47TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001H2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H2,100,0,true,false )
             ,new CursorDef("P001H3", "SELECT [TTBUS7_Pos], [TTBUS7_CodResp] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @AV24TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H3,1,0,true,true )
             ,new CursorDef("P001H4", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV28TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H4,100,0,true,false )
             ,new CursorDef("P001H5", "SELECT [TTBUS3_IdBien], [TTBUS3_NroAsoc], [TTBUS3_Sist], [TTBUS3_HdwId], [TTBUS3_BusEmp], [TTBUS3_BusRub], [TTBUS3_BusCod], [TTBUS3_BusPar], [TTBUS3_Usuario], [TTBUS3_FechaAsoc], [TTBUS3_MaquinaAsoc] FROM [TTBUS003] WITH (NOLOCK) WHERE [TTBUS3_IdBien] = @AV33TTBUS2_IdBien ORDER BY [TTBUS3_IdBien] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H5,100,0,true,false )
             ,new CursorDef("P001H6", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV57TTBUS3_Usuario ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001H6,1,0,false,true )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((int[]) buf[10])[0] = rslt.getInt(9) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((long[]) buf[4])[0] = rslt.getLong(5) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 1) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((short[]) buf[9])[0] = rslt.getShort(7) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((short[]) buf[11])[0] = rslt.getShort(8) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 16) ;
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 20) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
