/*
               File: SEG008L1
        Description: INFO MENUES X
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:18.12
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
   public class seg008l1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_11( A126PRG_COD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_12") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_12( A126PRG_COD, A361MNU_NIV) ;
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
               AV7PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7PRG_COD), 4, 0)));
               AV12MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12MNU_NIV), 6, 0)));
               AV13MNU_SNI = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13MNU_SNI), 5, 0)));
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "INFO MENUES X", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPRG_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public seg008l1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg008l1( IGxContext context )
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
                           short aP1_PRG_COD ,
                           int aP2_MNU_NIV ,
                           int aP3_MNU_SNI )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7PRG_COD = aP1_PRG_COD;
         this.AV12MNU_NIV = aP2_MNU_NIV;
         this.AV13MNU_SNI = aP3_MNU_SNI;
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
            wb_table1_2_0U29( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0U29e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0U29( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0U29( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0U29e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"INFO MENUES X"+"</legend>") ;
            wb_table3_27_0U29( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0U29e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0U29e( true) ;
         }
         else
         {
            wb_table1_2_0U29e( false) ;
         }
      }

      protected void wb_table3_27_0U29( bool wbgen )
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
            wb_table4_33_0U29( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0U29e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_SEG008L1.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_SEG008L1.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0U29e( true) ;
         }
         else
         {
            wb_table3_27_0U29e( false) ;
         }
      }

      protected void wb_table4_33_0U29( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG008L1.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_126_Internalname, "", "prompt.gif", "Modern", imgprompt_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_126_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_niv_Internalname, 1, 1, 0, "NIVEL", "", "", "", 0, lblTextblockmnu_niv_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NIV_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361MNU_NIV), 6, 0, ",", "")), "", 6, "chr", 1, "row", 6, 1, edtMNU_NIV_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A361MNU_NIV), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtMNU_NIV_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG008L1.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_361_Internalname, "", "prompt.gif", "Modern", imgprompt_361_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_361_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_nid_Internalname, 1, 1, 0, "TITULO", "", "", "", 0, lblTextblockmnu_nid_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NID_Internalname, StringUtil.RTrim( A129MNU_NID), "", 80, "chr", 1, "row", 100, 1, edtMNU_NID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A129MNU_NID, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtMNU_NID_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_link_Internalname, 1, 1, 0, "LINK", "", "", "", 0, lblTextblockmnu_link_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMNU_LINK_Internalname, StringUtil.RTrim( A362MNU_LINK), 1, edtMNU_LINK_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", "", -1, 0, "", "", true, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_sni_Internalname, 1, 1, 0, "SUB_NIVEL", "", "", "", 0, lblTextblockmnu_sni_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_SNI_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A130MNU_SNI), 5, 0, ",", "")), "", 5, "chr", 1, "row", 5, 1, edtMNU_SNI_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A130MNU_SNI), "ZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(63);\"", 0, edtMNU_SNI_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_dsn_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockmnu_dsn_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_DSN_Internalname, StringUtil.RTrim( A131MNU_DSN), "", 80, "chr", 1, "row", 100, 1, edtMNU_DSN_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A131MNU_DSN, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, edtMNU_DSN_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_slink_Internalname, 1, 1, 0, "LINK", "", "", "", 0, lblTextblockmnu_slink_Jsonclick, "", StyleString, ClassString, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtMNU_SLINK_Internalname, StringUtil.RTrim( A132MNU_SLINK), 1, edtMNU_SLINK_Enabled, 0, 80, "chr", 4, "row", StyleString, ClassString, "256", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(73);\"", -1, 0, "", "", true, "HLP_SEG008L1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0U29e( true) ;
         }
         else
         {
            wb_table4_33_0U29e( false) ;
         }
      }

      protected void wb_table2_5_0U29( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00t0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_NIV"+"'), id:'"+"MNU_NIV"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_SNI"+"'), id:'"+"MNU_SNI"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00t0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_NIV"+"'), id:'"+"MNU_NIV"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_SNI"+"'), id:'"+"MNU_SNI"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008L1.htm");
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
            wb_table2_5_0U29e( true) ;
         }
         else
         {
            wb_table2_5_0U29e( false) ;
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
         /* Execute user event: E110U2 */
         E110U2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
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
               if ( ! context.localUtil.VCNumber( cgiGet( edtMNU_NIV_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtMNU_NIV_Internalname), ",", ".") < Convert.ToDecimal( -99999 )) || ( ( context.localUtil.CToN( cgiGet( edtMNU_NIV_Internalname), ",", ".") > Convert.ToDecimal( 999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "MNU_NIV");
                  AnyError = 1 ;
                  GX_FocusControl = edtMNU_NIV_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A361MNU_NIV = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               }
               else
               {
                  A361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( edtMNU_NIV_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               }
               A129MNU_NID = cgiGet( edtMNU_NID_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
               A362MNU_LINK = cgiGet( edtMNU_LINK_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
               if ( ! context.localUtil.VCNumber( cgiGet( edtMNU_SNI_Internalname), "ZZZZ9") || ( context.localUtil.CToN( cgiGet( edtMNU_SNI_Internalname), ",", ".") < Convert.ToDecimal( -9999 )) || ( ( context.localUtil.CToN( cgiGet( edtMNU_SNI_Internalname), ",", ".") > Convert.ToDecimal( 99999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "MNU_SNI");
                  AnyError = 1 ;
                  GX_FocusControl = edtMNU_SNI_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A130MNU_SNI = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               }
               else
               {
                  A130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( edtMNU_SNI_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               }
               A131MNU_DSN = cgiGet( edtMNU_DSN_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
               A132MNU_SLINK = cgiGet( edtMNU_SLINK_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132MNU_SLINK", A132MNU_SLINK);
               /* Read saved values. */
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( "Z361MNU_NIV"), ",", ".")) ;
               Z130MNU_SNI = (int)(context.localUtil.CToN( cgiGet( "Z130MNU_SNI"), ",", ".")) ;
               Z131MNU_DSN = cgiGet( "Z131MNU_DSN") ;
               Z132MNU_SLINK = cgiGet( "Z132MNU_SLINK") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
               AV12MNU_NIV = (int)(context.localUtil.CToN( cgiGet( "vMNU_NIV"), ",", ".")) ;
               AV13MNU_SNI = (int)(context.localUtil.CToN( cgiGet( "vMNU_SNI"), ",", ".")) ;
               AV14Pgmname = cgiGet( "vPGMNAME") ;
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
                  A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
                  A361MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
                  A130MNU_SNI = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
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
                     sMode29 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode29 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound29 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0U0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "PRG_COD");
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
                           /* Execute user event: E110U2 */
                           E110U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120U2 */
                           E120U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
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
            /* Execute user event: E120U2 */
            E120U2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0U29( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
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
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
            edtPRG_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_DES_Enabled), 5, 0)));
            edtMNU_NIV_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_NIV_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_NIV_Enabled), 5, 0)));
            edtMNU_NID_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_NID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_NID_Enabled), 5, 0)));
            edtMNU_LINK_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_LINK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_LINK_Enabled), 5, 0)));
            edtMNU_SNI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_SNI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_SNI_Enabled), 5, 0)));
            edtMNU_DSN_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_DSN_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_DSN_Enabled), 5, 0)));
            edtMNU_SLINK_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_SLINK_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_SLINK_Enabled), 5, 0)));
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

      protected void CONFIRM_0U0( )
      {
         BeforeValidate0U29( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0U29( ) ;
            }
            else
            {
               CheckExtendedTable0U29( ) ;
               CloseExtendedTableCursors0U29( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0U0( )
      {
      }

      protected void E110U2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV14Pgmname, out  AV9IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", StringUtil.BoolToStr( AV9IsAuthorized));
         if ( ! AV9IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)) ;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), "");
      }

      protected void E120U2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwseg008l1.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0U29( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z131MNU_DSN = T000U3_A131MNU_DSN[0] ;
               Z132MNU_SLINK = T000U3_A132MNU_SLINK[0] ;
            }
            else
            {
               Z131MNU_DSN = A131MNU_DSN ;
               Z132MNU_SLINK = A132MNU_SLINK ;
            }
         }
         if ( GX_JID == -10 )
         {
            Z130MNU_SNI = A130MNU_SNI ;
            Z131MNU_DSN = A131MNU_DSN ;
            Z132MNU_SLINK = A132MNU_SLINK ;
            Z126PRG_COD = A126PRG_COD ;
            Z361MNU_NIV = A361MNU_NIV ;
            Z127PRG_DES = A127PRG_DES ;
            Z129MNU_NID = A129MNU_NID ;
            Z362MNU_LINK = A362MNU_LINK ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgprompt_361_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00s1.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:false,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_NIV"+"'), id:'"+"MNU_NIV"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! (0==AV7PRG_COD) )
         {
            A126PRG_COD = AV7PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         if ( ! (0==AV7PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         else
         {
            edtPRG_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV7PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV12MNU_NIV) )
         {
            A361MNU_NIV = AV12MNU_NIV ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         }
         if ( ! (0==AV12MNU_NIV) )
         {
            edtMNU_NIV_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_NIV_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_NIV_Enabled), 5, 0)));
         }
         else
         {
            edtMNU_NIV_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_NIV_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_NIV_Enabled), 5, 0)));
         }
         if ( ! (0==AV12MNU_NIV) )
         {
            edtMNU_NIV_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_NIV_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_NIV_Enabled), 5, 0)));
         }
         if ( ! (0==AV13MNU_SNI) )
         {
            A130MNU_SNI = AV13MNU_SNI ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         }
         if ( ! (0==AV13MNU_SNI) )
         {
            edtMNU_SNI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_SNI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_SNI_Enabled), 5, 0)));
         }
         else
         {
            edtMNU_SNI_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_SNI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_SNI_Enabled), 5, 0)));
         }
         if ( ! (0==AV13MNU_SNI) )
         {
            edtMNU_SNI_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMNU_SNI_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtMNU_SNI_Enabled), 5, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T000U4 */
            pr_default.execute(2, new Object[] {A126PRG_COD});
            A127PRG_DES = T000U4_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            pr_default.close(2);
            AV14Pgmname = "SEG008L1" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000U5 */
            pr_default.execute(3, new Object[] {A126PRG_COD, A361MNU_NIV});
            A129MNU_NID = T000U5_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000U5_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
            pr_default.close(3);
         }
      }

      protected void Load0U29( )
      {
         /* Using cursor T000U6 */
         pr_default.execute(4, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound29 = 1 ;
            A127PRG_DES = T000U6_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A129MNU_NID = T000U6_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000U6_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
            A131MNU_DSN = T000U6_A131MNU_DSN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
            A132MNU_SLINK = T000U6_A132MNU_SLINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132MNU_SLINK", A132MNU_SLINK);
            ZM0U29( -10) ;
         }
         pr_default.close(4);
         OnLoadActions0U29( ) ;
      }

      protected void OnLoadActions0U29( )
      {
         AV14Pgmname = "SEG008L1" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable0U29( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV14Pgmname = "SEG008L1" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         /* Using cursor T000U4 */
         pr_default.execute(2, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000U4_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         pr_default.close(2);
         /* Using cursor T000U5 */
         pr_default.execute(3, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'INFO MENUES X'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A129MNU_NID = T000U5_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000U5_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0U29( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( short A126PRG_COD )
      {
         /* Using cursor T000U7 */
         pr_default.execute(5, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000U7_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127PRG_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_12( short A126PRG_COD ,
                                int A361MNU_NIV )
      {
         /* Using cursor T000U8 */
         pr_default.execute(6, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'INFO MENUES X'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A129MNU_NID = T000U8_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000U8_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A129MNU_NID))+"\""+","+"\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A362MNU_LINK))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0U29( )
      {
         /* Using cursor T000U9 */
         pr_default.execute(7, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound29 = 1 ;
         }
         else
         {
            RcdFound29 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000U3 */
         pr_default.execute(1, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0U29( 10) ;
            RcdFound29 = 1 ;
            A130MNU_SNI = T000U3_A130MNU_SNI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
            A131MNU_DSN = T000U3_A131MNU_DSN[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
            A132MNU_SLINK = T000U3_A132MNU_SLINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132MNU_SLINK", A132MNU_SLINK);
            A126PRG_COD = T000U3_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = T000U3_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            Z126PRG_COD = A126PRG_COD ;
            Z361MNU_NIV = A361MNU_NIV ;
            Z130MNU_SNI = A130MNU_SNI ;
            sMode29 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0U29( ) ;
            Gx_mode = sMode29 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound29 = 0 ;
            InitializeNonKey0U29( ) ;
            sMode29 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode29 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0U29( ) ;
         if ( RcdFound29 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound29 = 0 ;
         /* Using cursor T000U10 */
         pr_default.execute(8, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000U10_A126PRG_COD[0] < A126PRG_COD ) || ( T000U10_A126PRG_COD[0] == A126PRG_COD ) && ( T000U10_A361MNU_NIV[0] < A361MNU_NIV ) || ( T000U10_A361MNU_NIV[0] == A361MNU_NIV ) && ( T000U10_A126PRG_COD[0] == A126PRG_COD ) && ( T000U10_A130MNU_SNI[0] < A130MNU_SNI ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000U10_A126PRG_COD[0] > A126PRG_COD ) || ( T000U10_A126PRG_COD[0] == A126PRG_COD ) && ( T000U10_A361MNU_NIV[0] > A361MNU_NIV ) || ( T000U10_A361MNU_NIV[0] == A361MNU_NIV ) && ( T000U10_A126PRG_COD[0] == A126PRG_COD ) && ( T000U10_A130MNU_SNI[0] > A130MNU_SNI ) ) )
            {
               A126PRG_COD = T000U10_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = T000U10_A361MNU_NIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               A130MNU_SNI = T000U10_A130MNU_SNI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               RcdFound29 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound29 = 0 ;
         /* Using cursor T000U11 */
         pr_default.execute(9, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000U11_A126PRG_COD[0] > A126PRG_COD ) || ( T000U11_A126PRG_COD[0] == A126PRG_COD ) && ( T000U11_A361MNU_NIV[0] > A361MNU_NIV ) || ( T000U11_A361MNU_NIV[0] == A361MNU_NIV ) && ( T000U11_A126PRG_COD[0] == A126PRG_COD ) && ( T000U11_A130MNU_SNI[0] > A130MNU_SNI ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000U11_A126PRG_COD[0] < A126PRG_COD ) || ( T000U11_A126PRG_COD[0] == A126PRG_COD ) && ( T000U11_A361MNU_NIV[0] < A361MNU_NIV ) || ( T000U11_A361MNU_NIV[0] == A361MNU_NIV ) && ( T000U11_A126PRG_COD[0] == A126PRG_COD ) && ( T000U11_A130MNU_SNI[0] < A130MNU_SNI ) ) )
            {
               A126PRG_COD = T000U11_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = T000U11_A361MNU_NIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               A130MNU_SNI = T000U11_A130MNU_SNI[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               RcdFound29 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0U29( ) ;
         if ( RcdFound29 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) || ( A130MNU_SNI != Z130MNU_SNI ) )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = Z361MNU_NIV ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               A130MNU_SNI = Z130MNU_SNI ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0U29( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) || ( A130MNU_SNI != Z130MNU_SNI ) )
            {
               /* Insert record */
               Insert0U29( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "PRG_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0U29( ) ;
                  GX_FocusControl = edtPRG_COD_Internalname ;
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
         if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) || ( A130MNU_SNI != Z130MNU_SNI ) )
         {
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = Z361MNU_NIV ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            A130MNU_SNI = Z130MNU_SNI ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPRG_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0U29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000U12 */
            pr_default.execute(10, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG008L1"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( StringUtil.StrCmp(Z131MNU_DSN, T000U12_A131MNU_DSN[0]) != 0 ) || ( StringUtil.StrCmp(Z132MNU_SLINK, T000U12_A132MNU_SLINK[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG008L1"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0U29( )
      {
         BeforeValidate0U29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U29( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0U29( 0) ;
            CheckOptimisticConcurrency0U29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0U29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U13 */
                     pr_default.execute(11, new Object[] {A130MNU_SNI, A131MNU_DSN, A132MNU_SLINK, A126PRG_COD, A361MNU_NIV});
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
                           ResetCaption0U0( ) ;
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
               Load0U29( ) ;
            }
            EndLevel0U29( ) ;
         }
         CloseExtendedTableCursors0U29( ) ;
      }

      protected void Update0U29( )
      {
         BeforeValidate0U29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U29( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0U29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U14 */
                     pr_default.execute(12, new Object[] {A131MNU_DSN, A132MNU_SLINK, A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG008L1"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0U29( ) ;
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
            EndLevel0U29( ) ;
         }
         CloseExtendedTableCursors0U29( ) ;
      }

      protected void DeferredUpdate0U29( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0U29( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U29( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0U29( ) ;
            AfterConfirm0U29( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0U29( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000U15 */
                  pr_default.execute(13, new Object[] {A126PRG_COD, A361MNU_NIV, A130MNU_SNI});
                  pr_default.close(13);
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
         sMode29 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0U29( ) ;
         Gx_mode = sMode29 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0U29( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "SEG008L1" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
            /* Using cursor T000U16 */
            pr_default.execute(14, new Object[] {A126PRG_COD});
            A127PRG_DES = T000U16_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            pr_default.close(14);
            /* Using cursor T000U17 */
            pr_default.execute(15, new Object[] {A126PRG_COD, A361MNU_NIV});
            A129MNU_NID = T000U17_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000U17_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
            pr_default.close(15);
         }
      }

      protected void EndLevel0U29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0U29( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            pr_default.close(15);
            context.CommitDataStores("SEG008L1");
            if ( AnyError == 0 )
            {
               ConfirmValues0U0( ) ;
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
            context.RollbackDataStores("SEG008L1");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0U29( )
      {
         /* Using cursor T000U18 */
         pr_default.execute(16);
         RcdFound29 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound29 = 1 ;
            A126PRG_COD = T000U18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = T000U18_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            A130MNU_SNI = T000U18_A130MNU_SNI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0U29( )
      {
         pr_default.readNext(16);
         RcdFound29 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound29 = 1 ;
            A126PRG_COD = T000U18_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = T000U18_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            A130MNU_SNI = T000U18_A130MNU_SNI[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         }
      }

      protected void ScanEnd0U29( )
      {
      }

      protected void AfterConfirm0U29( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0U29( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0U29( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0U29( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0U29( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0U29( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0U0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("seg008l1.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z126PRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z126PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z361MNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z361MNU_NIV), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z130MNU_SNI", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z130MNU_SNI), 5, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z131MNU_DSN", StringUtil.RTrim( Z131MNU_DSN));
         GxWebStd.gx_hidden_field( context, "Z132MNU_SLINK", StringUtil.RTrim( Z132MNU_SLINK));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12MNU_NIV), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMNU_SNI", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13MNU_SNI), 5, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
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
         return "SEG008L1" ;
      }

      public override String GetPgmdesc( )
      {
         return "INFO MENUES X" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("seg008l1.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) + "," + UrlEncode("" +AV13MNU_SNI) ;
      }

      protected void InitializeNonKey0U29( )
      {
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A129MNU_NID = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
         A362MNU_LINK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
         A131MNU_DSN = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131MNU_DSN", A131MNU_DSN);
         A132MNU_SLINK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132MNU_SLINK", A132MNU_SLINK);
      }

      protected void InitAll0U29( )
      {
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A361MNU_NIV = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         A130MNU_SNI = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130MNU_SNI", StringUtil.LTrim( StringUtil.Str( (decimal)(A130MNU_SNI), 5, 0)));
         InitializeNonKey0U29( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11191981");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("seg008l1.js", "?11191981");
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
         lblTextblockprg_cod_Internalname = "TEXTBLOCKPRG_COD" ;
         edtPRG_COD_Internalname = "PRG_COD" ;
         lblTextblockprg_des_Internalname = "TEXTBLOCKPRG_DES" ;
         edtPRG_DES_Internalname = "PRG_DES" ;
         lblTextblockmnu_niv_Internalname = "TEXTBLOCKMNU_NIV" ;
         edtMNU_NIV_Internalname = "MNU_NIV" ;
         lblTextblockmnu_nid_Internalname = "TEXTBLOCKMNU_NID" ;
         edtMNU_NID_Internalname = "MNU_NID" ;
         lblTextblockmnu_link_Internalname = "TEXTBLOCKMNU_LINK" ;
         edtMNU_LINK_Internalname = "MNU_LINK" ;
         lblTextblockmnu_sni_Internalname = "TEXTBLOCKMNU_SNI" ;
         edtMNU_SNI_Internalname = "MNU_SNI" ;
         lblTextblockmnu_dsn_Internalname = "TEXTBLOCKMNU_DSN" ;
         edtMNU_DSN_Internalname = "MNU_DSN" ;
         lblTextblockmnu_slink_Internalname = "TEXTBLOCKMNU_SLINK" ;
         edtMNU_SLINK_Internalname = "MNU_SLINK" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_126_Internalname = "PROMPT_126" ;
         imgprompt_361_Internalname = "PROMPT_361" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "INFO MENUES X" ;
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
         edtMNU_SLINK_Enabled = 1 ;
         edtMNU_DSN_Jsonclick = "" ;
         edtMNU_DSN_Enabled = 1 ;
         edtMNU_SNI_Jsonclick = "" ;
         edtMNU_SNI_Enabled = 1 ;
         edtMNU_LINK_Enabled = 0 ;
         edtMNU_NID_Jsonclick = "" ;
         edtMNU_NID_Enabled = 0 ;
         imgprompt_361_Visible = 1 ;
         imgprompt_361_Link = "" ;
         edtMNU_NIV_Jsonclick = "" ;
         edtMNU_NIV_Enabled = 1 ;
         edtPRG_DES_Jsonclick = "" ;
         edtPRG_DES_Enabled = 0 ;
         imgprompt_126_Visible = 1 ;
         imgprompt_126_Link = "" ;
         edtPRG_COD_Jsonclick = "" ;
         edtPRG_COD_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Prg_cod( short GX_Parm1 ,
                                 String GX_Parm2 )
      {
         A126PRG_COD = GX_Parm1 ;
         A127PRG_DES = GX_Parm2 ;
         /* Using cursor T000U16 */
         pr_default.execute(14, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000U16_A127PRG_DES[0] ;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127PRG_DES = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
      }

      public void Valid_Mnu_niv( short GX_Parm1 ,
                                 int GX_Parm2 ,
                                 String GX_Parm3 ,
                                 String GX_Parm4 )
      {
         A126PRG_COD = GX_Parm1 ;
         A361MNU_NIV = GX_Parm2 ;
         A129MNU_NID = GX_Parm3 ;
         A362MNU_LINK = GX_Parm4 ;
         /* Using cursor T000U17 */
         pr_default.execute(15, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No existe 'INFO MENUES X'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A129MNU_NID = T000U17_A129MNU_NID[0] ;
            A362MNU_LINK = T000U17_A362MNU_LINK[0] ;
         }
         pr_default.close(15);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A129MNU_NID = "" ;
            A362MNU_LINK = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A129MNU_NID)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A362MNU_LINK)));
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
         wcpOGx_mode = "" ;
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
         lblTextblockprg_cod_Jsonclick = "" ;
         lblTextblockprg_des_Jsonclick = "" ;
         A127PRG_DES = "" ;
         lblTextblockmnu_niv_Jsonclick = "" ;
         lblTextblockmnu_nid_Jsonclick = "" ;
         A129MNU_NID = "" ;
         lblTextblockmnu_link_Jsonclick = "" ;
         A362MNU_LINK = "" ;
         lblTextblockmnu_sni_Jsonclick = "" ;
         lblTextblockmnu_dsn_Jsonclick = "" ;
         A131MNU_DSN = "" ;
         lblTextblockmnu_slink_Jsonclick = "" ;
         A132MNU_SLINK = "" ;
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
         Z131MNU_DSN = "" ;
         Z132MNU_SLINK = "" ;
         AV14Pgmname = "" ;
         sMode29 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = new GxWebSession( context);
         Z127PRG_DES = "" ;
         Z129MNU_NID = "" ;
         Z362MNU_LINK = "" ;
         T000U4_A127PRG_DES = new String[] {""} ;
         T000U5_A129MNU_NID = new String[] {""} ;
         T000U5_A362MNU_LINK = new String[] {""} ;
         T000U6_A130MNU_SNI = new int[1] ;
         T000U6_A127PRG_DES = new String[] {""} ;
         T000U6_A129MNU_NID = new String[] {""} ;
         T000U6_A362MNU_LINK = new String[] {""} ;
         T000U6_A131MNU_DSN = new String[] {""} ;
         T000U6_A132MNU_SLINK = new String[] {""} ;
         T000U6_A126PRG_COD = new short[1] ;
         T000U6_A361MNU_NIV = new int[1] ;
         T000U7_A127PRG_DES = new String[] {""} ;
         T000U8_A129MNU_NID = new String[] {""} ;
         T000U8_A362MNU_LINK = new String[] {""} ;
         T000U9_A126PRG_COD = new short[1] ;
         T000U9_A361MNU_NIV = new int[1] ;
         T000U9_A130MNU_SNI = new int[1] ;
         T000U3_A130MNU_SNI = new int[1] ;
         T000U3_A131MNU_DSN = new String[] {""} ;
         T000U3_A132MNU_SLINK = new String[] {""} ;
         T000U3_A126PRG_COD = new short[1] ;
         T000U3_A361MNU_NIV = new int[1] ;
         T000U10_A126PRG_COD = new short[1] ;
         T000U10_A361MNU_NIV = new int[1] ;
         T000U10_A130MNU_SNI = new int[1] ;
         T000U11_A126PRG_COD = new short[1] ;
         T000U11_A361MNU_NIV = new int[1] ;
         T000U11_A130MNU_SNI = new int[1] ;
         T000U12_A130MNU_SNI = new int[1] ;
         T000U12_A131MNU_DSN = new String[] {""} ;
         T000U12_A132MNU_SLINK = new String[] {""} ;
         T000U12_A126PRG_COD = new short[1] ;
         T000U12_A361MNU_NIV = new int[1] ;
         T000U16_A127PRG_DES = new String[] {""} ;
         T000U17_A129MNU_NID = new String[] {""} ;
         T000U17_A362MNU_LINK = new String[] {""} ;
         T000U18_A126PRG_COD = new short[1] ;
         T000U18_A361MNU_NIV = new int[1] ;
         T000U18_A130MNU_SNI = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg008l1__default(),
            new Object[][] {
                new Object[] {
               T000U2_A130MNU_SNI, T000U2_A131MNU_DSN, T000U2_A132MNU_SLINK, T000U2_A126PRG_COD, T000U2_A361MNU_NIV
               }
               , new Object[] {
               T000U3_A130MNU_SNI, T000U3_A131MNU_DSN, T000U3_A132MNU_SLINK, T000U3_A126PRG_COD, T000U3_A361MNU_NIV
               }
               , new Object[] {
               T000U4_A127PRG_DES
               }
               , new Object[] {
               T000U5_A129MNU_NID, T000U5_A362MNU_LINK
               }
               , new Object[] {
               T000U6_A130MNU_SNI, T000U6_A127PRG_DES, T000U6_A129MNU_NID, T000U6_A362MNU_LINK, T000U6_A131MNU_DSN, T000U6_A132MNU_SLINK, T000U6_A126PRG_COD, T000U6_A361MNU_NIV
               }
               , new Object[] {
               T000U7_A127PRG_DES
               }
               , new Object[] {
               T000U8_A129MNU_NID, T000U8_A362MNU_LINK
               }
               , new Object[] {
               T000U9_A126PRG_COD, T000U9_A361MNU_NIV, T000U9_A130MNU_SNI
               }
               , new Object[] {
               T000U10_A126PRG_COD, T000U10_A361MNU_NIV, T000U10_A130MNU_SNI
               }
               , new Object[] {
               T000U11_A126PRG_COD, T000U11_A361MNU_NIV, T000U11_A130MNU_SNI
               }
               , new Object[] {
               T000U12_A130MNU_SNI, T000U12_A131MNU_DSN, T000U12_A132MNU_SLINK, T000U12_A126PRG_COD, T000U12_A361MNU_NIV
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000U16_A127PRG_DES
               }
               , new Object[] {
               T000U17_A129MNU_NID, T000U17_A362MNU_LINK
               }
               , new Object[] {
               T000U18_A126PRG_COD, T000U18_A361MNU_NIV, T000U18_A130MNU_SNI
               }
            }
         );
         AV14Pgmname = "SEG008L1" ;
      }

      private short wcpOAV7PRG_COD ;
      private short GxWebError ;
      private short A126PRG_COD ;
      private short AV7PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z126PRG_COD ;
      private short RcdFound29 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV12MNU_NIV ;
      private int wcpOAV13MNU_SNI ;
      private int A361MNU_NIV ;
      private int AV12MNU_NIV ;
      private int AV13MNU_SNI ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtPRG_COD_Enabled ;
      private int imgprompt_126_Visible ;
      private int edtPRG_DES_Enabled ;
      private int edtMNU_NIV_Enabled ;
      private int imgprompt_361_Visible ;
      private int edtMNU_NID_Enabled ;
      private int edtMNU_LINK_Enabled ;
      private int A130MNU_SNI ;
      private int edtMNU_SNI_Enabled ;
      private int edtMNU_DSN_Enabled ;
      private int edtMNU_SLINK_Enabled ;
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
      private int Z361MNU_NIV ;
      private int Z130MNU_SNI ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtPRG_COD_Internalname ;
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
      private String lblTextblockprg_cod_Internalname ;
      private String lblTextblockprg_cod_Jsonclick ;
      private String edtPRG_COD_Jsonclick ;
      private String imgprompt_126_Internalname ;
      private String imgprompt_126_Link ;
      private String lblTextblockprg_des_Internalname ;
      private String lblTextblockprg_des_Jsonclick ;
      private String edtPRG_DES_Internalname ;
      private String A127PRG_DES ;
      private String edtPRG_DES_Jsonclick ;
      private String lblTextblockmnu_niv_Internalname ;
      private String lblTextblockmnu_niv_Jsonclick ;
      private String edtMNU_NIV_Internalname ;
      private String edtMNU_NIV_Jsonclick ;
      private String imgprompt_361_Internalname ;
      private String imgprompt_361_Link ;
      private String lblTextblockmnu_nid_Internalname ;
      private String lblTextblockmnu_nid_Jsonclick ;
      private String edtMNU_NID_Internalname ;
      private String A129MNU_NID ;
      private String edtMNU_NID_Jsonclick ;
      private String lblTextblockmnu_link_Internalname ;
      private String lblTextblockmnu_link_Jsonclick ;
      private String edtMNU_LINK_Internalname ;
      private String lblTextblockmnu_sni_Internalname ;
      private String lblTextblockmnu_sni_Jsonclick ;
      private String edtMNU_SNI_Internalname ;
      private String edtMNU_SNI_Jsonclick ;
      private String lblTextblockmnu_dsn_Internalname ;
      private String lblTextblockmnu_dsn_Jsonclick ;
      private String edtMNU_DSN_Internalname ;
      private String A131MNU_DSN ;
      private String edtMNU_DSN_Jsonclick ;
      private String lblTextblockmnu_slink_Internalname ;
      private String lblTextblockmnu_slink_Jsonclick ;
      private String edtMNU_SLINK_Internalname ;
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
      private String Z131MNU_DSN ;
      private String AV14Pgmname ;
      private String sMode29 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z127PRG_DES ;
      private String Z129MNU_NID ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private String A362MNU_LINK ;
      private String A132MNU_SLINK ;
      private String Z132MNU_SLINK ;
      private String Z362MNU_LINK ;
      private GxWebSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000U4_A127PRG_DES ;
      private String[] T000U5_A129MNU_NID ;
      private String[] T000U5_A362MNU_LINK ;
      private int[] T000U6_A130MNU_SNI ;
      private String[] T000U6_A127PRG_DES ;
      private String[] T000U6_A129MNU_NID ;
      private String[] T000U6_A362MNU_LINK ;
      private String[] T000U6_A131MNU_DSN ;
      private String[] T000U6_A132MNU_SLINK ;
      private short[] T000U6_A126PRG_COD ;
      private int[] T000U6_A361MNU_NIV ;
      private String[] T000U7_A127PRG_DES ;
      private String[] T000U8_A129MNU_NID ;
      private String[] T000U8_A362MNU_LINK ;
      private short[] T000U9_A126PRG_COD ;
      private int[] T000U9_A361MNU_NIV ;
      private int[] T000U9_A130MNU_SNI ;
      private int[] T000U3_A130MNU_SNI ;
      private String[] T000U3_A131MNU_DSN ;
      private String[] T000U3_A132MNU_SLINK ;
      private short[] T000U3_A126PRG_COD ;
      private int[] T000U3_A361MNU_NIV ;
      private short[] T000U10_A126PRG_COD ;
      private int[] T000U10_A361MNU_NIV ;
      private int[] T000U10_A130MNU_SNI ;
      private short[] T000U11_A126PRG_COD ;
      private int[] T000U11_A361MNU_NIV ;
      private int[] T000U11_A130MNU_SNI ;
      private int[] T000U12_A130MNU_SNI ;
      private String[] T000U12_A131MNU_DSN ;
      private String[] T000U12_A132MNU_SLINK ;
      private short[] T000U12_A126PRG_COD ;
      private int[] T000U12_A361MNU_NIV ;
      private String[] T000U16_A127PRG_DES ;
      private String[] T000U17_A129MNU_NID ;
      private String[] T000U17_A362MNU_LINK ;
      private short[] T000U18_A126PRG_COD ;
      private int[] T000U18_A361MNU_NIV ;
      private int[] T000U18_A130MNU_SNI ;
      private int[] T000U2_A130MNU_SNI ;
      private String[] T000U2_A131MNU_DSN ;
      private String[] T000U2_A132MNU_SLINK ;
      private short[] T000U2_A126PRG_COD ;
      private int[] T000U2_A361MNU_NIV ;
      private GXWebForm Form ;
      private SdtTransactionContext AV10TrnContext ;
   }

   public class seg008l1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000U2 ;
          prmT000U2 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U6 ;
          prmT000U6 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U4 ;
          prmT000U4 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U5 ;
          prmT000U5 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000U7 ;
          prmT000U7 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U8 ;
          prmT000U8 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000U9 ;
          prmT000U9 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U3 ;
          prmT000U3 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U10 ;
          prmT000U10 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U11 ;
          prmT000U11 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U12 ;
          prmT000U12 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U13 ;
          prmT000U13 = new Object[] {
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0} ,
          new Object[] {"@MNU_DSN",SqlDbType.Char,100,0} ,
          new Object[] {"@MNU_SLINK",SqlDbType.VarChar,256,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000U14 ;
          prmT000U14 = new Object[] {
          new Object[] {"@MNU_DSN",SqlDbType.Char,100,0} ,
          new Object[] {"@MNU_SLINK",SqlDbType.VarChar,256,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U15 ;
          prmT000U15 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_SNI",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000U18 ;
          prmT000U18 = new Object[] {
          } ;
          Object[] prmT000U16 ;
          prmT000U16 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000U17 ;
          prmT000U17 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000U2", "SELECT [MNU_SNI], [MNU_DSN], [MNU_SLINK], [PRG_COD], [MNU_NIV] FROM [SEG008L1] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U2,1,1,true,false )
             ,new CursorDef("T000U3", "SELECT [MNU_SNI], [MNU_DSN], [MNU_SLINK], [PRG_COD], [MNU_NIV] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U3,1,1,true,false )
             ,new CursorDef("T000U4", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U4,1,1,true,false )
             ,new CursorDef("T000U5", "SELECT [MNU_NID], [MNU_LINK] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U5,1,1,true,false )
             ,new CursorDef("T000U6", "SELECT TM1.[MNU_SNI], T2.[PRG_DES], T3.[MNU_NID], T3.[MNU_LINK], TM1.[MNU_DSN], TM1.[MNU_SLINK], TM1.[PRG_COD], TM1.[MNU_NIV] FROM (([SEG008L1] TM1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = TM1.[PRG_COD]) INNER JOIN [SEG008] T3 WITH (NOLOCK) ON T3.[PRG_COD] = TM1.[PRG_COD] AND T3.[MNU_NIV] = TM1.[MNU_NIV]) WHERE TM1.[PRG_COD] = @PRG_COD and TM1.[MNU_NIV] = @MNU_NIV and TM1.[MNU_SNI] = @MNU_SNI ORDER BY TM1.[PRG_COD], TM1.[MNU_NIV], TM1.[MNU_SNI]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U6,100,1,true,false )
             ,new CursorDef("T000U7", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U7,1,1,true,false )
             ,new CursorDef("T000U8", "SELECT [MNU_NID], [MNU_LINK] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U8,1,1,true,false )
             ,new CursorDef("T000U9", "SELECT [PRG_COD], [MNU_NIV], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U9,1,1,true,false )
             ,new CursorDef("T000U10", "SELECT TOP 1 [PRG_COD], [MNU_NIV], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE ( [PRG_COD] > @PRG_COD or [PRG_COD] = @PRG_COD and [MNU_NIV] > @MNU_NIV or [MNU_NIV] = @MNU_NIV and [PRG_COD] = @PRG_COD and [MNU_SNI] > @MNU_SNI) ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U10,1,1,true,true )
             ,new CursorDef("T000U11", "SELECT TOP 1 [PRG_COD], [MNU_NIV], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE ( [PRG_COD] < @PRG_COD or [PRG_COD] = @PRG_COD and [MNU_NIV] < @MNU_NIV or [MNU_NIV] = @MNU_NIV and [PRG_COD] = @PRG_COD and [MNU_SNI] < @MNU_SNI) ORDER BY [PRG_COD] DESC, [MNU_NIV] DESC, [MNU_SNI] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U11,1,1,true,true )
             ,new CursorDef("T000U12", "SELECT [MNU_SNI], [MNU_DSN], [MNU_SLINK], [PRG_COD], [MNU_NIV] FROM [SEG008L1] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U12,1,1,true,false )
             ,new CursorDef("T000U13", "INSERT INTO [SEG008L1] ([MNU_SNI], [MNU_DSN], [MNU_SLINK], [PRG_COD], [MNU_NIV]) VALUES (@MNU_SNI, @MNU_DSN, @MNU_SLINK, @PRG_COD, @MNU_NIV)", GxErrorMask.GX_NOMASK,prmT000U13)
             ,new CursorDef("T000U14", "UPDATE [SEG008L1] SET [MNU_DSN]=@MNU_DSN, [MNU_SLINK]=@MNU_SLINK  WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI", GxErrorMask.GX_NOMASK,prmT000U14)
             ,new CursorDef("T000U15", "DELETE FROM [SEG008L1]  WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV AND [MNU_SNI] = @MNU_SNI", GxErrorMask.GX_NOMASK,prmT000U15)
             ,new CursorDef("T000U16", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U16,1,1,true,false )
             ,new CursorDef("T000U17", "SELECT [MNU_NID], [MNU_LINK] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U17,1,1,true,false )
             ,new CursorDef("T000U18", "SELECT [PRG_COD], [MNU_NIV], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) ORDER BY [PRG_COD], [MNU_NIV], [MNU_SNI]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U18,100,1,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                break;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
             case 12 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
