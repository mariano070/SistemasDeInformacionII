/*
               File: SEG008
        Description: INFO MENUES X
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:16.1
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
   public class seg008 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_8") == 0 )
         {
            A126PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_8( A126PRG_COD) ;
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
               AV11PRG_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11PRG_COD), 4, 0)));
               AV12MNU_NIV = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12MNU_NIV), 6, 0)));
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

      public seg008( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg008( IGxContext context )
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
                           int aP2_MNU_NIV )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV11PRG_COD = aP1_PRG_COD;
         this.AV12MNU_NIV = aP2_MNU_NIV;
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
            wb_table1_2_0T28( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0T28e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0T28( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0T28( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0T28e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"INFO MENUES X"+"</legend>") ;
            wb_table3_27_0T28( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0T28e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0T28e( true) ;
         }
         else
         {
            wb_table1_2_0T28e( false) ;
         }
      }

      protected void wb_table3_27_0T28( bool wbgen )
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
            wb_table4_33_0T28( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0T28e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_SEG008.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_SEG008.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0T28e( true) ;
         }
         else
         {
            wb_table3_27_0T28e( false) ;
         }
      }

      protected void wb_table4_33_0T28( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_cod_Internalname, 1, 1, 0, "CODIGO", "", "", "", 0, lblTextblockprg_cod_Jsonclick, "", StyleString, ClassString, "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A126PRG_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtPRG_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A126PRG_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtPRG_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG008.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_126_Internalname, "", "prompt.gif", "Modern", imgprompt_126_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_126_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockprg_des_Internalname, 1, 1, 0, "DESCRIPCION", "", "", "", 0, lblTextblockprg_des_Jsonclick, "", StyleString, ClassString, "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtPRG_DES_Internalname, StringUtil.RTrim( A127PRG_DES), "", 30, "chr", 1, "row", 30, 1, edtPRG_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A127PRG_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), "", 0, edtPRG_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_niv_Internalname, 1, 1, 0, "NIVEL", "", "", "", 0, lblTextblockmnu_niv_Jsonclick, "", StyleString, ClassString, "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NIV_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A361MNU_NIV), 6, 0, ",", "")), "", 6, "chr", 1, "row", 6, 1, edtMNU_NIV_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A361MNU_NIV), "ZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtMNU_NIV_Jsonclick, "", 0, 1, -1, true, "right", "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmnu_nid_Internalname, 1, 1, 0, "TITULO", "", "", "", 0, lblTextblockmnu_nid_Jsonclick, "", StyleString, ClassString, "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtMNU_NID_Internalname, StringUtil.RTrim( A129MNU_NID), "", 80, "chr", 1, "row", 100, 1, edtMNU_NID_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A129MNU_NID, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtMNU_NID_Jsonclick, "", 0, 1, -1, true, "left", "HLP_SEG008.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0T28e( true) ;
         }
         else
         {
            wb_table4_33_0T28e( false) ;
         }
      }

      protected void wb_table2_5_0T28( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00s0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_NIV"+"'), id:'"+"MNU_NIV"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00s0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"MNU_NIV"+"'), id:'"+"MNU_NIV"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_SEG008.htm");
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
            wb_table2_5_0T28e( true) ;
         }
         else
         {
            wb_table2_5_0T28e( false) ;
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
         /* Execute user event: E110T2 */
         E110T2 ();
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
               /* Read saved values. */
               Z126PRG_COD = (short)(context.localUtil.CToN( cgiGet( "Z126PRG_COD"), ",", ".")) ;
               Z361MNU_NIV = (int)(context.localUtil.CToN( cgiGet( "Z361MNU_NIV"), ",", ".")) ;
               Z129MNU_NID = cgiGet( "Z129MNU_NID") ;
               Z362MNU_LINK = cgiGet( "Z362MNU_LINK") ;
               A362MNU_LINK = cgiGet( "Z362MNU_LINK") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV11PRG_COD = (short)(context.localUtil.CToN( cgiGet( "vPRG_COD"), ",", ".")) ;
               AV12MNU_NIV = (int)(context.localUtil.CToN( cgiGet( "vMNU_NIV"), ",", ".")) ;
               A362MNU_LINK = cgiGet( "MNU_LINK") ;
               AV13Pgmname = cgiGet( "vPGMNAME") ;
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
                     sMode28 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode28 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound28 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0T0( ) ;
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
                           /* Execute user event: E110T2 */
                           E110T2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120T2 */
                           E120T2 ();
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
            /* Execute user event: E120T2 */
            E120T2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0T28( ) ;
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

      protected void CONFIRM_0T0( )
      {
         BeforeValidate0T28( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0T28( ) ;
            }
            else
            {
               CheckExtendedTable0T28( ) ;
               CloseExtendedTableCursors0T28( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0T0( )
      {
      }

      protected void E110T2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV13Pgmname, out  AV8IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8IsAuthorized", StringUtil.BoolToStr( AV8IsAuthorized));
         if ( ! AV8IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)) ;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), "");
      }

      protected void E120T2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwseg008.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0T28( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z129MNU_NID = T000T3_A129MNU_NID[0] ;
               Z362MNU_LINK = T000T3_A362MNU_LINK[0] ;
            }
            else
            {
               Z129MNU_NID = A129MNU_NID ;
               Z362MNU_LINK = A362MNU_LINK ;
            }
         }
         if ( GX_JID == -7 )
         {
            Z361MNU_NIV = A361MNU_NIV ;
            Z129MNU_NID = A129MNU_NID ;
            Z362MNU_LINK = A362MNU_LINK ;
            Z126PRG_COD = A126PRG_COD ;
            Z127PRG_DES = A127PRG_DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_126_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00r0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"PRG_COD"+"'), id:'"+"PRG_COD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! (0==AV11PRG_COD) )
         {
            A126PRG_COD = AV11PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         }
         if ( ! (0==AV11PRG_COD) )
         {
            edtPRG_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         else
         {
            edtPRG_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPRG_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPRG_COD_Enabled), 5, 0)));
         }
         if ( ! (0==AV11PRG_COD) )
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
            /* Using cursor T000T4 */
            pr_default.execute(2, new Object[] {A126PRG_COD});
            A127PRG_DES = T000T4_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            pr_default.close(2);
            AV13Pgmname = "SEG008" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void Load0T28( )
      {
         /* Using cursor T000T5 */
         pr_default.execute(3, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound28 = 1 ;
            A127PRG_DES = T000T5_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            A129MNU_NID = T000T5_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000T5_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
            ZM0T28( -7) ;
         }
         pr_default.close(3);
         OnLoadActions0T28( ) ;
      }

      protected void OnLoadActions0T28( )
      {
         AV13Pgmname = "SEG008" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable0T28( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV13Pgmname = "SEG008" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         /* Using cursor T000T4 */
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
            A127PRG_DES = T000T4_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0T28( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_8( short A126PRG_COD )
      {
         /* Using cursor T000T6 */
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
            A127PRG_DES = T000T6_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A127PRG_DES))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey0T28( )
      {
         /* Using cursor T000T7 */
         pr_default.execute(5, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound28 = 1 ;
         }
         else
         {
            RcdFound28 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000T3 */
         pr_default.execute(1, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0T28( 7) ;
            RcdFound28 = 1 ;
            A361MNU_NIV = T000T3_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
            A129MNU_NID = T000T3_A129MNU_NID[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
            A362MNU_LINK = T000T3_A362MNU_LINK[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
            A126PRG_COD = T000T3_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            Z126PRG_COD = A126PRG_COD ;
            Z361MNU_NIV = A361MNU_NIV ;
            sMode28 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0T28( ) ;
            Gx_mode = sMode28 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound28 = 0 ;
            InitializeNonKey0T28( ) ;
            sMode28 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode28 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0T28( ) ;
         if ( RcdFound28 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound28 = 0 ;
         /* Using cursor T000T8 */
         pr_default.execute(6, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000T8_A126PRG_COD[0] < A126PRG_COD ) || ( T000T8_A126PRG_COD[0] == A126PRG_COD ) && ( T000T8_A361MNU_NIV[0] < A361MNU_NIV ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000T8_A126PRG_COD[0] > A126PRG_COD ) || ( T000T8_A126PRG_COD[0] == A126PRG_COD ) && ( T000T8_A361MNU_NIV[0] > A361MNU_NIV ) ) )
            {
               A126PRG_COD = T000T8_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = T000T8_A361MNU_NIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               RcdFound28 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound28 = 0 ;
         /* Using cursor T000T9 */
         pr_default.execute(7, new Object[] {A126PRG_COD, A361MNU_NIV});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000T9_A126PRG_COD[0] > A126PRG_COD ) || ( T000T9_A126PRG_COD[0] == A126PRG_COD ) && ( T000T9_A361MNU_NIV[0] > A361MNU_NIV ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000T9_A126PRG_COD[0] < A126PRG_COD ) || ( T000T9_A126PRG_COD[0] == A126PRG_COD ) && ( T000T9_A361MNU_NIV[0] < A361MNU_NIV ) ) )
            {
               A126PRG_COD = T000T9_A126PRG_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = T000T9_A361MNU_NIV[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
               RcdFound28 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0T28( ) ;
         if ( RcdFound28 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "PRG_COD");
               AnyError = 1 ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) )
            {
               A126PRG_COD = Z126PRG_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
               A361MNU_NIV = Z361MNU_NIV ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
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
               Update0T28( ) ;
               GX_FocusControl = edtPRG_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) )
            {
               /* Insert record */
               Insert0T28( ) ;
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
                  Insert0T28( ) ;
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
         if ( ( A126PRG_COD != Z126PRG_COD ) || ( A361MNU_NIV != Z361MNU_NIV ) )
         {
            A126PRG_COD = Z126PRG_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = Z361MNU_NIV ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
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

      protected void CheckOptimisticConcurrency0T28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000T10 */
            pr_default.execute(8, new Object[] {A126PRG_COD, A361MNU_NIV});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG008"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z129MNU_NID, T000T10_A129MNU_NID[0]) != 0 ) || ( StringUtil.StrCmp(Z362MNU_LINK, T000T10_A362MNU_LINK[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SEG008"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0T28( )
      {
         BeforeValidate0T28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T28( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0T28( 0) ;
            CheckOptimisticConcurrency0T28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0T28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T11 */
                     pr_default.execute(9, new Object[] {A361MNU_NIV, A129MNU_NID, A362MNU_LINK, A126PRG_COD});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 1) )
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
                           ResetCaption0T0( ) ;
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
               Load0T28( ) ;
            }
            EndLevel0T28( ) ;
         }
         CloseExtendedTableCursors0T28( ) ;
      }

      protected void Update0T28( )
      {
         BeforeValidate0T28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T28( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0T28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T12 */
                     pr_default.execute(10, new Object[] {A129MNU_NID, A362MNU_LINK, A126PRG_COD, A361MNU_NIV});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SEG008"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0T28( ) ;
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
            EndLevel0T28( ) ;
         }
         CloseExtendedTableCursors0T28( ) ;
      }

      protected void DeferredUpdate0T28( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0T28( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T28( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0T28( ) ;
            AfterConfirm0T28( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0T28( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000T13 */
                  pr_default.execute(11, new Object[] {A126PRG_COD, A361MNU_NIV});
                  pr_default.close(11);
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
         sMode28 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0T28( ) ;
         Gx_mode = sMode28 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0T28( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "SEG008" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
            /* Using cursor T000T14 */
            pr_default.execute(12, new Object[] {A126PRG_COD});
            A127PRG_DES = T000T14_A127PRG_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000T15 */
            pr_default.execute(13, new Object[] {A126PRG_COD, A361MNU_NIV});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Level1"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0T28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0T28( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.CommitDataStores("SEG008");
            if ( AnyError == 0 )
            {
               ConfirmValues0T0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            pr_default.close(12);
            context.RollbackDataStores("SEG008");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0T28( )
      {
         /* Using cursor T000T16 */
         pr_default.execute(14);
         RcdFound28 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound28 = 1 ;
            A126PRG_COD = T000T16_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = T000T16_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0T28( )
      {
         pr_default.readNext(14);
         RcdFound28 = 0 ;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound28 = 1 ;
            A126PRG_COD = T000T16_A126PRG_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
            A361MNU_NIV = T000T16_A361MNU_NIV[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         }
      }

      protected void ScanEnd0T28( )
      {
      }

      protected void AfterConfirm0T28( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0T28( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0T28( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0T28( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0T28( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0T28( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0T0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("seg008.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV)+"\" class=\""+"Form"+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z129MNU_NID", StringUtil.RTrim( Z129MNU_NID));
         GxWebStd.gx_hidden_field( context, "Z362MNU_LINK", StringUtil.RTrim( Z362MNU_LINK));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vPRG_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11PRG_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMNU_NIV", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12MNU_NIV), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "MNU_LINK", StringUtil.RTrim( A362MNU_LINK));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
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
         return "SEG008" ;
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
         return formatLink("seg008.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV11PRG_COD) + "," + UrlEncode("" +AV12MNU_NIV) ;
      }

      protected void InitializeNonKey0T28( )
      {
         A127PRG_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127PRG_DES", A127PRG_DES);
         A129MNU_NID = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129MNU_NID", A129MNU_NID);
         A362MNU_LINK = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362MNU_LINK", A362MNU_LINK);
      }

      protected void InitAll0T28( )
      {
         A126PRG_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126PRG_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A126PRG_COD), 4, 0)));
         A361MNU_NIV = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361MNU_NIV", StringUtil.LTrim( StringUtil.Str( (decimal)(A361MNU_NIV), 6, 0)));
         InitializeNonKey0T28( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11191722");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("seg008.js", "?11191722");
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
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_126_Internalname = "PROMPT_126" ;
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
         edtMNU_NID_Jsonclick = "" ;
         edtMNU_NID_Enabled = 1 ;
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
         /* Using cursor T000T14 */
         pr_default.execute(12, new Object[] {A126PRG_COD});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("No existe 'SEG001'.", "ForeignKeyNotFound", 1, "PRG_COD");
            AnyError = 1 ;
            GX_FocusControl = edtPRG_COD_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A127PRG_DES = T000T14_A127PRG_DES[0] ;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A127PRG_DES = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A127PRG_DES)));
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
         pr_default.close(14);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(12);
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
         Z129MNU_NID = "" ;
         Z362MNU_LINK = "" ;
         A362MNU_LINK = "" ;
         AV13Pgmname = "" ;
         sMode28 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = new GxWebSession( context);
         Z127PRG_DES = "" ;
         T000T4_A127PRG_DES = new String[] {""} ;
         T000T5_A361MNU_NIV = new int[1] ;
         T000T5_A127PRG_DES = new String[] {""} ;
         T000T5_A129MNU_NID = new String[] {""} ;
         T000T5_A362MNU_LINK = new String[] {""} ;
         T000T5_A126PRG_COD = new short[1] ;
         T000T6_A127PRG_DES = new String[] {""} ;
         T000T7_A126PRG_COD = new short[1] ;
         T000T7_A361MNU_NIV = new int[1] ;
         T000T3_A361MNU_NIV = new int[1] ;
         T000T3_A129MNU_NID = new String[] {""} ;
         T000T3_A362MNU_LINK = new String[] {""} ;
         T000T3_A126PRG_COD = new short[1] ;
         T000T8_A126PRG_COD = new short[1] ;
         T000T8_A361MNU_NIV = new int[1] ;
         T000T9_A126PRG_COD = new short[1] ;
         T000T9_A361MNU_NIV = new int[1] ;
         T000T10_A361MNU_NIV = new int[1] ;
         T000T10_A129MNU_NID = new String[] {""} ;
         T000T10_A362MNU_LINK = new String[] {""} ;
         T000T10_A126PRG_COD = new short[1] ;
         T000T14_A127PRG_DES = new String[] {""} ;
         T000T15_A126PRG_COD = new short[1] ;
         T000T15_A361MNU_NIV = new int[1] ;
         T000T15_A130MNU_SNI = new int[1] ;
         T000T16_A126PRG_COD = new short[1] ;
         T000T16_A361MNU_NIV = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg008__default(),
            new Object[][] {
                new Object[] {
               T000T2_A361MNU_NIV, T000T2_A129MNU_NID, T000T2_A362MNU_LINK, T000T2_A126PRG_COD
               }
               , new Object[] {
               T000T3_A361MNU_NIV, T000T3_A129MNU_NID, T000T3_A362MNU_LINK, T000T3_A126PRG_COD
               }
               , new Object[] {
               T000T4_A127PRG_DES
               }
               , new Object[] {
               T000T5_A361MNU_NIV, T000T5_A127PRG_DES, T000T5_A129MNU_NID, T000T5_A362MNU_LINK, T000T5_A126PRG_COD
               }
               , new Object[] {
               T000T6_A127PRG_DES
               }
               , new Object[] {
               T000T7_A126PRG_COD, T000T7_A361MNU_NIV
               }
               , new Object[] {
               T000T8_A126PRG_COD, T000T8_A361MNU_NIV
               }
               , new Object[] {
               T000T9_A126PRG_COD, T000T9_A361MNU_NIV
               }
               , new Object[] {
               T000T10_A361MNU_NIV, T000T10_A129MNU_NID, T000T10_A362MNU_LINK, T000T10_A126PRG_COD
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000T14_A127PRG_DES
               }
               , new Object[] {
               T000T15_A126PRG_COD, T000T15_A361MNU_NIV, T000T15_A130MNU_SNI
               }
               , new Object[] {
               T000T16_A126PRG_COD, T000T16_A361MNU_NIV
               }
            }
         );
         AV13Pgmname = "SEG008" ;
      }

      private short wcpOAV11PRG_COD ;
      private short GxWebError ;
      private short A126PRG_COD ;
      private short AV11PRG_COD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Z126PRG_COD ;
      private short RcdFound28 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV12MNU_NIV ;
      private int AV12MNU_NIV ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtPRG_COD_Enabled ;
      private int imgprompt_126_Visible ;
      private int edtPRG_DES_Enabled ;
      private int A361MNU_NIV ;
      private int edtMNU_NIV_Enabled ;
      private int edtMNU_NID_Enabled ;
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
      private String lblTextblockmnu_nid_Internalname ;
      private String lblTextblockmnu_nid_Jsonclick ;
      private String edtMNU_NID_Internalname ;
      private String A129MNU_NID ;
      private String edtMNU_NID_Jsonclick ;
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
      private String Z129MNU_NID ;
      private String AV13Pgmname ;
      private String sMode28 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z127PRG_DES ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool AV8IsAuthorized ;
      private bool returnInSub ;
      private String Z362MNU_LINK ;
      private String A362MNU_LINK ;
      private GxWebSession AV10WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000T4_A127PRG_DES ;
      private int[] T000T5_A361MNU_NIV ;
      private String[] T000T5_A127PRG_DES ;
      private String[] T000T5_A129MNU_NID ;
      private String[] T000T5_A362MNU_LINK ;
      private short[] T000T5_A126PRG_COD ;
      private String[] T000T6_A127PRG_DES ;
      private short[] T000T7_A126PRG_COD ;
      private int[] T000T7_A361MNU_NIV ;
      private int[] T000T3_A361MNU_NIV ;
      private String[] T000T3_A129MNU_NID ;
      private String[] T000T3_A362MNU_LINK ;
      private short[] T000T3_A126PRG_COD ;
      private short[] T000T8_A126PRG_COD ;
      private int[] T000T8_A361MNU_NIV ;
      private short[] T000T9_A126PRG_COD ;
      private int[] T000T9_A361MNU_NIV ;
      private int[] T000T10_A361MNU_NIV ;
      private String[] T000T10_A129MNU_NID ;
      private String[] T000T10_A362MNU_LINK ;
      private short[] T000T10_A126PRG_COD ;
      private String[] T000T14_A127PRG_DES ;
      private short[] T000T15_A126PRG_COD ;
      private int[] T000T15_A361MNU_NIV ;
      private int[] T000T15_A130MNU_SNI ;
      private short[] T000T16_A126PRG_COD ;
      private int[] T000T16_A361MNU_NIV ;
      private int[] T000T2_A361MNU_NIV ;
      private String[] T000T2_A129MNU_NID ;
      private String[] T000T2_A362MNU_LINK ;
      private short[] T000T2_A126PRG_COD ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class seg008__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000T2 ;
          prmT000T2 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T5 ;
          prmT000T5 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T4 ;
          prmT000T4 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T6 ;
          prmT000T6 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T7 ;
          prmT000T7 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T3 ;
          prmT000T3 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T8 ;
          prmT000T8 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T9 ;
          prmT000T9 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T10 ;
          prmT000T10 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T11 ;
          prmT000T11 = new Object[] {
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0} ,
          new Object[] {"@MNU_NID",SqlDbType.Char,100,0} ,
          new Object[] {"@MNU_LINK",SqlDbType.VarChar,256,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000T12 ;
          prmT000T12 = new Object[] {
          new Object[] {"@MNU_NID",SqlDbType.Char,100,0} ,
          new Object[] {"@MNU_LINK",SqlDbType.VarChar,256,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T13 ;
          prmT000T13 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T15 ;
          prmT000T15 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MNU_NIV",SqlDbType.Int,6,0}
          } ;
          Object[] prmT000T16 ;
          prmT000T16 = new Object[] {
          } ;
          Object[] prmT000T14 ;
          prmT000T14 = new Object[] {
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000T2", "SELECT [MNU_NIV], [MNU_NID], [MNU_LINK], [PRG_COD] FROM [SEG008] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T2,1,1,true,false )
             ,new CursorDef("T000T3", "SELECT [MNU_NIV], [MNU_NID], [MNU_LINK], [PRG_COD] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T3,1,1,true,false )
             ,new CursorDef("T000T4", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T4,1,1,true,false )
             ,new CursorDef("T000T5", "SELECT TM1.[MNU_NIV], T2.[PRG_DES], TM1.[MNU_NID], TM1.[MNU_LINK], TM1.[PRG_COD] FROM ([SEG008] TM1 WITH (NOLOCK) INNER JOIN [SEG001] T2 WITH (NOLOCK) ON T2.[PRG_COD] = TM1.[PRG_COD]) WHERE TM1.[PRG_COD] = @PRG_COD and TM1.[MNU_NIV] = @MNU_NIV ORDER BY TM1.[PRG_COD], TM1.[MNU_NIV]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T5,100,1,true,false )
             ,new CursorDef("T000T6", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T6,1,1,true,false )
             ,new CursorDef("T000T7", "SELECT [PRG_COD], [MNU_NIV] FROM [SEG008] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T7,1,1,true,false )
             ,new CursorDef("T000T8", "SELECT TOP 1 [PRG_COD], [MNU_NIV] FROM [SEG008] WITH (NOLOCK) WHERE ( [PRG_COD] > @PRG_COD or [PRG_COD] = @PRG_COD and [MNU_NIV] > @MNU_NIV) ORDER BY [PRG_COD], [MNU_NIV]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T8,1,1,true,true )
             ,new CursorDef("T000T9", "SELECT TOP 1 [PRG_COD], [MNU_NIV] FROM [SEG008] WITH (NOLOCK) WHERE ( [PRG_COD] < @PRG_COD or [PRG_COD] = @PRG_COD and [MNU_NIV] < @MNU_NIV) ORDER BY [PRG_COD] DESC, [MNU_NIV] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T9,1,1,true,true )
             ,new CursorDef("T000T10", "SELECT [MNU_NIV], [MNU_NID], [MNU_LINK], [PRG_COD] FROM [SEG008] WITH (UPDLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T10,1,1,true,false )
             ,new CursorDef("T000T11", "INSERT INTO [SEG008] ([MNU_NIV], [MNU_NID], [MNU_LINK], [PRG_COD]) VALUES (@MNU_NIV, @MNU_NID, @MNU_LINK, @PRG_COD)", GxErrorMask.GX_NOMASK,prmT000T11)
             ,new CursorDef("T000T12", "UPDATE [SEG008] SET [MNU_NID]=@MNU_NID, [MNU_LINK]=@MNU_LINK  WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV", GxErrorMask.GX_NOMASK,prmT000T12)
             ,new CursorDef("T000T13", "DELETE FROM [SEG008]  WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV", GxErrorMask.GX_NOMASK,prmT000T13)
             ,new CursorDef("T000T14", "SELECT [PRG_DES] FROM [SEG001] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T14,1,1,true,false )
             ,new CursorDef("T000T15", "SELECT TOP 1 [PRG_COD], [MNU_NIV], [MNU_SNI] FROM [SEG008L1] WITH (NOLOCK) WHERE [PRG_COD] = @PRG_COD AND [MNU_NIV] = @MNU_NIV ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T15,1,1,true,true )
             ,new CursorDef("T000T16", "SELECT [PRG_COD], [MNU_NIV] FROM [SEG008] WITH (NOLOCK) ORDER BY [PRG_COD], [MNU_NIV]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T16,100,1,true,false )
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
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getString(1, 30) ;
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
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
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
