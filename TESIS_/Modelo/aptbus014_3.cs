/*
               File: PTBUS014_3
        Description: Listado de bienes por posición (en pdf)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:40.44
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
   public class aptbus014_3 : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
                  AV29USUARIO = GetNextPar( ) ;
                  AV28TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV26TTBUS7_CodResp = GetNextPar( ) ;
                  AV20TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         executePrivate();
         cleanup();
      }

      public aptbus014_3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public aptbus014_3( IGxContext context )
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
                           ref String aP3_TTBUS7_CodResp ,
                           ref short aP4_TTBUS_RubroBien )
      {
         this.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV29USUARIO = aP1_USUARIO;
         this.AV28TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV26TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV29USUARIO;
         aP2_TTBUS7_Pos=this.AV28TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV26TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_NOMBRE_REPORTE ,
                               ref String aP1_USUARIO ,
                               ref short aP2_TTBUS7_Pos ,
                               ref String aP3_TTBUS7_CodResp )
      {
         this.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV29USUARIO = aP1_USUARIO;
         this.AV28TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV26TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV29USUARIO;
         aP2_TTBUS7_Pos=this.AV28TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV26TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
         return AV20TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref short aP2_TTBUS7_Pos ,
                                 ref String aP3_TTBUS7_CodResp ,
                                 ref short aP4_TTBUS_RubroBien )
      {
         aptbus014_3 objaptbus014_3;
         objaptbus014_3 = new aptbus014_3();
         objaptbus014_3.AV15NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objaptbus014_3.AV29USUARIO = aP1_USUARIO;
         objaptbus014_3.AV28TTBUS7_Pos = aP2_TTBUS7_Pos;
         objaptbus014_3.AV26TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objaptbus014_3.AV20TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         objaptbus014_3.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objaptbus014_3.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV15NOMBRE_REPORTE;
         aP1_USUARIO=this.AV29USUARIO;
         aP2_TTBUS7_Pos=this.AV28TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV26TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
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
            GxHdr3 = true ;
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV28TTBUS7_Pos ,
                                                 A37TTBUS_CodPosicion ,
                                                 A14IdIdentificador },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.INT
                                                 }
            });
            /* Using cursor P00182 */
            pr_default.execute(0, new Object[] {AV28TTBUS7_Pos});
            while ( (pr_default.getStatus(0) != 101) )
            {
               BRK183 = false ;
               A27TTBUS_CodProveedor = P00182_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P00182_n27TTBUS_CodProveedor[0] ;
               A31W53POS = P00182_A31W53POS[0] ;
               A35TTBUS7_CodResp = P00182_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00182_n35TTBUS7_CodResp[0] ;
               A17TTBUS_RubroBien = P00182_A17TTBUS_RubroBien[0] ;
               A14IdIdentificador = P00182_A14IdIdentificador[0] ;
               A249USU_MAIW = P00182_A249USU_MAIW[0] ;
               n249USU_MAIW = P00182_n249USU_MAIW[0] ;
               A180USU_INT = P00182_A180USU_INT[0] ;
               n180USU_INT = P00182_n180USU_INT[0] ;
               A155USU_CLA = P00182_A155USU_CLA[0] ;
               n155USU_CLA = P00182_n155USU_CLA[0] ;
               A32W53DES = P00182_A32W53DES[0] ;
               A36TTBUS7_DesResp = P00182_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00182_n36TTBUS7_DesResp[0] ;
               A23TTBUS_Estado = P00182_A23TTBUS_Estado[0] ;
               A11TTBUS_Id = P00182_A11TTBUS_Id[0] ;
               A15NumeroIdentificador = P00182_A15NumeroIdentificador[0] ;
               A30TTBUS_DesProveedor = P00182_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P00182_n30TTBUS_DesProveedor[0] ;
               A18TTBUS_RubroDesc = P00182_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P00182_n18TTBUS_RubroDesc[0] ;
               A12TTBUS_Descripcion = P00182_A12TTBUS_Descripcion[0] ;
               A13TTBUS_FechaCarga = P00182_A13TTBUS_FechaCarga[0] ;
               A37TTBUS_CodPosicion = P00182_A37TTBUS_CodPosicion[0] ;
               A38TTBUS_DesPosicion = P00182_A38TTBUS_DesPosicion[0] ;
               A27TTBUS_CodProveedor = P00182_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P00182_n27TTBUS_CodProveedor[0] ;
               A17TTBUS_RubroBien = P00182_A17TTBUS_RubroBien[0] ;
               A23TTBUS_Estado = P00182_A23TTBUS_Estado[0] ;
               A12TTBUS_Descripcion = P00182_A12TTBUS_Descripcion[0] ;
               A13TTBUS_FechaCarga = P00182_A13TTBUS_FechaCarga[0] ;
               A37TTBUS_CodPosicion = P00182_A37TTBUS_CodPosicion[0] ;
               A38TTBUS_DesPosicion = P00182_A38TTBUS_DesPosicion[0] ;
               A30TTBUS_DesProveedor = P00182_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P00182_n30TTBUS_DesProveedor[0] ;
               A18TTBUS_RubroDesc = P00182_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P00182_n18TTBUS_RubroDesc[0] ;
               A35TTBUS7_CodResp = P00182_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00182_n35TTBUS7_CodResp[0] ;
               A249USU_MAIW = P00182_A249USU_MAIW[0] ;
               n249USU_MAIW = P00182_n249USU_MAIW[0] ;
               A180USU_INT = P00182_A180USU_INT[0] ;
               n180USU_INT = P00182_n180USU_INT[0] ;
               A155USU_CLA = P00182_A155USU_CLA[0] ;
               n155USU_CLA = P00182_n155USU_CLA[0] ;
               A36TTBUS7_DesResp = P00182_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P00182_n36TTBUS7_DesResp[0] ;
               A32W53DES = P00182_A32W53DES[0] ;
               if ( A37TTBUS_CodPosicion == 0 )
               {
                  AV18TTBUS_DesPosicion = "SIN POSICIÓN POR CAMBIO DE SECTOR." ;
               }
               else
               {
                  AV18TTBUS_DesPosicion = A38TTBUS_DesPosicion ;
               }
               while ( (pr_default.getStatus(0) != 101) && ( P00182_A37TTBUS_CodPosicion[0] == A37TTBUS_CodPosicion ) )
               {
                  BRK183 = false ;
                  A27TTBUS_CodProveedor = P00182_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P00182_n27TTBUS_CodProveedor[0] ;
                  A31W53POS = P00182_A31W53POS[0] ;
                  A35TTBUS7_CodResp = P00182_A35TTBUS7_CodResp[0] ;
                  n35TTBUS7_CodResp = P00182_n35TTBUS7_CodResp[0] ;
                  A17TTBUS_RubroBien = P00182_A17TTBUS_RubroBien[0] ;
                  A14IdIdentificador = P00182_A14IdIdentificador[0] ;
                  A249USU_MAIW = P00182_A249USU_MAIW[0] ;
                  n249USU_MAIW = P00182_n249USU_MAIW[0] ;
                  A180USU_INT = P00182_A180USU_INT[0] ;
                  n180USU_INT = P00182_n180USU_INT[0] ;
                  A155USU_CLA = P00182_A155USU_CLA[0] ;
                  n155USU_CLA = P00182_n155USU_CLA[0] ;
                  A32W53DES = P00182_A32W53DES[0] ;
                  A36TTBUS7_DesResp = P00182_A36TTBUS7_DesResp[0] ;
                  n36TTBUS7_DesResp = P00182_n36TTBUS7_DesResp[0] ;
                  A23TTBUS_Estado = P00182_A23TTBUS_Estado[0] ;
                  A11TTBUS_Id = P00182_A11TTBUS_Id[0] ;
                  A15NumeroIdentificador = P00182_A15NumeroIdentificador[0] ;
                  A30TTBUS_DesProveedor = P00182_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P00182_n30TTBUS_DesProveedor[0] ;
                  A18TTBUS_RubroDesc = P00182_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P00182_n18TTBUS_RubroDesc[0] ;
                  A12TTBUS_Descripcion = P00182_A12TTBUS_Descripcion[0] ;
                  A13TTBUS_FechaCarga = P00182_A13TTBUS_FechaCarga[0] ;
                  A27TTBUS_CodProveedor = P00182_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P00182_n27TTBUS_CodProveedor[0] ;
                  A17TTBUS_RubroBien = P00182_A17TTBUS_RubroBien[0] ;
                  A23TTBUS_Estado = P00182_A23TTBUS_Estado[0] ;
                  A12TTBUS_Descripcion = P00182_A12TTBUS_Descripcion[0] ;
                  A13TTBUS_FechaCarga = P00182_A13TTBUS_FechaCarga[0] ;
                  A30TTBUS_DesProveedor = P00182_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P00182_n30TTBUS_DesProveedor[0] ;
                  A18TTBUS_RubroDesc = P00182_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P00182_n18TTBUS_RubroDesc[0] ;
                  A35TTBUS7_CodResp = P00182_A35TTBUS7_CodResp[0] ;
                  n35TTBUS7_CodResp = P00182_n35TTBUS7_CodResp[0] ;
                  A249USU_MAIW = P00182_A249USU_MAIW[0] ;
                  n249USU_MAIW = P00182_n249USU_MAIW[0] ;
                  A180USU_INT = P00182_A180USU_INT[0] ;
                  n180USU_INT = P00182_n180USU_INT[0] ;
                  A155USU_CLA = P00182_A155USU_CLA[0] ;
                  n155USU_CLA = P00182_n155USU_CLA[0] ;
                  A36TTBUS7_DesResp = P00182_A36TTBUS7_DesResp[0] ;
                  n36TTBUS7_DesResp = P00182_n36TTBUS7_DesResp[0] ;
                  A32W53DES = P00182_A32W53DES[0] ;
                  if ( A23TTBUS_Estado == 1 )
                  {
                     AV12estado = "ASIGNADO A UN SECTOR" ;
                  }
                  else if ( A23TTBUS_Estado == 2 )
                  {
                     AV12estado = "CAMBIANDO DE SECTOR" ;
                  }
                  AV19TTBUS_Id = A11TTBUS_Id ;
                  AV9band = 0 ;
                  new ptbus007(context ).execute( ref  AV9band,  AV19TTBUS_Id,  AV29USUARIO) ;
                  if ( A23TTBUS_Estado == 1 )
                  {
                     /* Using cursor P00183 */
                     pr_default.execute(1, new Object[] {A37TTBUS_CodPosicion});
                     while ( (pr_default.getStatus(1) != 101) )
                     {
                        A33TTBUS7_Pos = P00183_A33TTBUS7_Pos[0] ;
                        AV27TTBUS7_DesResp = A36TTBUS7_DesResp ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(1);
                     if ( AV9band == 1 )
                     {
                        H180( false, 39) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 567, Gx_line+0, 628, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 183, Gx_line+0, 433, Gx_line+16, 0) ;
                        getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 125, Gx_line+0, 176, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")), 842, Gx_line+0, 999, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 567, Gx_line+17, 724, Gx_line+33, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV27TTBUS7_DesResp, "@!")), 842, Gx_line+17, 1103, Gx_line+33, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 117, Gx_line+16, 0) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText("Responsable Actual:", 733, Gx_line+17, 836, Gx_line+32, 0+256) ;
                        getPrinter().GxDrawText("Proveedor:", 483, Gx_line+17, 538, Gx_line+32, 0+256) ;
                        getPrinter().GxDrawText("Fecha Carga", 483, Gx_line+0, 548, Gx_line+15, 0+256) ;
                        getPrinter().GxDrawText("Rubro", 733, Gx_line+0, 764, Gx_line+15, 0+256) ;
                        Gx_OldLine = Gx_line ;
                        Gx_line = (int)(Gx_line+39) ;
                     }
                  }
                  else
                  {
                     /* Using cursor P00184 */
                     pr_default.execute(2, new Object[] {AV19TTBUS_Id});
                     while ( (pr_default.getStatus(2) != 101) )
                     {
                        A26TTBUS2_EstadoEnvio = P00184_A26TTBUS2_EstadoEnvio[0] ;
                        A22TTBUS2_IdBien = P00184_A22TTBUS2_IdBien[0] ;
                        A24TTBUS2_RespDesde = P00184_A24TTBUS2_RespDesde[0] ;
                        A25TTBUS2_RespHacia = P00184_A25TTBUS2_RespHacia[0] ;
                        A48TTBUS2_CodPosDesde = P00184_A48TTBUS2_CodPosDesde[0] ;
                        A49TTBUS2_CodPosHacia = P00184_A49TTBUS2_CodPosHacia[0] ;
                        A45TTBUS2_FechaEnvio = P00184_A45TTBUS2_FechaEnvio[0] ;
                        A52TTBUS2_IdMovimiento = P00184_A52TTBUS2_IdMovimiento[0] ;
                        AV24TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                        AV25TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                        AV21TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
                        AV22TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
                        AV23TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                        /* Using cursor P00185 */
                        pr_default.execute(3, new Object[] {AV21TTBUS2_CodPosDesde, A32W53DES});
                        while ( (pr_default.getStatus(3) != 101) )
                        {
                           A31W53POS = P00185_A31W53POS[0] ;
                           AV11dW53DES = A32W53DES ;
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(3);
                        /* Using cursor P00186 */
                        pr_default.execute(4, new Object[] {AV22TTBUS2_CodPosHacia, A32W53DES});
                        while ( (pr_default.getStatus(4) != 101) )
                        {
                           A31W53POS = P00186_A31W53POS[0] ;
                           AV14hW53DES = A32W53DES ;
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(4);
                        /* Using cursor P00187 */
                        pr_default.execute(5, new Object[] {AV24TTBUS2_RespDesde, A7USU_DES, n155USU_CLA, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
                        while ( (pr_default.getStatus(5) != 101) )
                        {
                           A6USU_COD = P00187_A6USU_COD[0] ;
                           AV10dUSU_DES = A7USU_DES ;
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(5);
                        /* Using cursor P00188 */
                        pr_default.execute(6, new Object[] {AV25TTBUS2_RespHacia, A7USU_DES, n155USU_CLA, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
                        while ( (pr_default.getStatus(6) != 101) )
                        {
                           A6USU_COD = P00188_A6USU_COD[0] ;
                           AV13hUSU_DES = A7USU_DES ;
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(6);
                        pr_default.readNext(2);
                     }
                     pr_default.close(2);
                     if ( AV9band == 1 )
                     {
                        H180( false, 73) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A18TTBUS_RubroDesc, "@!")), 842, Gx_line+0, 999, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9")), 125, Gx_line+0, 176, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")), 183, Gx_line+0, 433, Gx_line+16, 0) ;
                        getPrinter().GxDrawText(context.localUtil.Format( A13TTBUS_FechaCarga, "99/99/9999"), 550, Gx_line+0, 611, Gx_line+16, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV11dW53DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+33, 811, Gx_line+49, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14hW53DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 883, Gx_line+33, 1144, Gx_line+49, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A30TTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 550, Gx_line+17, 707, Gx_line+33, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV10dUSU_DES, "@!")), 550, Gx_line+50, 811, Gx_line+66, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV13hUSU_DES, "@!")), 883, Gx_line+50, 1144, Gx_line+66, 0+256) ;
                        getPrinter().GxDrawText(context.localUtil.Format( AV23TTBUS2_FechaEnvio, "99/99/9999 99:99"), 842, Gx_line+17, 935, Gx_line+33, 0+256) ;
                        getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A15NumeroIdentificador, "")), 17, Gx_line+0, 117, Gx_line+16, 0) ;
                        getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                        getPrinter().GxDrawText("Fecha Carga", 483, Gx_line+0, 548, Gx_line+15, 0+256) ;
                        getPrinter().GxDrawText("Proveedor:", 483, Gx_line+17, 538, Gx_line+32, 0+256) ;
                        getPrinter().GxDrawText("Pos. Desde:", 483, Gx_line+33, 544, Gx_line+48, 0+256) ;
                        getPrinter().GxDrawText("Pos. Hacia:", 817, Gx_line+33, 875, Gx_line+48, 0+256) ;
                        getPrinter().GxDrawText("Resp. Env.:", 483, Gx_line+50, 542, Gx_line+65, 0+256) ;
                        getPrinter().GxDrawText("Resp. Rec.:", 817, Gx_line+50, 877, Gx_line+65, 0+256) ;
                        getPrinter().GxDrawText("Fecha Envío", 733, Gx_line+17, 799, Gx_line+32, 0+256) ;
                        getPrinter().GxDrawText("Rubro", 733, Gx_line+0, 764, Gx_line+15, 0+256) ;
                        Gx_OldLine = Gx_line ;
                        Gx_line = (int)(Gx_line+73) ;
                     }
                  }
                  H180( false, 20) ;
                  getPrinter().GxDrawLine(125, Gx_line+8, 1150, Gx_line+8, 1, 0, 0, 0, 0) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+20) ;
                  BRK183 = true ;
                  pr_default.readNext(0);
               }
               /* Eject command */
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(P_lines+1) ;
               if ( ! BRK183 )
               {
                  BRK183 = true ;
                  pr_default.readNext(0);
               }
            }
            pr_default.close(0);
            GxHdr3 = false ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H180( true, 0) ;
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

      protected void H180( bool bFoot ,
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
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(Gx_page), "ZZZZZ9")), 1075, Gx_line+33, 1114, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText("Página:", 1000, Gx_line+33, 1039, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Fecha y Hora:", 1000, Gx_line+17, 1071, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( AV8AHORA, "99/99/99 99:99"), 1075, Gx_line+17, 1155, Gx_line+33, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("LISTADO DE BIENES DE USO POR POSICIÓN", 400, Gx_line+50, 773, Gx_line+70, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 14, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("TRAZABILIDAD DE BIENES DE USO", 400, Gx_line+17, 756, Gx_line+43, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+98) ;
               if ( GxHdr3 )
               {
                  getPrinter().GxDrawLine(0, Gx_line+68, 1150, Gx_line+68, 2, 0, 0, 0, 0) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Nº Bien", 125, Gx_line+50, 164, Gx_line+65, 0+256) ;
                  getPrinter().GxDrawText("Descripción", 183, Gx_line+50, 242, Gx_line+65, 0+256) ;
                  getPrinter().GxDrawText("Otros Datos", 483, Gx_line+50, 542, Gx_line+65, 0+256) ;
                  getPrinter().GxDrawText("Nº Etiqueta", 17, Gx_line+50, 74, Gx_line+65, 0+256) ;
                  getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, true, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
                  getPrinter().GxDrawText("Posición:", 0, Gx_line+17, 62, Gx_line+34, 0+256) ;
                  getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV18TTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), 60, Gx_line+17, 374, Gx_line+35, 0+256) ;
                  Gx_OldLine = Gx_line ;
                  Gx_line = (int)(Gx_line+72) ;
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
         P00182_A27TTBUS_CodProveedor = new int[1] ;
         P00182_n27TTBUS_CodProveedor = new bool[] {false} ;
         P00182_A31W53POS = new short[1] ;
         P00182_A35TTBUS7_CodResp = new String[] {""} ;
         P00182_n35TTBUS7_CodResp = new bool[] {false} ;
         P00182_A17TTBUS_RubroBien = new short[1] ;
         P00182_A14IdIdentificador = new int[1] ;
         P00182_A249USU_MAIW = new String[] {""} ;
         P00182_n249USU_MAIW = new bool[] {false} ;
         P00182_A180USU_INT = new String[] {""} ;
         P00182_n180USU_INT = new bool[] {false} ;
         P00182_A155USU_CLA = new String[] {""} ;
         P00182_n155USU_CLA = new bool[] {false} ;
         P00182_A32W53DES = new String[] {""} ;
         P00182_A36TTBUS7_DesResp = new String[] {""} ;
         P00182_n36TTBUS7_DesResp = new bool[] {false} ;
         P00182_A23TTBUS_Estado = new short[1] ;
         P00182_A11TTBUS_Id = new int[1] ;
         P00182_A15NumeroIdentificador = new String[] {""} ;
         P00182_A30TTBUS_DesProveedor = new String[] {""} ;
         P00182_n30TTBUS_DesProveedor = new bool[] {false} ;
         P00182_A18TTBUS_RubroDesc = new String[] {""} ;
         P00182_n18TTBUS_RubroDesc = new bool[] {false} ;
         P00182_A12TTBUS_Descripcion = new String[] {""} ;
         P00182_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00182_A37TTBUS_CodPosicion = new short[1] ;
         P00182_A38TTBUS_DesPosicion = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         A249USU_MAIW = "" ;
         A180USU_INT = "" ;
         A155USU_CLA = "" ;
         A32W53DES = "" ;
         A36TTBUS7_DesResp = "" ;
         A15NumeroIdentificador = "" ;
         A30TTBUS_DesProveedor = "" ;
         A18TTBUS_RubroDesc = "" ;
         A12TTBUS_Descripcion = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         AV18TTBUS_DesPosicion = "" ;
         AV12estado = "" ;
         P00183_A33TTBUS7_Pos = new short[1] ;
         AV27TTBUS7_DesResp = "" ;
         P00184_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00184_A22TTBUS2_IdBien = new int[1] ;
         P00184_A24TTBUS2_RespDesde = new String[] {""} ;
         P00184_A25TTBUS2_RespHacia = new String[] {""} ;
         P00184_A48TTBUS2_CodPosDesde = new short[1] ;
         P00184_A49TTBUS2_CodPosHacia = new short[1] ;
         P00184_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P00184_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV24TTBUS2_RespDesde = "" ;
         AV25TTBUS2_RespHacia = "" ;
         AV23TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         P00185_A32W53DES = new String[] {""} ;
         P00185_A31W53POS = new short[1] ;
         AV11dW53DES = "" ;
         P00186_A32W53DES = new String[] {""} ;
         P00186_A31W53POS = new short[1] ;
         AV14hW53DES = "" ;
         A7USU_DES = "" ;
         P00187_A7USU_DES = new String[] {""} ;
         P00187_A155USU_CLA = new String[] {""} ;
         P00187_n155USU_CLA = new bool[] {false} ;
         P00187_A180USU_INT = new String[] {""} ;
         P00187_n180USU_INT = new bool[] {false} ;
         P00187_A249USU_MAIW = new String[] {""} ;
         P00187_n249USU_MAIW = new bool[] {false} ;
         P00187_A6USU_COD = new String[] {""} ;
         A6USU_COD = "" ;
         AV10dUSU_DES = "" ;
         P00188_A7USU_DES = new String[] {""} ;
         P00188_A155USU_CLA = new String[] {""} ;
         P00188_n155USU_CLA = new bool[] {false} ;
         P00188_A180USU_INT = new String[] {""} ;
         P00188_n180USU_INT = new bool[] {false} ;
         P00188_A249USU_MAIW = new String[] {""} ;
         P00188_n249USU_MAIW = new bool[] {false} ;
         P00188_A6USU_COD = new String[] {""} ;
         AV13hUSU_DES = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aptbus014_3__default(),
            new Object[][] {
                new Object[] {
               P00182_A27TTBUS_CodProveedor, P00182_n27TTBUS_CodProveedor, P00182_A31W53POS, P00182_A35TTBUS7_CodResp, P00182_n35TTBUS7_CodResp, P00182_A17TTBUS_RubroBien, P00182_A14IdIdentificador, P00182_A249USU_MAIW, P00182_n249USU_MAIW, P00182_A180USU_INT,
               P00182_n180USU_INT, P00182_A155USU_CLA, P00182_n155USU_CLA, P00182_A32W53DES, P00182_A36TTBUS7_DesResp, P00182_n36TTBUS7_DesResp, P00182_A23TTBUS_Estado, P00182_A11TTBUS_Id, P00182_A15NumeroIdentificador, P00182_A30TTBUS_DesProveedor,
               P00182_n30TTBUS_DesProveedor, P00182_A18TTBUS_RubroDesc, P00182_n18TTBUS_RubroDesc, P00182_A12TTBUS_Descripcion, P00182_A13TTBUS_FechaCarga, P00182_A37TTBUS_CodPosicion, P00182_A38TTBUS_DesPosicion
               }
               , new Object[] {
               P00183_A33TTBUS7_Pos
               }
               , new Object[] {
               P00184_A26TTBUS2_EstadoEnvio, P00184_A22TTBUS2_IdBien, P00184_A24TTBUS2_RespDesde, P00184_A25TTBUS2_RespHacia, P00184_A48TTBUS2_CodPosDesde, P00184_A49TTBUS2_CodPosHacia, P00184_A45TTBUS2_FechaEnvio, P00184_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00185_A32W53DES, P00185_A31W53POS
               }
               , new Object[] {
               P00186_A32W53DES, P00186_A31W53POS
               }
               , new Object[] {
               P00187_A7USU_DES, P00187_A155USU_CLA, P00187_A180USU_INT, P00187_n180USU_INT, P00187_A249USU_MAIW, P00187_n249USU_MAIW, P00187_A6USU_COD
               }
               , new Object[] {
               P00188_A7USU_DES, P00188_A155USU_CLA, P00188_A180USU_INT, P00188_n180USU_INT, P00188_A249USU_MAIW, P00188_n249USU_MAIW, P00188_A6USU_COD
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short AV28TTBUS7_Pos ;
      private short AV20TTBUS_RubroBien ;
      private short A37TTBUS_CodPosicion ;
      private short A31W53POS ;
      private short A17TTBUS_RubroBien ;
      private short A23TTBUS_Estado ;
      private short AV9band ;
      private short A33TTBUS7_Pos ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV21TTBUS2_CodPosDesde ;
      private short AV22TTBUS2_CodPosHacia ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A14IdIdentificador ;
      private int A27TTBUS_CodProveedor ;
      private int A11TTBUS_Id ;
      private int AV19TTBUS_Id ;
      private int Gx_OldLine ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String gxfirstwebparm ;
      private String AV15NOMBRE_REPORTE ;
      private String AV29USUARIO ;
      private String AV26TTBUS7_CodResp ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A180USU_INT ;
      private String A155USU_CLA ;
      private String A32W53DES ;
      private String A36TTBUS7_DesResp ;
      private String A30TTBUS_DesProveedor ;
      private String A18TTBUS_RubroDesc ;
      private String A38TTBUS_DesPosicion ;
      private String AV18TTBUS_DesPosicion ;
      private String AV12estado ;
      private String AV27TTBUS7_DesResp ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV24TTBUS2_RespDesde ;
      private String AV25TTBUS2_RespHacia ;
      private String AV11dW53DES ;
      private String AV14hW53DES ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String AV10dUSU_DES ;
      private String AV13hUSU_DES ;
      private DateTime AV8AHORA ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV23TTBUS2_FechaEnvio ;
      private DateTime A13TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool GxHdr3 ;
      private bool BRK183 ;
      private bool n27TTBUS_CodProveedor ;
      private bool n35TTBUS7_CodResp ;
      private bool n249USU_MAIW ;
      private bool n180USU_INT ;
      private bool n155USU_CLA ;
      private bool n36TTBUS7_DesResp ;
      private bool n30TTBUS_DesProveedor ;
      private bool n18TTBUS_RubroDesc ;
      private String A249USU_MAIW ;
      private String A15NumeroIdentificador ;
      private String A12TTBUS_Descripcion ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private short aP4_TTBUS_RubroBien ;
      private IDataStoreProvider pr_default ;
      private int[] P00182_A27TTBUS_CodProveedor ;
      private bool[] P00182_n27TTBUS_CodProveedor ;
      private short[] P00182_A31W53POS ;
      private String[] P00182_A35TTBUS7_CodResp ;
      private bool[] P00182_n35TTBUS7_CodResp ;
      private short[] P00182_A17TTBUS_RubroBien ;
      private int[] P00182_A14IdIdentificador ;
      private String[] P00182_A249USU_MAIW ;
      private bool[] P00182_n249USU_MAIW ;
      private String[] P00182_A180USU_INT ;
      private bool[] P00182_n180USU_INT ;
      private String[] P00182_A155USU_CLA ;
      private bool[] P00182_n155USU_CLA ;
      private String[] P00182_A32W53DES ;
      private String[] P00182_A36TTBUS7_DesResp ;
      private bool[] P00182_n36TTBUS7_DesResp ;
      private short[] P00182_A23TTBUS_Estado ;
      private int[] P00182_A11TTBUS_Id ;
      private String[] P00182_A15NumeroIdentificador ;
      private String[] P00182_A30TTBUS_DesProveedor ;
      private bool[] P00182_n30TTBUS_DesProveedor ;
      private String[] P00182_A18TTBUS_RubroDesc ;
      private bool[] P00182_n18TTBUS_RubroDesc ;
      private String[] P00182_A12TTBUS_Descripcion ;
      private DateTime[] P00182_A13TTBUS_FechaCarga ;
      private short[] P00182_A37TTBUS_CodPosicion ;
      private String[] P00182_A38TTBUS_DesPosicion ;
      private short[] P00183_A33TTBUS7_Pos ;
      private short[] P00184_A26TTBUS2_EstadoEnvio ;
      private int[] P00184_A22TTBUS2_IdBien ;
      private String[] P00184_A24TTBUS2_RespDesde ;
      private String[] P00184_A25TTBUS2_RespHacia ;
      private short[] P00184_A48TTBUS2_CodPosDesde ;
      private short[] P00184_A49TTBUS2_CodPosHacia ;
      private DateTime[] P00184_A45TTBUS2_FechaEnvio ;
      private long[] P00184_A52TTBUS2_IdMovimiento ;
      private String[] P00185_A32W53DES ;
      private short[] P00185_A31W53POS ;
      private String[] P00186_A32W53DES ;
      private short[] P00186_A31W53POS ;
      private String[] P00187_A7USU_DES ;
      private String[] P00187_A155USU_CLA ;
      private bool[] P00187_n155USU_CLA ;
      private String[] P00187_A180USU_INT ;
      private bool[] P00187_n180USU_INT ;
      private String[] P00187_A249USU_MAIW ;
      private bool[] P00187_n249USU_MAIW ;
      private String[] P00187_A6USU_COD ;
      private String[] P00188_A7USU_DES ;
      private String[] P00188_A155USU_CLA ;
      private bool[] P00188_n155USU_CLA ;
      private String[] P00188_A180USU_INT ;
      private bool[] P00188_n180USU_INT ;
      private String[] P00188_A249USU_MAIW ;
      private bool[] P00188_n249USU_MAIW ;
      private String[] P00188_A6USU_COD ;
   }

   public class aptbus014_3__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00182( short AV28TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion ,
                                             int A14IdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [1] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T7.[W53POS], T5.[TTBUS7_CodResp] AS TTBUS7_CodResp, T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T1.[IdIdentificador], T6.[USU_MAIW], T6.[USU_INT], T6.[USU_CLA], T7.[W53DES], T6.[USU_DES] AS TTBUS7_DesResp, T2.[TTBUS_Estado], T1.[TTBUS_Id], T1.[NumeroIdentificador], T3.[PV_DESC] AS TTBUS_DesProveedor, T4.[RBR_DES] AS TTBUS_RubroDesc, T2.[TTBUS_Descripcion], T2.[TTBUS_FechaCarga], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T2.[TTBUS_DesPosicion] FROM (((((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) INNER JOIN [TTBUS007] T5 WITH (NOLOCK) ON T5.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T6 WITH (NOLOCK) ON T6.[USU_COD] = T5.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T7 WITH (NOLOCK) ON T7.[W53POS] = T2.[TTBUS_CodPosicion])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[IdIdentificador] = 1)" ;
         if ( AV28TTBUS7_Pos != 0 )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_CodPosicion] = @AV28TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int1[0] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T2.[TTBUS_CodPosicion]" ;
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
                     return conditional_P00182( (short)dynConstraints[0] , (short)dynConstraints[1] , (int)dynConstraints[2] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00183 ;
          prmP00183 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00184 ;
          prmP00184 = new Object[] {
          new Object[] {"@AV19TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00185 ;
          prmP00185 = new Object[] {
          new Object[] {"@AV21TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@W53DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmP00186 ;
          prmP00186 = new Object[] {
          new Object[] {"@AV22TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@W53DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmP00187 ;
          prmP00187 = new Object[] {
          new Object[] {"@AV24TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP00188 ;
          prmP00188 = new Object[] {
          new Object[] {"@AV25TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP00182 ;
          prmP00182 = new Object[] {
          new Object[] {"@AV28TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00182", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00182,100,0,true,false )
             ,new CursorDef("P00183", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00183,1,0,false,true )
             ,new CursorDef("P00184", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia], [TTBUS2_FechaEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV19TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00184,100,0,true,false )
             ,new CursorDef("P00185", "SELECT [W53DES], [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ([W53POS] = @AV21TTBUS2_CodPosDesde) AND ([W53DES] = @W53DES) ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00185,1,0,false,true )
             ,new CursorDef("P00186", "SELECT [W53DES], [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ([W53POS] = @AV22TTBUS2_CodPosHacia) AND ([W53DES] = @W53DES) ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00186,1,0,false,true )
             ,new CursorDef("P00187", "SELECT [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW], [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ([USU_COD] = @AV24TTBUS2_RespDesde) AND ([USU_DES] = @USU_DES) AND ([USU_CLA] = @USU_CLA) AND ([USU_INT] = @USU_INT) AND ([USU_MAIW] = @USU_MAIW) ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00187,1,0,false,true )
             ,new CursorDef("P00188", "SELECT [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW], [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ([USU_COD] = @AV25TTBUS2_RespHacia) AND ([USU_DES] = @USU_DES) AND ([USU_CLA] = @USU_CLA) AND ([USU_INT] = @USU_INT) AND ([USU_MAIW] = @USU_MAIW) ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00188,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((short[]) buf[5])[0] = rslt.getShort(4) ;
                ((int[]) buf[6])[0] = rslt.getInt(5) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((String[]) buf[9])[0] = rslt.getString(7, 10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(7);
                ((String[]) buf[11])[0] = rslt.getString(8, 20) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(8);
                ((String[]) buf[13])[0] = rslt.getString(9, 50) ;
                ((String[]) buf[14])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(10);
                ((short[]) buf[16])[0] = rslt.getShort(11) ;
                ((int[]) buf[17])[0] = rslt.getInt(12) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[19])[0] = rslt.getString(14, 30) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(14);
                ((String[]) buf[21])[0] = rslt.getString(15, 30) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(15);
                ((String[]) buf[23])[0] = rslt.getVarchar(16) ;
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(17) ;
                ((short[]) buf[25])[0] = rslt.getShort(18) ;
                ((String[]) buf[26])[0] = rslt.getString(19, 50) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((long[]) buf[7])[0] = rslt.getLong(8) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 10) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 16) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 10) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 16) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 5 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[7]);
                }
                break;
       }
    }

 }

}
