/*
               File: SEG009
        Description: Relaciones Programas - Objetos web
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:21.99
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
   public class seg009 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_3( A116SIS_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_4( A126PRG_COD) ;
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
         cmbACW_PRM.Name = "ACW_PRM" ;
         cmbACW_PRM.WebTags = "" ;
         cmbACW_PRM.addItem("", "Pendiente", 0);
         cmbACW_PRM.addItem("A", "Autorizado", 0);
         cmbACW_PRM.addItem("D", "Denegado", 0);
         cmbACW_PRM.addItem("I", "Informado", 0);
         if ( ( cmbACW_PRM.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A363ACW_PRM)) )
         {
            A363ACW_PRM = cmbACW_PRM.getItemValue(1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363ACW_PRM", A363ACW_PRM);
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Relaciones Programas - Objetos web", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSIS_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public seg009( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg009( IGxContext context )
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
         cmbACW_PRM = new GXCombobox();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_0V30( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0V30e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0V30( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0V30( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0V30e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Relaciones Programas - Objetos web"+"</legend>") ;
            wb_table3_27_0V30( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0V30e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0V30e( true) ;
         }
         else
         {
            wb_table1_2_0V30e( false) ;
         }
      }

      protected void wb_table3_27_0V30( bool wbgen )
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
            wb_table4_33_0V30( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0V30e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_SEG009.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_SEG009.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0V30e( true) ;
         }
         else
         {
            wb_table3_27_0V30e( false) ;
         }
      }

      protected void wb_table4_33_0V30( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblocksis_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG009.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_116_Internalname, "", "prompt.gif", "Modern", imgprompt_116_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_116_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksis_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblocksis_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG009.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_126_Internalname, "", "prompt.gif", "Modern", imgprompt_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_126_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockacw_obj_Internalname, 1, 1, 0, "OBJETO WEB", "", "", "", 0, lblTextblockacw_obj_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtACW_OBJ_Internalname, StringUtil.RTrim( A152ACW_OBJ), 1, edtACW_OBJ_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"", -1, 0, "", "", true, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockacw_prm_Internalname, 1, 1, 0, "PERMITIDO", "", "", "", 0, lblTextblockacw_prm_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbACW_PRM, cmbACW_PRM_Internalname, A363ACW_PRM, "", "char", 1, cmbACW_PRM.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbACW_PRM_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", true, "HLP_SEG009.htm");
            cmbACW_PRM.CurrentValue = A363ACW_PRM ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbACW_PRM_Internalname, "Values", (String)(cmbACW_PRM.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockacw_obs_Internalname, 1, 1, 0, "OBSERVACIONES ", "", "", "", 0, lblTextblockacw_obs_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtACW_OBS_Internalname, A153ACW_OBS, 1, edtACW_OBS_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "1000", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", -1, 0, "", "", true, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockacw_mom_Internalname, 1, 1, 0, "ACTUALIZACION", "", "", "", 0, lblTextblockacw_mom_Jsonclick, "", StyleString, ClassString, "HLP_SEG009.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtACW_MOM_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtACW_MOM_Internalname, context.localUtil.Format(A154ACW_MOM, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtACW_MOM_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A154ACW_MOM, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(73);\"", 0, edtACW_MOM_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG009.htm");
            GxWebStd.gx_bitmap( context, edtACW_MOM_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtACW_MOM_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_SEG009.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0V30e( true) ;
         }
         else
         {
            wb_table4_33_0V30e( false) ;
         }
      }

      protected void wb_table2_5_0V30( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00u0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"ACW_OBJ"+"'), id:'"+"ACW_OBJ"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00u0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"ACW_OBJ"+"'), id:'"+"ACW_OBJ"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG009.htm");
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
            wb_table2_5_0V30e( true) ;
         }
         else
         {
            wb_table2_5_0V30e( false) ;
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtSIS_COD_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "SIS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A116SIS_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               }
               else
               {
                  A116SIS_COD = (short)(context.localUtil.CToN( cgiGet( edtSIS_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               }
               A259SIS_DES = StringUtil.Upper( cgiGet( edtSIS_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRG_COD_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A126PRG_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               else
               {
                  A126PRG_COD = (short)(context.localUtil.CToN( cgiGet( edtPRG_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               }
               A127PRG_DES = cgiGet( edtPRG_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
               A152ACW_OBJ = cgiGet( edtACW_OBJ_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
               cmbACW_PRM.CurrentValue = cgiGet( cmbACW_PRM_Internalname) ;
               A363ACW_PRM = cgiGet( cmbACW_PRM_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363ACW_PRM", A363ACW_PRM);
               A153ACW_OBS = cgiGet( edtACW_OBS_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153ACW_OBS", A153ACW_OBS);
               if ( context.localUtil.VCDateTime( cgiGet( edtACW_MOM_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO ACTUALIZACION"}), 1, "ACW_MOM");
                  AnyError = 1 ;
                  GX_FocusControl = edtACW_MOM_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A154ACW_MOM = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154ACW_MOM", context.localUtil.TToC( A154ACW_MOM, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A154ACW_MOM = context.localUtil.CToT( cgiGet( edtACW_MOM_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154ACW_MOM", context.localUtil.TToC( A154ACW_MOM, 8, 5, 0, 3, "/", ":", " "));
               }
               /* Read saved values. */
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z152ACW_OBJ = cgiGet( "Z152ACW_OBJ") ;
               Z363ACW_PRM = cgiGet( "Z363ACW_PRM") ;
               Z154ACW_MOM = context.localUtil.CToT( cgiGet( "Z154ACW_MOM")) ;
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
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A152ACW_OBJ = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
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
               InitAll0V30( ) ;
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
         edtSIS_COD_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         edtSIS_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
         edtPRG_COD_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         edtPRG_DES_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
         edtACW_OBJ_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtACW_OBJ_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtACW_OBJ_Enabled), 5, 0)));
         cmbACW_PRM.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbACW_PRM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbACW_PRM.Enabled), 5, 0)));
         edtACW_OBS_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtACW_OBS_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtACW_OBS_Enabled), 5, 0)));
         edtACW_MOM_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtACW_MOM_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtACW_MOM_Enabled), 5, 0)));
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

      protected void ResetCaption0V0( )
      {
      }

      protected void ZM0V30( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z363ACW_PRM = T000V3_A363ACW_PRM[0] ;
               Z154ACW_MOM = T000V3_A154ACW_MOM[0] ;
            }
            else
            {
               Z363ACW_PRM = A363ACW_PRM ;
               Z154ACW_MOM = A154ACW_MOM ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z152ACW_OBJ = A152ACW_OBJ ;
            Z363ACW_PRM = A363ACW_PRM ;
            Z153ACW_OBS = A153ACW_OBS ;
            Z154ACW_MOM = A154ACW_MOM ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z259SIS_DES = A259SIS_DES ;
            Z127PRG_DES = A127PRG_DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_116_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00w0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
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

      protected void Load0V30( )
      {
         /* Using cursor T000V6 */
         pr_default.execute(4, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound30 = 1 ;
            A259SIS_DES = T000V6_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A127PRG_DES = T000V6_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A363ACW_PRM = T000V6_A363ACW_PRM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363ACW_PRM", A363ACW_PRM);
            A153ACW_OBS = T000V6_A153ACW_OBS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153ACW_OBS", A153ACW_OBS);
            A154ACW_MOM = T000V6_A154ACW_MOM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154ACW_MOM", context.localUtil.TToC( A154ACW_MOM, 8, 5, 0, 3, "/", ":", " "));
            ZM0V30( -2) ;
         }
         pr_default.close(4);
         OnLoadActions0V30( ) ;
      }

      protected void OnLoadActions0V30( )
      {
      }

      protected void CheckExtendedTable0V30( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         /* Using cursor T000V4 */
         pr_default.execute(2, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000V4_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(2);
         /* Using cursor T000V5 */
         pr_default.execute(3, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000V5_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A154ACW_MOM) || ( A154ACW_MOM >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo MOMENTO ACTUALIZACION fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0V30( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound30 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void gxLoad_3( short A116SIS_COD )
      {
         /* Using cursor T000V7 */
         pr_default.execute(5, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000V7_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A259SIS_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_4( short A126PRG_COD )
      {
         /* Using cursor T000V8 */
         pr_default.execute(6, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000V8_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127PRG_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0V30( )
      {
         /* Using cursor T000V9 */
         pr_default.execute(7, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound30 = 1 ;
         }
         else
         {
            RcdFound30 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000V3 */
         pr_default.execute(1, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0V30( 2) ;
            RcdFound30 = 1 ;
            A152ACW_OBJ = T000V3_A152ACW_OBJ[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
            A363ACW_PRM = T000V3_A363ACW_PRM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363ACW_PRM", A363ACW_PRM);
            A153ACW_OBS = T000V3_A153ACW_OBS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153ACW_OBS", A153ACW_OBS);
            A154ACW_MOM = T000V3_A154ACW_MOM[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154ACW_MOM", context.localUtil.TToC( A154ACW_MOM, 8, 5, 0, 3, "/", ":", " "));
            A116SIS_COD = T000V3_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T000V3_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z152ACW_OBJ = A152ACW_OBJ ;
            sMode30 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0V30( ) ;
            Gx_mode = sMode30 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound30 = 0 ;
            InitializeNonKey0V30( ) ;
            sMode30 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode30 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0V30( ) ;
         if ( RcdFound30 == 0 )
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
         RcdFound30 = 0 ;
         /* Using cursor T000V10 */
         pr_default.execute(8, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000V10_A116SIS_COD[0] < A116SIS_COD ) || ( T000V10_A116SIS_COD[0] == A116SIS_COD ) && ( T000V10_A126PRG_COD[0] < A126PRG_COD ) || ( T000V10_A126PRG_COD[0] == A126PRG_COD ) && ( T000V10_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T000V10_A152ACW_OBJ[0], A152ACW_OBJ) < 0 ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000V10_A116SIS_COD[0] > A116SIS_COD ) || ( T000V10_A116SIS_COD[0] == A116SIS_COD ) && ( T000V10_A126PRG_COD[0] > A126PRG_COD ) || ( T000V10_A126PRG_COD[0] == A126PRG_COD ) && ( T000V10_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T000V10_A152ACW_OBJ[0], A152ACW_OBJ) > 0 ) ) )
            {
               A116SIS_COD = T000V10_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = T000V10_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A152ACW_OBJ = T000V10_A152ACW_OBJ[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
               RcdFound30 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound30 = 0 ;
         /* Using cursor T000V11 */
         pr_default.execute(9, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000V11_A116SIS_COD[0] > A116SIS_COD ) || ( T000V11_A116SIS_COD[0] == A116SIS_COD ) && ( T000V11_A126PRG_COD[0] > A126PRG_COD ) || ( T000V11_A126PRG_COD[0] == A126PRG_COD ) && ( T000V11_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T000V11_A152ACW_OBJ[0], A152ACW_OBJ) > 0 ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000V11_A116SIS_COD[0] < A116SIS_COD ) || ( T000V11_A116SIS_COD[0] == A116SIS_COD ) && ( T000V11_A126PRG_COD[0] < A126PRG_COD ) || ( T000V11_A126PRG_COD[0] == A126PRG_COD ) && ( T000V11_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T000V11_A152ACW_OBJ[0], A152ACW_OBJ) < 0 ) ) )
            {
               A116SIS_COD = T000V11_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = T000V11_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A152ACW_OBJ = T000V11_A152ACW_OBJ[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
               RcdFound30 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0V30( ) ;
         if ( RcdFound30 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( StringUtil.StrCmp(A152ACW_OBJ, Z152ACW_OBJ) != 0 ) )
            {
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A152ACW_OBJ = Z152ACW_OBJ ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "SIS_COD");
               AnyError = 1 ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0V30( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( StringUtil.StrCmp(A152ACW_OBJ, Z152ACW_OBJ) != 0 ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0V30( ) ;
               GX_FocusControl = edtSIS_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "SIS_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0V30( ) ;
                  GX_FocusControl = edtSIS_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( StringUtil.StrCmp(A152ACW_OBJ, Z152ACW_OBJ) != 0 ) )
         {
            A116SIS_COD = Z116SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A152ACW_OBJ = Z152ACW_OBJ ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSIS_COD_Internalname ;
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
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
         }
         GX_FocusControl = cmbACW_PRM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0V30( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbACW_PRM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0V30( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbACW_PRM_Internalname ;
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
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbACW_PRM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0V30( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound30 != 0 )
            {
               ScanNext0V30( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = cmbACW_PRM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0V30( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0V30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000V12 */
            pr_default.execute(10, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG009"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z363ACW_PRM, T000V12_A363ACW_PRM[0]) != 0 ) || ( Z154ACW_MOM != T000V12_A154ACW_MOM[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG009"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0V30( )
      {
         BeforeValidate0V30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V30( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0V30( 0) ;
            CheckOptimisticConcurrency0V30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0V30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V13 */
                     pr_default.execute(11, new Object[] {A152ACW_OBJ, A363ACW_PRM, A153ACW_OBS, A154ACW_MOM, A116SIS_COD, A126PRG_COD});
                     pr_default.close(11);
                     if ( (pr_default.getStatus(11) == 1) )
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
                           ResetCaption0V0( ) ;
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
               Load0V30( ) ;
            }
            EndLevel0V30( ) ;
         }
         CloseExtendedTableCursors0V30( ) ;
      }

      protected void Update0V30( )
      {
         BeforeValidate0V30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V30( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0V30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000V14 */
                     pr_default.execute(12, new Object[] {A363ACW_PRM, A153ACW_OBS, A154ACW_MOM, A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG009"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0V30( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0V0( ) ;
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
            EndLevel0V30( ) ;
         }
         CloseExtendedTableCursors0V30( ) ;
      }

      protected void DeferredUpdate0V30( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0V30( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V30( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0V30( ) ;
            AfterConfirm0V30( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0V30( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000V15 */
                  pr_default.execute(13, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ});
                  pr_default.close(13);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound30 == 0 )
                        {
                           InitAll0V30( ) ;
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
                        ResetCaption0V0( ) ;
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
         sMode30 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0V30( ) ;
         Gx_mode = sMode30 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0V30( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000V16 */
            pr_default.execute(14, new Object[] {A116SIS_COD});
            A259SIS_DES = T000V16_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            pr_default.close(14);
            /* Using cursor T000V17 */
            pr_default.execute(15, new Object[] {A126PRG_COD});
            A127PRG_DES = T000V17_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            pr_default.close(15);
         }
      }

      protected void EndLevel0V30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0V30( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            pr_default.close(15);
            context.CommitDataStores("SEG009");
            if ( AnyError == 0 )
            {
               ConfirmValues0V0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            pr_default.close(15);
            context.RollbackDataStores("SEG009");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0V30( )
      {
         /* Using cursor T000V18 */
         pr_default.execute(16);
         RcdFound30 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound30 = 1 ;
            A116SIS_COD = T000V18_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T000V18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A152ACW_OBJ = T000V18_A152ACW_OBJ[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0V30( )
      {
         pr_default.readNext(16);
         RcdFound30 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound30 = 1 ;
            A116SIS_COD = T000V18_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T000V18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A152ACW_OBJ = T000V18_A152ACW_OBJ[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
         }
      }

      protected void ScanEnd0V30( )
      {
      }

      protected void AfterConfirm0V30( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0V30( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0V30( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0V30( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0V30( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0V30( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0V0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("seg009.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z152ACW_OBJ", StringUtil.RTrim( Z152ACW_OBJ));
         GxWebStd.gx_hidden_field( context, "Z363ACW_PRM", StringUtil.RTrim( Z363ACW_PRM));
         GxWebStd.gx_hidden_field( context, "Z154ACW_MOM", context.localUtil.TToC( Z154ACW_MOM, 10, 8, 0, 3, "/", ":", " "));
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
         return "SEG009" ;
      }

      public override String GetPgmdesc( )
      {
         return "Relaciones Programas - Objetos web" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("seg009.aspx")  ;
      }

      protected void InitializeNonKey0V30( )
      {
         A259SIS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A363ACW_PRM = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A363ACW_PRM", A363ACW_PRM);
         A153ACW_OBS = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153ACW_OBS", A153ACW_OBS);
         A154ACW_MOM = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154ACW_MOM", context.localUtil.TToC( A154ACW_MOM, 8, 5, 0, 3, "/", ":", " "));
      }

      protected void InitAll0V30( )
      {
         A116SIS_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A152ACW_OBJ = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152ACW_OBJ", A152ACW_OBJ);
         InitializeNonKey0V30( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11192351");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("seg009.js", "?11192351");
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
         lblTextblocksis_cod_Internalname = "TEXTBLOCKSIS_COD" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         lblTextblocksis_des_Internalname = "TEXTBLOCKSIS_DES" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         lblTextblockprg_cod_Internalname = "TEXTBLOCKPRG_COD" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         lblTextblockprg_des_Internalname = "TEXTBLOCKPRG_DES" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblockacw_obj_Internalname = "TEXTBLOCKACW_OBJ" ;
         edtACW_OBJ_Internalname = "ACW_OBJ" ;
         lblTextblockacw_prm_Internalname = "TEXTBLOCKACW_PRM" ;
         cmbACW_PRM_Internalname = "ACW_PRM" ;
         lblTextblockacw_obs_Internalname = "TEXTBLOCKACW_OBS" ;
         edtACW_OBS_Internalname = "ACW_OBS" ;
         lblTextblockacw_mom_Internalname = "TEXTBLOCKACW_MOM" ;
         edtACW_MOM_Internalname = "ACW_MOM" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_116_Internalname = "PROMPT_116" ;
         imgprompt_126_Internalname = "PROMPT_126" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Relaciones Programas - Objetos web" ;
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
         edtACW_MOM_Jsonclick = "" ;
         edtACW_MOM_Enabled = 1 ;
         edtACW_OBS_Enabled = 1 ;
         cmbACW_PRM_Jsonclick = "" ;
         cmbACW_PRM.Enabled = 1 ;
         edtACW_OBJ_Enabled = 1 ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_DES_Enabled = 0 ;
         imgprompt_126_Visible = 1 ;
         imgprompt_126_Link = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Enabled = 1 ;
         edtSIS_DES_Jsonclick = "" ;
         edtSIS_DES_Enabled = 0 ;
         imgprompt_116_Visible = 1 ;
         imgprompt_116_Link = "" ;
         edtSIS_COD_Jsonclick = "" ;
         edtSIS_COD_Enabled = 1 ;
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
         /* Using cursor T000V16 */
         pr_default.execute(14, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000V16_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(14);
         /* Using cursor T000V17 */
         pr_default.execute(15, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000V17_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         pr_default.close(15);
         GX_FocusControl = cmbACW_PRM_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Sis_cod( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A116SIS_COD = GX_Parm1 ;
         A259SIS_DES = GX_Parm2 ;
         /* Using cursor T000V16 */
         pr_default.execute(14, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T000V16_A259SIS_DES[0] ;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A259SIS_DES = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A259SIS_DES)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Prg_cod( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A126PRG_COD = GX_Parm1 ;
         A127PRG_DES = GX_Parm2 ;
         /* Using cursor T000V17 */
         pr_default.execute(15, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000V17_A127PRG_DES[0] ;
         }
         pr_default.close(15);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127PRG_DES = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Acw_obj( short GX_Parm1 ,
                                 short GX_Parm2 ,
                                 String GX_Parm3 ,
                                 GXCombobox cmbGX_Parm4 ,
                                 String GX_Parm5 ,
                                 DateTime GX_Parm6 )
      {
         A116SIS_COD = GX_Parm1 ;
         A126PRG_COD = GX_Parm2 ;
         A152ACW_OBJ = GX_Parm3 ;
         cmbACW_PRM = cmbGX_Parm4 ;
         A363ACW_PRM = cmbACW_PRM.CurrentValue ;
         cmbACW_PRM.CurrentValue = A363ACW_PRM ;
         A153ACW_OBS = GX_Parm5 ;
         A154ACW_MOM = GX_Parm6 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A259SIS_DES = "" ;
            A127PRG_DES = "" ;
         }
         cmbACW_PRM.CurrentValue = A363ACW_PRM ;
         isValidOutput.Add((Object)(cmbACW_PRM));
         isValidOutput.Add((Object)(A153ACW_OBS));
         isValidOutput.Add((Object)(context.localUtil.Format(A154ACW_MOM, "99/99/99 99:99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( A259SIS_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z152ACW_OBJ)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z363ACW_PRM)));
         isValidOutput.Add((Object)(Z153ACW_OBS));
         isValidOutput.Add((Object)(context.localUtil.TToC( Z154ACW_MOM, 10, 8, 0, 3, "/", ":", " ")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z259SIS_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z127PRG_DES)));
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
         pr_default.close(16);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(14);
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A363ACW_PRM = "" ;
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
         lblTextblocksis_cod_Jsonclick = "" ;
         lblTextblocksis_des_Jsonclick = "" ;
         A259SIS_DES = "" ;
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprg_des_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblockacw_obj_Jsonclick = "" ;
         A152ACW_OBJ = "" ;
         lblTextblockacw_prm_Jsonclick = "" ;
         lblTextblockacw_obs_Jsonclick = "" ;
         A153ACW_OBS = "" ;
         lblTextblockacw_mom_Jsonclick = "" ;
         A154ACW_MOM = (DateTime)(DateTime.MinValue) ;
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
         Z152ACW_OBJ = "" ;
         Z363ACW_PRM = "" ;
         Z154ACW_MOM = (DateTime)(DateTime.MinValue) ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z153ACW_OBS = "" ;
         Z259SIS_DES = "" ;
         Z127PRG_DES = "" ;
         T000V6_A152ACW_OBJ = new String[] {""} ;
         T000V6_A259SIS_DES = new String[] {""} ;
         T000V6_A127PRG_DES = new String[] {""} ;
         T000V6_A363ACW_PRM = new String[] {""} ;
         T000V6_A153ACW_OBS = new String[] {""} ;
         T000V6_A154ACW_MOM = new DateTime[] {DateTime.MinValue} ;
         T000V6_A116SIS_COD = new short[1] ;
         T000V6_A126PRG_COD = new short[1] ;
         T000V4_A259SIS_DES = new String[] {""} ;
         T000V5_A127PRG_DES = new String[] {""} ;
         T000V7_A259SIS_DES = new String[] {""} ;
         T000V8_A127PRG_DES = new String[] {""} ;
         T000V9_A116SIS_COD = new short[1] ;
         T000V9_A126PRG_COD = new short[1] ;
         T000V9_A152ACW_OBJ = new String[] {""} ;
         T000V3_A152ACW_OBJ = new String[] {""} ;
         T000V3_A363ACW_PRM = new String[] {""} ;
         T000V3_A153ACW_OBS = new String[] {""} ;
         T000V3_A154ACW_MOM = new DateTime[] {DateTime.MinValue} ;
         T000V3_A116SIS_COD = new short[1] ;
         T000V3_A126PRG_COD = new short[1] ;
         sMode30 = "" ;
         T000V10_A116SIS_COD = new short[1] ;
         T000V10_A126PRG_COD = new short[1] ;
         T000V10_A152ACW_OBJ = new String[] {""} ;
         T000V11_A116SIS_COD = new short[1] ;
         T000V11_A126PRG_COD = new short[1] ;
         T000V11_A152ACW_OBJ = new String[] {""} ;
         T000V12_A152ACW_OBJ = new String[] {""} ;
         T000V12_A363ACW_PRM = new String[] {""} ;
         T000V12_A153ACW_OBS = new String[] {""} ;
         T000V12_A154ACW_MOM = new DateTime[] {DateTime.MinValue} ;
         T000V12_A116SIS_COD = new short[1] ;
         T000V12_A126PRG_COD = new short[1] ;
         T000V16_A259SIS_DES = new String[] {""} ;
         T000V17_A127PRG_DES = new String[] {""} ;
         T000V18_A116SIS_COD = new short[1] ;
         T000V18_A126PRG_COD = new short[1] ;
         T000V18_A152ACW_OBJ = new String[] {""} ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg009__default(),
            new Object[][] {
                new Object[] {
               T000V2_A152ACW_OBJ, T000V2_A363ACW_PRM, T000V2_A153ACW_OBS, T000V2_A154ACW_MOM, T000V2_A116SIS_COD, T000V2_A126PRG_COD
               }
               , new Object[] {
               T000V3_A152ACW_OBJ, T000V3_A363ACW_PRM, T000V3_A153ACW_OBS, T000V3_A154ACW_MOM, T000V3_A116SIS_COD, T000V3_A126PRG_COD
               }
               , new Object[] {
               T000V4_A259SIS_DES
               }
               , new Object[] {
               T000V5_A127PRG_DES
               }
               , new Object[] {
               T000V6_A152ACW_OBJ, T000V6_A259SIS_DES, T000V6_A127PRG_DES, T000V6_A363ACW_PRM, T000V6_A153ACW_OBS, T000V6_A154ACW_MOM, T000V6_A116SIS_COD, T000V6_A126PRG_COD
               }
               , new Object[] {
               T000V7_A259SIS_DES
               }
               , new Object[] {
               T000V8_A127PRG_DES
               }
               , new Object[] {
               T000V9_A116SIS_COD, T000V9_A126PRG_COD, T000V9_A152ACW_OBJ
               }
               , new Object[] {
               T000V10_A116SIS_COD, T000V10_A126PRG_COD, T000V10_A152ACW_OBJ
               }
               , new Object[] {
               T000V11_A116SIS_COD, T000V11_A126PRG_COD, T000V11_A152ACW_OBJ
               }
               , new Object[] {
               T000V12_A152ACW_OBJ, T000V12_A363ACW_PRM, T000V12_A153ACW_OBS, T000V12_A154ACW_MOM, T000V12_A116SIS_COD, T000V12_A126PRG_COD
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000V16_A259SIS_DES
               }
               , new Object[] {
               T000V17_A127PRG_DES
               }
               , new Object[] {
               T000V18_A116SIS_COD, T000V18_A126PRG_COD, T000V18_A152ACW_OBJ
               }
            }
         );
      }

      private short RcdFound30 ;
      private short GxWebError ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z116SIS_COD ;
      private short Z126PRG_COD ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtSIS_COD_Enabled ;
      private int imgprompt_116_Visible ;
      private int edtSIS_DES_Enabled ;
      private int edtPRG_COD_Enabled ;
      private int imgprompt_126_Visible ;
      private int edtPRG_DES_Enabled ;
      private int edtACW_OBJ_Enabled ;
      private int edtACW_OBS_Enabled ;
      private int edtACW_MOM_Enabled ;
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
      private String A363ACW_PRM ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSIS_COD_Internalname ;
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
      private String lblTextblocksis_cod_Internalname ;
      private String lblTextblocksis_cod_Jsonclick ;
      private String edtSIS_COD_Jsonclick ;
      private String imgprompt_116_Internalname ;
      private String imgprompt_116_Link ;
      private String lblTextblocksis_des_Internalname ;
      private String lblTextblocksis_des_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_COD_Jsonclick ;
      private String imgprompt_126_Internalname ;
      private String imgprompt_126_Link ;
      private String lblTextblockprg_des_Internalname ;
      private String lblTextblockprg_des_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblockacw_obj_Internalname ;
      private String lblTextblockacw_obj_Jsonclick ;
      private String edtACW_OBJ_Internalname ;
      private String lblTextblockacw_prm_Internalname ;
      private String lblTextblockacw_prm_Jsonclick ;
      private String cmbACW_PRM_Internalname ;
      private String cmbACW_PRM_Jsonclick ;
      private String lblTextblockacw_obs_Internalname ;
      private String lblTextblockacw_obs_Jsonclick ;
      private String edtACW_OBS_Internalname ;
      private String lblTextblockacw_mom_Internalname ;
      private String lblTextblockacw_mom_Jsonclick ;
      private String edtACW_MOM_Internalname ;
      private String edtACW_MOM_Jsonclick ;
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
      private String Z363ACW_PRM ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z259SIS_DES ;
      private String Z127PRG_DES ;
      private String sMode30 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A154ACW_MOM ;
      private DateTime Z154ACW_MOM ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private String A153ACW_OBS ;
      private String Z153ACW_OBS ;
      private String A152ACW_OBJ ;
      private String Z152ACW_OBJ ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbACW_PRM ;
      private IDataStoreProvider pr_default ;
      private String[] T000V6_A152ACW_OBJ ;
      private String[] T000V6_A259SIS_DES ;
      private String[] T000V6_A127PRG_DES ;
      private String[] T000V6_A363ACW_PRM ;
      private String[] T000V6_A153ACW_OBS ;
      private DateTime[] T000V6_A154ACW_MOM ;
      private short[] T000V6_A116SIS_COD ;
      private short[] T000V6_A126PRG_COD ;
      private String[] T000V4_A259SIS_DES ;
      private String[] T000V5_A127PRG_DES ;
      private String[] T000V7_A259SIS_DES ;
      private String[] T000V8_A127PRG_DES ;
      private short[] T000V9_A116SIS_COD ;
      private short[] T000V9_A126PRG_COD ;
      private String[] T000V9_A152ACW_OBJ ;
      private String[] T000V3_A152ACW_OBJ ;
      private String[] T000V3_A363ACW_PRM ;
      private String[] T000V3_A153ACW_OBS ;
      private DateTime[] T000V3_A154ACW_MOM ;
      private short[] T000V3_A116SIS_COD ;
      private short[] T000V3_A126PRG_COD ;
      private short[] T000V10_A116SIS_COD ;
      private short[] T000V10_A126PRG_COD ;
      private String[] T000V10_A152ACW_OBJ ;
      private short[] T000V11_A116SIS_COD ;
      private short[] T000V11_A126PRG_COD ;
      private String[] T000V11_A152ACW_OBJ ;
      private String[] T000V12_A152ACW_OBJ ;
      private String[] T000V12_A363ACW_PRM ;
      private String[] T000V12_A153ACW_OBS ;
      private DateTime[] T000V12_A154ACW_MOM ;
      private short[] T000V12_A116SIS_COD ;
      private short[] T000V12_A126PRG_COD ;
      private String[] T000V16_A259SIS_DES ;
      private String[] T000V17_A127PRG_DES ;
      private short[] T000V18_A116SIS_COD ;
      private short[] T000V18_A126PRG_COD ;
      private String[] T000V18_A152ACW_OBJ ;
      private String[] T000V2_A152ACW_OBJ ;
      private String[] T000V2_A363ACW_PRM ;
      private String[] T000V2_A153ACW_OBS ;
      private DateTime[] T000V2_A154ACW_MOM ;
      private short[] T000V2_A116SIS_COD ;
      private short[] T000V2_A126PRG_COD ;
      private GXWebForm Form ;
   }

   public class seg009__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000V2 ;
          prmT000V2 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V6 ;
          prmT000V6 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V4 ;
          prmT000V4 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000V5 ;
          prmT000V5 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V7 ;
          prmT000V7 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000V8 ;
          prmT000V8 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V9 ;
          prmT000V9 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V3 ;
          prmT000V3 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V10 ;
          prmT000V10 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V11 ;
          prmT000V11 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V12 ;
          prmT000V12 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V13 ;
          prmT000V13 = new Object[] {
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0} ,
          new Object[] {"@ACW_PRM",SqlDbType.Char,1,0} ,
          new Object[] {"@ACW_OBS",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@ACW_MOM",SqlDbType.DateTime,8,5} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000V14 ;
          prmT000V14 = new Object[] {
          new Object[] {"@ACW_PRM",SqlDbType.Char,1,0} ,
          new Object[] {"@ACW_OBS",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@ACW_MOM",SqlDbType.DateTime,8,5} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V15 ;
          prmT000V15 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0}
          } ;
          Object[] prmT000V18 ;
          prmT000V18 = new Object[] {
          } ;
          Object[] prmT000V16 ;
          prmT000V16 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT000V17 ;
          prmT000V17 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000V2", "SELECT [ACW_OBJ], [ACW_PRM], [ACW_OBS], [ACW_MOM], [SIS_COD], [PRG_COD] FROM [SEG009] WITH (UPDLOCK) WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V2,1,1,true,false )
             ,new CursorDef("T000V3", "SELECT [ACW_OBJ], [ACW_PRM], [ACW_OBS], [ACW_MOM], [SIS_COD], [PRG_COD] FROM [SEG009] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V3,1,1,true,false )
             ,new CursorDef("T000V4", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V4,1,1,true,false )
             ,new CursorDef("T000V5", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V5,1,1,true,false )
             ,new CursorDef("T000V6", "SELECT TM1.[ACW_OBJ], T2.[SIS_DES], T3.[PRG_DES], TM1.[ACW_PRM], TM1.[ACW_OBS], TM1.[ACW_MOM], TM1.[SIS_COD], TM1.[PRG_COD] FROM (([SEG009] TM1 WITH (NOLOCK) INNER JOIN [SEG000] T2 WITH (NOLOCK) ON T2.[SIS_COD] = TM1.[SIS_COD]) INNER JOIN [SEG001] T3 WITH (NOLOCK) ON T3.[PRG_COD] = TM1.[PRG_COD]) WHERE TM1.[SIS_COD] = @SIS_COD and TM1.[PRG_COD] = @PRG_COD and TM1.[ACW_OBJ] = @ACW_OBJ ORDER BY TM1.[SIS_COD], TM1.[PRG_COD], TM1.[ACW_OBJ]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V6,100,1,true,false )
             ,new CursorDef("T000V7", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V7,1,1,true,false )
             ,new CursorDef("T000V8", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V8,1,1,true,false )
             ,new CursorDef("T000V9", "SELECT [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V9,1,1,true,false )
             ,new CursorDef("T000V10", "SELECT TOP 1 [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) WHERE ( [SIS_COD] > @SIS_COD or [SIS_COD] = @SIS_COD and [PRG_COD] > @PRG_COD or [PRG_COD] = @PRG_COD and [SIS_COD] = @SIS_COD and [ACW_OBJ] > @ACW_OBJ) ORDER BY [SIS_COD], [PRG_COD], [ACW_OBJ]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V10,1,1,true,true )
             ,new CursorDef("T000V11", "SELECT TOP 1 [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) WHERE ( [SIS_COD] < @SIS_COD or [SIS_COD] = @SIS_COD and [PRG_COD] < @PRG_COD or [PRG_COD] = @PRG_COD and [SIS_COD] = @SIS_COD and [ACW_OBJ] < @ACW_OBJ) ORDER BY [SIS_COD] DESC, [PRG_COD] DESC, [ACW_OBJ] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V11,1,1,true,true )
             ,new CursorDef("T000V12", "SELECT [ACW_OBJ], [ACW_PRM], [ACW_OBS], [ACW_MOM], [SIS_COD], [PRG_COD] FROM [SEG009] WITH (UPDLOCK) WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V12,1,1,true,false )
             ,new CursorDef("T000V13", "INSERT INTO [SEG009] ([ACW_OBJ], [ACW_PRM], [ACW_OBS], [ACW_MOM], [SIS_COD], [PRG_COD]) VALUES (@ACW_OBJ, @ACW_PRM, @ACW_OBS, @ACW_MOM, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmT000V13)
             ,new CursorDef("T000V14", "UPDATE [SEG009] SET [ACW_PRM]=@ACW_PRM, [ACW_OBS]=@ACW_OBS, [ACW_MOM]=@ACW_MOM  WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ", GxErrorMask.GX_NOMASK,prmT000V14)
             ,new CursorDef("T000V15", "DELETE FROM [SEG009]  WHERE [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [ACW_OBJ] = @ACW_OBJ", GxErrorMask.GX_NOMASK,prmT000V15)
             ,new CursorDef("T000V16", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V16,1,1,true,false )
             ,new CursorDef("T000V17", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000V17,1,1,true,false )
             ,new CursorDef("T000V18", "SELECT [SIS_COD], [PRG_COD], [ACW_OBJ] FROM [SEG009] WITH (NOLOCK) ORDER BY [SIS_COD], [PRG_COD], [ACW_OBJ]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000V18,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 15) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 30) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 1) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(5) ;
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 1) ;
                ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
