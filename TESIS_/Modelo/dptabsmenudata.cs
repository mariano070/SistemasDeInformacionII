/*
               File: DPTabsMenuData
        Description: DPTabs Menu Data
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:57.14
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
   public class dptabsmenudata : GXProcedure
   {
      public dptabsmenudata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
      }

      public dptabsmenudata( IGxContext context )
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
         dptabsmenudata objdptabsmenudata;
         objdptabsmenudata = new dptabsmenudata();
         objdptabsmenudata.Gxm2rootcol = new GxObjectCollection( context, "TabsMenuData.TabsMenuDataItem", "MarianoTesis", "SdtTabsMenuData_TabsMenuDataItem", "GeneXus.Programs") ;
         objdptabsmenudata.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objdptabsmenudata.executePrivateCatch ));
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
         Gxm1tabsmenudata.gxTpr_Menutitle = "HOME" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "HOME DESCRIPTION" ;
         Gxm1tabsmenudata.gxTpr_Menuurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB HOME 1 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB HOME 1 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 2 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "NEW" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "NEW DESCRIPTION" ;
         Gxm1tabsmenudata.gxTpr_Menuurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB NEW 1 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB NEW 1 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB NEW 2 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB NEW 2 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 3 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "CSS" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "CSS DESCRIPTION" ;
         Gxm1tabsmenudata.gxTpr_Menuurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB CSS 1 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB CSS 1 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB CSS 2 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB CSS 2 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 4 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "PARTNERS" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "PARTNERS DESCRIPTION" ;
         Gxm1tabsmenudata.gxTpr_Menuurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB PARTNERS 1 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB PARTNERS 1 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB PARTNERS 2 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB PARTNERS 2 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm1tabsmenudata = new SdtTabsMenuData_TabsMenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1tabsmenudata, 0);
         Gxm1tabsmenudata.gxTpr_Menuid = 5 ;
         Gxm1tabsmenudata.gxTpr_Menutitle = "TOOLS" ;
         Gxm1tabsmenudata.gxTpr_Menudescription = "TOOLS DESCRIPTION" ;
         Gxm1tabsmenudata.gxTpr_Menuurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 1 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB TOOLS 1 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB TOOLS 1 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
         Gxm3tabsmenudata_sections = new SdtTabsMenuData_TabsMenuDataItem_SectionsItem(context) ;
         Gxm1tabsmenudata.gxTpr_Sections.Add(Gxm3tabsmenudata_sections, 0);
         Gxm3tabsmenudata_sections.gxTpr_Sectionid = 2 ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiontitle = "SUB TOOLS 2 TITLE" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectiondescription = "SUB TOOLS 2 DESCRIPTION" ;
         Gxm3tabsmenudata_sections.gxTpr_Sectionurl = "http://www.gxtechnical.com/rocha" ;
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
