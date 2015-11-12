/*
               File: PTBUS014_1
        Description: Listado de bienes por posición (en excel)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:56.32
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
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ptbus014_1 : GXProcedure
   {
      public ptbus014_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus014_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref short aP1_TTBUS7_Pos ,
                           ref short aP2_TTBUS_RubroBien )
      {
         this.AV28USUARIO = aP0_USUARIO;
         this.AV27TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV28USUARIO;
         aP1_TTBUS7_Pos=this.AV27TTBUS7_Pos;
         aP2_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_USUARIO ,
                               ref short aP1_TTBUS7_Pos )
      {
         this.AV28USUARIO = aP0_USUARIO;
         this.AV27TTBUS7_Pos = aP1_TTBUS7_Pos;
         this.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV28USUARIO;
         aP1_TTBUS7_Pos=this.AV27TTBUS7_Pos;
         aP2_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
         return AV20TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref short aP1_TTBUS7_Pos ,
                                 ref short aP2_TTBUS_RubroBien )
      {
         ptbus014_1 objptbus014_1;
         objptbus014_1 = new ptbus014_1();
         objptbus014_1.AV28USUARIO = aP0_USUARIO;
         objptbus014_1.AV27TTBUS7_Pos = aP1_TTBUS7_Pos;
         objptbus014_1.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         objptbus014_1.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus014_1.executePrivateCatch ));
         aP0_USUARIO=this.AV28USUARIO;
         aP1_TTBUS7_Pos=this.AV27TTBUS7_Pos;
         aP2_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
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
         AV8AHORA = DateTimeUtil.Now( ) ;
         AV15NOMBRE_REPORTE = "PlanillaBienesPorPosicion_" + StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( AV8AHORA)), 10, 0)) + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Month( AV8AHORA)), 2, 0), 2, "0") + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Day( AV8AHORA)), 2, 0), 2, "0") + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) + ".xls" ;
         AV29planilla_excel.Open(AV15NOMBRE_REPORTE);
         AV29planilla_excel.Clear();
         AV29planilla_excel.SelectSheet("Sheet1");
         AV29planilla_excel.RenameSheet("Datos Planilla");
         AV29planilla_excel.SelectSheet("Datos Planilla");
         AV29planilla_excel.get_Cells(1, 1, 1, 1).Text = "TRAZABILIDAD DE BIENES DE USO" ;
         AV29planilla_excel.get_Cells(1, 1, 1, 1).Size = 14 ;
         AV29planilla_excel.get_Cells(1, 1, 1, 1).Bold = 1 ;
         AV29planilla_excel.get_Cells(1, 1, 1, 1).Underline = 1 ;
         AV29planilla_excel.get_Cells(2, 1, 1, 1).Text = "PLANILLA DE BIENES DE USO POR POSICIÓN" ;
         AV29planilla_excel.get_Cells(2, 1, 1, 1).Size = 12 ;
         AV29planilla_excel.get_Cells(2, 1, 1, 1).Bold = 1 ;
         AV30renglones = 0 ;
         AV31FILA = 4 ;
         AV29planilla_excel.get_Cells(AV31FILA, 1, 1, 1).Text = "Posición" ;
         AV29planilla_excel.get_Cells(AV31FILA, 2, 1, 1).Text = "Nº Etiqueta" ;
         AV29planilla_excel.get_Cells(AV31FILA, 3, 1, 1).Text = "Nº Bien" ;
         AV29planilla_excel.get_Cells(AV31FILA, 4, 1, 1).Text = "Descripción" ;
         AV29planilla_excel.get_Cells(AV31FILA, 5, 1, 1).Text = "Rubro" ;
         AV29planilla_excel.get_Cells(AV31FILA, 6, 1, 1).Text = "Fecha Carga" ;
         AV29planilla_excel.get_Cells(AV31FILA, 7, 1, 1).Text = "Proveedor" ;
         AV29planilla_excel.get_Cells(AV31FILA, 8, 1, 1).Text = "Responsable Actual" ;
         AV29planilla_excel.get_Cells(AV31FILA, 9, 1, 1).Text = "Pos. Desde" ;
         AV29planilla_excel.get_Cells(AV31FILA, 10, 1, 1).Text = "Pos. Hacia" ;
         AV29planilla_excel.get_Cells(AV31FILA, 11, 1, 1).Text = "Resp. Envío" ;
         AV29planilla_excel.get_Cells(AV31FILA, 12, 1, 1).Text = "Resp. Recep." ;
         AV29planilla_excel.get_Cells(AV31FILA, 13, 1, 1).Text = "Fecha Envío" ;
         AV31FILA = (int)(AV31FILA+1) ;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV27TTBUS7_Pos ,
                                              A37TTBUS_CodPosicion },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor P00192 */
         pr_default.execute(0, new Object[] {AV27TTBUS7_Pos});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK192 = false ;
            A27TTBUS_CodProveedor = P00192_A27TTBUS_CodProveedor[0] ;
            n27TTBUS_CodProveedor = P00192_n27TTBUS_CodProveedor[0] ;
            A31W53POS = P00192_A31W53POS[0] ;
            A35TTBUS7_CodResp = P00192_A35TTBUS7_CodResp[0] ;
            n35TTBUS7_CodResp = P00192_n35TTBUS7_CodResp[0] ;
            A17TTBUS_RubroBien = P00192_A17TTBUS_RubroBien[0] ;
            A249USU_MAIW = P00192_A249USU_MAIW[0] ;
            n249USU_MAIW = P00192_n249USU_MAIW[0] ;
            A180USU_INT = P00192_A180USU_INT[0] ;
            n180USU_INT = P00192_n180USU_INT[0] ;
            A155USU_CLA = P00192_A155USU_CLA[0] ;
            n155USU_CLA = P00192_n155USU_CLA[0] ;
            A32W53DES = P00192_A32W53DES[0] ;
            A11TTBUS_Id = P00192_A11TTBUS_Id[0] ;
            A12TTBUS_Descripcion = P00192_A12TTBUS_Descripcion[0] ;
            A18TTBUS_RubroDesc = P00192_A18TTBUS_RubroDesc[0] ;
            n18TTBUS_RubroDesc = P00192_n18TTBUS_RubroDesc[0] ;
            A13TTBUS_FechaCarga = P00192_A13TTBUS_FechaCarga[0] ;
            A30TTBUS_DesProveedor = P00192_A30TTBUS_DesProveedor[0] ;
            n30TTBUS_DesProveedor = P00192_n30TTBUS_DesProveedor[0] ;
            A23TTBUS_Estado = P00192_A23TTBUS_Estado[0] ;
            A42TTBUS_NroSerie = P00192_A42TTBUS_NroSerie[0] ;
            n42TTBUS_NroSerie = P00192_n42TTBUS_NroSerie[0] ;
            A37TTBUS_CodPosicion = P00192_A37TTBUS_CodPosicion[0] ;
            A38TTBUS_DesPosicion = P00192_A38TTBUS_DesPosicion[0] ;
            A30TTBUS_DesProveedor = P00192_A30TTBUS_DesProveedor[0] ;
            n30TTBUS_DesProveedor = P00192_n30TTBUS_DesProveedor[0] ;
            A18TTBUS_RubroDesc = P00192_A18TTBUS_RubroDesc[0] ;
            n18TTBUS_RubroDesc = P00192_n18TTBUS_RubroDesc[0] ;
            A35TTBUS7_CodResp = P00192_A35TTBUS7_CodResp[0] ;
            n35TTBUS7_CodResp = P00192_n35TTBUS7_CodResp[0] ;
            A249USU_MAIW = P00192_A249USU_MAIW[0] ;
            n249USU_MAIW = P00192_n249USU_MAIW[0] ;
            A180USU_INT = P00192_A180USU_INT[0] ;
            n180USU_INT = P00192_n180USU_INT[0] ;
            A155USU_CLA = P00192_A155USU_CLA[0] ;
            n155USU_CLA = P00192_n155USU_CLA[0] ;
            A32W53DES = P00192_A32W53DES[0] ;
            OV38TTBUS_Estado = AV38TTBUS_Estado ;
            if ( A37TTBUS_CodPosicion == 0 )
            {
               AV18TTBUS_DesPosicion = "SIN POSICIÓN POR CAMBIO DE SECTOR" ;
            }
            else
            {
               AV18TTBUS_DesPosicion = A38TTBUS_DesPosicion ;
            }
            AV29planilla_excel.get_Cells(AV31FILA, 1, 1, 1).Text = StringUtil.Trim( AV18TTBUS_DesPosicion) ;
            while ( (pr_default.getStatus(0) != 101) && ( P00192_A37TTBUS_CodPosicion[0] == A37TTBUS_CodPosicion ) )
            {
               BRK192 = false ;
               A27TTBUS_CodProveedor = P00192_A27TTBUS_CodProveedor[0] ;
               n27TTBUS_CodProveedor = P00192_n27TTBUS_CodProveedor[0] ;
               A31W53POS = P00192_A31W53POS[0] ;
               A35TTBUS7_CodResp = P00192_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00192_n35TTBUS7_CodResp[0] ;
               A17TTBUS_RubroBien = P00192_A17TTBUS_RubroBien[0] ;
               A249USU_MAIW = P00192_A249USU_MAIW[0] ;
               n249USU_MAIW = P00192_n249USU_MAIW[0] ;
               A180USU_INT = P00192_A180USU_INT[0] ;
               n180USU_INT = P00192_n180USU_INT[0] ;
               A155USU_CLA = P00192_A155USU_CLA[0] ;
               n155USU_CLA = P00192_n155USU_CLA[0] ;
               A32W53DES = P00192_A32W53DES[0] ;
               A11TTBUS_Id = P00192_A11TTBUS_Id[0] ;
               A12TTBUS_Descripcion = P00192_A12TTBUS_Descripcion[0] ;
               A18TTBUS_RubroDesc = P00192_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P00192_n18TTBUS_RubroDesc[0] ;
               A13TTBUS_FechaCarga = P00192_A13TTBUS_FechaCarga[0] ;
               A30TTBUS_DesProveedor = P00192_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P00192_n30TTBUS_DesProveedor[0] ;
               A23TTBUS_Estado = P00192_A23TTBUS_Estado[0] ;
               A42TTBUS_NroSerie = P00192_A42TTBUS_NroSerie[0] ;
               n42TTBUS_NroSerie = P00192_n42TTBUS_NroSerie[0] ;
               A30TTBUS_DesProveedor = P00192_A30TTBUS_DesProveedor[0] ;
               n30TTBUS_DesProveedor = P00192_n30TTBUS_DesProveedor[0] ;
               A18TTBUS_RubroDesc = P00192_A18TTBUS_RubroDesc[0] ;
               n18TTBUS_RubroDesc = P00192_n18TTBUS_RubroDesc[0] ;
               A35TTBUS7_CodResp = P00192_A35TTBUS7_CodResp[0] ;
               n35TTBUS7_CodResp = P00192_n35TTBUS7_CodResp[0] ;
               A249USU_MAIW = P00192_A249USU_MAIW[0] ;
               n249USU_MAIW = P00192_n249USU_MAIW[0] ;
               A180USU_INT = P00192_A180USU_INT[0] ;
               n180USU_INT = P00192_n180USU_INT[0] ;
               A155USU_CLA = P00192_A155USU_CLA[0] ;
               n155USU_CLA = P00192_n155USU_CLA[0] ;
               A32W53DES = P00192_A32W53DES[0] ;
               AV26TTBUS7_DesResp = "" ;
               AV11dW53DES = "" ;
               AV14hW53DES = "" ;
               AV10dUSU_DES = "" ;
               AV13hUSU_DES = "" ;
               new ptbus009(context ).execute(  A11TTBUS_Id,  1, out  AV40NumeroIdentificador) ;
               AV19TTBUS_Id = A11TTBUS_Id ;
               AV33TTBUS_Descripcion = A12TTBUS_Descripcion ;
               AV34TTBUS_RubroDesc = A18TTBUS_RubroDesc ;
               AV35TTBUS_FechaCarga = A13TTBUS_FechaCarga ;
               AV37TTBUS_DesProveedor = A30TTBUS_DesProveedor ;
               AV38TTBUS_Estado = A23TTBUS_Estado ;
               AV41TTBUS_NroSerie = A42TTBUS_NroSerie ;
               if ( A23TTBUS_Estado == 1 )
               {
                  AV12estado = "ASIGNADO A UN SECTOR" ;
               }
               else if ( A23TTBUS_Estado == 2 )
               {
                  AV12estado = "CAMBIANDO DE SECTOR" ;
               }
               AV9band = 0 ;
               new ptbus007(context ).execute( ref  AV9band,  AV19TTBUS_Id,  AV28USUARIO) ;
               if ( A23TTBUS_Estado == 1 )
               {
                  AV43TTBUS_CodPosicion = A37TTBUS_CodPosicion ;
                  /* Execute user subroutine: S12174 */
                  S12174 ();
                  if ( returnInSub )
                  {
                     pr_default.close(0);
                     this.cleanup();
                     if (true) return;
                  }
                  if ( AV9band == 1 )
                  {
                     /* Execute user subroutine: S11155 */
                     S11155 ();
                     if ( returnInSub )
                     {
                        pr_default.close(0);
                        this.cleanup();
                        if (true) return;
                     }
                  }
               }
               else
               {
                  /* Using cursor P00193 */
                  pr_default.execute(1, new Object[] {AV19TTBUS_Id});
                  while ( (pr_default.getStatus(1) != 101) )
                  {
                     A26TTBUS2_EstadoEnvio = P00193_A26TTBUS2_EstadoEnvio[0] ;
                     A22TTBUS2_IdBien = P00193_A22TTBUS2_IdBien[0] ;
                     A24TTBUS2_RespDesde = P00193_A24TTBUS2_RespDesde[0] ;
                     A25TTBUS2_RespHacia = P00193_A25TTBUS2_RespHacia[0] ;
                     A48TTBUS2_CodPosDesde = P00193_A48TTBUS2_CodPosDesde[0] ;
                     A49TTBUS2_CodPosHacia = P00193_A49TTBUS2_CodPosHacia[0] ;
                     A45TTBUS2_FechaEnvio = P00193_A45TTBUS2_FechaEnvio[0] ;
                     A52TTBUS2_IdMovimiento = P00193_A52TTBUS2_IdMovimiento[0] ;
                     AV23TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                     AV24TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                     AV21TTBUS2_CodPosDesde = A48TTBUS2_CodPosDesde ;
                     AV22TTBUS2_CodPosHacia = A49TTBUS2_CodPosHacia ;
                     AV39TTBUS2_FechaEnvio = A45TTBUS2_FechaEnvio ;
                     /* Using cursor P00194 */
                     pr_default.execute(2, new Object[] {AV21TTBUS2_CodPosDesde, A32W53DES});
                     while ( (pr_default.getStatus(2) != 101) )
                     {
                        A31W53POS = P00194_A31W53POS[0] ;
                        AV11dW53DES = A32W53DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(2);
                     /* Using cursor P00195 */
                     pr_default.execute(3, new Object[] {AV22TTBUS2_CodPosHacia, A32W53DES});
                     while ( (pr_default.getStatus(3) != 101) )
                     {
                        A31W53POS = P00195_A31W53POS[0] ;
                        AV14hW53DES = A32W53DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(3);
                     /* Using cursor P00196 */
                     pr_default.execute(4, new Object[] {AV23TTBUS2_RespDesde, A7USU_DES, n155USU_CLA, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
                     while ( (pr_default.getStatus(4) != 101) )
                     {
                        A6USU_COD = P00196_A6USU_COD[0] ;
                        AV10dUSU_DES = A7USU_DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(4);
                     /* Using cursor P00197 */
                     pr_default.execute(5, new Object[] {AV24TTBUS2_RespHacia, A7USU_DES, n155USU_CLA, A155USU_CLA, n180USU_INT, A180USU_INT, n249USU_MAIW, A249USU_MAIW});
                     while ( (pr_default.getStatus(5) != 101) )
                     {
                        A6USU_COD = P00197_A6USU_COD[0] ;
                        AV13hUSU_DES = A7USU_DES ;
                        /* Exiting from a For First loop. */
                        if (true) break;
                     }
                     pr_default.close(5);
                     pr_default.readNext(1);
                  }
                  pr_default.close(1);
                  if ( AV9band == 1 )
                  {
                     /* Execute user subroutine: S11155 */
                     S11155 ();
                     if ( returnInSub )
                     {
                        pr_default.close(0);
                        this.cleanup();
                        if (true) return;
                     }
                  }
               }
               BRK192 = true ;
               pr_default.readNext(0);
            }
            AV31FILA = (int)(AV31FILA+1) ;
            if ( ! BRK192 )
            {
               BRK192 = true ;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         AV29planilla_excel.Save();
         AV29planilla_excel.Close();
         context.wjLoc = AV15NOMBRE_REPORTE ;
         this.cleanup();
      }

      protected void S11155( )
      {
         /* 'DETALLE' Routine */
         AV29planilla_excel.get_Cells(AV31FILA, 2, 1, 1).Text = AV40NumeroIdentificador ;
         AV29planilla_excel.get_Cells(AV31FILA, 3, 1, 1).Number = AV19TTBUS_Id ;
         AV29planilla_excel.get_Cells(AV31FILA, 4, 1, 1).Text = AV33TTBUS_Descripcion ;
         AV29planilla_excel.get_Cells(AV31FILA, 5, 1, 1).Text = AV34TTBUS_RubroDesc ;
         GXt_dtime1 = DateTimeUtil.ResetTime( AV35TTBUS_FechaCarga ) ;
         AV29planilla_excel.get_Cells(AV31FILA, 6, 1, 1).Date = GXt_dtime1 ;
         AV29planilla_excel.get_Cells(AV31FILA, 7, 1, 1).Text = AV37TTBUS_DesProveedor ;
         AV29planilla_excel.get_Cells(AV31FILA, 8, 1, 1).Text = AV26TTBUS7_DesResp ;
         AV29planilla_excel.get_Cells(AV31FILA, 9, 1, 1).Text = AV11dW53DES ;
         AV29planilla_excel.get_Cells(AV31FILA, 10, 1, 1).Text = AV14hW53DES ;
         AV29planilla_excel.get_Cells(AV31FILA, 11, 1, 1).Text = AV10dUSU_DES ;
         AV29planilla_excel.get_Cells(AV31FILA, 12, 1, 1).Text = AV13hUSU_DES ;
         AV29planilla_excel.get_Cells(AV31FILA, 13, 1, 1).Date = AV39TTBUS2_FechaEnvio ;
         AV31FILA = (int)(AV31FILA+1) ;
      }

      protected void S12174( )
      {
         /* 'RESPONSABLE' Routine */
         AV26TTBUS7_DesResp = "" ;
         /* Using cursor P00198 */
         pr_default.execute(6, new Object[] {AV43TTBUS_CodPosicion});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A35TTBUS7_CodResp = P00198_A35TTBUS7_CodResp[0] ;
            n35TTBUS7_CodResp = P00198_n35TTBUS7_CodResp[0] ;
            A33TTBUS7_Pos = P00198_A33TTBUS7_Pos[0] ;
            A36TTBUS7_DesResp = P00198_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = P00198_n36TTBUS7_DesResp[0] ;
            A36TTBUS7_DesResp = P00198_A36TTBUS7_DesResp[0] ;
            n36TTBUS7_DesResp = P00198_n36TTBUS7_DesResp[0] ;
            AV26TTBUS7_DesResp = A36TTBUS7_DesResp ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(6);
      }

      protected void cleanup( )
      {
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
         AV8AHORA = (DateTime)(DateTime.MinValue) ;
         AV15NOMBRE_REPORTE = "" ;
         Gx_time = "" ;
         AV29planilla_excel = new ExcelDocumentI();
         scmdbuf = "" ;
         P00192_A27TTBUS_CodProveedor = new int[1] ;
         P00192_n27TTBUS_CodProveedor = new bool[] {false} ;
         P00192_A31W53POS = new short[1] ;
         P00192_A35TTBUS7_CodResp = new String[] {""} ;
         P00192_n35TTBUS7_CodResp = new bool[] {false} ;
         P00192_A17TTBUS_RubroBien = new short[1] ;
         P00192_A249USU_MAIW = new String[] {""} ;
         P00192_n249USU_MAIW = new bool[] {false} ;
         P00192_A180USU_INT = new String[] {""} ;
         P00192_n180USU_INT = new bool[] {false} ;
         P00192_A155USU_CLA = new String[] {""} ;
         P00192_n155USU_CLA = new bool[] {false} ;
         P00192_A32W53DES = new String[] {""} ;
         P00192_A11TTBUS_Id = new int[1] ;
         P00192_A12TTBUS_Descripcion = new String[] {""} ;
         P00192_A18TTBUS_RubroDesc = new String[] {""} ;
         P00192_n18TTBUS_RubroDesc = new bool[] {false} ;
         P00192_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P00192_A30TTBUS_DesProveedor = new String[] {""} ;
         P00192_n30TTBUS_DesProveedor = new bool[] {false} ;
         P00192_A23TTBUS_Estado = new short[1] ;
         P00192_A42TTBUS_NroSerie = new String[] {""} ;
         P00192_n42TTBUS_NroSerie = new bool[] {false} ;
         P00192_A37TTBUS_CodPosicion = new short[1] ;
         P00192_A38TTBUS_DesPosicion = new String[] {""} ;
         A35TTBUS7_CodResp = "" ;
         A249USU_MAIW = "" ;
         A180USU_INT = "" ;
         A155USU_CLA = "" ;
         A32W53DES = "" ;
         A12TTBUS_Descripcion = "" ;
         A18TTBUS_RubroDesc = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A42TTBUS_NroSerie = "" ;
         A38TTBUS_DesPosicion = "" ;
         AV38TTBUS_Estado = 1 ;
         AV18TTBUS_DesPosicion = "" ;
         AV26TTBUS7_DesResp = "" ;
         AV11dW53DES = "" ;
         AV14hW53DES = "" ;
         AV10dUSU_DES = "" ;
         AV13hUSU_DES = "" ;
         AV40NumeroIdentificador = "" ;
         AV33TTBUS_Descripcion = "" ;
         AV34TTBUS_RubroDesc = "" ;
         AV35TTBUS_FechaCarga = DateTime.MinValue ;
         AV37TTBUS_DesProveedor = "" ;
         AV41TTBUS_NroSerie = "" ;
         AV12estado = "" ;
         P00193_A26TTBUS2_EstadoEnvio = new short[1] ;
         P00193_A22TTBUS2_IdBien = new int[1] ;
         P00193_A24TTBUS2_RespDesde = new String[] {""} ;
         P00193_A25TTBUS2_RespHacia = new String[] {""} ;
         P00193_A48TTBUS2_CodPosDesde = new short[1] ;
         P00193_A49TTBUS2_CodPosHacia = new short[1] ;
         P00193_A45TTBUS2_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P00193_A52TTBUS2_IdMovimiento = new long[1] ;
         A24TTBUS2_RespDesde = "" ;
         A25TTBUS2_RespHacia = "" ;
         A45TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV23TTBUS2_RespDesde = "" ;
         AV24TTBUS2_RespHacia = "" ;
         AV39TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         P00194_A32W53DES = new String[] {""} ;
         P00194_A31W53POS = new short[1] ;
         P00195_A32W53DES = new String[] {""} ;
         P00195_A31W53POS = new short[1] ;
         A7USU_DES = "" ;
         P00196_A7USU_DES = new String[] {""} ;
         P00196_A155USU_CLA = new String[] {""} ;
         P00196_n155USU_CLA = new bool[] {false} ;
         P00196_A180USU_INT = new String[] {""} ;
         P00196_n180USU_INT = new bool[] {false} ;
         P00196_A249USU_MAIW = new String[] {""} ;
         P00196_n249USU_MAIW = new bool[] {false} ;
         P00196_A6USU_COD = new String[] {""} ;
         A6USU_COD = "" ;
         P00197_A7USU_DES = new String[] {""} ;
         P00197_A155USU_CLA = new String[] {""} ;
         P00197_n155USU_CLA = new bool[] {false} ;
         P00197_A180USU_INT = new String[] {""} ;
         P00197_n180USU_INT = new bool[] {false} ;
         P00197_A249USU_MAIW = new String[] {""} ;
         P00197_n249USU_MAIW = new bool[] {false} ;
         P00197_A6USU_COD = new String[] {""} ;
         GXt_dtime1 = (DateTime)(DateTime.MinValue) ;
         P00198_A35TTBUS7_CodResp = new String[] {""} ;
         P00198_n35TTBUS7_CodResp = new bool[] {false} ;
         P00198_A33TTBUS7_Pos = new short[1] ;
         P00198_A36TTBUS7_DesResp = new String[] {""} ;
         P00198_n36TTBUS7_DesResp = new bool[] {false} ;
         A36TTBUS7_DesResp = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus014_1__default(),
            new Object[][] {
                new Object[] {
               P00192_A27TTBUS_CodProveedor, P00192_n27TTBUS_CodProveedor, P00192_A31W53POS, P00192_A35TTBUS7_CodResp, P00192_n35TTBUS7_CodResp, P00192_A17TTBUS_RubroBien, P00192_A249USU_MAIW, P00192_n249USU_MAIW, P00192_A180USU_INT, P00192_n180USU_INT,
               P00192_A155USU_CLA, P00192_n155USU_CLA, P00192_A32W53DES, P00192_A11TTBUS_Id, P00192_A12TTBUS_Descripcion, P00192_A18TTBUS_RubroDesc, P00192_n18TTBUS_RubroDesc, P00192_A13TTBUS_FechaCarga, P00192_A30TTBUS_DesProveedor, P00192_n30TTBUS_DesProveedor,
               P00192_A23TTBUS_Estado, P00192_A42TTBUS_NroSerie, P00192_n42TTBUS_NroSerie, P00192_A37TTBUS_CodPosicion, P00192_A38TTBUS_DesPosicion
               }
               , new Object[] {
               P00193_A26TTBUS2_EstadoEnvio, P00193_A22TTBUS2_IdBien, P00193_A24TTBUS2_RespDesde, P00193_A25TTBUS2_RespHacia, P00193_A48TTBUS2_CodPosDesde, P00193_A49TTBUS2_CodPosHacia, P00193_A45TTBUS2_FechaEnvio, P00193_A52TTBUS2_IdMovimiento
               }
               , new Object[] {
               P00194_A32W53DES, P00194_A31W53POS
               }
               , new Object[] {
               P00195_A32W53DES, P00195_A31W53POS
               }
               , new Object[] {
               P00196_A7USU_DES, P00196_A155USU_CLA, P00196_A180USU_INT, P00196_n180USU_INT, P00196_A249USU_MAIW, P00196_n249USU_MAIW, P00196_A6USU_COD
               }
               , new Object[] {
               P00197_A7USU_DES, P00197_A155USU_CLA, P00197_A180USU_INT, P00197_n180USU_INT, P00197_A249USU_MAIW, P00197_n249USU_MAIW, P00197_A6USU_COD
               }
               , new Object[] {
               P00198_A35TTBUS7_CodResp, P00198_A33TTBUS7_Pos, P00198_A36TTBUS7_DesResp, P00198_n36TTBUS7_DesResp
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         context.Gx_err = 0 ;
      }

      private short AV27TTBUS7_Pos ;
      private short AV20TTBUS_RubroBien ;
      private short AV30renglones ;
      private short A37TTBUS_CodPosicion ;
      private short A31W53POS ;
      private short A17TTBUS_RubroBien ;
      private short A23TTBUS_Estado ;
      private short OV38TTBUS_Estado ;
      private short AV38TTBUS_Estado ;
      private short AV9band ;
      private short AV43TTBUS_CodPosicion ;
      private short A26TTBUS2_EstadoEnvio ;
      private short A48TTBUS2_CodPosDesde ;
      private short A49TTBUS2_CodPosHacia ;
      private short AV21TTBUS2_CodPosDesde ;
      private short AV22TTBUS2_CodPosHacia ;
      private short A33TTBUS7_Pos ;
      private int AV31FILA ;
      private int A27TTBUS_CodProveedor ;
      private int A11TTBUS_Id ;
      private int AV19TTBUS_Id ;
      private int A22TTBUS2_IdBien ;
      private long A52TTBUS2_IdMovimiento ;
      private String AV28USUARIO ;
      private String AV15NOMBRE_REPORTE ;
      private String Gx_time ;
      private String scmdbuf ;
      private String A35TTBUS7_CodResp ;
      private String A180USU_INT ;
      private String A155USU_CLA ;
      private String A32W53DES ;
      private String A18TTBUS_RubroDesc ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String AV18TTBUS_DesPosicion ;
      private String AV26TTBUS7_DesResp ;
      private String AV11dW53DES ;
      private String AV14hW53DES ;
      private String AV10dUSU_DES ;
      private String AV13hUSU_DES ;
      private String AV34TTBUS_RubroDesc ;
      private String AV37TTBUS_DesProveedor ;
      private String AV12estado ;
      private String A24TTBUS2_RespDesde ;
      private String A25TTBUS2_RespHacia ;
      private String AV23TTBUS2_RespDesde ;
      private String AV24TTBUS2_RespHacia ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A36TTBUS7_DesResp ;
      private DateTime AV8AHORA ;
      private DateTime A45TTBUS2_FechaEnvio ;
      private DateTime AV39TTBUS2_FechaEnvio ;
      private DateTime GXt_dtime1 ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime AV35TTBUS_FechaCarga ;
      private bool BRK192 ;
      private bool n27TTBUS_CodProveedor ;
      private bool n35TTBUS7_CodResp ;
      private bool n249USU_MAIW ;
      private bool n180USU_INT ;
      private bool n155USU_CLA ;
      private bool n18TTBUS_RubroDesc ;
      private bool n30TTBUS_DesProveedor ;
      private bool n42TTBUS_NroSerie ;
      private bool returnInSub ;
      private bool n36TTBUS7_DesResp ;
      private String A249USU_MAIW ;
      private String A12TTBUS_Descripcion ;
      private String A42TTBUS_NroSerie ;
      private String AV40NumeroIdentificador ;
      private String AV33TTBUS_Descripcion ;
      private String AV41TTBUS_NroSerie ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private short aP1_TTBUS7_Pos ;
      private short aP2_TTBUS_RubroBien ;
      private IDataStoreProvider pr_default ;
      private int[] P00192_A27TTBUS_CodProveedor ;
      private bool[] P00192_n27TTBUS_CodProveedor ;
      private short[] P00192_A31W53POS ;
      private String[] P00192_A35TTBUS7_CodResp ;
      private bool[] P00192_n35TTBUS7_CodResp ;
      private short[] P00192_A17TTBUS_RubroBien ;
      private String[] P00192_A249USU_MAIW ;
      private bool[] P00192_n249USU_MAIW ;
      private String[] P00192_A180USU_INT ;
      private bool[] P00192_n180USU_INT ;
      private String[] P00192_A155USU_CLA ;
      private bool[] P00192_n155USU_CLA ;
      private String[] P00192_A32W53DES ;
      private int[] P00192_A11TTBUS_Id ;
      private String[] P00192_A12TTBUS_Descripcion ;
      private String[] P00192_A18TTBUS_RubroDesc ;
      private bool[] P00192_n18TTBUS_RubroDesc ;
      private DateTime[] P00192_A13TTBUS_FechaCarga ;
      private String[] P00192_A30TTBUS_DesProveedor ;
      private bool[] P00192_n30TTBUS_DesProveedor ;
      private short[] P00192_A23TTBUS_Estado ;
      private String[] P00192_A42TTBUS_NroSerie ;
      private bool[] P00192_n42TTBUS_NroSerie ;
      private short[] P00192_A37TTBUS_CodPosicion ;
      private String[] P00192_A38TTBUS_DesPosicion ;
      private short[] P00193_A26TTBUS2_EstadoEnvio ;
      private int[] P00193_A22TTBUS2_IdBien ;
      private String[] P00193_A24TTBUS2_RespDesde ;
      private String[] P00193_A25TTBUS2_RespHacia ;
      private short[] P00193_A48TTBUS2_CodPosDesde ;
      private short[] P00193_A49TTBUS2_CodPosHacia ;
      private DateTime[] P00193_A45TTBUS2_FechaEnvio ;
      private long[] P00193_A52TTBUS2_IdMovimiento ;
      private String[] P00194_A32W53DES ;
      private short[] P00194_A31W53POS ;
      private String[] P00195_A32W53DES ;
      private short[] P00195_A31W53POS ;
      private String[] P00196_A7USU_DES ;
      private String[] P00196_A155USU_CLA ;
      private bool[] P00196_n155USU_CLA ;
      private String[] P00196_A180USU_INT ;
      private bool[] P00196_n180USU_INT ;
      private String[] P00196_A249USU_MAIW ;
      private bool[] P00196_n249USU_MAIW ;
      private String[] P00196_A6USU_COD ;
      private String[] P00197_A7USU_DES ;
      private String[] P00197_A155USU_CLA ;
      private bool[] P00197_n155USU_CLA ;
      private String[] P00197_A180USU_INT ;
      private bool[] P00197_n180USU_INT ;
      private String[] P00197_A249USU_MAIW ;
      private bool[] P00197_n249USU_MAIW ;
      private String[] P00197_A6USU_COD ;
      private String[] P00198_A35TTBUS7_CodResp ;
      private bool[] P00198_n35TTBUS7_CodResp ;
      private short[] P00198_A33TTBUS7_Pos ;
      private String[] P00198_A36TTBUS7_DesResp ;
      private bool[] P00198_n36TTBUS7_DesResp ;
      private ExcelDocumentI AV29planilla_excel ;
   }

   public class ptbus014_1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00192( short AV27TTBUS7_Pos ,
                                             short A37TTBUS_CodPosicion )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [1] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T6.[W53POS], T4.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS_RubroBien] AS TTBUS_RubroBien, T5.[USU_MAIW], T5.[USU_INT], T5.[USU_CLA], T6.[W53DES], T1.[TTBUS_Id], T1.[TTBUS_Descripcion], T3.[RBR_DES] AS TTBUS_RubroDesc, T1.[TTBUS_FechaCarga], T2.[PV_DESC] AS TTBUS_DesProveedor, T1.[TTBUS_Estado], T1.[TTBUS_NroSerie], T1.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T1.[TTBUS_DesPosicion] FROM ((((([TTBUS000] T1 WITH (NOLOCK) LEFT JOIN [M124FPROV] T2 WITH (NOLOCK) ON T2.[PV_NPRO] = T1.[TTBUS_CodProveedor]) INNER JOIN [BUS002] T3 WITH (NOLOCK) ON T3.[RBR_COD] = T1.[TTBUS_RubroBien]) INNER JOIN [TTBUS007] T4 WITH (NOLOCK) ON T4.[TTBUS7_Pos] = T1.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T5 WITH (NOLOCK) ON T5.[USU_COD] = T4.[TTBUS7_CodResp]) INNER JOIN [T53FPOS] T6 WITH (NOLOCK) ON T6.[W53POS] = T1.[TTBUS_CodPosicion])" ;
         if ( AV27TTBUS7_Pos != 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[TTBUS_CodPosicion] = @AV27TTBUS7_Pos)" ;
            }
            else
            {
               sWhereString = sWhereString + " (T1.[TTBUS_CodPosicion] = @AV27TTBUS7_Pos)" ;
            }
         }
         else
         {
            GXv_int2[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[TTBUS_CodPosicion]" ;
         GXv_Object3[0] = scmdbuf ;
         GXv_Object3[1] = (Object)(GXv_int2) ;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00192( (short)dynConstraints[0] , (short)dynConstraints[1] );
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
          Object[] prmP00193 ;
          prmP00193 = new Object[] {
          new Object[] {"@AV19TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmP00194 ;
          prmP00194 = new Object[] {
          new Object[] {"@AV21TTBUS2_CodPosDesde",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@W53DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmP00195 ;
          prmP00195 = new Object[] {
          new Object[] {"@AV22TTBUS2_CodPosHacia",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@W53DES",SqlDbType.Char,50,0}
          } ;
          Object[] prmP00196 ;
          prmP00196 = new Object[] {
          new Object[] {"@AV23TTBUS2_RespDesde",SqlDbType.Char,15,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP00197 ;
          prmP00197 = new Object[] {
          new Object[] {"@AV24TTBUS2_RespHacia",SqlDbType.Char,15,0} ,
          new Object[] {"@USU_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@USU_CLA",SqlDbType.Char,20,0} ,
          new Object[] {"@USU_INT",SqlDbType.Char,10,0} ,
          new Object[] {"@USU_MAIW",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmP00198 ;
          prmP00198 = new Object[] {
          new Object[] {"@AV43TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP00192 ;
          prmP00192 = new Object[] {
          new Object[] {"@AV27TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00192", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00192,100,0,true,false )
             ,new CursorDef("P00193", "SELECT [TTBUS2_EstadoEnvio], [TTBUS2_IdBien], [TTBUS2_RespDesde], [TTBUS2_RespHacia], [TTBUS2_CodPosDesde], [TTBUS2_CodPosHacia], [TTBUS2_FechaEnvio], [TTBUS2_IdMovimiento] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @AV19TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00193,100,0,true,false )
             ,new CursorDef("P00194", "SELECT [W53DES], [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ([W53POS] = @AV21TTBUS2_CodPosDesde) AND ([W53DES] = @W53DES) ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00194,1,0,false,true )
             ,new CursorDef("P00195", "SELECT [W53DES], [W53POS] FROM [T53FPOS] WITH (NOLOCK) WHERE ([W53POS] = @AV22TTBUS2_CodPosHacia) AND ([W53DES] = @W53DES) ORDER BY [W53POS] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00195,1,0,false,true )
             ,new CursorDef("P00196", "SELECT [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW], [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ([USU_COD] = @AV23TTBUS2_RespDesde) AND ([USU_DES] = @USU_DES) AND ([USU_CLA] = @USU_CLA) AND ([USU_INT] = @USU_INT) AND ([USU_MAIW] = @USU_MAIW) ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00196,1,0,false,true )
             ,new CursorDef("P00197", "SELECT [USU_DES], [USU_CLA], [USU_INT], [USU_MAIW], [USU_COD] FROM [SEG002] WITH (NOLOCK) WHERE ([USU_COD] = @AV24TTBUS2_RespHacia) AND ([USU_DES] = @USU_DES) AND ([USU_CLA] = @USU_CLA) AND ([USU_INT] = @USU_INT) AND ([USU_MAIW] = @USU_MAIW) ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00197,1,0,false,true )
             ,new CursorDef("P00198", "SELECT T1.[TTBUS7_CodResp] AS TTBUS7_CodResp, T1.[TTBUS7_Pos], T2.[USU_DES] AS TTBUS7_DesResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = T1.[TTBUS7_CodResp]) WHERE T1.[TTBUS7_Pos] = @AV43TTBUS_CodPosicion ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00198,1,0,false,true )
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
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getString(6, 10) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getString(7, 20) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getString(8, 50) ;
                ((int[]) buf[13])[0] = rslt.getInt(9) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[15])[0] = rslt.getString(11, 30) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(12) ;
                ((String[]) buf[18])[0] = rslt.getString(13, 30) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(13);
                ((short[]) buf[20])[0] = rslt.getShort(14) ;
                ((String[]) buf[21])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(15);
                ((short[]) buf[23])[0] = rslt.getShort(16) ;
                ((String[]) buf[24])[0] = rslt.getString(17, 50) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 15) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((long[]) buf[7])[0] = rslt.getLong(8) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 10) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getString(5, 16) ;
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
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
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
