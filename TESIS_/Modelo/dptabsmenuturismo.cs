/*
               File: DPTabsMenuTurismo
        Description: DPTabs Menu Turismo
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/15/2014 15:59:49.93
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class dptabsmenuturismo : GXProcedure
   {
      public dptabsmenuturismo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public dptabsmenuturismo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( out IGxCollection aP0_Gxm2rootcol )
      {
         dptabsmenuturismo objdptabsmenuturismo;
         objdptabsmenuturismo = new dptabsmenuturismo();
         objdptabsmenuturismo.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         objdptabsmenuturismo.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objdptabsmenuturismo.executePrivateCatch ));
         aP0_Gxm2rootcol=this.Gxm2rootcol;
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
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 1 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Actualización" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Actualización Archivos" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Solicitud de Servicio" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Solicitud de servicio" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWVoucher" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Notas de Venta" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Notas de Venta" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWNotaDeVenta" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Costos Sin Nota de Venta" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Costos Sin Nota de Venta" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWCostoSinNotaVenta" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 4 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Solicitudes de Pago" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Solicitudes de Pago" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWSolicitudPago" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 2 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Consultas" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Menú de Consultas" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Conceptos de Costos" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Consulta de Conceptos de Costos" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "ConsCostoNotaVenta" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 3 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Informes" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Menú de Informes" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Estadísticas" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Estadísticas" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "TurEstadDestino" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 4 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Tablas" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Menú de Tablas" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Operadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Operadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWOperador" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Destinos por Operador" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla Destinos por Operador" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWOperadorDestino" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Hoteles" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Hoteles" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWHotel" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 4 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Tipos de Habitaciones" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Habitaciones" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTipoHabitacion" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 5 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Regimenes" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Regimenes" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWRegimen" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 6 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Tipos de Hoteles" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Tipos de Hotel" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTipoHotel" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 7 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Destinos" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Destinos" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTurDestino" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 8 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Tours" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Tours" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTour" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 9 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Vendedores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Vendedores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWVendedor" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 10 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Personas (PAX)" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Tabla de Personas" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWM01FPERQ" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 5 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Contabilidad" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Aceso Menú de Procesos" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Períodos Contables" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Administración de Períodos Contables" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWPERIODO" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Consulta Asientos (N.Venta)" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Asientos Contables Notas de Venta" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWNotaDeVentaAsientos" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Asientos Contables" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Actualizar Asientos Contables" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTEGR004" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 4 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Referencias Contables por Comprobante" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Actualizar Referencias Contables" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "WWTUR003" ;
         this.cleanup();
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
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context);
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private IGxCollection aP0_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtTabsMenuData_TabsMenuDataItem Gxm1tabsmenudata ;
      private SdtTabsMenuData_TabsMenuDataItem_SectionsItem Gxm3tabsmenudata_sections ;
   }

}
