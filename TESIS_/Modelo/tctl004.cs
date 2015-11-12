/*
               File: TCTL004
        Description: ACT.CONTROL ULTIMO NUMERO(C/S)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/30/2014 17:20:58.40
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
   public class tctl004 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         Form.Meta.addItem("Description", "ACT.CONTROL ULTIMO NUMERO(C/S)", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCTM_SIS_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tctl004( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tctl004( IGxContext context )
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
            wb_table1_2_1640( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1640e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1640( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1640( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1640e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"ACT.CONTROL ULTIMO NUMERO(C/S)"+"</legend>") ;
            wb_table3_27_1640( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_1640e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1640e( true) ;
         }
         else
         {
            wb_table1_2_1640e( false) ;
         }
      }

      protected void wb_table3_27_1640( bool wbgen )
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
            wb_table4_33_1640( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_1640e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TCTL004.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TCTL004.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_1640e( true) ;
         }
         else
         {
            wb_table3_27_1640e( false) ;
         }
      }

      protected void wb_table4_33_1640( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockctm_sis_Internalname, 1, 1, 0, "SISTEMA (CONTROL ULT. NUM.)", "", "", "", 0, lblTextblockctm_sis_Jsonclick, "", StyleString, ClassString, "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCTM_SIS_Internalname, StringUtil.RTrim( A88CTM_SIS), "", 3, "chr", 1, "row", 3, 1, edtCTM_SIS_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A88CTM_SIS, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(38);\"", 0, edtCTM_SIS_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctm_tdo_Internalname, 1, 1, 0, "TIPO DOC. (CONTROL ULT. NUM.)", "", "", "", 0, lblTextblockctm_tdo_Jsonclick, "", StyleString, ClassString, "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCTM_TDO_Internalname, StringUtil.RTrim( A89CTM_TDO), "", 2, "chr", 1, "row", 2, 1, edtCTM_TDO_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A89CTM_TDO, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(43);\"", 0, edtCTM_TDO_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctm_num_Internalname, 1, 1, 0, "NUMERO (CONTROL ULT. NUM.)", "", "", "", 0, lblTextblockctm_num_Jsonclick, "", StyleString, ClassString, "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCTM_NUM_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A90CTM_NUM), 12, 0, ",", "")), "", 12, "chr", 1, "row", 12, 1, edtCTM_NUM_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A90CTM_NUM), "ZZZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtCTM_NUM_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctm_tnu_Internalname, 1, 1, 0, "TOPE DE NUM.(CONTROL ULT.NUM.)", "", "", "", 0, lblTextblockctm_tnu_Jsonclick, "", StyleString, ClassString, "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCTM_TNU_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A91CTM_TNU), 12, 0, ",", "")), "", 12, "chr", 1, "row", 12, 1, edtCTM_TNU_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A91CTM_TNU), "ZZZZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(53);\"", 0, edtCTM_TNU_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TCTL004.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_1640e( true) ;
         }
         else
         {
            wb_table4_33_1640e( false) ;
         }
      }

      protected void wb_table2_5_1640( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0140.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CTM_SIS"+"'), id:'"+"CTM_SIS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"CTM_TDO"+"'), id:'"+"CTM_TDO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0140.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CTM_SIS"+"'), id:'"+"CTM_SIS"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"CTM_TDO"+"'), id:'"+"CTM_TDO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TCTL004.htm");
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
            wb_table2_5_1640e( true) ;
         }
         else
         {
            wb_table2_5_1640e( false) ;
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
               A88CTM_SIS = StringUtil.Upper( cgiGet( edtCTM_SIS_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
               A89CTM_TDO = StringUtil.Upper( cgiGet( edtCTM_TDO_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
               if ( ! context.localUtil.VCNumber( cgiGet( edtCTM_NUM_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtCTM_NUM_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtCTM_NUM_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CTM_NUM");
                  AnyError = 1 ;
                  GX_FocusControl = edtCTM_NUM_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A90CTM_NUM = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90CTM_NUM", StringUtil.LTrim( StringUtil.Str( (decimal)(A90CTM_NUM), 12, 0)));
               }
               else
               {
                  A90CTM_NUM = (long)(context.localUtil.CToN( cgiGet( edtCTM_NUM_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90CTM_NUM", StringUtil.LTrim( StringUtil.Str( (decimal)(A90CTM_NUM), 12, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtCTM_TNU_Internalname), "ZZZZZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtCTM_TNU_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtCTM_TNU_Internalname), ",", ".") > Convert.ToDecimal( 999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CTM_TNU");
                  AnyError = 1 ;
                  GX_FocusControl = edtCTM_TNU_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A91CTM_TNU = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91CTM_TNU", StringUtil.LTrim( StringUtil.Str( (decimal)(A91CTM_TNU), 12, 0)));
               }
               else
               {
                  A91CTM_TNU = (long)(context.localUtil.CToN( cgiGet( edtCTM_TNU_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91CTM_TNU", StringUtil.LTrim( StringUtil.Str( (decimal)(A91CTM_TNU), 12, 0)));
               }
               /* Read saved values. */
               Z88CTM_SIS = cgiGet( "Z88CTM_SIS") ;
               Z89CTM_TDO = cgiGet( "Z89CTM_TDO") ;
               Z90CTM_NUM = (long)(context.localUtil.CToN( cgiGet( "Z90CTM_NUM"), ",", ".")) ;
               Z91CTM_TNU = (long)(context.localUtil.CToN( cgiGet( "Z91CTM_TNU"), ",", ".")) ;
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
                  A88CTM_SIS = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
                  A89CTM_TDO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
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
               InitAll1640( ) ;
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
         edtCTM_SIS_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCTM_SIS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCTM_SIS_Enabled), 5, 0)));
         edtCTM_TDO_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCTM_TDO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCTM_TDO_Enabled), 5, 0)));
         edtCTM_NUM_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCTM_NUM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCTM_NUM_Enabled), 5, 0)));
         edtCTM_TNU_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCTM_TNU_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCTM_TNU_Enabled), 5, 0)));
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

      protected void ResetCaption160( )
      {
      }

      protected void ZM1640( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z90CTM_NUM = T00163_A90CTM_NUM[0] ;
               Z91CTM_TNU = T00163_A91CTM_TNU[0] ;
            }
            else
            {
               Z90CTM_NUM = A90CTM_NUM ;
               Z91CTM_TNU = A91CTM_TNU ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z88CTM_SIS = A88CTM_SIS ;
            Z89CTM_TDO = A89CTM_TDO ;
            Z90CTM_NUM = A90CTM_NUM ;
            Z91CTM_TNU = A91CTM_TNU ;
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

      protected void Load1640( )
      {
         /* Using cursor T00164 */
         pr_default.execute(2, new Object[] {A88CTM_SIS, A89CTM_TDO});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound40 = 1 ;
            A90CTM_NUM = T00164_A90CTM_NUM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90CTM_NUM", StringUtil.LTrim( StringUtil.Str( (decimal)(A90CTM_NUM), 12, 0)));
            A91CTM_TNU = T00164_A91CTM_TNU[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91CTM_TNU", StringUtil.LTrim( StringUtil.Str( (decimal)(A91CTM_TNU), 12, 0)));
            ZM1640( -1) ;
         }
         pr_default.close(2);
         OnLoadActions1640( ) ;
      }

      protected void OnLoadActions1640( )
      {
      }

      protected void CheckExtendedTable1640( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1640( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound40 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey1640( )
      {
         /* Using cursor T00165 */
         pr_default.execute(3, new Object[] {A88CTM_SIS, A89CTM_TDO});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound40 = 1 ;
         }
         else
         {
            RcdFound40 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00163 */
         pr_default.execute(1, new Object[] {A88CTM_SIS, A89CTM_TDO});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1640( 1) ;
            RcdFound40 = 1 ;
            A88CTM_SIS = T00163_A88CTM_SIS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
            A89CTM_TDO = T00163_A89CTM_TDO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
            A90CTM_NUM = T00163_A90CTM_NUM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90CTM_NUM", StringUtil.LTrim( StringUtil.Str( (decimal)(A90CTM_NUM), 12, 0)));
            A91CTM_TNU = T00163_A91CTM_TNU[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91CTM_TNU", StringUtil.LTrim( StringUtil.Str( (decimal)(A91CTM_TNU), 12, 0)));
            Z88CTM_SIS = A88CTM_SIS ;
            Z89CTM_TDO = A89CTM_TDO ;
            sMode40 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1640( ) ;
            Gx_mode = sMode40 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound40 = 0 ;
            InitializeNonKey1640( ) ;
            sMode40 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode40 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1640( ) ;
         if ( RcdFound40 == 0 )
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
         RcdFound40 = 0 ;
         /* Using cursor T00166 */
         pr_default.execute(4, new Object[] {A88CTM_SIS, A89CTM_TDO});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00166_A88CTM_SIS[0], A88CTM_SIS) < 0 ) || ( StringUtil.StrCmp(T00166_A88CTM_SIS[0], A88CTM_SIS) == 0 ) && ( StringUtil.StrCmp(T00166_A89CTM_TDO[0], A89CTM_TDO) < 0 ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00166_A88CTM_SIS[0], A88CTM_SIS) > 0 ) || ( StringUtil.StrCmp(T00166_A88CTM_SIS[0], A88CTM_SIS) == 0 ) && ( StringUtil.StrCmp(T00166_A89CTM_TDO[0], A89CTM_TDO) > 0 ) ) )
            {
               A88CTM_SIS = T00166_A88CTM_SIS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
               A89CTM_TDO = T00166_A89CTM_TDO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
               RcdFound40 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound40 = 0 ;
         /* Using cursor T00167 */
         pr_default.execute(5, new Object[] {A88CTM_SIS, A89CTM_TDO});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00167_A88CTM_SIS[0], A88CTM_SIS) > 0 ) || ( StringUtil.StrCmp(T00167_A88CTM_SIS[0], A88CTM_SIS) == 0 ) && ( StringUtil.StrCmp(T00167_A89CTM_TDO[0], A89CTM_TDO) > 0 ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00167_A88CTM_SIS[0], A88CTM_SIS) < 0 ) || ( StringUtil.StrCmp(T00167_A88CTM_SIS[0], A88CTM_SIS) == 0 ) && ( StringUtil.StrCmp(T00167_A89CTM_TDO[0], A89CTM_TDO) < 0 ) ) )
            {
               A88CTM_SIS = T00167_A88CTM_SIS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
               A89CTM_TDO = T00167_A89CTM_TDO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
               RcdFound40 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1640( ) ;
         if ( RcdFound40 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "CTM_SIS");
               AnyError = 1 ;
               GX_FocusControl = edtCTM_SIS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A88CTM_SIS, Z88CTM_SIS) != 0 ) || ( StringUtil.StrCmp(A89CTM_TDO, Z89CTM_TDO) != 0 ) )
            {
               A88CTM_SIS = Z88CTM_SIS ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
               A89CTM_TDO = Z89CTM_TDO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "CTM_SIS");
               AnyError = 1 ;
               GX_FocusControl = edtCTM_SIS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtCTM_SIS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update1640( ) ;
               GX_FocusControl = edtCTM_SIS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A88CTM_SIS, Z88CTM_SIS) != 0 ) || ( StringUtil.StrCmp(A89CTM_TDO, Z89CTM_TDO) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert1640( ) ;
               GX_FocusControl = edtCTM_SIS_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "CTM_SIS");
                  AnyError = 1 ;
                  GX_FocusControl = edtCTM_SIS_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert1640( ) ;
                  GX_FocusControl = edtCTM_SIS_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A88CTM_SIS, Z88CTM_SIS) != 0 ) || ( StringUtil.StrCmp(A89CTM_TDO, Z89CTM_TDO) != 0 ) )
         {
            A88CTM_SIS = Z88CTM_SIS ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
            A89CTM_TDO = Z89CTM_TDO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "CTM_SIS");
            AnyError = 1 ;
            GX_FocusControl = edtCTM_SIS_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCTM_SIS_Internalname ;
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
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "CTM_SIS");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCTM_NUM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1640( ) ;
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCTM_NUM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1640( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCTM_NUM_Internalname ;
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
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCTM_NUM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart1640( ) ;
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound40 != 0 )
            {
               ScanNext1640( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCTM_NUM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1640( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1640( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00168 */
            pr_default.execute(6, new Object[] {A88CTM_SIS, A89CTM_TDO});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CTL004"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( Z90CTM_NUM != T00168_A90CTM_NUM[0] ) || ( Z91CTM_TNU != T00168_A91CTM_TNU[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CTL004"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1640( )
      {
         BeforeValidate1640( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1640( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1640( 0) ;
            CheckOptimisticConcurrency1640( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1640( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1640( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00169 */
                     pr_default.execute(7, new Object[] {A88CTM_SIS, A89CTM_TDO, A90CTM_NUM, A91CTM_TNU});
                     pr_default.close(7);
                     if ( (pr_default.getStatus(7) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption160( ) ;
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
               Load1640( ) ;
            }
            EndLevel1640( ) ;
         }
         CloseExtendedTableCursors1640( ) ;
      }

      protected void Update1640( )
      {
         BeforeValidate1640( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1640( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1640( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1640( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1640( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001610 */
                     pr_default.execute(8, new Object[] {A90CTM_NUM, A91CTM_TNU, A88CTM_SIS, A89CTM_TDO});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CTL004"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1640( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption160( ) ;
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
            EndLevel1640( ) ;
         }
         CloseExtendedTableCursors1640( ) ;
      }

      protected void DeferredUpdate1640( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1640( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1640( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1640( ) ;
            AfterConfirm1640( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1640( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001611 */
                  pr_default.execute(9, new Object[] {A88CTM_SIS, A89CTM_TDO});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound40 == 0 )
                        {
                           InitAll1640( ) ;
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
                        ResetCaption160( ) ;
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
         sMode40 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1640( ) ;
         Gx_mode = sMode40 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1640( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1640( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1640( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TCTL004");
            if ( AnyError == 0 )
            {
               ConfirmValues160( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TCTL004");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1640( )
      {
         /* Using cursor T001612 */
         pr_default.execute(10);
         RcdFound40 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound40 = 1 ;
            A88CTM_SIS = T001612_A88CTM_SIS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
            A89CTM_TDO = T001612_A89CTM_TDO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1640( )
      {
         pr_default.readNext(10);
         RcdFound40 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound40 = 1 ;
            A88CTM_SIS = T001612_A88CTM_SIS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
            A89CTM_TDO = T001612_A89CTM_TDO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
         }
      }

      protected void ScanEnd1640( )
      {
      }

      protected void AfterConfirm1640( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1640( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1640( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1640( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1640( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1640( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues160( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tctl004.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z88CTM_SIS", StringUtil.RTrim( Z88CTM_SIS));
         GxWebStd.gx_hidden_field( context, "Z89CTM_TDO", StringUtil.RTrim( Z89CTM_TDO));
         GxWebStd.gx_hidden_field( context, "Z90CTM_NUM", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z90CTM_NUM), 12, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z91CTM_TNU", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91CTM_TNU), 12, 0, ",", "")));
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
         return "TCTL004" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACT.CONTROL ULTIMO NUMERO(C/S)" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tctl004.aspx")  ;
      }

      protected void InitializeNonKey1640( )
      {
         A90CTM_NUM = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90CTM_NUM", StringUtil.LTrim( StringUtil.Str( (decimal)(A90CTM_NUM), 12, 0)));
         A91CTM_TNU = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91CTM_TNU", StringUtil.LTrim( StringUtil.Str( (decimal)(A91CTM_TNU), 12, 0)));
      }

      protected void InitAll1640( )
      {
         A88CTM_SIS = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A88CTM_SIS", A88CTM_SIS);
         A89CTM_TDO = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89CTM_TDO", A89CTM_TDO);
         InitializeNonKey1640( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?17205938");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tctl004.js", "?17205938");
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
         lblTextblockctm_sis_Internalname = "TEXTBLOCKCTM_SIS" ;
         edtCTM_SIS_Internalname = "CTM_SIS" ;
         lblTextblockctm_tdo_Internalname = "TEXTBLOCKCTM_TDO" ;
         edtCTM_TDO_Internalname = "CTM_TDO" ;
         lblTextblockctm_num_Internalname = "TEXTBLOCKCTM_NUM" ;
         edtCTM_NUM_Internalname = "CTM_NUM" ;
         lblTextblockctm_tnu_Internalname = "TEXTBLOCKCTM_TNU" ;
         edtCTM_TNU_Internalname = "CTM_TNU" ;
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
         Form.Caption = "ACT.CONTROL ULTIMO NUMERO(C/S)" ;
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
         edtCTM_TNU_Jsonclick = "" ;
         edtCTM_TNU_Enabled = 1 ;
         edtCTM_NUM_Jsonclick = "" ;
         edtCTM_NUM_Enabled = 1 ;
         edtCTM_TDO_Jsonclick = "" ;
         edtCTM_TDO_Enabled = 1 ;
         edtCTM_SIS_Jsonclick = "" ;
         edtCTM_SIS_Enabled = 1 ;
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
         GX_FocusControl = edtCTM_NUM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ctm_tdo( String GX_Parm1 ,
                                 String GX_Parm2 ,
                                 long GX_Parm3 ,
                                 long GX_Parm4 )
      {
         A88CTM_SIS = GX_Parm1 ;
         A89CTM_TDO = GX_Parm2 ;
         A90CTM_NUM = GX_Parm3 ;
         A91CTM_TNU = GX_Parm4 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A90CTM_NUM), 12, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A91CTM_TNU), 12, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z88CTM_SIS)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z89CTM_TDO)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z90CTM_NUM), 12, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z91CTM_TNU), 12, 0, ",", ""))));
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
         pr_default.close(10);
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
         lblTextblockctm_sis_Jsonclick = "" ;
         A88CTM_SIS = "" ;
         lblTextblockctm_tdo_Jsonclick = "" ;
         A89CTM_TDO = "" ;
         lblTextblockctm_num_Jsonclick = "" ;
         lblTextblockctm_tnu_Jsonclick = "" ;
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
         Z88CTM_SIS = "" ;
         Z89CTM_TDO = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00164_A88CTM_SIS = new String[] {""} ;
         T00164_A89CTM_TDO = new String[] {""} ;
         T00164_A90CTM_NUM = new long[1] ;
         T00164_A91CTM_TNU = new long[1] ;
         T00165_A88CTM_SIS = new String[] {""} ;
         T00165_A89CTM_TDO = new String[] {""} ;
         T00163_A88CTM_SIS = new String[] {""} ;
         T00163_A89CTM_TDO = new String[] {""} ;
         T00163_A90CTM_NUM = new long[1] ;
         T00163_A91CTM_TNU = new long[1] ;
         sMode40 = "" ;
         T00166_A88CTM_SIS = new String[] {""} ;
         T00166_A89CTM_TDO = new String[] {""} ;
         T00167_A88CTM_SIS = new String[] {""} ;
         T00167_A89CTM_TDO = new String[] {""} ;
         T00168_A88CTM_SIS = new String[] {""} ;
         T00168_A89CTM_TDO = new String[] {""} ;
         T00168_A90CTM_NUM = new long[1] ;
         T00168_A91CTM_TNU = new long[1] ;
         T001612_A88CTM_SIS = new String[] {""} ;
         T001612_A89CTM_TDO = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tctl004__default(),
            new Object[][] {
                new Object[] {
               T00162_A88CTM_SIS, T00162_A89CTM_TDO, T00162_A90CTM_NUM, T00162_A91CTM_TNU
               }
               , new Object[] {
               T00163_A88CTM_SIS, T00163_A89CTM_TDO, T00163_A90CTM_NUM, T00163_A91CTM_TNU
               }
               , new Object[] {
               T00164_A88CTM_SIS, T00164_A89CTM_TDO, T00164_A90CTM_NUM, T00164_A91CTM_TNU
               }
               , new Object[] {
               T00165_A88CTM_SIS, T00165_A89CTM_TDO
               }
               , new Object[] {
               T00166_A88CTM_SIS, T00166_A89CTM_TDO
               }
               , new Object[] {
               T00167_A88CTM_SIS, T00167_A89CTM_TDO
               }
               , new Object[] {
               T00168_A88CTM_SIS, T00168_A89CTM_TDO, T00168_A90CTM_NUM, T00168_A91CTM_TNU
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001612_A88CTM_SIS, T001612_A89CTM_TDO
               }
            }
         );
      }

      private short RcdFound40 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtCTM_SIS_Enabled ;
      private int edtCTM_TDO_Enabled ;
      private int edtCTM_NUM_Enabled ;
      private int edtCTM_TNU_Enabled ;
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
      private long A90CTM_NUM ;
      private long A91CTM_TNU ;
      private long Z90CTM_NUM ;
      private long Z91CTM_TNU ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCTM_SIS_Internalname ;
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
      private String lblTextblockctm_sis_Internalname ;
      private String lblTextblockctm_sis_Jsonclick ;
      private String A88CTM_SIS ;
      private String edtCTM_SIS_Jsonclick ;
      private String lblTextblockctm_tdo_Internalname ;
      private String lblTextblockctm_tdo_Jsonclick ;
      private String edtCTM_TDO_Internalname ;
      private String A89CTM_TDO ;
      private String edtCTM_TDO_Jsonclick ;
      private String lblTextblockctm_num_Internalname ;
      private String lblTextblockctm_num_Jsonclick ;
      private String edtCTM_NUM_Internalname ;
      private String edtCTM_NUM_Jsonclick ;
      private String lblTextblockctm_tnu_Internalname ;
      private String lblTextblockctm_tnu_Jsonclick ;
      private String edtCTM_TNU_Internalname ;
      private String edtCTM_TNU_Jsonclick ;
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
      private String Z88CTM_SIS ;
      private String Z89CTM_TDO ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode40 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00164_A88CTM_SIS ;
      private String[] T00164_A89CTM_TDO ;
      private long[] T00164_A90CTM_NUM ;
      private long[] T00164_A91CTM_TNU ;
      private String[] T00165_A88CTM_SIS ;
      private String[] T00165_A89CTM_TDO ;
      private String[] T00163_A88CTM_SIS ;
      private String[] T00163_A89CTM_TDO ;
      private long[] T00163_A90CTM_NUM ;
      private long[] T00163_A91CTM_TNU ;
      private String[] T00166_A88CTM_SIS ;
      private String[] T00166_A89CTM_TDO ;
      private String[] T00167_A88CTM_SIS ;
      private String[] T00167_A89CTM_TDO ;
      private String[] T00168_A88CTM_SIS ;
      private String[] T00168_A89CTM_TDO ;
      private long[] T00168_A90CTM_NUM ;
      private long[] T00168_A91CTM_TNU ;
      private String[] T001612_A88CTM_SIS ;
      private String[] T001612_A89CTM_TDO ;
      private String[] T00162_A88CTM_SIS ;
      private String[] T00162_A89CTM_TDO ;
      private long[] T00162_A90CTM_NUM ;
      private long[] T00162_A91CTM_TNU ;
      private GXWebForm Form ;
   }

   public class tctl004__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00162 ;
          prmT00162 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00164 ;
          prmT00164 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00165 ;
          prmT00165 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00163 ;
          prmT00163 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00166 ;
          prmT00166 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00167 ;
          prmT00167 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00168 ;
          prmT00168 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT00169 ;
          prmT00169 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0} ,
          new Object[] {"@CTM_NUM",SqlDbType.Decimal,12,0} ,
          new Object[] {"@CTM_TNU",SqlDbType.Decimal,12,0}
          } ;
          Object[] prmT001610 ;
          prmT001610 = new Object[] {
          new Object[] {"@CTM_NUM",SqlDbType.Decimal,12,0} ,
          new Object[] {"@CTM_TNU",SqlDbType.Decimal,12,0} ,
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT001611 ;
          prmT001611 = new Object[] {
          new Object[] {"@CTM_SIS",SqlDbType.Char,3,0} ,
          new Object[] {"@CTM_TDO",SqlDbType.Char,2,0}
          } ;
          Object[] prmT001612 ;
          prmT001612 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00162", "SELECT [CTM_SIS], [CTM_TDO], [CTM_NUM], [CTM_TNU] FROM [CTL004] WITH (UPDLOCK) WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00162,1,0,true,false )
             ,new CursorDef("T00163", "SELECT [CTM_SIS], [CTM_TDO], [CTM_NUM], [CTM_TNU] FROM [CTL004] WITH (NOLOCK) WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00163,1,0,true,false )
             ,new CursorDef("T00164", "SELECT TM1.[CTM_SIS], TM1.[CTM_TDO], TM1.[CTM_NUM], TM1.[CTM_TNU] FROM [CTL004] TM1 WITH (NOLOCK) WHERE TM1.[CTM_SIS] = @CTM_SIS and TM1.[CTM_TDO] = @CTM_TDO ORDER BY TM1.[CTM_SIS], TM1.[CTM_TDO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00164,100,0,true,false )
             ,new CursorDef("T00165", "SELECT [CTM_SIS], [CTM_TDO] FROM [CTL004] WITH (NOLOCK) WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00165,1,0,true,false )
             ,new CursorDef("T00166", "SELECT TOP 1 [CTM_SIS], [CTM_TDO] FROM [CTL004] WITH (NOLOCK) WHERE ( [CTM_SIS] > @CTM_SIS or [CTM_SIS] = @CTM_SIS and [CTM_TDO] > @CTM_TDO) ORDER BY [CTM_SIS], [CTM_TDO]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00166,1,0,true,true )
             ,new CursorDef("T00167", "SELECT TOP 1 [CTM_SIS], [CTM_TDO] FROM [CTL004] WITH (NOLOCK) WHERE ( [CTM_SIS] < @CTM_SIS or [CTM_SIS] = @CTM_SIS and [CTM_TDO] < @CTM_TDO) ORDER BY [CTM_SIS] DESC, [CTM_TDO] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00167,1,0,true,true )
             ,new CursorDef("T00168", "SELECT [CTM_SIS], [CTM_TDO], [CTM_NUM], [CTM_TNU] FROM [CTL004] WITH (UPDLOCK) WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00168,1,0,true,false )
             ,new CursorDef("T00169", "INSERT INTO [CTL004] ([CTM_SIS], [CTM_TDO], [CTM_NUM], [CTM_TNU]) VALUES (@CTM_SIS, @CTM_TDO, @CTM_NUM, @CTM_TNU)", GxErrorMask.GX_NOMASK,prmT00169)
             ,new CursorDef("T001610", "UPDATE [CTL004] SET [CTM_NUM]=@CTM_NUM, [CTM_TNU]=@CTM_TNU  WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO", GxErrorMask.GX_NOMASK,prmT001610)
             ,new CursorDef("T001611", "DELETE FROM [CTL004]  WHERE [CTM_SIS] = @CTM_SIS AND [CTM_TDO] = @CTM_TDO", GxErrorMask.GX_NOMASK,prmT001611)
             ,new CursorDef("T001612", "SELECT [CTM_SIS], [CTM_TDO] FROM [CTL004] WITH (NOLOCK) ORDER BY [CTM_SIS], [CTM_TDO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001612,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                ((long[]) buf[3])[0] = rslt.getLong(4) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 3) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (long)parms[2]);
                stmt.SetParameter(4, (long)parms[3]);
                break;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
