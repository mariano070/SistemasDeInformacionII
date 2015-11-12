/*
               File: PTBUS014_2
        Description: Listado de bienes por responsable (en excel)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:56.91
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
   public class ptbus014_2 : GXProcedure
   {
      public ptbus014_2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus014_2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USUARIO ,
                           ref String aP1_TTBUS7_CodResp ,
                           ref short aP2_TTBUS_RubroBien )
      {
         this.AV37USUARIO = aP0_USUARIO;
         this.AV34TTBUS7_CodResp = aP1_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV37USUARIO;
         aP1_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
         aP2_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_USUARIO ,
                               ref String aP1_TTBUS7_CodResp )
      {
         this.AV37USUARIO = aP0_USUARIO;
         this.AV34TTBUS7_CodResp = aP1_TTBUS7_CodResp;
         this.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_USUARIO=this.AV37USUARIO;
         aP1_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
         aP2_TTBUS_RubroBien=this.AV20TTBUS_RubroBien;
         return AV20TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_USUARIO ,
                                 ref String aP1_TTBUS7_CodResp ,
                                 ref short aP2_TTBUS_RubroBien )
      {
         ptbus014_2 objptbus014_2;
         objptbus014_2 = new ptbus014_2();
         objptbus014_2.AV37USUARIO = aP0_USUARIO;
         objptbus014_2.AV34TTBUS7_CodResp = aP1_TTBUS7_CodResp;
         objptbus014_2.AV20TTBUS_RubroBien = aP2_TTBUS_RubroBien;
         objptbus014_2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus014_2.executePrivateCatch ));
         aP0_USUARIO=this.AV37USUARIO;
         aP1_TTBUS7_CodResp=this.AV34TTBUS7_CodResp;
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
         AV15NOMBRE_REPORTE = "PlanillaBienesPorResponsable_" + StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( AV8AHORA)), 10, 0)) + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Month( AV8AHORA)), 2, 0), 2, "0") + StringUtil.PadL( StringUtil.Str( (decimal)(DateTimeUtil.Day( AV8AHORA)), 2, 0), 2, "0") + StringUtil.Substring( Gx_time, 1, 2) + StringUtil.Substring( Gx_time, 4, 2) + StringUtil.Substring( Gx_time, 7, 2) + ".xls" ;
         new ptbus015(context ).execute( ref  AV34TTBUS7_CodResp) ;
         AV39planilla_excel.Open(AV15NOMBRE_REPORTE);
         AV39planilla_excel.Clear();
         AV39planilla_excel.SelectSheet("Sheet1");
         AV39planilla_excel.RenameSheet("Datos Planilla");
         AV39planilla_excel.SelectSheet("Datos Planilla");
         AV39planilla_excel.get_Cells(1, 1, 1, 1).Text = "TRAZABILIDAD DE BIENES DE USO" ;
         AV39planilla_excel.get_Cells(1, 1, 1, 1).Size = 14 ;
         AV39planilla_excel.get_Cells(1, 1, 1, 1).Bold = 1 ;
         AV39planilla_excel.get_Cells(1, 1, 1, 1).Underline = 1 ;
         AV39planilla_excel.get_Cells(2, 1, 1, 1).Text = "PLANILLA DE BIENES DE USO POR RESPONSABLE" ;
         AV39planilla_excel.get_Cells(2, 1, 1, 1).Size = 12 ;
         AV39planilla_excel.get_Cells(2, 1, 1, 1).Bold = 1 ;
         AV40FILA = 4 ;
         AV39planilla_excel.get_Cells(AV40FILA, 1, 1, 1).Text = "Responsable" ;
         AV39planilla_excel.get_Cells(AV40FILA, 2, 1, 1).Text = "Marca de Envío" ;
         AV39planilla_excel.get_Cells(AV40FILA, 3, 1, 1).Text = "Nº Etiqueta" ;
         AV39planilla_excel.get_Cells(AV40FILA, 4, 1, 1).Text = "Nº Bien" ;
         AV39planilla_excel.get_Cells(AV40FILA, 5, 1, 1).Text = "Descripción" ;
         AV39planilla_excel.get_Cells(AV40FILA, 6, 1, 1).Text = "Rubro" ;
         AV39planilla_excel.get_Cells(AV40FILA, 7, 1, 1).Text = "Fecha Carga" ;
         AV39planilla_excel.get_Cells(AV40FILA, 8, 1, 1).Text = "Fecha Adquisición" ;
         AV39planilla_excel.get_Cells(AV40FILA, 9, 1, 1).Text = "Fecha Envío" ;
         AV39planilla_excel.get_Cells(AV40FILA, 10, 1, 1).Text = "Proveedor" ;
         AV39planilla_excel.get_Cells(AV40FILA, 11, 1, 1).Text = "Posición Actual" ;
         AV39planilla_excel.get_Cells(AV40FILA, 12, 1, 1).Text = "Pos. Desde" ;
         AV39planilla_excel.get_Cells(AV40FILA, 13, 1, 1).Text = "Pos. Hacia" ;
         AV40FILA = (int)(AV40FILA+1) ;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV20TTBUS_RubroBien ,
                                              A214TTBUS14_CodRubro },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         });
         /* Using cursor P001C2 */
         pr_default.execute(0, new Object[] {AV20TTBUS_RubroBien});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK1C2 = false ;
            A215TTBUS14_CodEtiqueta = P001C2_A215TTBUS14_CodEtiqueta[0] ;
            A202TTBUS14_Descripcion = P001C2_A202TTBUS14_Descripcion[0] ;
            A203TTBUS14_Rubro = P001C2_A203TTBUS14_Rubro[0] ;
            A205TTBUS14_FechaCarga = P001C2_A205TTBUS14_FechaCarga[0] ;
            A206TTBUS14_FechaAdquisicion = P001C2_A206TTBUS14_FechaAdquisicion[0] ;
            A207TTBUS14_FechaEnvio = P001C2_A207TTBUS14_FechaEnvio[0] ;
            n207TTBUS14_FechaEnvio = P001C2_n207TTBUS14_FechaEnvio[0] ;
            A204TTBUS14_Proveedor = P001C2_A204TTBUS14_Proveedor[0] ;
            A210TTBUS14_PosDesde = P001C2_A210TTBUS14_PosDesde[0] ;
            n210TTBUS14_PosDesde = P001C2_n210TTBUS14_PosDesde[0] ;
            A208TTBUS14_Estado = P001C2_A208TTBUS14_Estado[0] ;
            A211TTBUS14_PosHacia = P001C2_A211TTBUS14_PosHacia[0] ;
            n211TTBUS14_PosHacia = P001C2_n211TTBUS14_PosHacia[0] ;
            A201TTBUS14_IdBien = P001C2_A201TTBUS14_IdBien[0] ;
            A213TTBUS14_CodResponsable = P001C2_A213TTBUS14_CodResponsable[0] ;
            A212TTBUS14_MarcaEnvio = P001C2_A212TTBUS14_MarcaEnvio[0] ;
            A214TTBUS14_CodRubro = P001C2_A214TTBUS14_CodRubro[0] ;
            A209TTBUS14_Responsable = P001C2_A209TTBUS14_Responsable[0] ;
            AV39planilla_excel.get_Cells(AV40FILA, 1, 1, 1).Text = A209TTBUS14_Responsable ;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001C2_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) )
            {
               BRK1C2 = false ;
               A215TTBUS14_CodEtiqueta = P001C2_A215TTBUS14_CodEtiqueta[0] ;
               A202TTBUS14_Descripcion = P001C2_A202TTBUS14_Descripcion[0] ;
               A203TTBUS14_Rubro = P001C2_A203TTBUS14_Rubro[0] ;
               A205TTBUS14_FechaCarga = P001C2_A205TTBUS14_FechaCarga[0] ;
               A206TTBUS14_FechaAdquisicion = P001C2_A206TTBUS14_FechaAdquisicion[0] ;
               A207TTBUS14_FechaEnvio = P001C2_A207TTBUS14_FechaEnvio[0] ;
               n207TTBUS14_FechaEnvio = P001C2_n207TTBUS14_FechaEnvio[0] ;
               A204TTBUS14_Proveedor = P001C2_A204TTBUS14_Proveedor[0] ;
               A210TTBUS14_PosDesde = P001C2_A210TTBUS14_PosDesde[0] ;
               n210TTBUS14_PosDesde = P001C2_n210TTBUS14_PosDesde[0] ;
               A208TTBUS14_Estado = P001C2_A208TTBUS14_Estado[0] ;
               A211TTBUS14_PosHacia = P001C2_A211TTBUS14_PosHacia[0] ;
               n211TTBUS14_PosHacia = P001C2_n211TTBUS14_PosHacia[0] ;
               A201TTBUS14_IdBien = P001C2_A201TTBUS14_IdBien[0] ;
               A212TTBUS14_MarcaEnvio = P001C2_A212TTBUS14_MarcaEnvio[0] ;
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
               AV39planilla_excel.get_Cells(AV40FILA, 2, 1, 1).Text = AV38MarcaEnvio ;
               while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001C2_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( P001C2_A212TTBUS14_MarcaEnvio[0] == A212TTBUS14_MarcaEnvio ) )
               {
                  BRK1C2 = false ;
                  A215TTBUS14_CodEtiqueta = P001C2_A215TTBUS14_CodEtiqueta[0] ;
                  A202TTBUS14_Descripcion = P001C2_A202TTBUS14_Descripcion[0] ;
                  A203TTBUS14_Rubro = P001C2_A203TTBUS14_Rubro[0] ;
                  A205TTBUS14_FechaCarga = P001C2_A205TTBUS14_FechaCarga[0] ;
                  A206TTBUS14_FechaAdquisicion = P001C2_A206TTBUS14_FechaAdquisicion[0] ;
                  A207TTBUS14_FechaEnvio = P001C2_A207TTBUS14_FechaEnvio[0] ;
                  n207TTBUS14_FechaEnvio = P001C2_n207TTBUS14_FechaEnvio[0] ;
                  A204TTBUS14_Proveedor = P001C2_A204TTBUS14_Proveedor[0] ;
                  A210TTBUS14_PosDesde = P001C2_A210TTBUS14_PosDesde[0] ;
                  n210TTBUS14_PosDesde = P001C2_n210TTBUS14_PosDesde[0] ;
                  A208TTBUS14_Estado = P001C2_A208TTBUS14_Estado[0] ;
                  A211TTBUS14_PosHacia = P001C2_A211TTBUS14_PosHacia[0] ;
                  n211TTBUS14_PosHacia = P001C2_n211TTBUS14_PosHacia[0] ;
                  A201TTBUS14_IdBien = P001C2_A201TTBUS14_IdBien[0] ;
                  AV19TTBUS_Id = A201TTBUS14_IdBien ;
                  AV9band = 0 ;
                  new ptbus007(context ).execute( ref  AV9band,  AV19TTBUS_Id,  AV37USUARIO) ;
                  if ( AV9band == 1 )
                  {
                     AV39planilla_excel.get_Cells(AV40FILA, 3, 1, 1).Text = StringUtil.Trim( A215TTBUS14_CodEtiqueta) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 4, 1, 1).Number = A201TTBUS14_IdBien ;
                     AV39planilla_excel.get_Cells(AV40FILA, 5, 1, 1).Text = StringUtil.Trim( A202TTBUS14_Descripcion) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 6, 1, 1).Text = A203TTBUS14_Rubro ;
                     GXt_dtime2 = DateTimeUtil.ResetTime( A205TTBUS14_FechaCarga ) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 7, 1, 1).Date = GXt_dtime2 ;
                     GXt_dtime2 = DateTimeUtil.ResetTime( A206TTBUS14_FechaAdquisicion ) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 8, 1, 1).Date = GXt_dtime2 ;
                     GXt_dtime2 = DateTimeUtil.ResetTime( A207TTBUS14_FechaEnvio ) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 9, 1, 1).Date = GXt_dtime2 ;
                     AV39planilla_excel.get_Cells(AV40FILA, 10, 1, 1).Text = StringUtil.Trim( A204TTBUS14_Proveedor) ;
                     AV39planilla_excel.get_Cells(AV40FILA, 11, 1, 1).Text = StringUtil.Trim( A210TTBUS14_PosDesde) ;
                     if ( A208TTBUS14_Estado == 1 )
                     {
                        AV39planilla_excel.get_Cells(AV40FILA, 11, 1, 1).Text = StringUtil.Trim( A210TTBUS14_PosDesde) ;
                        AV39planilla_excel.get_Cells(AV40FILA, 12, 1, 1).Text = "" ;
                        AV39planilla_excel.get_Cells(AV40FILA, 13, 1, 1).Text = "" ;
                     }
                     else
                     {
                        AV39planilla_excel.get_Cells(AV40FILA, 11, 1, 1).Text = "" ;
                        AV39planilla_excel.get_Cells(AV40FILA, 12, 1, 1).Text = StringUtil.Trim( A210TTBUS14_PosDesde) ;
                        AV39planilla_excel.get_Cells(AV40FILA, 13, 1, 1).Text = StringUtil.Trim( A211TTBUS14_PosHacia) ;
                     }
                     AV40FILA = (int)(AV40FILA+1) ;
                  }
                  BRK1C2 = true ;
                  pr_default.readNext(0);
               }
               AV40FILA = (int)(AV40FILA+1) ;
               if ( ! BRK1C2 )
               {
                  BRK1C2 = true ;
                  pr_default.readNext(0);
               }
            }
            AV40FILA = (int)(AV40FILA+1) ;
            if ( ! BRK1C2 )
            {
               BRK1C2 = true ;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
         AV39planilla_excel.Save();
         AV39planilla_excel.Close();
         context.wjLoc = AV15NOMBRE_REPORTE ;
         /* Optimized DELETE. */
         /* Using cursor P001C3 */
         pr_default.execute(1);
         pr_default.close(1);
         /* End optimized DELETE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS014_2");
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
         AV39planilla_excel = new ExcelDocumentI();
         scmdbuf = "" ;
         P001C2_A215TTBUS14_CodEtiqueta = new String[] {""} ;
         P001C2_A202TTBUS14_Descripcion = new String[] {""} ;
         P001C2_A203TTBUS14_Rubro = new String[] {""} ;
         P001C2_A205TTBUS14_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         P001C2_A206TTBUS14_FechaAdquisicion = new DateTime[] {DateTime.MinValue} ;
         P001C2_A207TTBUS14_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         P001C2_n207TTBUS14_FechaEnvio = new bool[] {false} ;
         P001C2_A204TTBUS14_Proveedor = new String[] {""} ;
         P001C2_A210TTBUS14_PosDesde = new String[] {""} ;
         P001C2_n210TTBUS14_PosDesde = new bool[] {false} ;
         P001C2_A208TTBUS14_Estado = new short[1] ;
         P001C2_A211TTBUS14_PosHacia = new String[] {""} ;
         P001C2_n211TTBUS14_PosHacia = new bool[] {false} ;
         P001C2_A201TTBUS14_IdBien = new int[1] ;
         P001C2_A213TTBUS14_CodResponsable = new String[] {""} ;
         P001C2_A212TTBUS14_MarcaEnvio = new short[1] ;
         P001C2_A214TTBUS14_CodRubro = new short[1] ;
         P001C2_A209TTBUS14_Responsable = new String[] {""} ;
         A215TTBUS14_CodEtiqueta = "" ;
         A202TTBUS14_Descripcion = "" ;
         A203TTBUS14_Rubro = "" ;
         A205TTBUS14_FechaCarga = DateTime.MinValue ;
         A206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
         A207TTBUS14_FechaEnvio = DateTime.MinValue ;
         A204TTBUS14_Proveedor = "" ;
         A210TTBUS14_PosDesde = "" ;
         A211TTBUS14_PosHacia = "" ;
         A213TTBUS14_CodResponsable = "" ;
         A209TTBUS14_Responsable = "" ;
         AV38MarcaEnvio = "" ;
         GXt_char1 = "" ;
         GXt_dtime2 = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus014_2__default(),
            new Object[][] {
                new Object[] {
               P001C2_A215TTBUS14_CodEtiqueta, P001C2_A202TTBUS14_Descripcion, P001C2_A203TTBUS14_Rubro, P001C2_A205TTBUS14_FechaCarga, P001C2_A206TTBUS14_FechaAdquisicion, P001C2_A207TTBUS14_FechaEnvio, P001C2_n207TTBUS14_FechaEnvio, P001C2_A204TTBUS14_Proveedor, P001C2_A210TTBUS14_PosDesde, P001C2_n210TTBUS14_PosDesde,
               P001C2_A208TTBUS14_Estado, P001C2_A211TTBUS14_PosHacia, P001C2_n211TTBUS14_PosHacia, P001C2_A201TTBUS14_IdBien, P001C2_A213TTBUS14_CodResponsable, P001C2_A212TTBUS14_MarcaEnvio, P001C2_A214TTBUS14_CodRubro, P001C2_A209TTBUS14_Responsable
               }
               , new Object[] {
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         context.Gx_err = 0 ;
      }

      private short AV20TTBUS_RubroBien ;
      private short A214TTBUS14_CodRubro ;
      private short A208TTBUS14_Estado ;
      private short A212TTBUS14_MarcaEnvio ;
      private short AV9band ;
      private int AV40FILA ;
      private int A201TTBUS14_IdBien ;
      private int AV19TTBUS_Id ;
      private String AV37USUARIO ;
      private String AV34TTBUS7_CodResp ;
      private String AV15NOMBRE_REPORTE ;
      private String Gx_time ;
      private String scmdbuf ;
      private String A203TTBUS14_Rubro ;
      private String A204TTBUS14_Proveedor ;
      private String A210TTBUS14_PosDesde ;
      private String A211TTBUS14_PosHacia ;
      private String A213TTBUS14_CodResponsable ;
      private String A209TTBUS14_Responsable ;
      private String AV38MarcaEnvio ;
      private String GXt_char1 ;
      private DateTime AV8AHORA ;
      private DateTime GXt_dtime2 ;
      private DateTime A205TTBUS14_FechaCarga ;
      private DateTime A206TTBUS14_FechaAdquisicion ;
      private DateTime A207TTBUS14_FechaEnvio ;
      private bool BRK1C2 ;
      private bool n207TTBUS14_FechaEnvio ;
      private bool n210TTBUS14_PosDesde ;
      private bool n211TTBUS14_PosHacia ;
      private String A215TTBUS14_CodEtiqueta ;
      private String A202TTBUS14_Descripcion ;
      private IGxDataStore dsDefault ;
      private String aP0_USUARIO ;
      private String aP1_TTBUS7_CodResp ;
      private short aP2_TTBUS_RubroBien ;
      private IDataStoreProvider pr_default ;
      private String[] P001C2_A215TTBUS14_CodEtiqueta ;
      private String[] P001C2_A202TTBUS14_Descripcion ;
      private String[] P001C2_A203TTBUS14_Rubro ;
      private DateTime[] P001C2_A205TTBUS14_FechaCarga ;
      private DateTime[] P001C2_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] P001C2_A207TTBUS14_FechaEnvio ;
      private bool[] P001C2_n207TTBUS14_FechaEnvio ;
      private String[] P001C2_A204TTBUS14_Proveedor ;
      private String[] P001C2_A210TTBUS14_PosDesde ;
      private bool[] P001C2_n210TTBUS14_PosDesde ;
      private short[] P001C2_A208TTBUS14_Estado ;
      private String[] P001C2_A211TTBUS14_PosHacia ;
      private bool[] P001C2_n211TTBUS14_PosHacia ;
      private int[] P001C2_A201TTBUS14_IdBien ;
      private String[] P001C2_A213TTBUS14_CodResponsable ;
      private short[] P001C2_A212TTBUS14_MarcaEnvio ;
      private short[] P001C2_A214TTBUS14_CodRubro ;
      private String[] P001C2_A209TTBUS14_Responsable ;
      private ExcelDocumentI AV39planilla_excel ;
   }

   public class ptbus014_2__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001C2( short AV20TTBUS_RubroBien ,
                                             short A214TTBUS14_CodRubro )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [1] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [TTBUS14_CodEtiqueta], [TTBUS14_Descripcion], [TTBUS14_Rubro], [TTBUS14_FechaCarga], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_Proveedor], [TTBUS14_PosDesde], [TTBUS14_Estado], [TTBUS14_PosHacia], [TTBUS14_IdBien], [TTBUS14_CodResponsable], [TTBUS14_MarcaEnvio], [TTBUS14_CodRubro], [TTBUS14_Responsable] FROM [TTBUS014_1] WITH (NOLOCK)" ;
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
            GXv_int3[0] = 1 ;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE " + sWhereString ;
         }
         scmdbuf = scmdbuf + " ORDER BY [TTBUS14_CodResponsable], [TTBUS14_MarcaEnvio], [TTBUS14_IdBien]" ;
         GXv_Object4[0] = scmdbuf ;
         GXv_Object4[1] = (Object)(GXv_int3) ;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001C2( (short)dynConstraints[0] , (short)dynConstraints[1] );
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
          Object[] prmP001C3 ;
          prmP001C3 = new Object[] {
          } ;
          Object[] prmP001C2 ;
          prmP001C2 = new Object[] {
          new Object[] {"@AV20TTBUS_RubroBien",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C2,100,0,true,false )
             ,new CursorDef("P001C3", "DELETE FROM [TTBUS014_1] ", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001C3)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 30) ;
                ((String[]) buf[8])[0] = rslt.getString(8, 50) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(8);
                ((short[]) buf[10])[0] = rslt.getShort(9) ;
                ((String[]) buf[11])[0] = rslt.getString(10, 50) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((int[]) buf[13])[0] = rslt.getInt(11) ;
                ((String[]) buf[14])[0] = rslt.getString(12, 15) ;
                ((short[]) buf[15])[0] = rslt.getShort(13) ;
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((String[]) buf[17])[0] = rslt.getString(15, 50) ;
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
