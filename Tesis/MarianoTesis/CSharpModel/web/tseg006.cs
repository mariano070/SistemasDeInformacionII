/*
               File: TSEG006
        Description: SESIONES POR USUARIO
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:48.98
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
   public class tseg006 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_18") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_18( A6USU_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_19( A116SIS_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_20") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_20( A126PRG_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_21") == 0 )
         {
            A6USU_COD = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_21( A6USU_COD, A116SIS_COD, A126PRG_COD) ;
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
         if ( ! entryPointCalled )
         {
            Gx_mode = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV10USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USU_COD", AV10USU_COD);
               AV11SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11SIS_COD), 3, 0)));
               AV12PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12PRG_COD), 4, 0)));
               AV13PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PRS_NRO), 8, 0)));
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "SESIONES POR USUARIO", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUSU_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tseg006( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tseg006( IGxContext context )
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

      public void execute( String aP0_Gx_mode ,
                           String aP1_USU_COD ,
                           short aP2_SIS_COD ,
                           short aP3_PRG_COD ,
                           int aP4_PRS_NRO )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV10USU_COD = aP1_USU_COD;
         this.AV11SIS_COD = aP2_SIS_COD;
         this.AV12PRG_COD = aP3_PRG_COD;
         this.AV13PRS_NRO = aP4_PRS_NRO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("hmaster_seg_p", "GeneXus.Programs.hmaster_seg_p", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_1034( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1034e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1034( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 5,'',false,'',0)\"" ;
            ClassString = "BtnFirst" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_first_Internalname, "|<", "|<", "", StyleString, ClassString, bttBtn_first_Visible, 0, "rounded", 5, bttBtn_first_Jsonclick, "EFIRST.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 6,'',false,'',0)\"" ;
            ClassString = "BtnPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_previous_Internalname, "<", "<", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "rounded", 5, bttBtn_previous_Jsonclick, "EPREVIOUS.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 7,'',false,'',0)\"" ;
            ClassString = "BtnNext" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_next_Internalname, ">", ">", "", StyleString, ClassString, bttBtn_next_Visible, 0, "rounded", 5, bttBtn_next_Jsonclick, "ENEXT.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "BtnLast" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_last_Internalname, ">|", ">|", "", StyleString, ClassString, bttBtn_last_Visible, 0, "rounded", 5, bttBtn_last_Jsonclick, "ELAST.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "BtnSelect" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_select_Internalname, "Seleccionar", "Seleccionar", "", StyleString, ClassString, bttBtn_select_Visible, 0, "rounded", 4, bttBtn_select_Jsonclick, "ESELECT.", TempTags, "", "gx.popup.openPrompt('"+"gx00y0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USU_COD"+"'), id:'"+"USU_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"PRS_NRO"+"'), id:'"+"PRS_NRO"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_15_1034( true) ;
         }
         return  ;
      }

      protected void wb_table2_15_1034e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"" ;
            ClassString = "BtnCheck" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_check_Internalname, "Verificar", "Verificar", "", StyleString, ClassString, bttBtn_check_Visible, bttBtn_check_Enabled, "rounded", 5, bttBtn_check_Jsonclick, "ECHECK.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "BtnHelp" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_help_Internalname, "Ayuda", "Ayuda", "", StyleString, ClassString, bttBtn_help_Visible, 1, "rounded", 3, bttBtn_help_Jsonclick, "EHELP.", TempTags, "", "", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1034e( true) ;
         }
         else
         {
            wb_table1_2_1034e( false) ;
         }
      }

      protected void wb_table2_15_1034( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, edtUSU_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(20);\"", 0, edtUSU_COD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_6_Internalname, "", "prompt.gif", "Modern", imgprompt_6_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_6_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, edtUSU_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "CONTRASEÑA", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CLA_Internalname, StringUtil.RTrim( A155USU_CLA), "", 20, "chr", 1, "row", 20, 1, edtUSU_CLA_Enabled, 0, -1, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A155USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), "", 0, edtUSU_CLA_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A116SIS_COD), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtSIS_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A116SIS_COD), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(35);\"", 0, edtSIS_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG006.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_116_Internalname, "", "prompt.gif", "Modern", imgprompt_116_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_116_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSIS_DES_Internalname, StringUtil.RTrim( A259SIS_DES), "", 15, "chr", 1, "row", 15, 1, edtSIS_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A259SIS_DES, "@!")), "", 0, edtSIS_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(45);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG006.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_126_Internalname, "", "prompt.gif", "Modern", imgprompt_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_126_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "NOMBRE FISICO", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_NFI_Internalname, StringUtil.RTrim( A289PRG_NFI), "", 8, "chr", 1, "row", 8, 1, edtPRG_NFI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A289PRG_NFI, "@!")), "", 0, edtPRG_NFI_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "CONEXION DE USUARIO", "", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_CNT_Internalname, StringUtil.RTrim( A290USU_CNT), "", 1, "chr", 1, "row", 1, 1, edtUSU_CNT_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A290USU_CNT, "X")), "", 0, edtUSU_CNT_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "NRO DE SESION ASIGNADA", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_NRO_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A118PRS_NRO), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtPRS_NRO_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A118PRS_NRO), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(65);\"", 0, edtPRS_NRO_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG006.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnGet" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_get_Internalname, "=>", "=>", "", StyleString, ClassString, bttBtn_get_Visible, bttBtn_get_Enabled, "rounded", 6, bttBtn_get_Jsonclick, "EGET.", TempTags, "", "", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, 1, 1, 0, "MOMENTO DE INICIO SESION", "", "", "", 0, lblTextblock11_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_INI_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_INI_Internalname, context.localUtil.Format(A166PRS_INI, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRS_INI_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A166PRS_INI, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(71);\"", 0, edtPRS_INI_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG006.htm");
            GxWebStd.gx_bitmap( context, edtPRS_INI_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRS_INI_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG006.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, 1, 1, 0, "ULTIMO OBJETO", "", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UOB_Internalname, StringUtil.RTrim( A404PRS_UOB), "", 20, "chr", 1, "row", 20, 1, edtPRS_UOB_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A404PRS_UOB, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(76);\"", 0, edtPRS_UOB_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, 1, 1, 0, "MOMENTO CADUCIDAD SESION", "", "", "", 0, lblTextblock13_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtPRS_CAD_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtPRS_CAD_Internalname, context.localUtil.Format(A165PRS_CAD, "99/99/99 99:99"), "", 14, "chr", 1, "row", 14, 1, edtPRS_CAD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A165PRS_CAD, "99/99/99 99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',5,24,'spa',false,0);"+";gx.evt.onblur(81);\"", 0, edtPRS_CAD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TSEG006.htm");
            GxWebStd.gx_bitmap( context, edtPRS_CAD_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtPRS_CAD_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TSEG006.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, 1, 1, 0, "DESCRIPCION ULTIMO OBJETO", "", "", "", 0, lblTextblock14_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRS_UDE_Internalname, StringUtil.RTrim( A405PRS_UDE), "", 30, "chr", 1, "row", 30, 1, edtPRS_UDE_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A405PRS_UDE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(86);\"", 0, edtPRS_UDE_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, 1, 1, 0, "ULTIMO LINK", "", "", "", 0, lblTextblock15_Jsonclick, "", StyleString, ClassString, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtPRS_ULNK_Internalname, A406PRS_ULNK, 1, edtPRS_ULNK_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "300", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(91);\"", -1, 0, "", "", true, "HLP_TSEG006.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_15_1034e( true) ;
         }
         else
         {
            wb_table2_15_1034e( false) ;
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
         /* Execute user event: E11102 */
         E11102 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A155USU_CLA = cgiGet( edtUSU_CLA_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
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
               A289PRG_NFI = StringUtil.Upper( cgiGet( edtPRG_NFI_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
               A290USU_CNT = cgiGet( edtUSU_CNT_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
               if ( ! context.localUtil.VCNumber( cgiGet( edtPRS_NRO_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRS_NRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRS_NRO_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A118PRS_NRO = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               }
               else
               {
                  A118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( edtPRS_NRO_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               }
               if ( context.localUtil.VCDateTime( cgiGet( edtPRS_INI_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO DE INICIO SESION"}), 1, "PRS_INI");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRS_INI_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A166PRS_INI = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A166PRS_INI = context.localUtil.CToT( cgiGet( edtPRS_INI_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
               }
               A404PRS_UOB = cgiGet( edtPRS_UOB_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
               if ( context.localUtil.VCDateTime( cgiGet( edtPRS_CAD_Internalname), 4, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"MOMENTO CADUCIDAD SESION"}), 1, "PRS_CAD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRS_CAD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               }
               else
               {
                  A165PRS_CAD = context.localUtil.CToT( cgiGet( edtPRS_CAD_Internalname)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
               }
               A405PRS_UDE = cgiGet( edtPRS_UDE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
               A406PRS_ULNK = cgiGet( edtPRS_ULNK_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
               /* Read saved values. */
               Z6USU_COD = cgiGet( "Z6USU_COD") ;
               Z116SIS_COD = (short)(context.localUtil.CToN( cgiGet( "Z116SIS_COD"), ",", ".")) ;
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z118PRS_NRO = (int)(context.localUtil.CToN( cgiGet( "Z118PRS_NRO"), ",", ".")) ;
               Z166PRS_INI = context.localUtil.CToT( cgiGet( "Z166PRS_INI")) ;
               Z404PRS_UOB = cgiGet( "Z404PRS_UOB") ;
               Z165PRS_CAD = context.localUtil.CToT( cgiGet( "Z165PRS_CAD")) ;
               Z405PRS_UDE = cgiGet( "Z405PRS_UDE") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV10USU_COD = cgiGet( "vUSU_COD") ;
               AV11SIS_COD = (short)(context.localUtil.CToN( cgiGet( "vSIS_COD"), ",", ".")) ;
               AV12PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
               AV13PRS_NRO = (int)(context.localUtil.CToN( cgiGet( "vPRS_NRO"), ",", ".")) ;
               AV18Pgmname = cgiGet( "vPGMNAME") ;
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
                  A6USU_COD = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                  A116SIS_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A118PRS_NRO = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode34 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode34 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound34 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_100( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "USU_COD");
                        AnyError = 1 ;
                     }
                  }
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11102 */
                           E11102 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12102 */
                           E12102 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "CHECK") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_Check( ) ;
                           /* No code required for Help button. It is implemented at the Browser level. */
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
            /* Execute user event: E12102 */
            E12102 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1034( ) ;
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
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         bttBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)));
         bttBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)));
         bttBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)));
         bttBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)));
         bttBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
            edtUSU_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_DES_Enabled), 5, 0)));
            edtUSU_CLA_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CLA_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CLA_Enabled), 5, 0)));
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
            edtSIS_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_DES_Enabled), 5, 0)));
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            edtPRG_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
            edtPRG_NFI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_NFI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_NFI_Enabled), 5, 0)));
            edtUSU_CNT_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_CNT_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_CNT_Enabled), 5, 0)));
            edtPRS_NRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Enabled), 5, 0)));
            edtPRS_INI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_INI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_INI_Enabled), 5, 0)));
            edtPRS_UOB_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_UOB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_UOB_Enabled), 5, 0)));
            edtPRS_CAD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_CAD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_CAD_Enabled), 5, 0)));
            edtPRS_UDE_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_UDE_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_UDE_Enabled), 5, 0)));
            edtPRS_ULNK_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_ULNK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_ULNK_Enabled), 5, 0)));
         }
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

      protected void CONFIRM_100( )
      {
         BeforeValidate1034( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1034( ) ;
            }
            else
            {
               CheckExtendedTable1034( ) ;
               if ( AnyError == 0 )
               {
                  ZM1034( 18) ;
                  ZM1034( 19) ;
                  ZM1034( 20) ;
                  ZM1034( 21) ;
               }
               CloseExtendedTableCursors1034( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
         if ( AnyError == 0 )
         {
            ConfirmValues100( ) ;
         }
      }

      protected void ResetCaption100( )
      {
      }

      protected void E11102( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV18Pgmname, out  AV15IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15IsAuthorized", StringUtil.BoolToStr( AV15IsAuthorized));
         if ( ! AV15IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV18Pgmname)) ;
         }
         AV16TrnContext.FromXml(AV17WebSession.Get("TrnContext"), "");
      }

      protected void E12102( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV16TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwtseg006.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1034( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z166PRS_INI = T00103_A166PRS_INI[0] ;
               Z404PRS_UOB = T00103_A404PRS_UOB[0] ;
               Z165PRS_CAD = T00103_A165PRS_CAD[0] ;
               Z405PRS_UDE = T00103_A405PRS_UDE[0] ;
            }
            else
            {
               Z166PRS_INI = A166PRS_INI ;
               Z404PRS_UOB = A404PRS_UOB ;
               Z165PRS_CAD = A165PRS_CAD ;
               Z405PRS_UDE = A405PRS_UDE ;
            }
         }
         if ( GX_JID == -17 )
         {
            Z118PRS_NRO = A118PRS_NRO ;
            Z166PRS_INI = A166PRS_INI ;
            Z404PRS_UOB = A404PRS_UOB ;
            Z165PRS_CAD = A165PRS_CAD ;
            Z405PRS_UDE = A405PRS_UDE ;
            Z406PRS_ULNK = A406PRS_ULNK ;
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z7USU_DES = A7USU_DES ;
            Z155USU_CLA = A155USU_CLA ;
            Z259SIS_DES = A259SIS_DES ;
            Z127PRG_DES = A127PRG_DES ;
            Z289PRG_NFI = A289PRG_NFI ;
            Z290USU_CNT = A290USU_CNT ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00f0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"USU_COD"+"'), id:'"+"USU_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_116_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00w0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"SIS_COD"+"'), id:'"+"SIS_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            A6USU_COD = AV10USU_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         else
         {
            edtUSU_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10USU_COD)) )
         {
            edtUSU_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUSU_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUSU_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
         {
            A116SIS_COD = AV11SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         else
         {
            edtSIS_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV11SIS_COD) )
         {
            edtSIS_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSIS_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSIS_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV12PRG_COD) )
         {
            A126PRG_COD = AV12PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         if ( ! (0==AV12PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV13PRS_NRO) )
         {
            A118PRS_NRO = AV13PRS_NRO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         }
         if ( ! (0==AV13PRS_NRO) )
         {
            edtPRS_NRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Enabled), 5, 0)));
         }
         else
         {
            edtPRS_NRO_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Enabled), 5, 0)));
         }
         if ( ! (0==AV13PRS_NRO) )
         {
            edtPRS_NRO_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRS_NRO_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRS_NRO_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV12PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         else
         {
            if ( true )
            {
               edtPRG_COD_Enabled = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            }
            else
            {
               if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  )
               {
                  edtPRG_COD_Enabled = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
               }
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )  || ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )  )
         {
            bttBtn_get_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_get_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_get_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_get_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_enter_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_check_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         else
         {
            bttBtn_check_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_check_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_check_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00104 */
            pr_default.execute(2, new Object[] {A6USU_COD});
            A7USU_DES = T00104_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00104_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            pr_default.close(2);
            AV18Pgmname = "TSEG006" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T00105 */
            pr_default.execute(3, new Object[] {A116SIS_COD});
            A259SIS_DES = T00105_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            pr_default.close(3);
            /* Using cursor T00106 */
            pr_default.execute(4, new Object[] {A126PRG_COD});
            A127PRG_DES = T00106_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00106_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            pr_default.close(4);
            /* Using cursor T00107 */
            pr_default.execute(5, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            A290USU_CNT = T00107_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            pr_default.close(5);
         }
      }

      protected void Load1034( )
      {
         /* Using cursor T00108 */
         pr_default.execute(6, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound34 = 1 ;
            A7USU_DES = T00108_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00108_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            A259SIS_DES = T00108_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            A127PRG_DES = T00108_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00108_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            A290USU_CNT = T00108_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            A166PRS_INI = T00108_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T00108_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A165PRS_CAD = T00108_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            A405PRS_UDE = T00108_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T00108_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            ZM1034( -17) ;
         }
         pr_default.close(6);
         OnLoadActions1034( ) ;
      }

      protected void OnLoadActions1034( )
      {
         AV18Pgmname = "TSEG006" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
      }

      protected void CheckExtendedTable1034( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV18Pgmname = "TSEG006" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
         /* Using cursor T00104 */
         pr_default.execute(2, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T00104_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00104_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         pr_default.close(2);
         /* Using cursor T00105 */
         pr_default.execute(3, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T00105_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         pr_default.close(3);
         /* Using cursor T00106 */
         pr_default.execute(4, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T00106_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T00106_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         }
         pr_default.close(4);
         /* Using cursor T00107 */
         pr_default.execute(5, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T00107_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         }
         pr_default.close(5);
         if ( (0==A126PRG_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A166PRS_INI) || ( A166PRS_INI >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo MOMENTO DE INICIO SESION fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A165PRS_CAD) || ( A165PRS_CAD >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo MOMENTO CADUCIDAD SESION fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1034( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
         pr_default.close(5);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_18( String A6USU_COD )
      {
         /* Using cursor T00109 */
         pr_default.execute(7, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T00109_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T00109_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A7USU_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A155USU_CLA))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(7) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(7);
      }

      protected void gxLoad_19( short A116SIS_COD )
      {
         /* Using cursor T001010 */
         pr_default.execute(8, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T001010_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A259SIS_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(8) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(8);
      }

      protected void gxLoad_20( short A126PRG_COD )
      {
         /* Using cursor T001011 */
         pr_default.execute(9, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T001011_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T001011_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127PRG_DES))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A289PRG_NFI))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(9) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(9);
      }

      protected void gxLoad_21( String A6USU_COD ,
                                short A116SIS_COD ,
                                short A126PRG_COD )
      {
         /* Using cursor T001012 */
         pr_default.execute(10, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T001012_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A290USU_CNT))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(10) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(10);
      }

      protected void GetKey1034( )
      {
         /* Using cursor T001013 */
         pr_default.execute(11, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound34 = 1 ;
         }
         else
         {
            RcdFound34 = 0 ;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00103 */
         pr_default.execute(1, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1034( 17) ;
            RcdFound34 = 1 ;
            A118PRS_NRO = T00103_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            A166PRS_INI = T00103_A166PRS_INI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
            A404PRS_UOB = T00103_A404PRS_UOB[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
            A165PRS_CAD = T00103_A165PRS_CAD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
            A405PRS_UDE = T00103_A405PRS_UDE[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
            A406PRS_ULNK = T00103_A406PRS_ULNK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
            A6USU_COD = T00103_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T00103_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T00103_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            Z6USU_COD = A6USU_COD ;
            Z116SIS_COD = A116SIS_COD ;
            Z126PRG_COD = A126PRG_COD ;
            Z118PRS_NRO = A118PRS_NRO ;
            sMode34 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1034( ) ;
            Gx_mode = sMode34 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound34 = 0 ;
            InitializeNonKey1034( ) ;
            sMode34 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode34 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1034( ) ;
         if ( RcdFound34 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound34 = 0 ;
         /* Using cursor T001014 */
         pr_default.execute(12, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(12) != 101) )
         {
            while ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) < 0 ) || ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A116SIS_COD[0] < A116SIS_COD ) || ( T001014_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A126PRG_COD[0] < A126PRG_COD ) || ( T001014_A126PRG_COD[0] == A126PRG_COD ) && ( T001014_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A118PRS_NRO[0] < A118PRS_NRO ) ) )
            {
               pr_default.readNext(12);
            }
            if ( (pr_default.getStatus(12) != 101) && ( ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) > 0 ) || ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A116SIS_COD[0] > A116SIS_COD ) || ( T001014_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A126PRG_COD[0] > A126PRG_COD ) || ( T001014_A126PRG_COD[0] == A126PRG_COD ) && ( T001014_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001014_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001014_A118PRS_NRO[0] > A118PRS_NRO ) ) )
            {
               A6USU_COD = T001014_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = T001014_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = T001014_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = T001014_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               RcdFound34 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound34 = 0 ;
         /* Using cursor T001015 */
         pr_default.execute(13, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
         if ( (pr_default.getStatus(13) != 101) )
         {
            while ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) > 0 ) || ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A116SIS_COD[0] > A116SIS_COD ) || ( T001015_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A126PRG_COD[0] > A126PRG_COD ) || ( T001015_A126PRG_COD[0] == A126PRG_COD ) && ( T001015_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A118PRS_NRO[0] > A118PRS_NRO ) ) )
            {
               pr_default.readNext(13);
            }
            if ( (pr_default.getStatus(13) != 101) && ( ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) < 0 ) || ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A116SIS_COD[0] < A116SIS_COD ) || ( T001015_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A126PRG_COD[0] < A126PRG_COD ) || ( T001015_A126PRG_COD[0] == A126PRG_COD ) && ( T001015_A116SIS_COD[0] == A116SIS_COD ) && ( StringUtil.StrCmp(T001015_A6USU_COD[0], A6USU_COD) == 0 ) && ( T001015_A118PRS_NRO[0] < A118PRS_NRO ) ) )
            {
               A6USU_COD = T001015_A6USU_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = T001015_A116SIS_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = T001015_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = T001015_A118PRS_NRO[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               RcdFound34 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1034( ) ;
         if ( RcdFound34 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = Z118PRS_NRO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update1034( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) )
            {
               /* Insert record */
               Insert1034( ) ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert1034( ) ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1 ;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) )
         {
            A6USU_COD = Z6USU_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = Z116SIS_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = Z118PRS_NRO ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUSU_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void btn_Check( )
      {
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey1034( ) ;
         if ( RcdFound34 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) )
            {
               A6USU_COD = Z6USU_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A116SIS_COD = Z116SIS_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A118PRS_NRO = Z118PRS_NRO ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "DuplicatePrimaryKey", 1, "USU_COD");
               AnyError = 1 ;
               GX_FocusControl = edtUSU_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               update_Check( ) ;
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A6USU_COD, Z6USU_COD) != 0 ) || ( A116SIS_COD != Z116SIS_COD ) || ( A126PRG_COD != Z126PRG_COD ) || ( A118PRS_NRO != Z118PRS_NRO ) )
            {
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "USU_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtUSU_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(13);
         pr_default.close(12);
         context.RollbackDataStores("TSEG006");
         GX_FocusControl = edtPRS_INI_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
      }

      protected void insert_Check( )
      {
         CONFIRM_100( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency1034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001016 */
            pr_default.execute(14, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
            if ( (pr_default.getStatus(14) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG006"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(14) == 101) || ( Z166PRS_INI != T001016_A166PRS_INI[0] ) || ( StringUtil.StrCmp(Z404PRS_UOB, T001016_A404PRS_UOB[0]) != 0 ) || ( Z165PRS_CAD != T001016_A165PRS_CAD[0] ) || ( StringUtil.StrCmp(Z405PRS_UDE, T001016_A405PRS_UDE[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG006"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1034( )
      {
         BeforeValidate1034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1034( 0) ;
            CheckOptimisticConcurrency1034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001017 */
                     pr_default.execute(15, new Object[] {A118PRS_NRO, A166PRS_INI, A404PRS_UOB, A165PRS_CAD, A405PRS_UDE, A406PRS_ULNK, A6USU_COD, A116SIS_COD, A126PRG_COD});
                     pr_default.close(15);
                     if ( (pr_default.getStatus(15) == 1) )
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
                           ResetCaption100( ) ;
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
               Load1034( ) ;
            }
            EndLevel1034( ) ;
         }
         CloseExtendedTableCursors1034( ) ;
      }

      protected void Update1034( )
      {
         BeforeValidate1034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001018 */
                     pr_default.execute(16, new Object[] {A166PRS_INI, A404PRS_UOB, A165PRS_CAD, A405PRS_UDE, A406PRS_ULNK, A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
                     pr_default.close(16);
                     if ( (pr_default.getStatus(16) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG006"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1 ;
                              }
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
            }
            EndLevel1034( ) ;
         }
         CloseExtendedTableCursors1034( ) ;
      }

      protected void DeferredUpdate1034( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1034( ) ;
            AfterConfirm1034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1034( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001019 */
                  pr_default.execute(17, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
                  pr_default.close(17);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1 ;
                           }
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
         }
         sMode34 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1034( ) ;
         Gx_mode = sMode34 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1034( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV18Pgmname = "TSEG006" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18Pgmname", AV18Pgmname);
            /* Using cursor T001020 */
            pr_default.execute(18, new Object[] {A6USU_COD});
            A7USU_DES = T001020_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            A155USU_CLA = T001020_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            pr_default.close(18);
            /* Using cursor T001021 */
            pr_default.execute(19, new Object[] {A116SIS_COD});
            A259SIS_DES = T001021_A259SIS_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
            pr_default.close(19);
            /* Using cursor T001022 */
            pr_default.execute(20, new Object[] {A126PRG_COD});
            A127PRG_DES = T001022_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A289PRG_NFI = T001022_A289PRG_NFI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
            pr_default.close(20);
            /* Using cursor T001023 */
            pr_default.execute(21, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
            A290USU_CNT = T001023_A290USU_CNT[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
            pr_default.close(21);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T001024 */
            pr_default.execute(22, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"PROGRAMAS ACCEDIDOS POR SESION"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(22);
         }
      }

      protected void EndLevel1034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(14);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1034( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.CommitDataStores("TSEG006");
            if ( AnyError == 0 )
            {
               ConfirmValues100( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(13);
            pr_default.close(12);
            pr_default.close(18);
            pr_default.close(19);
            pr_default.close(20);
            pr_default.close(21);
            context.RollbackDataStores("TSEG006");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1034( )
      {
         /* Using cursor T001025 */
         pr_default.execute(23);
         RcdFound34 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound34 = 1 ;
            A6USU_COD = T001025_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T001025_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T001025_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = T001025_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1034( )
      {
         pr_default.readNext(23);
         RcdFound34 = 0 ;
         if ( (pr_default.getStatus(23) != 101) )
         {
            RcdFound34 = 1 ;
            A6USU_COD = T001025_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A116SIS_COD = T001025_A116SIS_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
            A126PRG_COD = T001025_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A118PRS_NRO = T001025_A118PRS_NRO[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         }
      }

      protected void ScanEnd1034( )
      {
      }

      protected void AfterConfirm1034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1034( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues100( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV10USU_COD)) + "," + UrlEncode("" +AV11SIS_COD) + "," + UrlEncode("" +AV12PRG_COD) + "," + UrlEncode("" +AV13PRS_NRO)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z6USU_COD", StringUtil.RTrim( Z6USU_COD));
         GxWebStd.gx_hidden_field( context, "Z116SIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z116SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z118PRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z118PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z166PRS_INI", context.localUtil.TToC( Z166PRS_INI, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z404PRS_UOB", StringUtil.RTrim( Z404PRS_UOB));
         GxWebStd.gx_hidden_field( context, "Z165PRS_CAD", context.localUtil.TToC( Z165PRS_CAD, 10, 8, 0, 3, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z405PRS_UDE", StringUtil.RTrim( Z405PRS_UDE));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vUSU_COD", StringUtil.RTrim( AV10USU_COD));
         GxWebStd.gx_hidden_field( context, "vSIS_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11SIS_COD), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPRS_NRO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13PRS_NRO), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV18Pgmname));
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
         return "TSEG006" ;
      }

      public override String GetPgmdesc( )
      {
         return "SESIONES POR USUARIO" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tseg006.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV10USU_COD)) + "," + UrlEncode("" +AV11SIS_COD) + "," + UrlEncode("" +AV12PRG_COD) + "," + UrlEncode("" +AV13PRS_NRO) ;
      }

      protected void InitializeNonKey1034( )
      {
         A7USU_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
         A155USU_CLA = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
         A259SIS_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259SIS_DES", A259SIS_DES);
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A289PRG_NFI = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289PRG_NFI", A289PRG_NFI);
         A290USU_CNT = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290USU_CNT", A290USU_CNT);
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166PRS_INI", context.localUtil.TToC( A166PRS_INI, 8, 5, 0, 3, "/", ":", " "));
         A404PRS_UOB = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404PRS_UOB", A404PRS_UOB);
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165PRS_CAD", context.localUtil.TToC( A165PRS_CAD, 8, 5, 0, 3, "/", ":", " "));
         A405PRS_UDE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405PRS_UDE", A405PRS_UDE);
         A406PRS_ULNK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406PRS_ULNK", A406PRS_ULNK);
      }

      protected void InitAll1034( )
      {
         A6USU_COD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
         A116SIS_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A116SIS_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A116SIS_COD), 3, 0)));
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A118PRS_NRO = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118PRS_NRO", StringUtil.LTrim( StringUtil.Str( (decimal)(A118PRS_NRO), 8, 0)));
         InitializeNonKey1034( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11195138");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tseg006.js", "?11195139");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         bttBtn_first_Internalname = "BTN_FIRST" ;
         bttBtn_previous_Internalname = "BTN_PREVIOUS" ;
         bttBtn_next_Internalname = "BTN_NEXT" ;
         bttBtn_last_Internalname = "BTN_LAST" ;
         bttBtn_select_Internalname = "BTN_SELECT" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtUSU_CLA_Internalname = "USU_CLA" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtSIS_COD_Internalname = "SIS_COD" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtSIS_DES_Internalname = "SIS_DES" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtPRG_NFI_Internalname = "PRG_NFI" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtUSU_CNT_Internalname = "USU_CNT" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtPRS_NRO_Internalname = "PRS_NRO" ;
         bttBtn_get_Internalname = "BTN_GET" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtPRS_INI_Internalname = "PRS_INI" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtPRS_UOB_Internalname = "PRS_UOB" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtPRS_CAD_Internalname = "PRS_CAD" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtPRS_UDE_Internalname = "PRS_UDE" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtPRS_ULNK_Internalname = "PRS_ULNK" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_check_Internalname = "BTN_CHECK" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_help_Internalname = "BTN_HELP" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_6_Internalname = "PROMPT_6" ;
         imgprompt_116_Internalname = "PROMPT_116" ;
         imgprompt_126_Internalname = "PROMPT_126" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "SESIONES POR USUARIO" ;
         edtPRS_ULNK_Enabled = 1 ;
         edtPRS_UDE_Jsonclick = "" ;
         edtPRS_UDE_Enabled = 1 ;
         edtPRS_CAD_Jsonclick = "" ;
         edtPRS_CAD_Enabled = 1 ;
         edtPRS_UOB_Jsonclick = "" ;
         edtPRS_UOB_Enabled = 1 ;
         edtPRS_INI_Jsonclick = "" ;
         edtPRS_INI_Enabled = 1 ;
         bttBtn_get_Enabled = 0 ;
         bttBtn_get_Visible = 1 ;
         edtPRS_NRO_Jsonclick = "" ;
         edtPRS_NRO_Enabled = 1 ;
         edtUSU_CNT_Jsonclick = "" ;
         edtUSU_CNT_Enabled = 0 ;
         edtPRG_NFI_Jsonclick = "" ;
         edtPRG_NFI_Enabled = 0 ;
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
         edtUSU_CLA_Jsonclick = "" ;
         edtUSU_CLA_Enabled = 0 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_DES_Enabled = 0 ;
         imgprompt_6_Visible = 1 ;
         imgprompt_6_Link = "" ;
         edtUSU_COD_Jsonclick = "" ;
         edtUSU_COD_Enabled = 1 ;
         bttBtn_help_Visible = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_check_Enabled = 1 ;
         bttBtn_check_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_select_Visible = 1 ;
         bttBtn_last_Visible = 1 ;
         bttBtn_next_Visible = 1 ;
         bttBtn_previous_Visible = 1 ;
         bttBtn_first_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Usu_cod( String GX_Parm1 ,
                                 String GX_Parm2 ,
                                 String GX_Parm3 )
      {
         A6USU_COD = GX_Parm1 ;
         A7USU_DES = GX_Parm2 ;
         A155USU_CLA = GX_Parm3 ;
         /* Using cursor T001020 */
         pr_default.execute(18, new Object[] {A6USU_COD});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG002'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A7USU_DES = T001020_A7USU_DES[0] ;
            A155USU_CLA = T001020_A155USU_CLA[0] ;
         }
         pr_default.close(18);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A7USU_DES = "" ;
            A155USU_CLA = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A7USU_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A155USU_CLA)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Sis_cod( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A116SIS_COD = GX_Parm1 ;
         A259SIS_DES = GX_Parm2 ;
         /* Using cursor T001021 */
         pr_default.execute(19, new Object[] {A116SIS_COD});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG000'.", "ForeignKeyNotFound", 1, "SIS_COD");
            AnyError = 1 ;
            GX_FocusControl = edtSIS_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A259SIS_DES = T001021_A259SIS_DES[0] ;
         }
         pr_default.close(19);
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
                                 String GX_Parm2 ,
                                 short GX_Parm3 ,
                                 String GX_Parm4 ,
                                 String GX_Parm5 ,
                                 String GX_Parm6 )
      {
         A126PRG_COD = GX_Parm1 ;
         A6USU_COD = GX_Parm2 ;
         A116SIS_COD = GX_Parm3 ;
         A127PRG_DES = GX_Parm4 ;
         A289PRG_NFI = GX_Parm5 ;
         A290USU_CNT = GX_Parm6 ;
         /* Using cursor T001022 */
         pr_default.execute(20, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(20) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T001022_A127PRG_DES[0] ;
            A289PRG_NFI = T001022_A289PRG_NFI[0] ;
         }
         pr_default.close(20);
         /* Using cursor T001023 */
         pr_default.execute(21, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG004'.", "ForeignKeyNotFound", 1, "USU_COD");
            AnyError = 1 ;
            GX_FocusControl = edtUSU_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A290USU_CNT = T001023_A290USU_CNT[0] ;
         }
         pr_default.close(21);
         if ( (0==A126PRG_COD) )
         {
            GX_msglist.addItem("Código NO debe ser NULO", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127PRG_DES = "" ;
            A289PRG_NFI = "" ;
            A290USU_CNT = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A289PRG_NFI)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A290USU_CNT)));
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
         pr_default.close(23);
         pr_default.close(13);
         pr_default.close(12);
         pr_default.close(18);
         pr_default.close(21);
         pr_default.close(19);
         pr_default.close(20);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV10USU_COD = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A6USU_COD = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         TempTags = "" ;
         ClassString = "" ;
         StyleString = "" ;
         bttBtn_first_Jsonclick = "" ;
         bttBtn_previous_Jsonclick = "" ;
         bttBtn_next_Jsonclick = "" ;
         bttBtn_last_Jsonclick = "" ;
         bttBtn_select_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_check_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_help_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         A7USU_DES = "" ;
         lblTextblock3_Jsonclick = "" ;
         A155USU_CLA = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         A259SIS_DES = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblock8_Jsonclick = "" ;
         A289PRG_NFI = "" ;
         lblTextblock9_Jsonclick = "" ;
         A290USU_CNT = "" ;
         lblTextblock10_Jsonclick = "" ;
         bttBtn_get_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         lblTextblock12_Jsonclick = "" ;
         A404PRS_UOB = "" ;
         lblTextblock13_Jsonclick = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         lblTextblock14_Jsonclick = "" ;
         A405PRS_UDE = "" ;
         lblTextblock15_Jsonclick = "" ;
         A406PRS_ULNK = "" ;
         Z6USU_COD = "" ;
         Z166PRS_INI = (DateTime)(DateTime.MinValue) ;
         Z404PRS_UOB = "" ;
         Z165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         Z405PRS_UDE = "" ;
         AV18Pgmname = "" ;
         sMode34 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV16TrnContext = new SdtTransactionContext(context);
         AV17WebSession = new GxWebSession( context);
         Z406PRS_ULNK = "" ;
         Z7USU_DES = "" ;
         Z155USU_CLA = "" ;
         Z259SIS_DES = "" ;
         Z127PRG_DES = "" ;
         Z289PRG_NFI = "" ;
         Z290USU_CNT = "" ;
         T00104_A7USU_DES = new String[] {""} ;
         T00104_A155USU_CLA = new String[] {""} ;
         T00105_A259SIS_DES = new String[] {""} ;
         T00106_A127PRG_DES = new String[] {""} ;
         T00106_A289PRG_NFI = new String[] {""} ;
         T00107_A290USU_CNT = new String[] {""} ;
         T00108_A118PRS_NRO = new int[1] ;
         T00108_A7USU_DES = new String[] {""} ;
         T00108_A155USU_CLA = new String[] {""} ;
         T00108_A259SIS_DES = new String[] {""} ;
         T00108_A127PRG_DES = new String[] {""} ;
         T00108_A289PRG_NFI = new String[] {""} ;
         T00108_A290USU_CNT = new String[] {""} ;
         T00108_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T00108_A404PRS_UOB = new String[] {""} ;
         T00108_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T00108_A405PRS_UDE = new String[] {""} ;
         T00108_A406PRS_ULNK = new String[] {""} ;
         T00108_A6USU_COD = new String[] {""} ;
         T00108_A116SIS_COD = new short[1] ;
         T00108_A126PRG_COD = new short[1] ;
         T00109_A7USU_DES = new String[] {""} ;
         T00109_A155USU_CLA = new String[] {""} ;
         T001010_A259SIS_DES = new String[] {""} ;
         T001011_A127PRG_DES = new String[] {""} ;
         T001011_A289PRG_NFI = new String[] {""} ;
         T001012_A290USU_CNT = new String[] {""} ;
         T001013_A6USU_COD = new String[] {""} ;
         T001013_A116SIS_COD = new short[1] ;
         T001013_A126PRG_COD = new short[1] ;
         T001013_A118PRS_NRO = new int[1] ;
         T00103_A118PRS_NRO = new int[1] ;
         T00103_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T00103_A404PRS_UOB = new String[] {""} ;
         T00103_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T00103_A405PRS_UDE = new String[] {""} ;
         T00103_A406PRS_ULNK = new String[] {""} ;
         T00103_A6USU_COD = new String[] {""} ;
         T00103_A116SIS_COD = new short[1] ;
         T00103_A126PRG_COD = new short[1] ;
         T001014_A6USU_COD = new String[] {""} ;
         T001014_A116SIS_COD = new short[1] ;
         T001014_A126PRG_COD = new short[1] ;
         T001014_A118PRS_NRO = new int[1] ;
         T001015_A6USU_COD = new String[] {""} ;
         T001015_A116SIS_COD = new short[1] ;
         T001015_A126PRG_COD = new short[1] ;
         T001015_A118PRS_NRO = new int[1] ;
         T001016_A118PRS_NRO = new int[1] ;
         T001016_A166PRS_INI = new DateTime[] {DateTime.MinValue} ;
         T001016_A404PRS_UOB = new String[] {""} ;
         T001016_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         T001016_A405PRS_UDE = new String[] {""} ;
         T001016_A406PRS_ULNK = new String[] {""} ;
         T001016_A6USU_COD = new String[] {""} ;
         T001016_A116SIS_COD = new short[1] ;
         T001016_A126PRG_COD = new short[1] ;
         T001020_A7USU_DES = new String[] {""} ;
         T001020_A155USU_CLA = new String[] {""} ;
         T001021_A259SIS_DES = new String[] {""} ;
         T001022_A127PRG_DES = new String[] {""} ;
         T001022_A289PRG_NFI = new String[] {""} ;
         T001023_A290USU_CNT = new String[] {""} ;
         T001024_A6USU_COD = new String[] {""} ;
         T001024_A116SIS_COD = new short[1] ;
         T001024_A126PRG_COD = new short[1] ;
         T001024_A118PRS_NRO = new int[1] ;
         T001024_A407PRS_ORD = new short[1] ;
         T001025_A6USU_COD = new String[] {""} ;
         T001025_A116SIS_COD = new short[1] ;
         T001025_A126PRG_COD = new short[1] ;
         T001025_A118PRS_NRO = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tseg006__default(),
            new Object[][] {
                new Object[] {
               T00102_A118PRS_NRO, T00102_A166PRS_INI, T00102_A404PRS_UOB, T00102_A165PRS_CAD, T00102_A405PRS_UDE, T00102_A406PRS_ULNK, T00102_A6USU_COD, T00102_A116SIS_COD, T00102_A126PRG_COD
               }
               , new Object[] {
               T00103_A118PRS_NRO, T00103_A166PRS_INI, T00103_A404PRS_UOB, T00103_A165PRS_CAD, T00103_A405PRS_UDE, T00103_A406PRS_ULNK, T00103_A6USU_COD, T00103_A116SIS_COD, T00103_A126PRG_COD
               }
               , new Object[] {
               T00104_A7USU_DES, T00104_A155USU_CLA
               }
               , new Object[] {
               T00105_A259SIS_DES
               }
               , new Object[] {
               T00106_A127PRG_DES, T00106_A289PRG_NFI
               }
               , new Object[] {
               T00107_A290USU_CNT
               }
               , new Object[] {
               T00108_A118PRS_NRO, T00108_A7USU_DES, T00108_A155USU_CLA, T00108_A259SIS_DES, T00108_A127PRG_DES, T00108_A289PRG_NFI, T00108_A290USU_CNT, T00108_A166PRS_INI, T00108_A404PRS_UOB, T00108_A165PRS_CAD,
               T00108_A405PRS_UDE, T00108_A406PRS_ULNK, T00108_A6USU_COD, T00108_A116SIS_COD, T00108_A126PRG_COD
               }
               , new Object[] {
               T00109_A7USU_DES, T00109_A155USU_CLA
               }
               , new Object[] {
               T001010_A259SIS_DES
               }
               , new Object[] {
               T001011_A127PRG_DES, T001011_A289PRG_NFI
               }
               , new Object[] {
               T001012_A290USU_CNT
               }
               , new Object[] {
               T001013_A6USU_COD, T001013_A116SIS_COD, T001013_A126PRG_COD, T001013_A118PRS_NRO
               }
               , new Object[] {
               T001014_A6USU_COD, T001014_A116SIS_COD, T001014_A126PRG_COD, T001014_A118PRS_NRO
               }
               , new Object[] {
               T001015_A6USU_COD, T001015_A116SIS_COD, T001015_A126PRG_COD, T001015_A118PRS_NRO
               }
               , new Object[] {
               T001016_A118PRS_NRO, T001016_A166PRS_INI, T001016_A404PRS_UOB, T001016_A165PRS_CAD, T001016_A405PRS_UDE, T001016_A406PRS_ULNK, T001016_A6USU_COD, T001016_A116SIS_COD, T001016_A126PRG_COD
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001020_A7USU_DES, T001020_A155USU_CLA
               }
               , new Object[] {
               T001021_A259SIS_DES
               }
               , new Object[] {
               T001022_A127PRG_DES, T001022_A289PRG_NFI
               }
               , new Object[] {
               T001023_A290USU_CNT
               }
               , new Object[] {
               T001024_A6USU_COD, T001024_A116SIS_COD, T001024_A126PRG_COD, T001024_A118PRS_NRO, T001024_A407PRS_ORD
               }
               , new Object[] {
               T001025_A6USU_COD, T001025_A116SIS_COD, T001025_A126PRG_COD, T001025_A118PRS_NRO
               }
            }
         );
         AV18Pgmname = "TSEG006" ;
      }

      private short wcpOAV11SIS_COD ;
      private short wcpOAV12PRG_COD ;
      private short GxWebError ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private short AV11SIS_COD ;
      private short AV12PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z116SIS_COD ;
      private short Z126PRG_COD ;
      private short RcdFound34 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV13PRS_NRO ;
      private int AV13PRS_NRO ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_check_Visible ;
      private int bttBtn_check_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_help_Visible ;
      private int edtUSU_COD_Enabled ;
      private int imgprompt_6_Visible ;
      private int edtUSU_DES_Enabled ;
      private int edtUSU_CLA_Enabled ;
      private int edtSIS_COD_Enabled ;
      private int imgprompt_116_Visible ;
      private int edtSIS_DES_Enabled ;
      private int edtPRG_COD_Enabled ;
      private int imgprompt_126_Visible ;
      private int edtPRG_DES_Enabled ;
      private int edtPRG_NFI_Enabled ;
      private int edtUSU_CNT_Enabled ;
      private int A118PRS_NRO ;
      private int edtPRS_NRO_Enabled ;
      private int bttBtn_get_Visible ;
      private int bttBtn_get_Enabled ;
      private int edtPRS_INI_Enabled ;
      private int edtPRS_UOB_Enabled ;
      private int edtPRS_CAD_Enabled ;
      private int edtPRS_UDE_Enabled ;
      private int edtPRS_ULNK_Enabled ;
      private int Z118PRS_NRO ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV10USU_COD ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A6USU_COD ;
      private String Gx_mode ;
      private String AV10USU_COD ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtUSU_COD_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_check_Internalname ;
      private String bttBtn_check_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_help_Internalname ;
      private String bttBtn_help_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String imgprompt_6_Internalname ;
      private String imgprompt_6_Link ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtUSU_DES_Internalname ;
      private String A7USU_DES ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtUSU_CLA_Internalname ;
      private String A155USU_CLA ;
      private String edtUSU_CLA_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtSIS_COD_Internalname ;
      private String edtSIS_COD_Jsonclick ;
      private String imgprompt_116_Internalname ;
      private String imgprompt_116_Link ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtSIS_DES_Internalname ;
      private String A259SIS_DES ;
      private String edtSIS_DES_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtPRG_COD_Internalname ;
      private String edtPRG_COD_Jsonclick ;
      private String imgprompt_126_Internalname ;
      private String imgprompt_126_Link ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtPRG_NFI_Internalname ;
      private String A289PRG_NFI ;
      private String edtPRG_NFI_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtUSU_CNT_Internalname ;
      private String A290USU_CNT ;
      private String edtUSU_CNT_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtPRS_NRO_Internalname ;
      private String edtPRS_NRO_Jsonclick ;
      private String bttBtn_get_Internalname ;
      private String bttBtn_get_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtPRS_INI_Internalname ;
      private String edtPRS_INI_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtPRS_UOB_Internalname ;
      private String A404PRS_UOB ;
      private String edtPRS_UOB_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtPRS_CAD_Internalname ;
      private String edtPRS_CAD_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtPRS_UDE_Internalname ;
      private String A405PRS_UDE ;
      private String edtPRS_UDE_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtPRS_ULNK_Internalname ;
      private String Z6USU_COD ;
      private String Z404PRS_UOB ;
      private String Z405PRS_UDE ;
      private String AV18Pgmname ;
      private String sMode34 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z7USU_DES ;
      private String Z155USU_CLA ;
      private String Z259SIS_DES ;
      private String Z127PRG_DES ;
      private String Z289PRG_NFI ;
      private String Z290USU_CNT ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A166PRS_INI ;
      private DateTime A165PRS_CAD ;
      private DateTime Z166PRS_INI ;
      private DateTime Z165PRS_CAD ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV15IsAuthorized ;
      private bool returnInSub ;
      private String A406PRS_ULNK ;
      private String Z406PRS_ULNK ;
      private GxWebSession AV17WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00104_A7USU_DES ;
      private String[] T00104_A155USU_CLA ;
      private String[] T00105_A259SIS_DES ;
      private String[] T00106_A127PRG_DES ;
      private String[] T00106_A289PRG_NFI ;
      private String[] T00107_A290USU_CNT ;
      private int[] T00108_A118PRS_NRO ;
      private String[] T00108_A7USU_DES ;
      private String[] T00108_A155USU_CLA ;
      private String[] T00108_A259SIS_DES ;
      private String[] T00108_A127PRG_DES ;
      private String[] T00108_A289PRG_NFI ;
      private String[] T00108_A290USU_CNT ;
      private DateTime[] T00108_A166PRS_INI ;
      private String[] T00108_A404PRS_UOB ;
      private DateTime[] T00108_A165PRS_CAD ;
      private String[] T00108_A405PRS_UDE ;
      private String[] T00108_A406PRS_ULNK ;
      private String[] T00108_A6USU_COD ;
      private short[] T00108_A116SIS_COD ;
      private short[] T00108_A126PRG_COD ;
      private String[] T00109_A7USU_DES ;
      private String[] T00109_A155USU_CLA ;
      private String[] T001010_A259SIS_DES ;
      private String[] T001011_A127PRG_DES ;
      private String[] T001011_A289PRG_NFI ;
      private String[] T001012_A290USU_CNT ;
      private String[] T001013_A6USU_COD ;
      private short[] T001013_A116SIS_COD ;
      private short[] T001013_A126PRG_COD ;
      private int[] T001013_A118PRS_NRO ;
      private int[] T00103_A118PRS_NRO ;
      private DateTime[] T00103_A166PRS_INI ;
      private String[] T00103_A404PRS_UOB ;
      private DateTime[] T00103_A165PRS_CAD ;
      private String[] T00103_A405PRS_UDE ;
      private String[] T00103_A406PRS_ULNK ;
      private String[] T00103_A6USU_COD ;
      private short[] T00103_A116SIS_COD ;
      private short[] T00103_A126PRG_COD ;
      private String[] T001014_A6USU_COD ;
      private short[] T001014_A116SIS_COD ;
      private short[] T001014_A126PRG_COD ;
      private int[] T001014_A118PRS_NRO ;
      private String[] T001015_A6USU_COD ;
      private short[] T001015_A116SIS_COD ;
      private short[] T001015_A126PRG_COD ;
      private int[] T001015_A118PRS_NRO ;
      private int[] T001016_A118PRS_NRO ;
      private DateTime[] T001016_A166PRS_INI ;
      private String[] T001016_A404PRS_UOB ;
      private DateTime[] T001016_A165PRS_CAD ;
      private String[] T001016_A405PRS_UDE ;
      private String[] T001016_A406PRS_ULNK ;
      private String[] T001016_A6USU_COD ;
      private short[] T001016_A116SIS_COD ;
      private short[] T001016_A126PRG_COD ;
      private String[] T001020_A7USU_DES ;
      private String[] T001020_A155USU_CLA ;
      private String[] T001021_A259SIS_DES ;
      private String[] T001022_A127PRG_DES ;
      private String[] T001022_A289PRG_NFI ;
      private String[] T001023_A290USU_CNT ;
      private String[] T001024_A6USU_COD ;
      private short[] T001024_A116SIS_COD ;
      private short[] T001024_A126PRG_COD ;
      private int[] T001024_A118PRS_NRO ;
      private short[] T001024_A407PRS_ORD ;
      private String[] T001025_A6USU_COD ;
      private short[] T001025_A116SIS_COD ;
      private short[] T001025_A126PRG_COD ;
      private int[] T001025_A118PRS_NRO ;
      private int[] T00102_A118PRS_NRO ;
      private DateTime[] T00102_A166PRS_INI ;
      private String[] T00102_A404PRS_UOB ;
      private DateTime[] T00102_A165PRS_CAD ;
      private String[] T00102_A405PRS_UDE ;
      private String[] T00102_A406PRS_ULNK ;
      private String[] T00102_A6USU_COD ;
      private short[] T00102_A116SIS_COD ;
      private short[] T00102_A126PRG_COD ;
      private GXWebForm Form ;
      private SdtTransactionContext AV16TrnContext ;
   }

   public class tseg006__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new ForEachCursor(def[22])
         ,new ForEachCursor(def[23])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00102 ;
          prmT00102 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00108 ;
          prmT00108 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00104 ;
          prmT00104 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT00105 ;
          prmT00105 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT00106 ;
          prmT00106 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00107 ;
          prmT00107 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00109 ;
          prmT00109 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT001010 ;
          prmT001010 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001011 ;
          prmT001011 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001012 ;
          prmT001012 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001013 ;
          prmT001013 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT00103 ;
          prmT00103 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001014 ;
          prmT001014 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001015 ;
          prmT001015 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001016 ;
          prmT001016 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001017 ;
          prmT001017 = new Object[] {
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRS_UOB",SqlDbType.Char,20,0} ,
          new Object[] {"@PRS_CAD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRS_UDE",SqlDbType.Char,30,0} ,
          new Object[] {"@PRS_ULNK",SqlDbType.VarChar,300,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001018 ;
          prmT001018 = new Object[] {
          new Object[] {"@PRS_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRS_UOB",SqlDbType.Char,20,0} ,
          new Object[] {"@PRS_CAD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRS_UDE",SqlDbType.Char,30,0} ,
          new Object[] {"@PRS_ULNK",SqlDbType.VarChar,300,0} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001019 ;
          prmT001019 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001024 ;
          prmT001024 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmT001025 ;
          prmT001025 = new Object[] {
          } ;
          Object[] prmT001020 ;
          prmT001020 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmT001021 ;
          prmT001021 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmT001022 ;
          prmT001022 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001023 ;
          prmT001023 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00102", "SELECT [PRS_NRO], [PRS_INI], [PRS_UOB], [PRS_CAD], [PRS_UDE], [PRS_ULNK], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG006] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00102,1,1,true,false )
             ,new CursorDef("T00103", "SELECT [PRS_NRO], [PRS_INI], [PRS_UOB], [PRS_CAD], [PRS_UDE], [PRS_ULNK], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT00103,1,1,true,false )
             ,new CursorDef("T00104", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00104,1,0,true,false )
             ,new CursorDef("T00105", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00105,1,1,true,false )
             ,new CursorDef("T00106", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00106,1,1,true,false )
             ,new CursorDef("T00107", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00107,1,1,true,false )
             ,new CursorDef("T00108", "SELECT TM1.[PRS_NRO], T2.[USU_DES], T2.[USU_CLA], T3.[SIS_DES], T4.[PRG_DES], T4.[PRG_NFI], T5.[USU_CNT], TM1.[PRS_INI], TM1.[PRS_UOB], TM1.[PRS_CAD], TM1.[PRS_UDE], TM1.[PRS_ULNK], TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD] FROM (((([SEG006] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[USU_COD]) INNER JOIN [SEG000] T3 WITH (NOLOCK) ON T3.[SIS_COD] = TM1.[SIS_COD]) INNER JOIN [SEG001] T4 WITH (NOLOCK) ON T4.[PRG_COD] = TM1.[PRG_COD]) INNER JOIN [SEG004] T5 WITH (NOLOCK) ON T5.[USU_COD] = TM1.[USU_COD] AND T5.[SIS_COD] = TM1.[SIS_COD] AND T5.[PRG_COD] = TM1.[PRG_COD]) WHERE TM1.[USU_COD] = @USU_COD and TM1.[SIS_COD] = @SIS_COD and TM1.[PRG_COD] = @PRG_COD and TM1.[PRS_NRO] = @PRS_NRO ORDER BY TM1.[USU_COD], TM1.[SIS_COD], TM1.[PRG_COD], TM1.[PRS_NRO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00108,100,0,true,false )
             ,new CursorDef("T00109", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00109,1,0,true,false )
             ,new CursorDef("T001010", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001010,1,1,true,false )
             ,new CursorDef("T001011", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001011,1,1,true,false )
             ,new CursorDef("T001012", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001012,1,1,true,false )
             ,new CursorDef("T001013", "SELECT [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG006] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001013,1,1,true,false )
             ,new CursorDef("T001014", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG006] WITH (NOLOCK) WHERE ( [USU_COD] > @USU_COD or [USU_COD] = @USU_COD and [SIS_COD] > @SIS_COD or [SIS_COD] = @SIS_COD and [USU_COD] = @USU_COD and [PRG_COD] > @PRG_COD or [PRG_COD] = @PRG_COD and [SIS_COD] = @SIS_COD and [USU_COD] = @USU_COD and [PRS_NRO] > @PRS_NRO) ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001014,1,1,true,true )
             ,new CursorDef("T001015", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG006] WITH (NOLOCK) WHERE ( [USU_COD] < @USU_COD or [USU_COD] = @USU_COD and [SIS_COD] < @SIS_COD or [SIS_COD] = @SIS_COD and [USU_COD] = @USU_COD and [PRG_COD] < @PRG_COD or [PRG_COD] = @PRG_COD and [SIS_COD] = @SIS_COD and [USU_COD] = @USU_COD and [PRS_NRO] < @PRS_NRO) ORDER BY [USU_COD] DESC, [SIS_COD] DESC, [PRG_COD] DESC, [PRS_NRO] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001015,1,1,true,true )
             ,new CursorDef("T001016", "SELECT [PRS_NRO], [PRS_INI], [PRS_UOB], [PRS_CAD], [PRS_UDE], [PRS_ULNK], [USU_COD], [SIS_COD], [PRG_COD] FROM [SEG006] WITH (UPDLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT001016,1,1,true,false )
             ,new CursorDef("T001017", "INSERT INTO [SEG006] ([PRS_NRO], [PRS_INI], [PRS_UOB], [PRS_CAD], [PRS_UDE], [PRS_ULNK], [USU_COD], [SIS_COD], [PRG_COD]) VALUES (@PRS_NRO, @PRS_INI, @PRS_UOB, @PRS_CAD, @PRS_UDE, @PRS_ULNK, @USU_COD, @SIS_COD, @PRG_COD)", GxErrorMask.GX_NOMASK,prmT001017)
             ,new CursorDef("T001018", "UPDATE [SEG006] SET [PRS_INI]=@PRS_INI, [PRS_UOB]=@PRS_UOB, [PRS_CAD]=@PRS_CAD, [PRS_UDE]=@PRS_UDE, [PRS_ULNK]=@PRS_ULNK  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO", GxErrorMask.GX_NOMASK,prmT001018)
             ,new CursorDef("T001019", "DELETE FROM [SEG006]  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO", GxErrorMask.GX_NOMASK,prmT001019)
             ,new CursorDef("T001020", "SELECT [USU_DES], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001020,1,0,true,false )
             ,new CursorDef("T001021", "SELECT [SIS_DES] FROM [SEG000] WITH (NOLOCK) WHERE [SIS_COD] = @SIS_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001021,1,1,true,false )
             ,new CursorDef("T001022", "SELECT [PRG_DES], [PRG_NFI] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001022,1,1,true,false )
             ,new CursorDef("T001023", "SELECT [USU_CNT] FROM [SEG004] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001023,1,1,true,false )
             ,new CursorDef("T001024", "SELECT TOP 1 [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_ORD] FROM [SEG007] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO ",true, GxErrorMask.GX_NOMASK, false, this,prmT001024,1,1,true,true )
             ,new CursorDef("T001025", "SELECT [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] FROM [SEG006] WITH (NOLOCK) ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001025,100,1,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 8) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 1) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(8) ;
                ((String[]) buf[8])[0] = rslt.getString(9, 20) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(10) ;
                ((String[]) buf[10])[0] = rslt.getString(11, 30) ;
                ((String[]) buf[11])[0] = rslt.getLongVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getString(13, 16) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 14 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 30) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 16) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                break;
             case 21 :
                ((String[]) buf[0])[0] = rslt.getString(1, 1) ;
                break;
             case 22 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 23 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 15 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                break;
             case 16 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (int)parms[8]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 18 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 22 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
