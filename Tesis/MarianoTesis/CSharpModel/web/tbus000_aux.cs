/*
               File: TBUS000_AUX
        Description: Auxiliar de bienes de uso
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:55.96
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tbus000_aux : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Auxiliar de bienes de uso", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBUS_AUX_ID_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tbus000_aux( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tbus000_aux( IGxContext context )
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

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_0P25( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0P25e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0P25( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0P25( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0P25e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Auxiliar de bienes de uso"+"</legend>") ;
            wb_table3_27_0P25( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0P25e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0P25e( true) ;
         }
         else
         {
            wb_table1_2_0P25e( false) ;
         }
      }

      protected void wb_table3_27_0P25( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_0P25( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0P25e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TBUS000_AUX.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TBUS000_AUX.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0P25e( true) ;
         }
         else
         {
            wb_table3_27_0P25e( false) ;
         }
      }

      protected void wb_table4_33_0P25( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_id_Internalname, 1, 1, 0, "de auxiliar", "", "", "", 0, lblTextblockbus_aux_id_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A352BUS_AUX_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_AUX_ID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A352BUS_AUX_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtBUS_AUX_ID_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_rub_Internalname, 1, 1, 0, "DEL BIEN", "", "", "", 0, lblTextblockbus_aux_rub_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_RUB_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A353BUS_AUX_RUB), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtBUS_AUX_RUB_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A353BUS_AUX_RUB), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtBUS_AUX_RUB_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_des_Internalname, 1, 1, 0, "DEL BIEN", "", "", "", 0, lblTextblockbus_aux_des_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_DES_Internalname, StringUtil.RTrim( A354BUS_AUX_DES), "", 50, "chr", 1, "row", 50, 1, edtBUS_AUX_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A354BUS_AUX_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(48);\"", 0, edtBUS_AUX_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_fal_Internalname, 1, 1, 0, "DEL BIEN", "", "", "", 0, lblTextblockbus_aux_fal_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_AUX_FAL_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_FAL_Internalname, context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_AUX_FAL_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A355BUS_AUX_FAL, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(53);\"", 0, edtBUS_AUX_FAL_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000_AUX.htm");
            GxWebStd.gx_bitmap( context, edtBUS_AUX_FAL_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_AUX_FAL_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_fad_Internalname, 1, 1, 0, "DEL BIEN", "", "", "", 0, lblTextblockbus_aux_fad_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtBUS_AUX_FAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_FAD_Internalname, context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtBUS_AUX_FAD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A356BUS_AUX_FAD, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(58);\"", 0, edtBUS_AUX_FAD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS000_AUX.htm");
            GxWebStd.gx_bitmap( context, edtBUS_AUX_FAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtBUS_AUX_FAD_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_nco_Internalname, 1, 1, 0, "DE COMPRA", "", "", "", 0, lblTextblockbus_aux_nco_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_NCO_Internalname, StringUtil.RTrim( A357BUS_AUX_NCO), "", 12, "chr", 1, "row", 12, 1, edtBUS_AUX_NCO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A357BUS_AUX_NCO, "XXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, edtBUS_AUX_NCO_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbus_aux_com_Internalname, 1, 1, 0, "DE COMPRA", "", "", "", 0, lblTextblockbus_aux_com_Jsonclick, "", StyleString, ClassString, "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtBUS_AUX_COM_Internalname, StringUtil.RTrim( A358BUS_AUX_COM), "", 2, "chr", 1, "row", 2, 1, edtBUS_AUX_COM_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A358BUS_AUX_COM, "XX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, edtBUS_AUX_COM_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0P25e( true) ;
         }
         else
         {
            wb_table4_33_0P25e( false) ;
         }
      }

      protected void wb_table2_5_0P25( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_AUX_ID"+"'), id:'"+"BUS_AUX_ID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00p0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BUS_AUX_ID"+"'), id:'"+"BUS_AUX_ID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS000_AUX.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_0P25e( true) ;
         }
         else
         {
            wb_table2_5_0P25e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_AUX_ID_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_AUX_ID_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_AUX_ID_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_AUX_ID");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_AUX_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A352BUS_AUX_ID = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               }
               else
               {
                  A352BUS_AUX_ID = (short)(context.localUtil.CToN( cgiGet( edtBUS_AUX_ID_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtBUS_AUX_RUB_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtBUS_AUX_RUB_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtBUS_AUX_RUB_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "BUS_AUX_RUB");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A353BUS_AUX_RUB = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
               }
               else
               {
                  A353BUS_AUX_RUB = (short)(context.localUtil.CToN( cgiGet( edtBUS_AUX_RUB_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
               }
               A354BUS_AUX_DES = cgiGet( edtBUS_AUX_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
               if ( context.localUtil.VCDate( cgiGet( edtBUS_AUX_FAL_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ALTA DEL BIEN"}), 1, "BUS_AUX_FAL");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_AUX_FAL_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A355BUS_AUX_FAL = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
               }
               else
               {
                  A355BUS_AUX_FAL = context.localUtil.CToD( cgiGet( edtBUS_AUX_FAL_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtBUS_AUX_FAD_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"FECHA DE ADQUISICIÓN DEL BIEN"}), 1, "BUS_AUX_FAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_AUX_FAD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A356BUS_AUX_FAD = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
               }
               else
               {
                  A356BUS_AUX_FAD = context.localUtil.CToD( cgiGet( edtBUS_AUX_FAD_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
               }
               A357BUS_AUX_NCO = cgiGet( edtBUS_AUX_NCO_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357BUS_AUX_NCO", A357BUS_AUX_NCO);
               A358BUS_AUX_COM = cgiGet( edtBUS_AUX_COM_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
               /* Read saved values. */
               Z352BUS_AUX_ID = (short)(context.localUtil.CToN( cgiGet( "Z352BUS_AUX_ID"), ",", ".")) ;
               Z353BUS_AUX_RUB = (short)(context.localUtil.CToN( cgiGet( "Z353BUS_AUX_RUB"), ",", ".")) ;
               Z354BUS_AUX_DES = cgiGet( "Z354BUS_AUX_DES") ;
               Z355BUS_AUX_FAL = context.localUtil.CToD( cgiGet( "Z355BUS_AUX_FAL"), 0) ;
               Z356BUS_AUX_FAD = context.localUtil.CToD( cgiGet( "Z356BUS_AUX_FAD"), 0) ;
               Z357BUS_AUX_NCO = cgiGet( "Z357BUS_AUX_NCO") ;
               Z358BUS_AUX_COM = cgiGet( "Z358BUS_AUX_COM") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A352BUS_AUX_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0P25( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
            imgBtn_enter2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         edtBUS_AUX_ID_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_ID_Enabled), 5, 0)));
         edtBUS_AUX_RUB_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_RUB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_RUB_Enabled), 5, 0)));
         edtBUS_AUX_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_DES_Enabled), 5, 0)));
         edtBUS_AUX_FAL_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_FAL_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_FAL_Enabled), 5, 0)));
         edtBUS_AUX_FAD_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_FAD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_FAD_Enabled), 5, 0)));
         edtBUS_AUX_NCO_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_NCO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_NCO_Enabled), 5, 0)));
         edtBUS_AUX_COM_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBUS_AUX_COM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBUS_AUX_COM_Enabled), 5, 0)));
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void ResetCaption0P0( )
      {
      }

      protected void ZM0P25( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z353BUS_AUX_RUB = T000P3_A353BUS_AUX_RUB[0] ;
               Z354BUS_AUX_DES = T000P3_A354BUS_AUX_DES[0] ;
               Z355BUS_AUX_FAL = T000P3_A355BUS_AUX_FAL[0] ;
               Z356BUS_AUX_FAD = T000P3_A356BUS_AUX_FAD[0] ;
               Z357BUS_AUX_NCO = T000P3_A357BUS_AUX_NCO[0] ;
               Z358BUS_AUX_COM = T000P3_A358BUS_AUX_COM[0] ;
            }
            else
            {
               Z353BUS_AUX_RUB = A353BUS_AUX_RUB ;
               Z354BUS_AUX_DES = A354BUS_AUX_DES ;
               Z355BUS_AUX_FAL = A355BUS_AUX_FAL ;
               Z356BUS_AUX_FAD = A356BUS_AUX_FAD ;
               Z357BUS_AUX_NCO = A357BUS_AUX_NCO ;
               Z358BUS_AUX_COM = A358BUS_AUX_COM ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z352BUS_AUX_ID = A352BUS_AUX_ID ;
            Z353BUS_AUX_RUB = A353BUS_AUX_RUB ;
            Z354BUS_AUX_DES = A354BUS_AUX_DES ;
            Z355BUS_AUX_FAL = A355BUS_AUX_FAL ;
            Z356BUS_AUX_FAD = A356BUS_AUX_FAD ;
            Z357BUS_AUX_NCO = A357BUS_AUX_NCO ;
            Z358BUS_AUX_COM = A358BUS_AUX_COM ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
      }

      protected void Load0P25( )
      {
         /* Using cursor T000P4 */
         pr_default.execute(2, new Object[] {A352BUS_AUX_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound25 = 1 ;
            A353BUS_AUX_RUB = T000P4_A353BUS_AUX_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
            A354BUS_AUX_DES = T000P4_A354BUS_AUX_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
            A355BUS_AUX_FAL = T000P4_A355BUS_AUX_FAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
            A356BUS_AUX_FAD = T000P4_A356BUS_AUX_FAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
            A357BUS_AUX_NCO = T000P4_A357BUS_AUX_NCO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357BUS_AUX_NCO", A357BUS_AUX_NCO);
            A358BUS_AUX_COM = T000P4_A358BUS_AUX_COM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
            ZM0P25( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0P25( ) ;
      }

      protected void OnLoadActions0P25( )
      {
      }

      protected void CheckExtendedTable0P25( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A355BUS_AUX_FAL) || ( A355BUS_AUX_FAL >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE ALTA DEL BIEN fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A356BUS_AUX_FAD) || ( A356BUS_AUX_FAD >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo FECHA DE ADQUISICIÓN DEL BIEN fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0P25( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound25 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey0P25( )
      {
         /* Using cursor T000P5 */
         pr_default.execute(3, new Object[] {A352BUS_AUX_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound25 = 1 ;
         }
         else
         {
            RcdFound25 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000P3 */
         pr_default.execute(1, new Object[] {A352BUS_AUX_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0P25( 3) ;
            RcdFound25 = 1 ;
            A352BUS_AUX_ID = T000P3_A352BUS_AUX_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
            A353BUS_AUX_RUB = T000P3_A353BUS_AUX_RUB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
            A354BUS_AUX_DES = T000P3_A354BUS_AUX_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
            A355BUS_AUX_FAL = T000P3_A355BUS_AUX_FAL[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
            A356BUS_AUX_FAD = T000P3_A356BUS_AUX_FAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
            A357BUS_AUX_NCO = T000P3_A357BUS_AUX_NCO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357BUS_AUX_NCO", A357BUS_AUX_NCO);
            A358BUS_AUX_COM = T000P3_A358BUS_AUX_COM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
            Z352BUS_AUX_ID = A352BUS_AUX_ID ;
            sMode25 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0P25( ) ;
            Gx_mode = sMode25 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound25 = 0 ;
            InitializeNonKey0P25( ) ;
            sMode25 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode25 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0P25( ) ;
         if ( RcdFound25 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound25 = 0 ;
         /* Using cursor T000P6 */
         pr_default.execute(4, new Object[] {A352BUS_AUX_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000P6_A352BUS_AUX_ID[0] < A352BUS_AUX_ID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000P6_A352BUS_AUX_ID[0] > A352BUS_AUX_ID ) ) )
            {
               A352BUS_AUX_ID = T000P6_A352BUS_AUX_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               RcdFound25 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound25 = 0 ;
         /* Using cursor T000P7 */
         pr_default.execute(5, new Object[] {A352BUS_AUX_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000P7_A352BUS_AUX_ID[0] > A352BUS_AUX_ID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000P7_A352BUS_AUX_ID[0] < A352BUS_AUX_ID ) ) )
            {
               A352BUS_AUX_ID = T000P7_A352BUS_AUX_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               RcdFound25 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0P25( ) ;
         if ( RcdFound25 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "BUS_AUX_ID");
               AnyError = 1 ;
               GX_FocusControl = edtBUS_AUX_ID_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A352BUS_AUX_ID != Z352BUS_AUX_ID )
            {
               A352BUS_AUX_ID = Z352BUS_AUX_ID ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "BUS_AUX_ID");
               AnyError = 1 ;
               GX_FocusControl = edtBUS_AUX_ID_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtBUS_AUX_ID_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0P25( ) ;
               GX_FocusControl = edtBUS_AUX_ID_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A352BUS_AUX_ID != Z352BUS_AUX_ID )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0P25( ) ;
               GX_FocusControl = edtBUS_AUX_ID_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "BUS_AUX_ID");
                  AnyError = 1 ;
                  GX_FocusControl = edtBUS_AUX_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0P25( ) ;
                  GX_FocusControl = edtBUS_AUX_ID_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A352BUS_AUX_ID != Z352BUS_AUX_ID )
         {
            A352BUS_AUX_ID = Z352BUS_AUX_ID ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "BUS_AUX_ID");
            AnyError = 1 ;
            GX_FocusControl = edtBUS_AUX_ID_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBUS_AUX_ID_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "BUS_AUX_ID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0P25( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0P25( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0P25( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound25 != 0 )
            {
               ScanNext0P25( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0P25( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0P25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000P8 */
            pr_default.execute(6, new Object[] {A352BUS_AUX_ID});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TBUS000_AUX"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( Z353BUS_AUX_RUB != T000P8_A353BUS_AUX_RUB[0] ) || ( StringUtil.StrCmp(Z354BUS_AUX_DES, T000P8_A354BUS_AUX_DES[0]) != 0 ) || ( Z355BUS_AUX_FAL != T000P8_A355BUS_AUX_FAL[0] ) || ( Z356BUS_AUX_FAD != T000P8_A356BUS_AUX_FAD[0] ) || ( StringUtil.StrCmp(Z357BUS_AUX_NCO, T000P8_A357BUS_AUX_NCO[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z358BUS_AUX_COM, T000P8_A358BUS_AUX_COM[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TBUS000_AUX"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0P25( )
      {
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P25( 0) ;
            CheckOptimisticConcurrency0P25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P9 */
                     pr_default.execute(7, new Object[] {A353BUS_AUX_RUB, A354BUS_AUX_DES, A355BUS_AUX_FAL, A356BUS_AUX_FAD, A357BUS_AUX_NCO, A358BUS_AUX_COM});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000P10 */
                     pr_default.execute(8);
                     A352BUS_AUX_ID = T000P10_A352BUS_AUX_ID[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption0P0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load0P25( ) ;
            }
            EndLevel0P25( ) ;
         }
         CloseExtendedTableCursors0P25( ) ;
      }

      protected void Update0P25( )
      {
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P11 */
                     pr_default.execute(9, new Object[] {A353BUS_AUX_RUB, A354BUS_AUX_DES, A355BUS_AUX_FAL, A356BUS_AUX_FAD, A357BUS_AUX_NCO, A358BUS_AUX_COM, A352BUS_AUX_ID});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TBUS000_AUX"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0P25( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0P0( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel0P25( ) ;
         }
         CloseExtendedTableCursors0P25( ) ;
      }

      protected void DeferredUpdate0P25( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0P25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P25( ) ;
            AfterConfirm0P25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P25( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000P12 */
                  pr_default.execute(10, new Object[] {A352BUS_AUX_ID});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound25 == 0 )
                        {
                           InitAll0P25( ) ;
                           Gx_mode = "INS" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                        ResetCaption0P0( ) ;
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode25 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0P25( ) ;
         Gx_mode = sMode25 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0P25( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0P25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0P25( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TBUS000_AUX");
            if ( AnyError == 0 )
            {
               ConfirmValues0P0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TBUS000_AUX");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0P25( )
      {
         /* Using cursor T000P13 */
         pr_default.execute(11);
         RcdFound25 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound25 = 1 ;
            A352BUS_AUX_ID = T000P13_A352BUS_AUX_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0P25( )
      {
         pr_default.readNext(11);
         RcdFound25 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound25 = 1 ;
            A352BUS_AUX_ID = T000P13_A352BUS_AUX_ID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
         }
      }

      protected void ScanEnd0P25( )
      {
      }

      protected void AfterConfirm0P25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P25( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0P0( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tbus000_aux.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z352BUS_AUX_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z352BUS_AUX_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z353BUS_AUX_RUB), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z354BUS_AUX_DES", StringUtil.RTrim( Z354BUS_AUX_DES));
         GxWebStd.gx_hidden_field( context, "Z355BUS_AUX_FAL", context.localUtil.DToC( Z355BUS_AUX_FAL, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z356BUS_AUX_FAD", context.localUtil.DToC( Z356BUS_AUX_FAD, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z357BUS_AUX_NCO", StringUtil.RTrim( Z357BUS_AUX_NCO));
         GxWebStd.gx_hidden_field( context, "Z358BUS_AUX_COM", StringUtil.RTrim( Z358BUS_AUX_COM));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "TBUS000_AUX" ;
      }

      public override String GetPgmdesc( )
      {
         return "Auxiliar de bienes de uso" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tbus000_aux.aspx")  ;
      }

      protected void InitializeNonKey0P25( )
      {
         A353BUS_AUX_RUB = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A353BUS_AUX_RUB", StringUtil.LTrim( StringUtil.Str( (decimal)(A353BUS_AUX_RUB), 4, 0)));
         A354BUS_AUX_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A354BUS_AUX_DES", A354BUS_AUX_DES);
         A355BUS_AUX_FAL = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A355BUS_AUX_FAL", context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999"));
         A356BUS_AUX_FAD = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A356BUS_AUX_FAD", context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999"));
         A357BUS_AUX_NCO = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A357BUS_AUX_NCO", A357BUS_AUX_NCO);
         A358BUS_AUX_COM = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358BUS_AUX_COM", A358BUS_AUX_COM);
      }

      protected void InitAll0P25( )
      {
         A352BUS_AUX_ID = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A352BUS_AUX_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A352BUS_AUX_ID), 4, 0)));
         InitializeNonKey0P25( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1720579");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tbus000_aux.js", "?1720579");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockbus_aux_id_Internalname = "TEXTBLOCKBUS_AUX_ID" ;
         edtBUS_AUX_ID_Internalname = "BUS_AUX_ID" ;
         lblTextblockbus_aux_rub_Internalname = "TEXTBLOCKBUS_AUX_RUB" ;
         edtBUS_AUX_RUB_Internalname = "BUS_AUX_RUB" ;
         lblTextblockbus_aux_des_Internalname = "TEXTBLOCKBUS_AUX_DES" ;
         edtBUS_AUX_DES_Internalname = "BUS_AUX_DES" ;
         lblTextblockbus_aux_fal_Internalname = "TEXTBLOCKBUS_AUX_FAL" ;
         edtBUS_AUX_FAL_Internalname = "BUS_AUX_FAL" ;
         lblTextblockbus_aux_fad_Internalname = "TEXTBLOCKBUS_AUX_FAD" ;
         edtBUS_AUX_FAD_Internalname = "BUS_AUX_FAD" ;
         lblTextblockbus_aux_nco_Internalname = "TEXTBLOCKBUS_AUX_NCO" ;
         edtBUS_AUX_NCO_Internalname = "BUS_AUX_NCO" ;
         lblTextblockbus_aux_com_Internalname = "TEXTBLOCKBUS_AUX_COM" ;
         edtBUS_AUX_COM_Internalname = "BUS_AUX_COM" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Auxiliar de bienes de uso" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         edtBUS_AUX_COM_Jsonclick = "" ;
         edtBUS_AUX_COM_Enabled = 1 ;
         edtBUS_AUX_NCO_Jsonclick = "" ;
         edtBUS_AUX_NCO_Enabled = 1 ;
         edtBUS_AUX_FAD_Jsonclick = "" ;
         edtBUS_AUX_FAD_Enabled = 1 ;
         edtBUS_AUX_FAL_Jsonclick = "" ;
         edtBUS_AUX_FAL_Enabled = 1 ;
         edtBUS_AUX_DES_Jsonclick = "" ;
         edtBUS_AUX_DES_Enabled = 1 ;
         edtBUS_AUX_RUB_Jsonclick = "" ;
         edtBUS_AUX_RUB_Enabled = 1 ;
         edtBUS_AUX_ID_Jsonclick = "" ;
         edtBUS_AUX_ID_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtBUS_AUX_RUB_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Bus_aux_id( short GX_Parm1 ,
                                    short GX_Parm2 ,
                                    String GX_Parm3 ,
                                    DateTime GX_Parm4 ,
                                    DateTime GX_Parm5 ,
                                    String GX_Parm6 ,
                                    String GX_Parm7 )
      {
         A352BUS_AUX_ID = GX_Parm1 ;
         A353BUS_AUX_RUB = GX_Parm2 ;
         A354BUS_AUX_DES = GX_Parm3 ;
         A355BUS_AUX_FAL = GX_Parm4 ;
         A356BUS_AUX_FAD = GX_Parm5 ;
         A357BUS_AUX_NCO = GX_Parm6 ;
         A358BUS_AUX_COM = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A353BUS_AUX_RUB), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A354BUS_AUX_DES)));
         isValidOutput.Add((Object)(context.localUtil.Format(A355BUS_AUX_FAL, "99/99/9999")));
         isValidOutput.Add((Object)(context.localUtil.Format(A356BUS_AUX_FAD, "99/99/9999")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A357BUS_AUX_NCO)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A358BUS_AUX_COM)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z352BUS_AUX_ID), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z353BUS_AUX_RUB), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z354BUS_AUX_DES)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z355BUS_AUX_FAL, 0, "/")));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z356BUS_AUX_FAD, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z357BUS_AUX_NCO)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z358BUS_AUX_COM)));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(11);
         pr_default.close(5);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockbus_aux_id_Jsonclick = "" ;
         lblTextblockbus_aux_rub_Jsonclick = "" ;
         lblTextblockbus_aux_des_Jsonclick = "" ;
         A354BUS_AUX_DES = "" ;
         lblTextblockbus_aux_fal_Jsonclick = "" ;
         A355BUS_AUX_FAL = DateTime.MinValue ;
         lblTextblockbus_aux_fad_Jsonclick = "" ;
         A356BUS_AUX_FAD = DateTime.MinValue ;
         lblTextblockbus_aux_nco_Jsonclick = "" ;
         A357BUS_AUX_NCO = "" ;
         lblTextblockbus_aux_com_Jsonclick = "" ;
         A358BUS_AUX_COM = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z354BUS_AUX_DES = "" ;
         Z355BUS_AUX_FAL = DateTime.MinValue ;
         Z356BUS_AUX_FAD = DateTime.MinValue ;
         Z357BUS_AUX_NCO = "" ;
         Z358BUS_AUX_COM = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000P4_A352BUS_AUX_ID = new short[1] ;
         T000P4_A353BUS_AUX_RUB = new short[1] ;
         T000P4_A354BUS_AUX_DES = new String[] {""} ;
         T000P4_A355BUS_AUX_FAL = new DateTime[] {DateTime.MinValue} ;
         T000P4_A356BUS_AUX_FAD = new DateTime[] {DateTime.MinValue} ;
         T000P4_A357BUS_AUX_NCO = new String[] {""} ;
         T000P4_A358BUS_AUX_COM = new String[] {""} ;
         T000P5_A352BUS_AUX_ID = new short[1] ;
         T000P3_A352BUS_AUX_ID = new short[1] ;
         T000P3_A353BUS_AUX_RUB = new short[1] ;
         T000P3_A354BUS_AUX_DES = new String[] {""} ;
         T000P3_A355BUS_AUX_FAL = new DateTime[] {DateTime.MinValue} ;
         T000P3_A356BUS_AUX_FAD = new DateTime[] {DateTime.MinValue} ;
         T000P3_A357BUS_AUX_NCO = new String[] {""} ;
         T000P3_A358BUS_AUX_COM = new String[] {""} ;
         sMode25 = "" ;
         T000P6_A352BUS_AUX_ID = new short[1] ;
         T000P7_A352BUS_AUX_ID = new short[1] ;
         T000P8_A352BUS_AUX_ID = new short[1] ;
         T000P8_A353BUS_AUX_RUB = new short[1] ;
         T000P8_A354BUS_AUX_DES = new String[] {""} ;
         T000P8_A355BUS_AUX_FAL = new DateTime[] {DateTime.MinValue} ;
         T000P8_A356BUS_AUX_FAD = new DateTime[] {DateTime.MinValue} ;
         T000P8_A357BUS_AUX_NCO = new String[] {""} ;
         T000P8_A358BUS_AUX_COM = new String[] {""} ;
         T000P10_A352BUS_AUX_ID = new short[1] ;
         T000P13_A352BUS_AUX_ID = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tbus000_aux__default(),
            new Object[][] {
                new Object[] {
               T000P2_A352BUS_AUX_ID, T000P2_A353BUS_AUX_RUB, T000P2_A354BUS_AUX_DES, T000P2_A355BUS_AUX_FAL, T000P2_A356BUS_AUX_FAD, T000P2_A357BUS_AUX_NCO, T000P2_A358BUS_AUX_COM
               }
               , new Object[] {
               T000P3_A352BUS_AUX_ID, T000P3_A353BUS_AUX_RUB, T000P3_A354BUS_AUX_DES, T000P3_A355BUS_AUX_FAL, T000P3_A356BUS_AUX_FAD, T000P3_A357BUS_AUX_NCO, T000P3_A358BUS_AUX_COM
               }
               , new Object[] {
               T000P4_A352BUS_AUX_ID, T000P4_A353BUS_AUX_RUB, T000P4_A354BUS_AUX_DES, T000P4_A355BUS_AUX_FAL, T000P4_A356BUS_AUX_FAD, T000P4_A357BUS_AUX_NCO, T000P4_A358BUS_AUX_COM
               }
               , new Object[] {
               T000P5_A352BUS_AUX_ID
               }
               , new Object[] {
               T000P6_A352BUS_AUX_ID
               }
               , new Object[] {
               T000P7_A352BUS_AUX_ID
               }
               , new Object[] {
               T000P8_A352BUS_AUX_ID, T000P8_A353BUS_AUX_RUB, T000P8_A354BUS_AUX_DES, T000P8_A355BUS_AUX_FAL, T000P8_A356BUS_AUX_FAD, T000P8_A357BUS_AUX_NCO, T000P8_A358BUS_AUX_COM
               }
               , new Object[] {
               }
               , new Object[] {
               T000P10_A352BUS_AUX_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000P13_A352BUS_AUX_ID
               }
            }
         );
      }

      private short RcdFound25 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A352BUS_AUX_ID ;
      private short A353BUS_AUX_RUB ;
      private short Z352BUS_AUX_ID ;
      private short Z353BUS_AUX_RUB ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtBUS_AUX_ID_Enabled ;
      private int edtBUS_AUX_RUB_Enabled ;
      private int edtBUS_AUX_DES_Enabled ;
      private int edtBUS_AUX_FAL_Enabled ;
      private int edtBUS_AUX_FAD_Enabled ;
      private int edtBUS_AUX_NCO_Enabled ;
      private int edtBUS_AUX_COM_Enabled ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBUS_AUX_ID_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockbus_aux_id_Internalname ;
      private String lblTextblockbus_aux_id_Jsonclick ;
      private String edtBUS_AUX_ID_Jsonclick ;
      private String lblTextblockbus_aux_rub_Internalname ;
      private String lblTextblockbus_aux_rub_Jsonclick ;
      private String edtBUS_AUX_RUB_Internalname ;
      private String edtBUS_AUX_RUB_Jsonclick ;
      private String lblTextblockbus_aux_des_Internalname ;
      private String lblTextblockbus_aux_des_Jsonclick ;
      private String edtBUS_AUX_DES_Internalname ;
      private String A354BUS_AUX_DES ;
      private String edtBUS_AUX_DES_Jsonclick ;
      private String lblTextblockbus_aux_fal_Internalname ;
      private String lblTextblockbus_aux_fal_Jsonclick ;
      private String edtBUS_AUX_FAL_Internalname ;
      private String edtBUS_AUX_FAL_Jsonclick ;
      private String lblTextblockbus_aux_fad_Internalname ;
      private String lblTextblockbus_aux_fad_Jsonclick ;
      private String edtBUS_AUX_FAD_Internalname ;
      private String edtBUS_AUX_FAD_Jsonclick ;
      private String lblTextblockbus_aux_nco_Internalname ;
      private String lblTextblockbus_aux_nco_Jsonclick ;
      private String edtBUS_AUX_NCO_Internalname ;
      private String A357BUS_AUX_NCO ;
      private String edtBUS_AUX_NCO_Jsonclick ;
      private String lblTextblockbus_aux_com_Internalname ;
      private String lblTextblockbus_aux_com_Jsonclick ;
      private String edtBUS_AUX_COM_Internalname ;
      private String A358BUS_AUX_COM ;
      private String edtBUS_AUX_COM_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String Z354BUS_AUX_DES ;
      private String Z357BUS_AUX_NCO ;
      private String Z358BUS_AUX_COM ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode25 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A355BUS_AUX_FAL ;
      private DateTime A356BUS_AUX_FAD ;
      private DateTime Z355BUS_AUX_FAL ;
      private DateTime Z356BUS_AUX_FAD ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T000P4_A352BUS_AUX_ID ;
      private short[] T000P4_A353BUS_AUX_RUB ;
      private String[] T000P4_A354BUS_AUX_DES ;
      private DateTime[] T000P4_A355BUS_AUX_FAL ;
      private DateTime[] T000P4_A356BUS_AUX_FAD ;
      private String[] T000P4_A357BUS_AUX_NCO ;
      private String[] T000P4_A358BUS_AUX_COM ;
      private short[] T000P5_A352BUS_AUX_ID ;
      private short[] T000P3_A352BUS_AUX_ID ;
      private short[] T000P3_A353BUS_AUX_RUB ;
      private String[] T000P3_A354BUS_AUX_DES ;
      private DateTime[] T000P3_A355BUS_AUX_FAL ;
      private DateTime[] T000P3_A356BUS_AUX_FAD ;
      private String[] T000P3_A357BUS_AUX_NCO ;
      private String[] T000P3_A358BUS_AUX_COM ;
      private short[] T000P6_A352BUS_AUX_ID ;
      private short[] T000P7_A352BUS_AUX_ID ;
      private short[] T000P8_A352BUS_AUX_ID ;
      private short[] T000P8_A353BUS_AUX_RUB ;
      private String[] T000P8_A354BUS_AUX_DES ;
      private DateTime[] T000P8_A355BUS_AUX_FAL ;
      private DateTime[] T000P8_A356BUS_AUX_FAD ;
      private String[] T000P8_A357BUS_AUX_NCO ;
      private String[] T000P8_A358BUS_AUX_COM ;
      private short[] T000P10_A352BUS_AUX_ID ;
      private short[] T000P13_A352BUS_AUX_ID ;
      private short[] T000P2_A352BUS_AUX_ID ;
      private short[] T000P2_A353BUS_AUX_RUB ;
      private String[] T000P2_A354BUS_AUX_DES ;
      private DateTime[] T000P2_A355BUS_AUX_FAL ;
      private DateTime[] T000P2_A356BUS_AUX_FAD ;
      private String[] T000P2_A357BUS_AUX_NCO ;
      private String[] T000P2_A358BUS_AUX_COM ;
      private GXWebForm Form ;
   }

   public class tbus000_aux__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000P2 ;
          prmT000P2 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P4 ;
          prmT000P4 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P5 ;
          prmT000P5 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P3 ;
          prmT000P3 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P6 ;
          prmT000P6 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P7 ;
          prmT000P7 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P8 ;
          prmT000P8 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P9 ;
          prmT000P9 = new Object[] {
          new Object[] {"@BUS_AUX_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_AUX_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@BUS_AUX_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@BUS_AUX_COM",SqlDbType.Char,2,0}
          } ;
          Object[] prmT000P10 ;
          prmT000P10 = new Object[] {
          } ;
          Object[] prmT000P11 ;
          prmT000P11 = new Object[] {
          new Object[] {"@BUS_AUX_RUB",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@BUS_AUX_DES",SqlDbType.Char,50,0} ,
          new Object[] {"@BUS_AUX_FAL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_FAD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@BUS_AUX_NCO",SqlDbType.Char,12,0} ,
          new Object[] {"@BUS_AUX_COM",SqlDbType.Char,2,0} ,
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P12 ;
          prmT000P12 = new Object[] {
          new Object[] {"@BUS_AUX_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000P13 ;
          prmT000P13 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000P2", "SELECT [BUS_AUX_ID], [BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM] FROM [TBUS000_AUX] WITH (UPDLOCK) WHERE [BUS_AUX_ID] = @BUS_AUX_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P2,1,0,true,false )
             ,new CursorDef("T000P3", "SELECT [BUS_AUX_ID], [BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM] FROM [TBUS000_AUX] WITH (NOLOCK) WHERE [BUS_AUX_ID] = @BUS_AUX_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P3,1,0,true,false )
             ,new CursorDef("T000P4", "SELECT TM1.[BUS_AUX_ID], TM1.[BUS_AUX_RUB], TM1.[BUS_AUX_DES], TM1.[BUS_AUX_FAL], TM1.[BUS_AUX_FAD], TM1.[BUS_AUX_NCO], TM1.[BUS_AUX_COM] FROM [TBUS000_AUX] TM1 WITH (NOLOCK) WHERE TM1.[BUS_AUX_ID] = @BUS_AUX_ID ORDER BY TM1.[BUS_AUX_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P4,100,0,true,false )
             ,new CursorDef("T000P5", "SELECT [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) WHERE [BUS_AUX_ID] = @BUS_AUX_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P5,1,0,true,false )
             ,new CursorDef("T000P6", "SELECT TOP 1 [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) WHERE ( [BUS_AUX_ID] > @BUS_AUX_ID) ORDER BY [BUS_AUX_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P6,1,0,true,true )
             ,new CursorDef("T000P7", "SELECT TOP 1 [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) WHERE ( [BUS_AUX_ID] < @BUS_AUX_ID) ORDER BY [BUS_AUX_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P7,1,0,true,true )
             ,new CursorDef("T000P8", "SELECT [BUS_AUX_ID], [BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM] FROM [TBUS000_AUX] WITH (UPDLOCK) WHERE [BUS_AUX_ID] = @BUS_AUX_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P8,1,0,true,false )
             ,new CursorDef("T000P9", "INSERT INTO [TBUS000_AUX] ([BUS_AUX_RUB], [BUS_AUX_DES], [BUS_AUX_FAL], [BUS_AUX_FAD], [BUS_AUX_NCO], [BUS_AUX_COM]) VALUES (@BUS_AUX_RUB, @BUS_AUX_DES, @BUS_AUX_FAL, @BUS_AUX_FAD, @BUS_AUX_NCO, @BUS_AUX_COM)", GxErrorMask.GX_NOMASK,prmT000P9)
             ,new CursorDef("T000P10", "SELECT Ident_Current('[TBUS000_AUX]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P10,1,0,true,false )
             ,new CursorDef("T000P11", "UPDATE [TBUS000_AUX] SET [BUS_AUX_RUB]=@BUS_AUX_RUB, [BUS_AUX_DES]=@BUS_AUX_DES, [BUS_AUX_FAL]=@BUS_AUX_FAL, [BUS_AUX_FAD]=@BUS_AUX_FAD, [BUS_AUX_NCO]=@BUS_AUX_NCO, [BUS_AUX_COM]=@BUS_AUX_COM  WHERE [BUS_AUX_ID] = @BUS_AUX_ID", GxErrorMask.GX_NOMASK,prmT000P11)
             ,new CursorDef("T000P12", "DELETE FROM [TBUS000_AUX]  WHERE [BUS_AUX_ID] = @BUS_AUX_ID", GxErrorMask.GX_NOMASK,prmT000P12)
             ,new CursorDef("T000P13", "SELECT [BUS_AUX_ID] FROM [TBUS000_AUX] WITH (NOLOCK) ORDER BY [BUS_AUX_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P13,100,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 12) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 2) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 12) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 2) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 12) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 2) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 12) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 2) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
