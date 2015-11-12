/*
               File: DPTabsMenuTrazabilidad2
        Description: DPTabs Menu Trazabilidad2
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:57.42
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
   public class dptabsmenutrazabilidad2 : GXProcedure
   {
      public dptabsmenutrazabilidad2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public dptabsmenutrazabilidad2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_SISTEMA ,
                           String aP1_USUARIO ,
                           out IGxCollection aP2_Gxm2rootcol )
      {
         this.AV5SISTEMA = aP0_SISTEMA;
         this.AV6USUARIO = aP1_USUARIO;
         this.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP2_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( String aP0_SISTEMA ,
                                       String aP1_USUARIO )
      {
         this.AV5SISTEMA = aP0_SISTEMA;
         this.AV6USUARIO = aP1_USUARIO;
         this.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP2_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( String aP0_SISTEMA ,
                                 String aP1_USUARIO ,
                                 out IGxCollection aP2_Gxm2rootcol )
      {
         dptabsmenutrazabilidad2 objdptabsmenutrazabilidad2;
         objdptabsmenutrazabilidad2 = new dptabsmenutrazabilidad2();
         objdptabsmenutrazabilidad2.AV5SISTEMA = aP0_SISTEMA;
         objdptabsmenutrazabilidad2.AV6USUARIO = aP1_USUARIO;
         objdptabsmenutrazabilidad2.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         objdptabsmenutrazabilidad2.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objdptabsmenutrazabilidad2.executePrivateCatch ));
         aP2_Gxm2rootcol=this.Gxm2rootcol;
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
         Gxm1tabsmenudata.gxTpr_Menutitle = "Actualizaci�n" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Actualizaci�n Trazabilidad" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Actualizaci�n de Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Actualizaci�n de Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus001_prev.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Administrador de Cambio de Posiciones" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Administrador de Cambio de Posiciones" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus020.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Administraci�n Bajas Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Administraci�n Bajas Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus001b.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 2 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Informes" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Men� de Informes" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Env�os Pendientes de Recepci�n" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Informe de Env�os Pendientes de Recepci�n" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus011.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Movimientos de Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Informe de Movimientos de Bienes de Uso" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus013.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Bienes por Posici�n o por Responsable" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Informe de Bienes por Posici�n o por Responsable" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus014.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 4 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Bienes e Identificadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Informe de Bienes e Identificadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus016.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 3 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "Tablas" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "Acceso Men� de Tablas" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Identificadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Identificadores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "htbus005.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Rubros" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Rubros" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "hbus002.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 3 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "Proveedores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "Proveedores" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "hm124fprov.aspx"+ "?" + GXUtil.UrlEncode(StringUtil.RTrim(AV5SISTEMA)) + "," + GXUtil.UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
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

      private String AV5SISTEMA ;
      private String AV6USUARIO ;
      private IGxCollection aP2_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtTabsMenuData_TabsMenuDataItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtTabsMenuData_TabsMenuDataItem Gxm1tabsmenudata ;
      private SdtTabsMenuData_TabsMenuDataItem_SectionsItem Gxm3tabsmenudata_sections ;
   }

}
