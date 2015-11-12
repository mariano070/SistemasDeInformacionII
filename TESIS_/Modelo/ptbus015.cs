/*
               File: PTBUS015
        Description: Llenado de tablas auxiliares informe de bienes por responsable
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:41.21
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ptbus015 : GXProcedure
   {
      public ptbus015( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus015( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_TTBUS7_CodResp )
      {
         this.AV19TTBUS7_CodResp = aP0_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_TTBUS7_CodResp=this.AV19TTBUS7_CodResp;
      }

      public String executeUdp( )
      {
         this.AV19TTBUS7_CodResp = aP0_TTBUS7_CodResp;
         initialize();
         executePrivate();
         aP0_TTBUS7_CodResp=this.AV19TTBUS7_CodResp;
         return AV19TTBUS7_CodResp ;
      }

      public void executeSubmit( ref String aP0_TTBUS7_CodResp )
      {
         ptbus015 objptbus015;
         objptbus015 = new ptbus015();
         objptbus015.AV19TTBUS7_CodResp = aP0_TTBUS7_CodResp;
         objptbus015.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus015.executePrivateCatch ));
         aP0_TTBUS7_CodResp=this.AV19TTBUS7_CodResp;
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
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV19TTBUS7_CodResp)) )
         {
            /* Using cursor P001B2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A27TTBUS_CodProveedor = P001B2_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P001B2_n27TTBUS_CodProveedor[0] ;
               A11TTBUS_Id = P001B2_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P001B2_A12TTBUS_Descripcion[0] ;
               A17TTBUS_RubroBien = P001B2_A17TTBUS_RubroBien[0] ;
               A18TTBUS_RubroDesc = P001B2_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P001B2_n18TTBUS_RubroDesc[0] ;
               A30TTBUS_DesProveedor = P001B2_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P001B2_n30TTBUS_DesProveedor[0] ;
               A13TTBUS_FechaCarga = P001B2_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P001B2_A38TTBUS_DesPosicion[0] ;
               A15NumeroIdentificador = P001B2_A15NumeroIdentificador[0] ;
               A42TTBUS_NroSerie = P001B2_A42TTBUS_NroSerie[0] ;
               n42TTBUS_NroSerie = P001B2_n42TTBUS_NroSerie[0] ;
               A37TTBUS_CodPosicion = P001B2_A37TTBUS_CodPosicion[0] ;
               A35TTBUS7_CodResp = P001B2_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001B2_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001B2_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001B2_n36TTBUS7_DesResp[0] ;
               A14IdIdentificador = P001B2_A14IdIdentificador[0] ;
               A23TTBUS_Estado = P001B2_A23TTBUS_Estado[0] ;
               A27TTBUS_CodProveedor = P001B2_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P001B2_n27TTBUS_CodProveedor[0] ;
               A12TTBUS_Descripcion = P001B2_A12TTBUS_Descripcion[0] ;
               A17TTBUS_RubroBien = P001B2_A17TTBUS_RubroBien[0] ;
               A13TTBUS_FechaCarga = P001B2_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P001B2_A38TTBUS_DesPosicion[0] ;
               A42TTBUS_NroSerie = P001B2_A42TTBUS_NroSerie[0] ;
               n42TTBUS_NroSerie = P001B2_n42TTBUS_NroSerie[0] ;
               A37TTBUS_CodPosicion = P001B2_A37TTBUS_CodPosicion[0] ;
               A23TTBUS_Estado = P001B2_A23TTBUS_Estado[0] ;
               A30TTBUS_DesProveedor = P001B2_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P001B2_n30TTBUS_DesProveedor[0] ;
               A18TTBUS_RubroDesc = P001B2_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P001B2_n18TTBUS_RubroDesc[0] ;
               A35TTBUS7_CodResp = P001B2_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001B2_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001B2_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001B2_n36TTBUS7_DesResp[0] ;
               /* Using cursor P001B3 */
               pr_default.execute(1, new Object[] {A37TTBUS_CodPosicion});
               while ( (pr_default.getStatus(1) != 101) )
               {
                  A33TTBUS7_Pos = P001B3_A33TTBUS7_Pos[0] ;
                  AV8TTBUS14_CodResponsable = A35TTBUS7_CodResp ;
                  AV9TTBUS14_Responsable = A36TTBUS7_DesResp ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(1);
               if ( StringUtil.StrCmp(AV8TTBUS14_CodResponsable, AV19TTBUS7_CodResp) == 0 )
               {
                  /*
                     INSERT RECORD ON TABLE TTBUS014_1

                  */
                  A213TTBUS14_CodResponsable = AV8TTBUS14_CodResponsable ;
                  A209TTBUS14_Responsable = AV9TTBUS14_Responsable ;
                  A201TTBUS14_IdBien = A11TTBUS_Id ;
                  A202TTBUS14_Descripcion = A12TTBUS_Descripcion ;
                  A214TTBUS14_CodRubro = A17TTBUS_RubroBien ;
                  A203TTBUS14_Rubro = A18TTBUS_RubroDesc ;
                  A204TTBUS14_Proveedor = A30TTBUS_DesProveedor ;
                  A205TTBUS14_FechaCarga = A13TTBUS_FechaCarga ;
                  A208TTBUS14_Estado = 1 ;
                  A212TTBUS14_MarcaEnvio = 3 ;
                  A210TTBUS14_PosDesde = A38TTBUS_DesPosicion ;
                  n210TTBUS14_PosDesde = false ;
                  A215TTBUS14_CodEtiqueta = A15NumeroIdentificador ;
                  A216TTBUS14_NroSerie = A42TTBUS_NroSerie ;
                  /* Using cursor P001B4 */
                  pr_default.execute(2, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, A212TTBUS14_MarcaEnvio, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
                  pr_default.close(2);
                  if ( (pr_default.getStatus(2) == 1) )
                  {
                     context.Gx_err = 1 ;
                     Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
                  }
                  else
                  {
                     context.Gx_err = 0 ;
                     Gx_emsg = "" ;
                  }
                  /* End Insert */
               }
               pr_default.readNext(0);
            }
            pr_default.close(0);
            /* Using cursor P001B5 */
            pr_default.execute(3, new Object[] {AV19TTBUS7_CodResp});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A45TTBUS2_FechaEnvio = P001B5_A45TTBUS2_FechaEnvio[0] ;
               A49TTBUS2_CodPosHacia = P001B5_A49TTBUS2_CodPosHacia[0] ;
               A48TTBUS2_CodPosDesde = P001B5_A48TTBUS2_CodPosDesde[0] ;
               A25TTBUS2_RespHacia = P001B5_A25TTBUS2_RespHacia[0] ;
               A24TTBUS2_RespDesde = P001B5_A24TTBUS2_RespDesde[0] ;
               A22TTBUS2_IdBien = P001B5_A22TTBUS2_IdBien[0] ;
               A26TTBUS2_EstadoEnvio = P001B5_A26TTBUS2_EstadoEnvio[0] ;
               A52TTBUS2_IdMovimiento = P001B5_A52TTBUS2_IdMovimiento[0] ;
               /* Using cursor P001B6 */
               pr_default.execute(4, new Object[] {A22TTBUS2_IdBien});
               while ( (pr_default.getStatus(4) != 101) )
               {
                  A27TTBUS_CodProveedor = P001B6_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B6_n27TTBUS_CodProveedor[0] ;
                  A11TTBUS_Id = P001B6_A11TTBUS_Id[0] ;
                  A14IdIdentificador = P001B6_A14IdIdentificador[0] ;
                  A12TTBUS_Descripcion = P001B6_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B6_A17TTBUS_RubroBien[0] ;
                  A18TTBUS_RubroDesc = P001B6_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B6_n18TTBUS_RubroDesc[0] ;
                  A30TTBUS_DesProveedor = P001B6_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B6_n30TTBUS_DesProveedor[0] ;
                  A13TTBUS_FechaCarga = P001B6_A13TTBUS_FechaCarga[0] ;
                  A15NumeroIdentificador = P001B6_A15NumeroIdentificador[0] ;
                  A42TTBUS_NroSerie = P001B6_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B6_n42TTBUS_NroSerie[0] ;
                  A27TTBUS_CodProveedor = P001B6_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B6_n27TTBUS_CodProveedor[0] ;
                  A12TTBUS_Descripcion = P001B6_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B6_A17TTBUS_RubroBien[0] ;
                  A13TTBUS_FechaCarga = P001B6_A13TTBUS_FechaCarga[0] ;
                  A42TTBUS_NroSerie = P001B6_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B6_n42TTBUS_NroSerie[0] ;
                  A30TTBUS_DesProveedor = P001B6_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B6_n30TTBUS_DesProveedor[0] ;
                  A18TTBUS_RubroDesc = P001B6_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B6_n18TTBUS_RubroDesc[0] ;
                  AV10TTBUS14_Descripcion = A12TTBUS_Descripcion ;
                  AV11TTBUS14_CodRubro = A17TTBUS_RubroBien ;
                  AV12TTBUS14_Rubro = A18TTBUS_RubroDesc ;
                  AV13TTBUS14_Proveedor = A30TTBUS_DesProveedor ;
                  AV14TTBUS14_FechaCarga = A13TTBUS_FechaCarga ;
                  AV16TTBUS14_Estado = 2 ;
                  AV21TTBUS14_CodEtiqueta = A15NumeroIdentificador ;
                  AV23TTBUS14_NroSerie = A42TTBUS_NroSerie ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(4);
               if ( StringUtil.StrCmp(A24TTBUS2_RespDesde, AV19TTBUS7_CodResp) == 0 )
               {
                  AV8TTBUS14_CodResponsable = A24TTBUS2_RespDesde ;
                  /* Using cursor P001B7 */
                  pr_default.execute(5, new Object[] {A24TTBUS2_RespDesde});
                  while ( (pr_default.getStatus(5) != 101) )
                  {
                     A6USU_COD = P001B7_A6USU_COD[0] ;
                     A7USU_DES = P001B7_A7USU_DES[0] ;
                     AV9TTBUS14_Responsable = A7USU_DES ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(5);
                  AV20TTBUS14_MarcaEnvio = 1 ;
               }
               else
               {
                  AV8TTBUS14_CodResponsable = A25TTBUS2_RespHacia ;
                  /* Using cursor P001B8 */
                  pr_default.execute(6, new Object[] {A25TTBUS2_RespHacia});
                  while ( (pr_default.getStatus(6) != 101) )
                  {
                     A6USU_COD = P001B8_A6USU_COD[0] ;
                     A7USU_DES = P001B8_A7USU_DES[0] ;
                     AV9TTBUS14_Responsable = A7USU_DES ;
                     /* Exiting from a For First loop. */
                     if (true) break;
                  }
                  pr_default.close(6);
                  AV20TTBUS14_MarcaEnvio = 2 ;
               }
               /* Using cursor P001B9 */
               pr_default.execute(7, new Object[] {A48TTBUS2_CodPosDesde});
               while ( (pr_default.getStatus(7) != 101) )
               {
                  A31W53POS = P001B9_A31W53POS[0] ;
                  A32W53DES = P001B9_A32W53DES[0] ;
                  AV17dW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(7);
               /* Using cursor P001B10 */
               pr_default.execute(8, new Object[] {A49TTBUS2_CodPosHacia});
               while ( (pr_default.getStatus(8) != 101) )
               {
                  A31W53POS = P001B10_A31W53POS[0] ;
                  A32W53DES = P001B10_A32W53DES[0] ;
                  AV18hW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(8);
               /*
                  INSERT RECORD ON TABLE TTBUS014_1

               */
               A213TTBUS14_CodResponsable = AV8TTBUS14_CodResponsable ;
               A209TTBUS14_Responsable = AV9TTBUS14_Responsable ;
               A201TTBUS14_IdBien = A22TTBUS2_IdBien ;
               A202TTBUS14_Descripcion = AV10TTBUS14_Descripcion ;
               A214TTBUS14_CodRubro = AV11TTBUS14_CodRubro ;
               A203TTBUS14_Rubro = AV12TTBUS14_Rubro ;
               A204TTBUS14_Proveedor = AV13TTBUS14_Proveedor ;
               A205TTBUS14_FechaCarga = AV14TTBUS14_FechaCarga ;
               A207TTBUS14_FechaEnvio = DateTimeUtil.ResetTime(A45TTBUS2_FechaEnvio) ;
               n207TTBUS14_FechaEnvio = false ;
               A208TTBUS14_Estado = AV16TTBUS14_Estado ;
               A210TTBUS14_PosDesde = AV17dW53DES ;
               n210TTBUS14_PosDesde = false ;
               A211TTBUS14_PosHacia = AV18hW53DES ;
               n211TTBUS14_PosHacia = false ;
               A212TTBUS14_MarcaEnvio = AV20TTBUS14_MarcaEnvio ;
               A216TTBUS14_NroSerie = AV23TTBUS14_NroSerie ;
               A215TTBUS14_CodEtiqueta = AV21TTBUS14_CodEtiqueta ;
               /* Using cursor P001B11 */
               pr_default.execute(9, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, n207TTBUS14_FechaEnvio, A207TTBUS14_FechaEnvio, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, n211TTBUS14_PosHacia, A211TTBUS14_PosHacia, A212TTBUS14_MarcaEnvio, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
               pr_default.close(9);
               if ( (pr_default.getStatus(9) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               /* End Insert */
               pr_default.readNext(3);
            }
            pr_default.close(3);
         }
         else
         {
            /* Using cursor P001B12 */
            pr_default.execute(10);
            while ( (pr_default.getStatus(10) != 101) )
            {
               A27TTBUS_CodProveedor = P001B12_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P001B12_n27TTBUS_CodProveedor[0] ;
               A11TTBUS_Id = P001B12_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P001B12_A12TTBUS_Descripcion[0] ;
               A17TTBUS_RubroBien = P001B12_A17TTBUS_RubroBien[0] ;
               A18TTBUS_RubroDesc = P001B12_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P001B12_n18TTBUS_RubroDesc[0] ;
               A30TTBUS_DesProveedor = P001B12_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P001B12_n30TTBUS_DesProveedor[0] ;
               A13TTBUS_FechaCarga = P001B12_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P001B12_A38TTBUS_DesPosicion[0] ;
               A15NumeroIdentificador = P001B12_A15NumeroIdentificador[0] ;
               A42TTBUS_NroSerie = P001B12_A42TTBUS_NroSerie[0] ;
               n42TTBUS_NroSerie = P001B12_n42TTBUS_NroSerie[0] ;
               A37TTBUS_CodPosicion = P001B12_A37TTBUS_CodPosicion[0] ;
               A35TTBUS7_CodResp = P001B12_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001B12_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001B12_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001B12_n36TTBUS7_DesResp[0] ;
               A14IdIdentificador = P001B12_A14IdIdentificador[0] ;
               A23TTBUS_Estado = P001B12_A23TTBUS_Estado[0] ;
               A27TTBUS_CodProveedor = P001B12_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P001B12_n27TTBUS_CodProveedor[0] ;
               A12TTBUS_Descripcion = P001B12_A12TTBUS_Descripcion[0] ;
               A17TTBUS_RubroBien = P001B12_A17TTBUS_RubroBien[0] ;
               A13TTBUS_FechaCarga = P001B12_A13TTBUS_FechaCarga[0] ;
               A38TTBUS_DesPosicion = P001B12_A38TTBUS_DesPosicion[0] ;
               A42TTBUS_NroSerie = P001B12_A42TTBUS_NroSerie[0] ;
               n42TTBUS_NroSerie = P001B12_n42TTBUS_NroSerie[0] ;
               A37TTBUS_CodPosicion = P001B12_A37TTBUS_CodPosicion[0] ;
               A23TTBUS_Estado = P001B12_A23TTBUS_Estado[0] ;
               A30TTBUS_DesProveedor = P001B12_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P001B12_n30TTBUS_DesProveedor[0] ;
               A18TTBUS_RubroDesc = P001B12_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P001B12_n18TTBUS_RubroDesc[0] ;
               A35TTBUS7_CodResp = P001B12_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P001B12_n35TTBUS7_CodResp[0] ;
               A36TTBUS7_DesResp = P001B12_A36TTBUS7_DesResp[0] ;
               n36TTBUS7_DesResp = P001B12_n36TTBUS7_DesResp[0] ;
               /* Using cursor P001B13 */
               pr_default.execute(11, new Object[] {A37TTBUS_CodPosicion});
               while ( (pr_default.getStatus(11) != 101) )
               {
                  A33TTBUS7_Pos = P001B13_A33TTBUS7_Pos[0] ;
                  AV8TTBUS14_CodResponsable = A35TTBUS7_CodResp ;
                  AV9TTBUS14_Responsable = A36TTBUS7_DesResp ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(11);
               /*
                  INSERT RECORD ON TABLE TTBUS014_1

               */
               A213TTBUS14_CodResponsable = AV8TTBUS14_CodResponsable ;
               A209TTBUS14_Responsable = AV9TTBUS14_Responsable ;
               A201TTBUS14_IdBien = A11TTBUS_Id ;
               A202TTBUS14_Descripcion = A12TTBUS_Descripcion ;
               A214TTBUS14_CodRubro = A17TTBUS_RubroBien ;
               A203TTBUS14_Rubro = A18TTBUS_RubroDesc ;
               A204TTBUS14_Proveedor = A30TTBUS_DesProveedor ;
               A205TTBUS14_FechaCarga = A13TTBUS_FechaCarga ;
               A208TTBUS14_Estado = 1 ;
               A212TTBUS14_MarcaEnvio = 3 ;
               A210TTBUS14_PosDesde = A38TTBUS_DesPosicion ;
               n210TTBUS14_PosDesde = false ;
               A215TTBUS14_CodEtiqueta = A15NumeroIdentificador ;
               A216TTBUS14_NroSerie = A42TTBUS_NroSerie ;
               /* Using cursor P001B14 */
               pr_default.execute(12, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, A212TTBUS14_MarcaEnvio, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
               pr_default.close(12);
               if ( (pr_default.getStatus(12) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               /* End Insert */
               pr_default.readNext(10);
            }
            pr_default.close(10);
            /* Using cursor P001B15 */
            pr_default.execute(13);
            while ( (pr_default.getStatus(13) != 101) )
            {
               A45TTBUS2_FechaEnvio = P001B15_A45TTBUS2_FechaEnvio[0] ;
               A49TTBUS2_CodPosHacia = P001B15_A49TTBUS2_CodPosHacia[0] ;
               A48TTBUS2_CodPosDesde = P001B15_A48TTBUS2_CodPosDesde[0] ;
               A24TTBUS2_RespDesde = P001B15_A24TTBUS2_RespDesde[0] ;
               A22TTBUS2_IdBien = P001B15_A22TTBUS2_IdBien[0] ;
               A26TTBUS2_EstadoEnvio = P001B15_A26TTBUS2_EstadoEnvio[0] ;
               A52TTBUS2_IdMovimiento = P001B15_A52TTBUS2_IdMovimiento[0] ;
               /* Using cursor P001B16 */
               pr_default.execute(14, new Object[] {A22TTBUS2_IdBien});
               while ( (pr_default.getStatus(14) != 101) )
               {
                  A27TTBUS_CodProveedor = P001B16_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B16_n27TTBUS_CodProveedor[0] ;
                  A11TTBUS_Id = P001B16_A11TTBUS_Id[0] ;
                  A14IdIdentificador = P001B16_A14IdIdentificador[0] ;
                  A12TTBUS_Descripcion = P001B16_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B16_A17TTBUS_RubroBien[0] ;
                  A18TTBUS_RubroDesc = P001B16_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B16_n18TTBUS_RubroDesc[0] ;
                  A30TTBUS_DesProveedor = P001B16_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B16_n30TTBUS_DesProveedor[0] ;
                  A13TTBUS_FechaCarga = P001B16_A13TTBUS_FechaCarga[0] ;
                  A15NumeroIdentificador = P001B16_A15NumeroIdentificador[0] ;
                  A42TTBUS_NroSerie = P001B16_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B16_n42TTBUS_NroSerie[0] ;
                  A27TTBUS_CodProveedor = P001B16_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B16_n27TTBUS_CodProveedor[0] ;
                  A12TTBUS_Descripcion = P001B16_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B16_A17TTBUS_RubroBien[0] ;
                  A13TTBUS_FechaCarga = P001B16_A13TTBUS_FechaCarga[0] ;
                  A42TTBUS_NroSerie = P001B16_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B16_n42TTBUS_NroSerie[0] ;
                  A30TTBUS_DesProveedor = P001B16_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B16_n30TTBUS_DesProveedor[0] ;
                  A18TTBUS_RubroDesc = P001B16_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B16_n18TTBUS_RubroDesc[0] ;
                  AV10TTBUS14_Descripcion = A12TTBUS_Descripcion ;
                  AV11TTBUS14_CodRubro = A17TTBUS_RubroBien ;
                  AV12TTBUS14_Rubro = A18TTBUS_RubroDesc ;
                  AV13TTBUS14_Proveedor = A30TTBUS_DesProveedor ;
                  AV14TTBUS14_FechaCarga = A13TTBUS_FechaCarga ;
                  AV16TTBUS14_Estado = 2 ;
                  AV21TTBUS14_CodEtiqueta = A15NumeroIdentificador ;
                  AV23TTBUS14_NroSerie = A42TTBUS_NroSerie ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(14);
               /* Using cursor P001B17 */
               pr_default.execute(15, new Object[] {A24TTBUS2_RespDesde});
               while ( (pr_default.getStatus(15) != 101) )
               {
                  A6USU_COD = P001B17_A6USU_COD[0] ;
                  A7USU_DES = P001B17_A7USU_DES[0] ;
                  AV9TTBUS14_Responsable = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(15);
               /* Using cursor P001B18 */
               pr_default.execute(16, new Object[] {A48TTBUS2_CodPosDesde});
               while ( (pr_default.getStatus(16) != 101) )
               {
                  A31W53POS = P001B18_A31W53POS[0] ;
                  A32W53DES = P001B18_A32W53DES[0] ;
                  AV17dW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(16);
               /* Using cursor P001B19 */
               pr_default.execute(17, new Object[] {A49TTBUS2_CodPosHacia});
               while ( (pr_default.getStatus(17) != 101) )
               {
                  A31W53POS = P001B19_A31W53POS[0] ;
                  A32W53DES = P001B19_A32W53DES[0] ;
                  AV18hW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(17);
               /*
                  INSERT RECORD ON TABLE TTBUS014_1

               */
               A213TTBUS14_CodResponsable = A24TTBUS2_RespDesde ;
               A209TTBUS14_Responsable = AV9TTBUS14_Responsable ;
               A201TTBUS14_IdBien = A22TTBUS2_IdBien ;
               A202TTBUS14_Descripcion = AV10TTBUS14_Descripcion ;
               A214TTBUS14_CodRubro = AV11TTBUS14_CodRubro ;
               A203TTBUS14_Rubro = AV12TTBUS14_Rubro ;
               A204TTBUS14_Proveedor = AV13TTBUS14_Proveedor ;
               A205TTBUS14_FechaCarga = AV14TTBUS14_FechaCarga ;
               A207TTBUS14_FechaEnvio = DateTimeUtil.ResetTime(A45TTBUS2_FechaEnvio) ;
               n207TTBUS14_FechaEnvio = false ;
               A208TTBUS14_Estado = AV16TTBUS14_Estado ;
               A210TTBUS14_PosDesde = AV17dW53DES ;
               n210TTBUS14_PosDesde = false ;
               A211TTBUS14_PosHacia = AV18hW53DES ;
               n211TTBUS14_PosHacia = false ;
               A212TTBUS14_MarcaEnvio = 1 ;
               A216TTBUS14_NroSerie = AV23TTBUS14_NroSerie ;
               A215TTBUS14_CodEtiqueta = AV21TTBUS14_CodEtiqueta ;
               /* Using cursor P001B20 */
               pr_default.execute(18, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, n207TTBUS14_FechaEnvio, A207TTBUS14_FechaEnvio, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, n211TTBUS14_PosHacia, A211TTBUS14_PosHacia, A212TTBUS14_MarcaEnvio, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
               pr_default.close(18);
               if ( (pr_default.getStatus(18) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               /* End Insert */
               pr_default.readNext(13);
            }
            pr_default.close(13);
            /* Using cursor P001B21 */
            pr_default.execute(19);
            while ( (pr_default.getStatus(19) != 101) )
            {
               A45TTBUS2_FechaEnvio = P001B21_A45TTBUS2_FechaEnvio[0] ;
               A49TTBUS2_CodPosHacia = P001B21_A49TTBUS2_CodPosHacia[0] ;
               A48TTBUS2_CodPosDesde = P001B21_A48TTBUS2_CodPosDesde[0] ;
               A25TTBUS2_RespHacia = P001B21_A25TTBUS2_RespHacia[0] ;
               A22TTBUS2_IdBien = P001B21_A22TTBUS2_IdBien[0] ;
               A26TTBUS2_EstadoEnvio = P001B21_A26TTBUS2_EstadoEnvio[0] ;
               A52TTBUS2_IdMovimiento = P001B21_A52TTBUS2_IdMovimiento[0] ;
               /* Using cursor P001B22 */
               pr_default.execute(20, new Object[] {A22TTBUS2_IdBien});
               while ( (pr_default.getStatus(20) != 101) )
               {
                  A27TTBUS_CodProveedor = P001B22_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B22_n27TTBUS_CodProveedor[0] ;
                  A11TTBUS_Id = P001B22_A11TTBUS_Id[0] ;
                  A14IdIdentificador = P001B22_A14IdIdentificador[0] ;
                  A12TTBUS_Descripcion = P001B22_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B22_A17TTBUS_RubroBien[0] ;
                  A18TTBUS_RubroDesc = P001B22_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B22_n18TTBUS_RubroDesc[0] ;
                  A30TTBUS_DesProveedor = P001B22_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B22_n30TTBUS_DesProveedor[0] ;
                  A13TTBUS_FechaCarga = P001B22_A13TTBUS_FechaCarga[0] ;
                  A15NumeroIdentificador = P001B22_A15NumeroIdentificador[0] ;
                  A42TTBUS_NroSerie = P001B22_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B22_n42TTBUS_NroSerie[0] ;
                  A27TTBUS_CodProveedor = P001B22_A27TTBUS_CodProveedor[0] ;
                  n27TTBUS_CodProveedor = P001B22_n27TTBUS_CodProveedor[0] ;
                  A12TTBUS_Descripcion = P001B22_A12TTBUS_Descripcion[0] ;
                  A17TTBUS_RubroBien = P001B22_A17TTBUS_RubroBien[0] ;
                  A13TTBUS_FechaCarga = P001B22_A13TTBUS_FechaCarga[0] ;
                  A42TTBUS_NroSerie = P001B22_A42TTBUS_NroSerie[0] ;
                  n42TTBUS_NroSerie = P001B22_n42TTBUS_NroSerie[0] ;
                  A30TTBUS_DesProveedor = P001B22_A30TTBUS_DesProveedor[0] ;
                  n30TTBUS_DesProveedor = P001B22_n30TTBUS_DesProveedor[0] ;
                  A18TTBUS_RubroDesc = P001B22_A18TTBUS_RubroDesc[0] ;
                  n18TTBUS_RubroDesc = P001B22_n18TTBUS_RubroDesc[0] ;
                  AV10TTBUS14_Descripcion = A12TTBUS_Descripcion ;
                  AV11TTBUS14_CodRubro = A17TTBUS_RubroBien ;
                  AV12TTBUS14_Rubro = A18TTBUS_RubroDesc ;
                  AV13TTBUS14_Proveedor = A30TTBUS_DesProveedor ;
                  AV14TTBUS14_FechaCarga = A13TTBUS_FechaCarga ;
                  AV16TTBUS14_Estado = 2 ;
                  AV21TTBUS14_CodEtiqueta = A15NumeroIdentificador ;
                  AV23TTBUS14_NroSerie = A42TTBUS_NroSerie ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(20);
               /* Using cursor P001B23 */
               pr_default.execute(21, new Object[] {A25TTBUS2_RespHacia});
               while ( (pr_default.getStatus(21) != 101) )
               {
                  A6USU_COD = P001B23_A6USU_COD[0] ;
                  A7USU_DES = P001B23_A7USU_DES[0] ;
                  AV9TTBUS14_Responsable = A7USU_DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(21);
               /* Using cursor P001B24 */
               pr_default.execute(22, new Object[] {A48TTBUS2_CodPosDesde});
               while ( (pr_default.getStatus(22) != 101) )
               {
                  A31W53POS = P001B24_A31W53POS[0] ;
                  A32W53DES = P001B24_A32W53DES[0] ;
                  AV17dW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(22);
               /* Using cursor P001B25 */
               pr_default.execute(23, new Object[] {A49TTBUS2_CodPosHacia});
               while ( (pr_default.getStatus(23) != 101) )
               {
                  A31W53POS = P001B25_A31W53POS[0] ;
                  A32W53DES = P001B25_A32W53DES[0] ;
                  AV18hW53DES = A32W53DES ;
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(23);
               /*
                  INSERT RECORD ON TABLE TTBUS014_1

               */
               A213TTBUS14_CodResponsable = A25TTBUS2_RespHacia ;
               A209TTBUS14_Responsable = AV9TTBUS14_Responsable ;
               A201TTBUS14_IdBien = A22TTBUS2_IdBien ;
               A202TTBUS14_Descripcion = AV10TTBUS14_Descripcion ;
               A214TTBUS14_CodRubro = AV11TTBUS14_CodRubro ;
               A203TTBUS14_Rubro = AV12TTBUS14_Rubro ;
               A204TTBUS14_Proveedor = AV13TTBUS14_Proveedor ;
               A205TTBUS14_FechaCarga = AV14TTBUS14_FechaCarga ;
               A207TTBUS14_FechaEnvio = DateTimeUtil.ResetTime(A45TTBUS2_FechaEnvio) ;
               n207TTBUS14_FechaEnvio = false ;
               A208TTBUS14_Estado = AV16TTBUS14_Estado ;
               A210TTBUS14_PosDesde = AV17dW53DES ;
               n210TTBUS14_PosDesde = false ;
               A211TTBUS14_PosHacia = AV18hW53DES ;
               n211TTBUS14_PosHacia = false ;
               A212TTBUS14_MarcaEnvio = 2 ;
               A216TTBUS14_NroSerie = AV23TTBUS14_NroSerie ;
               A215TTBUS14_CodEtiqueta = AV21TTBUS14_CodEtiqueta ;
               /* Using cursor P001B26 */
               pr_default.execute(24, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, n207TTBUS14_FechaEnvio, A207TTBUS14_FechaEnvio, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, n211TTBUS14_PosHacia, A211TTBUS14_PosHacia, A212TTBUS14_MarcaEnvio, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
               pr_default.close(24);
               if ( (pr_default.getStatus(24) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               /* End Insert */
               pr_default.readNext(19);
            }
            pr_default.close(19);
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS015");
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
         scmdbuf = "" ;
         P001B2_A27TTBUS_CodProveedor = new int[1] ;
         P001B2_n27TTBUS_CodProveedor = new bool[] {false} ;
         P001B2_A11TTBUS_Id = new int[1] ;
         P001B2_A12TTBUS_Descripcion = new String[] {""} ;
         P001B2_A17TTBUS_RubroBien = new short[1] ;
         P001B2_A18TTBUS_RubroDesc = new String[] {""} ;
         P001B2_n18TTBUS_RubroDesc = new bool[] {false} ;
         P001B2_A30TTBUS_DesProveedor = new String[] {""} ;
         P001B2_n30TTBUS_DesProveedor = new bool[] {false} ;
         P001B2_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001B2_A38TTBUS_DesPosicion = new String[] {""} ;
         P001B2_A15NumeroIdentificador = new String[] {""} ;
         P001B2_A42TTBUS_NroSerie = new String[] {""} ;
         P001B2_n42TTBUS_NroSerie = new bool[] {false} ;
         P001B2_A37TTBUS_CodPosicion = new short[1] ;
         P001B2_A35TTBUS7_CodResp = new String[] {""} ;
         P001B2_n35TTBUS7_CodResp = new bool[] {false} ;
         P001B2_A36TTBUS7_DesResp = new String[] {""} ;
         P001B2_n36TTBUS7_DesResp = new bool[] {false} ;
         P001B2_A14IdIdentificador = new int[1] ;
         P001B2_A23TTBUS_Estado = new short[1] ;
         A12TTBUS_Descripcion = "" ;
         A18TTBUS_RubroDesc = "" ;
         A30TTBUS_DesProveedor = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A38TTBUS_DesPosicion = "" ;
         A15NumeroIdentificador = "" ;
         A42TTBUS_NroSerie = "" ;
         A35TTBUS7_CodResp = "" ;
         A36TTBUS7_DesResp = "" ;
         P001B3_A33TTBUS7_Pos = new short[1] ;
         AV8TTBUS14_CodResponsable = "" ;
         AV9TTBUS14_Responsable = "" ;
         A213TTBUS14_CodResponsable = "" ;
         A209TTBUS14_Responsable = "" ;
         A202TTBUS14_Descripcion = "" ;
         A203TTBUS14_Rubro = "" ;
         A204TTBUS14_Proveedor = "" ;
         A205TTBUS14_FechaCarga = DateTime.MinValue ;
         A210TTBUS14_PosDesde = "" ;
         A215TTBUS14_CodEtiqueta = "" ;
         A216TTBUS14_NroSerie = "" ;
         Gx_emsg = "" ;
         P001B5_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001B5_A49TTBUS2_CodPosHacia = new short[1] ;
         P001B5_A48TTBUS2_CodPosDesde = new short[1] ;
         P001B5_A25TTBUS2_RespHacia = new String[] {""} ;
         P001B5_A24TTBUS2_RespDesde = new String[] {""} ;
         P001B5_A22TTBUS2_IdBien = new int[1] ;
         P001B5_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001B5_A52TTBUS2_IdMovimiento = new long[1] ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         P001B6_A27TTBUS_CodProveedor = new int[1] ;
         P001B6_n27TTBUS_CodProveedor = new bool[] {false} ;
         P001B6_A11TTBUS_Id = new int[1] ;
         P001B6_A14IdIdentificador = new int[1] ;
         P001B6_A12TTBUS_Descripcion = new String[] {""} ;
         P001B6_A17TTBUS_RubroBien = new short[1] ;
         P001B6_A18TTBUS_RubroDesc = new String[] {""} ;
         P001B6_n18TTBUS_RubroDesc = new bool[] {false} ;
         P001B6_A30TTBUS_DesProveedor = new String[] {""} ;
         P001B6_n30TTBUS_DesProveedor = new bool[] {false} ;
         P001B6_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001B6_A15NumeroIdentificador = new String[] {""} ;
         P001B6_A42TTBUS_NroSerie = new String[] {""} ;
         P001B6_n42TTBUS_NroSerie = new bool[] {false} ;
         AV10TTBUS14_Descripcion = "" ;
         AV12TTBUS14_Rubro = "" ;
         AV13TTBUS14_Proveedor = "" ;
         AV14TTBUS14_FechaCarga = DateTime.MinValue ;
         AV21TTBUS14_CodEtiqueta = "" ;
         AV23TTBUS14_NroSerie = "" ;
         P001B7_A6USU_COD = new String[] {""} ;
         P001B7_A7USU_DES = new String[] {""} ;
         A6USU_COD = "" ;
         A7USU_DES = "" ;
         P001B8_A6USU_COD = new String[] {""} ;
         P001B8_A7USU_DES = new String[] {""} ;
         P001B9_A31W53POS = new short[1] ;
         P001B9_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         AV17dW53DES = "" ;
         P001B10_A31W53POS = new short[1] ;
         P001B10_A32W53DES = new String[] {""} ;
         AV18hW53DES = "" ;
         A207TTBUS14_FechaEnvio = DateTime.MinValue ;
         A211TTBUS14_PosHacia = "" ;
         P001B12_A27TTBUS_CodProveedor = new int[1] ;
         P001B12_n27TTBUS_CodProveedor = new bool[] {false} ;
         P001B12_A11TTBUS_Id = new int[1] ;
         P001B12_A12TTBUS_Descripcion = new String[] {""} ;
         P001B12_A17TTBUS_RubroBien = new short[1] ;
         P001B12_A18TTBUS_RubroDesc = new String[] {""} ;
         P001B12_n18TTBUS_RubroDesc = new bool[] {false} ;
         P001B12_A30TTBUS_DesProveedor = new String[] {""} ;
         P001B12_n30TTBUS_DesProveedor = new bool[] {false} ;
         P001B12_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001B12_A38TTBUS_DesPosicion = new String[] {""} ;
         P001B12_A15NumeroIdentificador = new String[] {""} ;
         P001B12_A42TTBUS_NroSerie = new String[] {""} ;
         P001B12_n42TTBUS_NroSerie = new bool[] {false} ;
         P001B12_A37TTBUS_CodPosicion = new short[1] ;
         P001B12_A35TTBUS7_CodResp = new String[] {""} ;
         P001B12_n35TTBUS7_CodResp = new bool[] {false} ;
         P001B12_A36TTBUS7_DesResp = new String[] {""} ;
         P001B12_n36TTBUS7_DesResp = new bool[] {false} ;
         P001B12_A14IdIdentificador = new int[1] ;
         P001B12_A23TTBUS_Estado = new short[1] ;
         P001B13_A33TTBUS7_Pos = new short[1] ;
         P001B15_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001B15_A49TTBUS2_CodPosHacia = new short[1] ;
         P001B15_A48TTBUS2_CodPosDesde = new short[1] ;
         P001B15_A24TTBUS2_RespDesde = new String[] {""} ;
         P001B15_A22TTBUS2_IdBien = new int[1] ;
         P001B15_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001B15_A52TTBUS2_IdMovimiento = new long[1] ;
         P001B16_A27TTBUS_CodProveedor = new int[1] ;
         P001B16_n27TTBUS_CodProveedor = new bool[] {false} ;
         P001B16_A11TTBUS_Id = new int[1] ;
         P001B16_A14IdIdentificador = new int[1] ;
         P001B16_A12TTBUS_Descripcion = new String[] {""} ;
         P001B16_A17TTBUS_RubroBien = new short[1] ;
         P001B16_A18TTBUS_RubroDesc = new String[] {""} ;
         P001B16_n18TTBUS_RubroDesc = new bool[] {false} ;
         P001B16_A30TTBUS_DesProveedor = new String[] {""} ;
         P001B16_n30TTBUS_DesProveedor = new bool[] {false} ;
         P001B16_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001B16_A15NumeroIdentificador = new String[] {""} ;
         P001B16_A42TTBUS_NroSerie = new String[] {""} ;
         P001B16_n42TTBUS_NroSerie = new bool[] {false} ;
         P001B17_A6USU_COD = new String[] {""} ;
         P001B17_A7USU_DES = new String[] {""} ;
         P001B18_A31W53POS = new short[1] ;
         P001B18_A32W53DES = new String[] {""} ;
         P001B19_A31W53POS = new short[1] ;
         P001B19_A32W53DES = new String[] {""} ;
         P001B21_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001B21_A49TTBUS2_CodPosHacia = new short[1] ;
         P001B21_A48TTBUS2_CodPosDesde = new short[1] ;
         P001B21_A25TTBUS2_RespHacia = new String[] {""} ;
         P001B21_A22TTBUS2_IdBien = new int[1] ;
         P001B21_A26TTBUS2_EstadoEnvio = new short[1] ;
         P001B21_A52TTBUS2_IdMovimiento = new long[1] ;
         P001B22_A27TTBUS_CodProveedor = new int[1] ;
         P001B22_n27TTBUS_CodProveedor = new bool[] {false} ;
         P001B22_A11TTBUS_Id = new int[1] ;
         P001B22_A14IdIdentificador = new int[1] ;
         P001B22_A12TTBUS_Descripcion = new String[] {""} ;
         P001B22_A17TTBUS_RubroBien = new short[1] ;
         P001B22_A18TTBUS_RubroDesc = new String[] {""} ;
         P001B22_n18TTBUS_RubroDesc = new bool[] {false} ;
         P001B22_A30TTBUS_DesProveedor = new String[] {""} ;
         P001B22_n30TTBUS_DesProveedor = new bool[] {false} ;
         P001B22_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001B22_A15NumeroIdentificador = new String[] {""} ;
         P001B22_A42TTBUS_NroSerie = new String[] {""} ;
         P001B22_n42TTBUS_NroSerie = new bool[] {false} ;
         P001B23_A6USU_COD = new String[] {""} ;
         P001B23_A7USU_DES = new String[] {""} ;
         P001B24_A31W53POS = new short[1] ;
         P001B24_A32W53DES = new String[] {""} ;
         P001B25_A31W53POS = new short[1] ;
         P001B25_A32W53DES = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus015__default(),
            new Object[][] {
                new Object[] {
               P001B2_A27TTBUS_CodProveedor, P001B2_n27TTBUS_CodProveedor, P001B2_A11TTBUS_Id, P001B2_A12TTBUS_Descripcion, P001B2_A17TTBUS_RubroBien, P001B2_A18TTBUS_RubroDesc, P001B2_n18TTBUS_RubroDesc, P001B2_A30TTBUS_DesProveedor, P001B2_n30TTBUS_DesProveedor, P001B2_A13TTBUS_FechaCarga,
               P001B2_A38TTBUS_DesPosicion, P001B2_A15NumeroIdentificador, P001B2_A42TTBUS_NroSerie, P001B2_n42TTBUS_NroSerie, P001B2_A37TTBUS_CodPosicion, P001B2_A35TTBUS7_CodResp, P001B2_n35TTBUS7_CodResp, P001B2_A36TTBUS7_DesResp, P001B2_n36TTBUS7_DesResp, P001B2_A14IdIdentificador,
               P001B2_A23TTBUS_Estado
               }
               , new Object[] {
               P001B3_A33TTBUS7_Pos
               }
               , new Object[] {
               }
               , new Object[] {
               P001B5_A45TTBUS2_FechaEnvio, P001B5_A49TTBUS2_CodPosHacia, P001B5_A48TTBUS2_CodPosDesde, P001B5_A25TTBUS2_RespHacia, P001B5_A24TTBUS2_RespDesde, P001B5_A22TTBUS2_IdBien, P001B5_A26TTBUS2_EstadoEnvio, P001B5_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001B6_A27TTBUS_CodProveedor, P001B6_n27TTBUS_CodProveedor, P001B6_A11TTBUS_Id, P001B6_A14IdIdentificador, P001B6_A12TTBUS_Descripcion, P001B6_A17TTBUS_RubroBien, P001B6_A18TTBUS_RubroDesc, P001B6_n18TTBUS_RubroDesc, P001B6_A30TTBUS_DesProveedor, P001B6_n30TTBUS_DesProveedor,
               P001B6_A13TTBUS_FechaCarga, P001B6_A15NumeroIdentificador, P001B6_A42TTBUS_NroSerie, P001B6_n42TTBUS_NroSerie
               }
               , new Object[] {
               P001B7_A6USU_COD, P001B7_A7USU_DES
               }
               , new Object[] {
               P001B8_A6USU_COD, P001B8_A7USU_DES
               }
               , new Object[] {
               P001B9_A31W53POS, P001B9_A32W53DES
               }
               , new Object[] {
               P001B10_A31W53POS, P001B10_A32W53DES
               }
               , new Object[] {
               }
               , new Object[] {
               P001B12_A27TTBUS_CodProveedor, P001B12_n27TTBUS_CodProveedor, P001B12_A11TTBUS_Id, P001B12_A12TTBUS_Descripcion, P001B12_A17TTBUS_RubroBien, P001B12_A18TTBUS_RubroDesc, P001B12_n18TTBUS_RubroDesc, P001B12_A30TTBUS_DesProveedor, P001B12_n30TTBUS_DesProveedor, P001B12_A13TTBUS_FechaCarga,
               P001B12_A38TTBUS_DesPosicion, P001B12_A15NumeroIdentificador, P001B12_A42TTBUS_NroSerie, P001B12_n42TTBUS_NroSerie, P001B12_A37TTBUS_CodPosicion, P001B12_A35TTBUS7_CodResp, P001B12_n35TTBUS7_CodResp, P001B12_A36TTBUS7_DesResp, P001B12_n36TTBUS7_DesResp, P001B12_A14IdIdentificador,
               P001B12_A23TTBUS_Estado
               }
               , new Object[] {
               P001B13_A33TTBUS7_Pos
               }
               , new Object[] {
               }
               , new Object[] {
               P001B15_A45TTBUS2_FechaEnvio, P001B15_A49TTBUS2_CodPosHacia, P001B15_A48TTBUS2_CodPosDesde, P001B15_A24TTBUS2_RespDesde, P001B15_A22TTBUS2_IdBien, P001B15_A26TTBUS2_EstadoEnvio, P001B15_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001B16_A27TTBUS_CodProveedor, P001B16_n27TTBUS_CodProveedor, P001B16_A11TTBUS_Id, P001B16_A14IdIdentificador, P001B16_A12TTBUS_Descripcion, P001B16_A17TTBUS_RubroBien, P001B16_A18TTBUS_RubroDesc, P001B16_n18TTBUS_RubroDesc, P001B16_A30TTBUS_DesProveedor, P001B16_n30TTBUS_DesProveedor,
               P001B16_A13TTBUS_FechaCarga, P001B16_A15NumeroIdentificador, P001B16_A42TTBUS_NroSerie, P001B16_n42TTBUS_NroSerie
               }
               , new Object[] {
               P001B17_A6USU_COD, P001B17_A7USU_DES
               }
               , new Object[] {
               P001B18_A31W53POS, P001B18_A32W53DES
               }
               , new Object[] {
               P001B19_A31W53POS, P001B19_A32W53DES
               }
               , new Object[] {
               }
               , new Object[] {
               P001B21_A45TTBUS2_FechaEnvio, P001B21_A49TTBUS2_CodPosHacia, P001B21_A48TTBUS2_CodPosDesde, P001B21_A25TTBUS2_RespHacia, P001B21_A22TTBUS2_IdBien, P001B21_A26TTBUS2_EstadoEnvio, P001B21_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P001B22_A27TTBUS_CodProveedor, P001B22_n27TTBUS_CodProveedor, P001B22_A11TTBUS_Id, P001B22_A14IdIdentificador, P001B22_A12TTBUS_Descripcion, P001B22_A17TTBUS_RubroBien, P001B22_A18TTBUS_RubroDesc, P001B22_n18TTBUS_RubroDesc, P001B22_A30TTBUS_DesProveedor, P001B22_n30TTBUS_DesProveedor,
               P001B22_A13TTBUS_FechaCarga, P001B22_A15NumeroIdentificador, P001B22_A42TTBUS_NroSerie, P001B22_n42TTBUS_NroSerie
               }
               , new Object[] {
               P001B23_A6USU_COD, P001B23_A7USU_DES
               }
               , new Object[] {
               P001B24_A31W53POS, P001B24_A32W53DES
               }
               , new Object[] {
               P001B25_A31W53POS, P001B25_A32W53DES
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A17TTBUS_RubroBien ;
      private short A37TTBUS_CodPosicion ;
      private short A23TTBUS_Estado ;
      private short A33TTBUS7_Pos ;
      private short A214TTBUS14_CodRubro ;
      private short A208TTBUS14_Estado ;
      private short A212TTBUS14_MarcaEnvio ;
      private short A49TTBUS2_CodPosHacia ;
      private short A48TTBUS2_CodPosDesde ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV11TTBUS14_CodRubro ;
      private short AV16TTBUS14_Estado ;
      private short AV20TTBUS14_MarcaEnvio ;
      private short A31W53POS ;
      private int A27TTBUS_CodProveedor ;
      private int A11TTBUS_Id ;
      private int A14IdIdentificador ;
      private int GX_INS12 ;
      private int A201TTBUS14_IdBien ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV19TTBUS7_CodResp ;
      private String scmdbuf ;
      private String A18TTBUS_RubroDesc ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String A35TTBUS7_CodResp ;
      private String A36TTBUS7_DesResp ;
      private String AV8TTBUS14_CodResponsable ;
      private String AV9TTBUS14_Responsable ;
      private String A213TTBUS14_CodResponsable ;
      private String A209TTBUS14_Responsable ;
      private String A203TTBUS14_Rubro ;
      private String A204TTBUS14_Proveedor ;
      private String A210TTBUS14_PosDesde ;
      private String Gx_emsg ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String AV12TTBUS14_Rubro ;
      private String AV13TTBUS14_Proveedor ;
      private String A6USU_COD ;
      private String A7USU_DES ;
      private String A32W53DES ;
      private String AV17dW53DES ;
      private String AV18hW53DES ;
      private String A211TTBUS14_PosHacia ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A205TTBUS14_FechaCarga ;
      private DateTime AV14TTBUS14_FechaCarga ;
      private DateTime A207TTBUS14_FechaEnvio ;
      private bool n27TTBUS_CodProveedor ;
      private bool n18TTBUS_RubroDesc ;
      private bool n30TTBUS_DesProveedor ;
      private bool n42TTBUS_NroSerie ;
      private bool n35TTBUS7_CodResp ;
      private bool n36TTBUS7_DesResp ;
      private bool n210TTBUS14_PosDesde ;
      private bool n207TTBUS14_FechaEnvio ;
      private bool n211TTBUS14_PosHacia ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String A42TTBUS_NroSerie ;
      private String A202TTBUS14_Descripcion ;
      private String A215TTBUS14_CodEtiqueta ;
      private String A216TTBUS14_NroSerie ;
      private String AV10TTBUS14_Descripcion ;
      private String AV21TTBUS14_CodEtiqueta ;
      private String AV23TTBUS14_NroSerie ;
      private IGxDataStore dsDefault ;
      private String aP0_TTBUS7_CodResp ;
      private IDataStoreProvider pr_default ;
      private int[] P001B2_A27TTBUS_CodProveedor ;
      private bool[] P001B2_n27TTBUS_CodProveedor ;
      private int[] P001B2_A11TTBUS_Id ;
      private String[] P001B2_A12TTBUS_Descripcion ;
      private short[] P001B2_A17TTBUS_RubroBien ;
      private String[] P001B2_A18TTBUS_RubroDesc ;
      private bool[] P001B2_n18TTBUS_RubroDesc ;
      private String[] P001B2_A30TTBUS_DesProveedor ;
      private bool[] P001B2_n30TTBUS_DesProveedor ;
      private DateTime[] P001B2_A13TTBUS_FechaCarga ;
      private String[] P001B2_A38TTBUS_DesPosicion ;
      private String[] P001B2_A15NumeroIdentificador ;
      private String[] P001B2_A42TTBUS_NroSerie ;
      private bool[] P001B2_n42TTBUS_NroSerie ;
      private short[] P001B2_A37TTBUS_CodPosicion ;
      private String[] P001B2_A35TTBUS7_CodResp ;
      private bool[] P001B2_n35TTBUS7_CodResp ;
      private String[] P001B2_A36TTBUS7_DesResp ;
      private bool[] P001B2_n36TTBUS7_DesResp ;
      private int[] P001B2_A14IdIdentificador ;
      private short[] P001B2_A23TTBUS_Estado ;
      private short[] P001B3_A33TTBUS7_Pos ;
      private DateTime[] P001B5_A45TTBUS2_FechaEnvio ;
      private short[] P001B5_A49TTBUS2_CodPosHacia ;
      private short[] P001B5_A48TTBUS2_CodPosDesde ;
      private String[] P001B5_A25TTBUS2_RespHacia ;
      private String[] P001B5_A24TTBUS2_RespDesde ;
      private int[] P001B5_A22TTBUS2_IdBien ;
      private short[] P001B5_A26TTBUS2_EstadoEnvio ;
      private long[] P001B5_A52TTBUS2_IdMovimiento ;
      private int[] P001B6_A27TTBUS_CodProveedor ;
      private bool[] P001B6_n27TTBUS_CodProveedor ;
      private int[] P001B6_A11TTBUS_Id ;
      private int[] P001B6_A14IdIdentificador ;
      private String[] P001B6_A12TTBUS_Descripcion ;
      private short[] P001B6_A17TTBUS_RubroBien ;
      private String[] P001B6_A18TTBUS_RubroDesc ;
      private bool[] P001B6_n18TTBUS_RubroDesc ;
      private String[] P001B6_A30TTBUS_DesProveedor ;
      private bool[] P001B6_n30TTBUS_DesProveedor ;
      private DateTime[] P001B6_A13TTBUS_FechaCarga ;
      private String[] P001B6_A15NumeroIdentificador ;
      private String[] P001B6_A42TTBUS_NroSerie ;
      private bool[] P001B6_n42TTBUS_NroSerie ;
      private String[] P001B7_A6USU_COD ;
      private String[] P001B7_A7USU_DES ;
      private String[] P001B8_A6USU_COD ;
      private String[] P001B8_A7USU_DES ;
      private short[] P001B9_A31W53POS ;
      private String[] P001B9_A32W53DES ;
      private short[] P001B10_A31W53POS ;
      private String[] P001B10_A32W53DES ;
      private int[] P001B12_A27TTBUS_CodProveedor ;
      private bool[] P001B12_n27TTBUS_CodProveedor ;
      private int[] P001B12_A11TTBUS_Id ;
      private String[] P001B12_A12TTBUS_Descripcion ;
      private short[] P001B12_A17TTBUS_RubroBien ;
      private String[] P001B12_A18TTBUS_RubroDesc ;
      private bool[] P001B12_n18TTBUS_RubroDesc ;
      private String[] P001B12_A30TTBUS_DesProveedor ;
      private bool[] P001B12_n30TTBUS_DesProveedor ;
      private DateTime[] P001B12_A13TTBUS_FechaCarga ;
      private String[] P001B12_A38TTBUS_DesPosicion ;
      private String[] P001B12_A15NumeroIdentificador ;
      private String[] P001B12_A42TTBUS_NroSerie ;
      private bool[] P001B12_n42TTBUS_NroSerie ;
      private short[] P001B12_A37TTBUS_CodPosicion ;
      private String[] P001B12_A35TTBUS7_CodResp ;
      private bool[] P001B12_n35TTBUS7_CodResp ;
      private String[] P001B12_A36TTBUS7_DesResp ;
      private bool[] P001B12_n36TTBUS7_DesResp ;
      private int[] P001B12_A14IdIdentificador ;
      private short[] P001B12_A23TTBUS_Estado ;
      private short[] P001B13_A33TTBUS7_Pos ;
      private DateTime[] P001B15_A45TTBUS2_FechaEnvio ;
      private short[] P001B15_A49TTBUS2_CodPosHacia ;
      private short[] P001B15_A48TTBUS2_CodPosDesde ;
      private String[] P001B15_A24TTBUS2_RespDesde ;
      private int[] P001B15_A22TTBUS2_IdBien ;
      private short[] P001B15_A26TTBUS2_EstadoEnvio ;
      private long[] P001B15_A52TTBUS2_IdMovimiento ;
      private int[] P001B16_A27TTBUS_CodProveedor ;
      private bool[] P001B16_n27TTBUS_CodProveedor ;
      private int[] P001B16_A11TTBUS_Id ;
      private int[] P001B16_A14IdIdentificador ;
      private String[] P001B16_A12TTBUS_Descripcion ;
      private short[] P001B16_A17TTBUS_RubroBien ;
      private String[] P001B16_A18TTBUS_RubroDesc ;
      private bool[] P001B16_n18TTBUS_RubroDesc ;
      private String[] P001B16_A30TTBUS_DesProveedor ;
      private bool[] P001B16_n30TTBUS_DesProveedor ;
      private DateTime[] P001B16_A13TTBUS_FechaCarga ;
      private String[] P001B16_A15NumeroIdentificador ;
      private String[] P001B16_A42TTBUS_NroSerie ;
      private bool[] P001B16_n42TTBUS_NroSerie ;
      private String[] P001B17_A6USU_COD ;
      private String[] P001B17_A7USU_DES ;
      private short[] P001B18_A31W53POS ;
      private String[] P001B18_A32W53DES ;
      private short[] P001B19_A31W53POS ;
      private String[] P001B19_A32W53DES ;
      private DateTime[] P001B21_A45TTBUS2_FechaEnvio ;
      private short[] P001B21_A49TTBUS2_CodPosHacia ;
      private short[] P001B21_A48TTBUS2_CodPosDesde ;
      private String[] P001B21_A25TTBUS2_RespHacia ;
      private int[] P001B21_A22TTBUS2_IdBien ;
      private short[] P001B21_A26TTBUS2_EstadoEnvio ;
      private long[] P001B21_A52TTBUS2_IdMovimiento ;
      private int[] P001B22_A27TTBUS_CodProveedor ;
      private bool[] P001B22_n27TTBUS_CodProveedor ;
      private int[] P001B22_A11TTBUS_Id ;
      private int[] P001B22_A14IdIdentificador ;
      private String[] P001B22_A12TTBUS_Descripcion ;
      private short[] P001B22_A17TTBUS_RubroBien ;
      private String[] P001B22_A18TTBUS_RubroDesc ;
      private bool[] P001B22_n18TTBUS_RubroDesc ;
      private String[] P001B22_A30TTBUS_DesProveedor ;
      private bool[] P001B22_n30TTBUS_DesProveedor ;
      private DateTime[] P001B22_A13TTBUS_FechaCarga ;
      private String[] P001B22_A15NumeroIdentificador ;
      private String[] P001B22_A42TTBUS_NroSerie ;
      private bool[] P001B22_n42TTBUS_NroSerie ;
      private String[] P001B23_A6USU_COD ;
      private String[] P001B23_A7USU_DES ;
      private short[] P001B24_A31W53POS ;
      private String[] P001B24_A32W53DES ;
      private short[] P001B25_A31W53POS ;
      private String[] P001B25_A32W53DES ;
   }

   public class ptbus015__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
         ,new UpdateCursor(def[24])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001B2 ;
          prmP001B2 = new Object[] {
          } ;
          Object[] prmP001B3 ;
          prmP001B3 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B4 ;
          prmP001B4 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmP001B5 ;
          prmP001B5 = new Object[] {
          new Object[] {"@AV19TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmP001B6 ;
          prmP001B6 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001B7 ;
          prmP001B7 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001B8 ;
          prmP001B8 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001B9 ;
          prmP001B9 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B10 ;
          prmP001B10 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B11 ;
          prmP001B11 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaEnvio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_PosHacia",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmP001B12 ;
          prmP001B12 = new Object[] {
          } ;
          Object[] prmP001B13 ;
          prmP001B13 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B14 ;
          prmP001B14 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmP001B15 ;
          prmP001B15 = new Object[] {
          } ;
          Object[] prmP001B16 ;
          prmP001B16 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001B17 ;
          prmP001B17 = new Object[] {
          new Object[] {"@TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001B18 ;
          prmP001B18 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B19 ;
          prmP001B19 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B20 ;
          prmP001B20 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaEnvio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_PosHacia",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmP001B21 ;
          prmP001B21 = new Object[] {
          } ;
          Object[] prmP001B22 ;
          prmP001B22 = new Object[] {
          new Object[] {"@TTBUS2_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmP001B23 ;
          prmP001B23 = new Object[] {
          new Object[] {"@TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmP001B24 ;
          prmP001B24 = new Object[] {
          new Object[] {"@TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B25 ;
          prmP001B25 = new Object[] {
          new Object[] {"@TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP001B26 ;
          prmP001B26 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaEnvio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_PosHacia",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001B2", "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T1.[TTBUS_Id], T2.[TTBUS_Descripcion], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T4.[RBR_DES] AS TTBUS_RubroDesc, T3.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_FechaCarga], T2.[TTBUS_DesPosicion], T1.[NumeroIdentificador], T2.[TTBUS_NroSerie], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T5.[TTBUS7_CodResp] AS TTBUS7_CodResp, T6.[USU_DES] AS TTBUS7_DesResp, T1.[IdIdentificador], T2.[TTBUS_Estado] FROM ((((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) INNER JOIN [TTBUS007] T5 WITH (NOLOCK) ON T5.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T6 WITH (NOLOCK) ON T6.[USU_COD] = T5.[TTBUS7_CodResp]) WHERE (T2.[TTBUS_Estado] = 1) AND (T1.[IdIdentificador] = 1) ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B2,100,0,true,false )
             ,new CursorDef("P001B3", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B3,1,0,false,true )
             ,new CursorDef("P001B4", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_MarcaEnvio], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_PosHacia], [TTBUS14_Empresa]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_MarcaEnvio, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie, convert( DATETIME, '17530101', 112 ), convert( DATETIME, '17530101', 112 ), '', convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001B4)
             ,new CursorDef("P001B5", "SELECT [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_RespHacia], [TTBUS2_RespDesde], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE (( [TTBUS2_RespDesde] = @AV19TTBUS7_CodResp) or ( [TTBUS2_RespHacia] = @AV19TTBUS7_CodResp)) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B5,100,0,true,false )
             ,new CursorDef("P001B6", "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T1.[TTBUS_Id], T1.[IdIdentificador], T2.[TTBUS_Descripcion], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T4.[RBR_DES] AS TTBUS_RubroDesc, T3.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_FechaCarga], T1.[NumeroIdentificador], T2.[TTBUS_NroSerie] FROM ((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) WHERE T1.[TTBUS_Id] = @TTBUS2_IdBien and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B6,1,0,false,true )
             ,new CursorDef("P001B7", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B7,1,0,false,true )
             ,new CursorDef("P001B8", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B8,1,0,false,true )
             ,new CursorDef("P001B9", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosDesde ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B9,1,0,false,true )
             ,new CursorDef("P001B10", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosHacia ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B10,1,0,false,true )
             ,new CursorDef("P001B11", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie], [TTBUS14_FechaAdquisicion], [TTBUS14_Empresa]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_FechaEnvio, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_PosHacia, @TTBUS14_MarcaEnvio, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie, convert( DATETIME, '17530101', 112 ), convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001B11)
             ,new CursorDef("P001B12", "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T1.[TTBUS_Id], T2.[TTBUS_Descripcion], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T4.[RBR_DES] AS TTBUS_RubroDesc, T3.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_FechaCarga], T2.[TTBUS_DesPosicion], T1.[NumeroIdentificador], T2.[TTBUS_NroSerie], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T5.[TTBUS7_CodResp] AS TTBUS7_CodResp, T6.[USU_DES] AS TTBUS7_DesResp, T1.[IdIdentificador], T2.[TTBUS_Estado] FROM ((((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) INNER JOIN [TTBUS007] T5 WITH (NOLOCK) ON T5.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T6 WITH (NOLOCK) ON T6.[USU_COD] = T5.[TTBUS7_CodResp]) WHERE (T2.[TTBUS_Estado] = 1) AND (T1.[IdIdentificador] = 1) ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B12,100,0,true,false )
             ,new CursorDef("P001B13", "SELECT [TTBUS7_Pos] FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B13,1,0,false,true )
             ,new CursorDef("P001B14", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_MarcaEnvio], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_PosHacia], [TTBUS14_Empresa]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_MarcaEnvio, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie, convert( DATETIME, '17530101', 112 ), convert( DATETIME, '17530101', 112 ), '', convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001B14)
             ,new CursorDef("P001B15", "SELECT [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_RespDesde], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_EstadoEnvio] = 1 ORDER BY [TTBUS2_RespDesde] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B15,100,0,true,false )
             ,new CursorDef("P001B16", "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T1.[TTBUS_Id], T1.[IdIdentificador], T2.[TTBUS_Descripcion], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T4.[RBR_DES] AS TTBUS_RubroDesc, T3.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_FechaCarga], T1.[NumeroIdentificador], T2.[TTBUS_NroSerie] FROM ((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) WHERE T1.[TTBUS_Id] = @TTBUS2_IdBien and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B16,1,0,false,true )
             ,new CursorDef("P001B17", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B17,1,0,false,true )
             ,new CursorDef("P001B18", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosDesde ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B18,1,0,false,true )
             ,new CursorDef("P001B19", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosHacia ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B19,1,0,false,true )
             ,new CursorDef("P001B20", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie], [TTBUS14_FechaAdquisicion], [TTBUS14_Empresa]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_FechaEnvio, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_PosHacia, @TTBUS14_MarcaEnvio, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie, convert( DATETIME, '17530101', 112 ), convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001B20)
             ,new CursorDef("P001B21", "SELECT [TTBUS2_FechaEnvio], [TTBUS2_CodPosHacia], [TTBUS2_CodPosDesde], [TTBUS2_RespHacia], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE [TTBUS2_EstadoEnvio] = 1 ORDER BY [TTBUS2_RespHacia] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B21,100,0,true,false )
             ,new CursorDef("P001B22", "SELECT T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T1.[TTBUS_Id], T1.[IdIdentificador], T2.[TTBUS_Descripcion], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T4.[RBR_DES] AS TTBUS_RubroDesc, T3.[PV_DESC] AS TTBUS_DesProveedor, T2.[TTBUS_FechaCarga], T1.[NumeroIdentificador], T2.[TTBUS_NroSerie] FROM ((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) LEFT JOIN [M124FPROV] T3 WITH (NOLOCK) ON T3.[PV_NPRO] = T2.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T4 WITH (NOLOCK) ON T4.[RBR_COD] = T2.[TTBUS_RubroBien]) WHERE T1.[TTBUS_Id] = @TTBUS2_IdBien and T1.[IdIdentificador] = 1 ORDER BY T1.[TTBUS_Id], T1.[IdIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B22,1,0,false,true )
             ,new CursorDef("P001B23", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B23,1,0,false,true )
             ,new CursorDef("P001B24", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosDesde ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B24,1,0,false,true )
             ,new CursorDef("P001B25", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) WHERE [W53POS] = @TTBUS2_CodPosHacia ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001B25,1,0,false,true )
             ,new CursorDef("P001B26", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie], [TTBUS14_FechaAdquisicion], [TTBUS14_Empresa]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_FechaEnvio, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_PosHacia, @TTBUS14_MarcaEnvio, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie, convert( DATETIME, '17530101', 112 ), convert(int, 0))", GxErrorMask.GX_NOMASK,prmP001B26)
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
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[10])[0] = rslt.getString(8, 50) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 16) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((String[]) buf[17])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                ((int[]) buf[19])[0] = rslt.getInt(14) ;
                ((short[]) buf[20])[0] = rslt.getShort(15) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 3 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((long[]) buf[7])[0] = rslt.getLong(8) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getString(5, 30) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[10])[0] = rslt.getString(8, 50) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((short[]) buf[14])[0] = rslt.getShort(11) ;
                ((String[]) buf[15])[0] = rslt.getString(12, 16) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                ((String[]) buf[17])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(13);
                ((int[]) buf[19])[0] = rslt.getInt(14) ;
                ((short[]) buf[20])[0] = rslt.getShort(15) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 13 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 19 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDateTime(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((long[]) buf[6])[0] = rslt.getLong(7) ;
                break;
             case 20 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((int[]) buf[3])[0] = rslt.getInt(3) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getString(6, 30) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getString(7, 30) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 22 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 23 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[10]);
                }
                stmt.SetParameter(11, (short)parms[11]);
                stmt.SetParameter(12, (String)parms[12]);
                stmt.SetParameter(13, (String)parms[13]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
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
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[9]);
                }
                stmt.SetParameter(10, (short)parms[10]);
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[14]);
                }
                stmt.SetParameter(13, (short)parms[15]);
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (String)parms[17]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[10]);
                }
                stmt.SetParameter(11, (short)parms[11]);
                stmt.SetParameter(12, (String)parms[12]);
                stmt.SetParameter(13, (String)parms[13]);
                break;
             case 14 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[9]);
                }
                stmt.SetParameter(10, (short)parms[10]);
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[14]);
                }
                stmt.SetParameter(13, (short)parms[15]);
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (String)parms[17]);
                break;
             case 20 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 23 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 24 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 9 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(9, (DateTime)parms[9]);
                }
                stmt.SetParameter(10, (short)parms[10]);
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[12]);
                }
                if ( (bool)parms[13] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[14]);
                }
                stmt.SetParameter(13, (short)parms[15]);
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (String)parms[17]);
                break;
       }
    }

 }

}
