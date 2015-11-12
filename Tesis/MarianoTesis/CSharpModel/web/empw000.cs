/*
               File: EMPW000
        Description: Empresas con Acceso WEB
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:8:38.21
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
   public class empw000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         if ( ! entryPointCalled )
         {
            A278EMPW_USU = gxfirstwebparm ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278EMPW_USU", A278EMPW_USU);
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7EMPW_EMP = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EMPW_EMP), 8, 0)));
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Empresas con Acceso WEB", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEMPW_EMP_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public empw000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public empw000( IGxContext context )
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

      public void execute( ref String aP0_EMPW_USU ,
                           ref int aP1_EMPW_EMP ,
                           ref String aP2_Gx_mode )
      {
         this.A278EMPW_USU = aP0_EMPW_USU;
         this.AV7EMPW_EMP = aP1_EMPW_EMP;
         this.Gx_mode = aP2_Gx_mode;
         executePrivate();
         aP0_EMPW_USU=this.A278EMPW_USU;
         aP1_EMPW_EMP=this.AV7EMPW_EMP;
         aP2_Gx_mode=this.Gx_mode;
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
            wb_table1_2_0I19( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0I19e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0I19( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0I19( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0I19e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Empresas con Acceso WEB"+"</legend>") ;
            wb_table3_27_0I19( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0I19e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0I19e( true) ;
         }
         else
         {
            wb_table1_2_0I19e( false) ;
         }
      }

      protected void wb_table3_27_0I19( bool wbgen )
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
            wb_table4_33_0I19( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0I19e( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_EMPW000.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_EMPW000.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0I19e( true) ;
         }
         else
         {
            wb_table3_27_0I19e( false) ;
         }
      }

      protected void wb_table4_33_0I19( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockempw_usu_Internalname, 1, 1, 0, "Usuario", "", "", "", 0, lblTextblockempw_usu_Jsonclick, "", StyleString, ClassString, "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEMPW_USU_Internalname, StringUtil.RTrim( A278EMPW_USU), "", 16, "chr", 1, "row", 16, 1, edtEMPW_USU_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A278EMPW_USU, "@!")), "", 0, edtEMPW_USU_Jsonclick, "", 0, 1, -1, true, "left", "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempw_usd_Internalname, 1, 1, 0, "Usuario", "", "", "", 0, lblTextblockempw_usd_Jsonclick, "", StyleString, ClassString, "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEMPW_USD_Internalname, StringUtil.RTrim( A283EMPW_USD), "", 50, "chr", 1, "row", 50, 1, edtEMPW_USD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A283EMPW_USD, "@!")), "", 0, edtEMPW_USD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempw_emp_Internalname, 1, 1, 0, "Empresa", "", "", "", 0, lblTextblockempw_emp_Jsonclick, "", StyleString, ClassString, "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEMPW_EMP_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A279EMPW_EMP), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtEMPW_EMP_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A279EMPW_EMP), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtEMPW_EMP_Jsonclick, "", 0, 1, -1, true, "right", "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempw_emd_Internalname, 1, 1, 0, "Empresa", "", "", "", 0, lblTextblockempw_emd_Jsonclick, "", StyleString, ClassString, "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEMPW_EMD_Internalname, StringUtil.RTrim( A281EMPW_EMD), "", 50, "chr", 1, "row", 50, 1, edtEMPW_EMD_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A281EMPW_EMD, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtEMPW_EMD_Jsonclick, "", 0, 1, -1, true, "left", "HLP_EMPW000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0I19e( true) ;
         }
         else
         {
            wb_table4_33_0I19e( false) ;
         }
      }

      protected void wb_table2_5_0I19( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00j1.aspx"+"',["+"'"+StringUtil.RTrim( A278EMPW_USU)+"'"+","+"{Ctrl:gx.dom.el('"+"EMPW_EMP"+"'), id:'"+"EMPW_EMP"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00j1.aspx"+"',["+"'"+StringUtil.RTrim( A278EMPW_USU)+"'"+","+"{Ctrl:gx.dom.el('"+"EMPW_EMP"+"'), id:'"+"EMPW_EMP"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMPW000.htm");
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
            wb_table2_5_0I19e( true) ;
         }
         else
         {
            wb_table2_5_0I19e( false) ;
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
               A278EMPW_USU = StringUtil.Upper( cgiGet( edtEMPW_USU_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278EMPW_USU", A278EMPW_USU);
               A283EMPW_USD = StringUtil.Upper( cgiGet( edtEMPW_USD_Internalname)) ;
               n283EMPW_USD = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283EMPW_USD", A283EMPW_USD);
               if ( ! context.localUtil.VCNumber( cgiGet( edtEMPW_EMP_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtEMPW_EMP_Internalname), ",", ".") < Convert.ToDecimal( -9999999 )) || ( ( context.localUtil.CToN( cgiGet( edtEMPW_EMP_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "EMPW_EMP");
                  AnyError = 1 ;
                  GX_FocusControl = edtEMPW_EMP_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A279EMPW_EMP = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
               }
               else
               {
                  A279EMPW_EMP = (int)(context.localUtil.CToN( cgiGet( edtEMPW_EMP_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
               }
               A281EMPW_EMD = cgiGet( edtEMPW_EMD_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281EMPW_EMD", A281EMPW_EMD);
               /* Read saved values. */
               Z278EMPW_USU = cgiGet( "Z278EMPW_USU") ;
               Z279EMPW_EMP = (int)(context.localUtil.CToN( cgiGet( "Z279EMPW_EMP"), ",", ".")) ;
               Z281EMPW_EMD = cgiGet( "Z281EMPW_EMD") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV7EMPW_EMP = (int)(context.localUtil.CToN( cgiGet( "vEMPW_EMP"), ",", ".")) ;
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
                  A278EMPW_USU = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A278EMPW_USU", A278EMPW_USU);
                  A279EMPW_EMP = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
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
                     sMode19 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode19 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound19 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0I0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "EMPW_USU");
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
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
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0I19( ) ;
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
            edtEMPW_USU_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEMPW_USU_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEMPW_USU_Enabled), 5, 0)));
            edtEMPW_USD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEMPW_USD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEMPW_USD_Enabled), 5, 0)));
            edtEMPW_EMP_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEMPW_EMP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEMPW_EMP_Enabled), 5, 0)));
            edtEMPW_EMD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEMPW_EMD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEMPW_EMD_Enabled), 5, 0)));
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

      protected void CONFIRM_0I0( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0I19( ) ;
            }
            else
            {
               CheckExtendedTable0I19( ) ;
               CloseExtendedTableCursors0I19( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0I0( )
      {
      }

      protected void ZM0I19( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z281EMPW_EMD = T000I3_A281EMPW_EMD[0] ;
            }
            else
            {
               Z281EMPW_EMD = A281EMPW_EMD ;
            }
         }
         if ( GX_JID == -2 )
         {
            Z279EMPW_EMP = A279EMPW_EMP ;
            Z281EMPW_EMD = A281EMPW_EMD ;
            Z278EMPW_USU = A278EMPW_USU ;
            Z283EMPW_USD = A283EMPW_USD ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         /* Using cursor T000I4 */
         pr_default.execute(2, new Object[] {A278EMPW_USU});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'USUARIO'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
            A283EMPW_USD = T000I4_A283EMPW_USD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283EMPW_USD", A283EMPW_USD);
            n283EMPW_USD = T000I4_n283EMPW_USD[0] ;
         }
         pr_default.close(2);
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A279EMPW_EMP = AV7EMPW_EMP ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
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
      }

      protected void Load0I19( )
      {
         /* Using cursor T000I5 */
         pr_default.execute(3, new Object[] {A278EMPW_USU, A279EMPW_EMP});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound19 = 1 ;
            A283EMPW_USD = T000I5_A283EMPW_USD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A283EMPW_USD", A283EMPW_USD);
            n283EMPW_USD = T000I5_n283EMPW_USD[0] ;
            A281EMPW_EMD = T000I5_A281EMPW_EMD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281EMPW_EMD", A281EMPW_EMD);
            ZM0I19( -2) ;
         }
         pr_default.close(3);
         OnLoadActions0I19( ) ;
      }

      protected void OnLoadActions0I19( )
      {
      }

      protected void CheckExtendedTable0I19( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0I19( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0I19( )
      {
         /* Using cursor T000I6 */
         pr_default.execute(4, new Object[] {A278EMPW_USU, A279EMPW_EMP});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound19 = 1 ;
         }
         else
         {
            RcdFound19 = 0 ;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000I3 */
         pr_default.execute(1, new Object[] {A278EMPW_USU, A279EMPW_EMP});
         if ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(T000I3_A278EMPW_USU[0], A278EMPW_USU) == 0 ) )
         {
            ZM0I19( 2) ;
            RcdFound19 = 1 ;
            A279EMPW_EMP = T000I3_A279EMPW_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
            A281EMPW_EMD = T000I3_A281EMPW_EMD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281EMPW_EMD", A281EMPW_EMD);
            Z278EMPW_USU = A278EMPW_USU ;
            Z279EMPW_EMP = A279EMPW_EMP ;
            sMode19 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0I19( ) ;
            Gx_mode = sMode19 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound19 = 0 ;
            InitializeNonKey0I19( ) ;
            sMode19 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode19 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I19( ) ;
         if ( RcdFound19 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound19 = 0 ;
         /* Using cursor T000I7 */
         pr_default.execute(5, new Object[] {A279EMPW_EMP, A278EMPW_USU});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000I7_A279EMPW_EMP[0] < A279EMPW_EMP ) ) && ( StringUtil.StrCmp(T000I7_A278EMPW_USU[0], A278EMPW_USU) == 0 ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000I7_A279EMPW_EMP[0] > A279EMPW_EMP ) ) && ( StringUtil.StrCmp(T000I7_A278EMPW_USU[0], A278EMPW_USU) == 0 ) )
            {
               A279EMPW_EMP = T000I7_A279EMPW_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
               RcdFound19 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound19 = 0 ;
         /* Using cursor T000I8 */
         pr_default.execute(6, new Object[] {A279EMPW_EMP, A278EMPW_USU});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000I8_A279EMPW_EMP[0] > A279EMPW_EMP ) ) && ( StringUtil.StrCmp(T000I8_A278EMPW_USU[0], A278EMPW_USU) == 0 ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000I8_A279EMPW_EMP[0] < A279EMPW_EMP ) ) && ( StringUtil.StrCmp(T000I8_A278EMPW_USU[0], A278EMPW_USU) == 0 ) )
            {
               A279EMPW_EMP = T000I8_A279EMPW_EMP[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
               RcdFound19 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0I19( ) ;
         if ( RcdFound19 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "EMPW_USU");
               AnyError = 1 ;
               GX_FocusControl = edtEMPW_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A278EMPW_USU, Z278EMPW_USU) != 0 ) || ( A279EMPW_EMP != Z279EMPW_EMP ) )
            {
               A279EMPW_EMP = Z279EMPW_EMP ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "EMPW_USU");
               AnyError = 1 ;
               GX_FocusControl = edtEMPW_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtEMPW_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0I19( ) ;
               GX_FocusControl = edtEMPW_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A278EMPW_USU, Z278EMPW_USU) != 0 ) || ( A279EMPW_EMP != Z279EMPW_EMP ) )
            {
               /* Insert record */
               Insert0I19( ) ;
               GX_FocusControl = edtEMPW_EMP_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "EMPW_USU");
                  AnyError = 1 ;
                  GX_FocusControl = edtEMPW_EMP_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0I19( ) ;
                  GX_FocusControl = edtEMPW_EMP_Internalname ;
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
         if ( ( StringUtil.StrCmp(A278EMPW_USU, Z278EMPW_USU) != 0 ) || ( A279EMPW_EMP != Z279EMPW_EMP ) )
         {
            A279EMPW_EMP = Z279EMPW_EMP ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "EMPW_USU");
            AnyError = 1 ;
            GX_FocusControl = edtEMPW_EMP_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEMPW_EMP_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000I9 */
            pr_default.execute(7, new Object[] {A278EMPW_USU, A279EMPW_EMP});
            if ( (pr_default.getStatus(7) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPW000"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(7) == 101) || ( StringUtil.StrCmp(Z281EMPW_EMD, T000I9_A281EMPW_EMD[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EMPW000"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I19( 0) ;
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I10 */
                     pr_default.execute(8, new Object[] {A279EMPW_EMP, A281EMPW_EMD, A278EMPW_USU});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 1) )
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
                           ResetCaption0I0( ) ;
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
               Load0I19( ) ;
            }
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void Update0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I11 */
                     pr_default.execute(9, new Object[] {A281EMPW_EMD, A278EMPW_USU, A279EMPW_EMP});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMPW000"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0I19( ) ;
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
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void DeferredUpdate0I19( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I19( ) ;
            AfterConfirm0I19( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I19( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000I12 */
                  pr_default.execute(10, new Object[] {A278EMPW_USU, A279EMPW_EMP});
                  pr_default.close(10);
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
         sMode19 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0I19( ) ;
         Gx_mode = sMode19 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0I19( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(7);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(6);
            pr_default.close(5);
            context.CommitDataStores("EMPW000");
            if ( AnyError == 0 )
            {
               ConfirmValues0I0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(6);
            pr_default.close(5);
            context.RollbackDataStores("EMPW000");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0I19( )
      {
         /* Using cursor T000I13 */
         pr_default.execute(11, new Object[] {A278EMPW_USU});
         RcdFound19 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound19 = 1 ;
            A279EMPW_EMP = T000I13_A279EMPW_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0I19( )
      {
         pr_default.readNext(11);
         RcdFound19 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound19 = 1 ;
            A279EMPW_EMP = T000I13_A279EMPW_EMP[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
         }
      }

      protected void ScanEnd0I19( )
      {
      }

      protected void AfterConfirm0I19( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I19( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0I19( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0I19( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I19( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I19( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0I0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("empw000.aspx") + "?" + UrlEncode(StringUtil.RTrim(A278EMPW_USU)) + "," + UrlEncode("" +AV7EMPW_EMP) + "," + UrlEncode(StringUtil.RTrim(Gx_mode))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z278EMPW_USU", StringUtil.RTrim( Z278EMPW_USU));
         GxWebStd.gx_hidden_field( context, "Z279EMPW_EMP", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z279EMPW_EMP), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z281EMPW_EMD", StringUtil.RTrim( Z281EMPW_EMD));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vEMPW_EMP", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EMPW_EMP), 8, 0, ",", "")));
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
         return "EMPW000" ;
      }

      public override String GetPgmdesc( )
      {
         return "Empresas con Acceso WEB" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("empw000.aspx") + "?" + UrlEncode(StringUtil.RTrim(A278EMPW_USU)) + "," + UrlEncode("" +AV7EMPW_EMP) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) ;
      }

      protected void InitializeNonKey0I19( )
      {
         A281EMPW_EMD = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A281EMPW_EMD", A281EMPW_EMD);
      }

      protected void InitAll0I19( )
      {
         A279EMPW_EMP = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A279EMPW_EMP", StringUtil.LTrim( StringUtil.Str( (decimal)(A279EMPW_EMP), 8, 0)));
         InitializeNonKey0I19( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1183918");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("empw000.js", "?1183918");
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
         lblTextblockempw_usu_Internalname = "TEXTBLOCKEMPW_USU" ;
         edtEMPW_USU_Internalname = "EMPW_USU" ;
         lblTextblockempw_usd_Internalname = "TEXTBLOCKEMPW_USD" ;
         edtEMPW_USD_Internalname = "EMPW_USD" ;
         lblTextblockempw_emp_Internalname = "TEXTBLOCKEMPW_EMP" ;
         edtEMPW_EMP_Internalname = "EMPW_EMP" ;
         lblTextblockempw_emd_Internalname = "TEXTBLOCKEMPW_EMD" ;
         edtEMPW_EMD_Internalname = "EMPW_EMD" ;
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
         Form.Caption = "Empresas con Acceso WEB" ;
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
         edtEMPW_EMD_Jsonclick = "" ;
         edtEMPW_EMD_Enabled = 1 ;
         edtEMPW_EMP_Jsonclick = "" ;
         edtEMPW_EMP_Enabled = 1 ;
         edtEMPW_USD_Jsonclick = "" ;
         edtEMPW_USD_Enabled = 0 ;
         edtEMPW_USU_Jsonclick = "" ;
         edtEMPW_USU_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
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
         pr_default.close(6);
         pr_default.close(5);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOA278EMPW_USU = "" ;
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
         lblTextblockempw_usu_Jsonclick = "" ;
         lblTextblockempw_usd_Jsonclick = "" ;
         A283EMPW_USD = "" ;
         lblTextblockempw_emp_Jsonclick = "" ;
         lblTextblockempw_emd_Jsonclick = "" ;
         A281EMPW_EMD = "" ;
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
         Z278EMPW_USU = "" ;
         Z281EMPW_EMD = "" ;
         sMode19 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z283EMPW_USD = "" ;
         T000I4_A283EMPW_USD = new String[] {""} ;
         T000I4_n283EMPW_USD = new bool[] {false} ;
         T000I5_A279EMPW_EMP = new int[1] ;
         T000I5_A283EMPW_USD = new String[] {""} ;
         T000I5_n283EMPW_USD = new bool[] {false} ;
         T000I5_A281EMPW_EMD = new String[] {""} ;
         T000I5_A278EMPW_USU = new String[] {""} ;
         T000I6_A278EMPW_USU = new String[] {""} ;
         T000I6_A279EMPW_EMP = new int[1] ;
         T000I3_A279EMPW_EMP = new int[1] ;
         T000I3_A281EMPW_EMD = new String[] {""} ;
         T000I3_A278EMPW_USU = new String[] {""} ;
         T000I7_A278EMPW_USU = new String[] {""} ;
         T000I7_A279EMPW_EMP = new int[1] ;
         T000I8_A278EMPW_USU = new String[] {""} ;
         T000I8_A279EMPW_EMP = new int[1] ;
         T000I9_A279EMPW_EMP = new int[1] ;
         T000I9_A281EMPW_EMD = new String[] {""} ;
         T000I9_A278EMPW_USU = new String[] {""} ;
         T000I13_A278EMPW_USU = new String[] {""} ;
         T000I13_A279EMPW_EMP = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.empw000__default(),
            new Object[][] {
                new Object[] {
               T000I2_A279EMPW_EMP, T000I2_A281EMPW_EMD, T000I2_A278EMPW_USU
               }
               , new Object[] {
               T000I3_A279EMPW_EMP, T000I3_A281EMPW_EMD, T000I3_A278EMPW_USU
               }
               , new Object[] {
               T000I4_A283EMPW_USD, T000I4_n283EMPW_USD
               }
               , new Object[] {
               T000I5_A279EMPW_EMP, T000I5_A283EMPW_USD, T000I5_n283EMPW_USD, T000I5_A281EMPW_EMD, T000I5_A278EMPW_USU
               }
               , new Object[] {
               T000I6_A278EMPW_USU, T000I6_A279EMPW_EMP
               }
               , new Object[] {
               T000I7_A278EMPW_USU, T000I7_A279EMPW_EMP
               }
               , new Object[] {
               T000I8_A278EMPW_USU, T000I8_A279EMPW_EMP
               }
               , new Object[] {
               T000I9_A279EMPW_EMP, T000I9_A281EMPW_EMD, T000I9_A278EMPW_USU
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000I13_A278EMPW_USU, T000I13_A279EMPW_EMP
               }
            }
         );
         Z278EMPW_USU = "" ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound19 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7EMPW_EMP ;
      private int AV7EMPW_EMP ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtEMPW_USU_Enabled ;
      private int edtEMPW_USD_Enabled ;
      private int A279EMPW_EMP ;
      private int edtEMPW_EMP_Enabled ;
      private int edtEMPW_EMD_Enabled ;
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
      private int Z279EMPW_EMP ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOA278EMPW_USU ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A278EMPW_USU ;
      private String Gx_mode ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEMPW_EMP_Internalname ;
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
      private String lblTextblockempw_usu_Internalname ;
      private String lblTextblockempw_usu_Jsonclick ;
      private String edtEMPW_USU_Internalname ;
      private String edtEMPW_USU_Jsonclick ;
      private String lblTextblockempw_usd_Internalname ;
      private String lblTextblockempw_usd_Jsonclick ;
      private String edtEMPW_USD_Internalname ;
      private String A283EMPW_USD ;
      private String edtEMPW_USD_Jsonclick ;
      private String lblTextblockempw_emp_Internalname ;
      private String lblTextblockempw_emp_Jsonclick ;
      private String edtEMPW_EMP_Jsonclick ;
      private String lblTextblockempw_emd_Internalname ;
      private String lblTextblockempw_emd_Jsonclick ;
      private String edtEMPW_EMD_Internalname ;
      private String A281EMPW_EMD ;
      private String edtEMPW_EMD_Jsonclick ;
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
      private String Z278EMPW_USU ;
      private String Z281EMPW_EMD ;
      private String sMode19 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z283EMPW_USD ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n283EMPW_USD ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_EMPW_USU ;
      private int aP1_EMPW_EMP ;
      private String aP2_Gx_mode ;
      private IDataStoreProvider pr_default ;
      private String[] T000I4_A283EMPW_USD ;
      private bool[] T000I4_n283EMPW_USD ;
      private int[] T000I5_A279EMPW_EMP ;
      private String[] T000I5_A283EMPW_USD ;
      private bool[] T000I5_n283EMPW_USD ;
      private String[] T000I5_A281EMPW_EMD ;
      private String[] T000I5_A278EMPW_USU ;
      private String[] T000I6_A278EMPW_USU ;
      private int[] T000I6_A279EMPW_EMP ;
      private int[] T000I3_A279EMPW_EMP ;
      private String[] T000I3_A281EMPW_EMD ;
      private String[] T000I3_A278EMPW_USU ;
      private String[] T000I7_A278EMPW_USU ;
      private int[] T000I7_A279EMPW_EMP ;
      private String[] T000I8_A278EMPW_USU ;
      private int[] T000I8_A279EMPW_EMP ;
      private int[] T000I9_A279EMPW_EMP ;
      private String[] T000I9_A281EMPW_EMD ;
      private String[] T000I9_A278EMPW_USU ;
      private String[] T000I13_A278EMPW_USU ;
      private int[] T000I13_A279EMPW_EMP ;
      private int[] T000I2_A279EMPW_EMP ;
      private String[] T000I2_A281EMPW_EMD ;
      private String[] T000I2_A278EMPW_USU ;
      private GXWebForm Form ;
   }

   public class empw000__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
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
          Object[] prmT000I2 ;
          prmT000I2 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I4 ;
          prmT000I4 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000I5 ;
          prmT000I5 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I6 ;
          prmT000I6 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I3 ;
          prmT000I3 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I7 ;
          prmT000I7 = new Object[] {
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0} ,
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000I8 ;
          prmT000I8 = new Object[] {
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0} ,
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000I9 ;
          prmT000I9 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I10 ;
          prmT000I10 = new Object[] {
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0} ,
          new Object[] {"@EMPW_EMD",SqlDbType.Char,50,0} ,
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0}
          } ;
          Object[] prmT000I11 ;
          prmT000I11 = new Object[] {
          new Object[] {"@EMPW_EMD",SqlDbType.Char,50,0} ,
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I12 ;
          prmT000I12 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0} ,
          new Object[] {"@EMPW_EMP",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000I13 ;
          prmT000I13 = new Object[] {
          new Object[] {"@EMPW_USU",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000I2", "SELECT [EMPW_EMP], [EMPW_EMD], [EMPW_USU] AS EMPW_USU FROM [EMPW000] WITH (UPDLOCK) WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I2,1,0,true,false )
             ,new CursorDef("T000I3", "SELECT [EMPW_EMP], [EMPW_EMD], [EMPW_USU] AS EMPW_USU FROM [EMPW000] WITH (NOLOCK) WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I3,1,0,true,false )
             ,new CursorDef("T000I4", "SELECT [USU_DES] AS EMPW_USD FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @EMPW_USU ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I4,1,0,true,false )
             ,new CursorDef("T000I5", "SELECT TM1.[EMPW_EMP], T2.[USU_DES] AS EMPW_USD, TM1.[EMPW_EMD], TM1.[EMPW_USU] AS EMPW_USU FROM ([EMPW000] TM1 WITH (NOLOCK) INNER JOIN [SEG002] T2 WITH (NOLOCK) ON T2.[USU_COD] = TM1.[EMPW_USU]) WHERE TM1.[EMPW_USU] = @EMPW_USU and TM1.[EMPW_EMP] = @EMPW_EMP ORDER BY TM1.[EMPW_USU], TM1.[EMPW_EMP]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I5,100,0,true,false )
             ,new CursorDef("T000I6", "SELECT [EMPW_USU] AS EMPW_USU, [EMPW_EMP] FROM [EMPW000] WITH (NOLOCK) WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I6,1,0,true,false )
             ,new CursorDef("T000I7", "SELECT TOP 1 [EMPW_USU] AS EMPW_USU, [EMPW_EMP] FROM [EMPW000] WITH (NOLOCK) WHERE ( [EMPW_EMP] > @EMPW_EMP) and [EMPW_USU] = @EMPW_USU ORDER BY [EMPW_USU], [EMPW_EMP]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I7,1,0,true,true )
             ,new CursorDef("T000I8", "SELECT TOP 1 [EMPW_USU] AS EMPW_USU, [EMPW_EMP] FROM [EMPW000] WITH (NOLOCK) WHERE ( [EMPW_EMP] < @EMPW_EMP) and [EMPW_USU] = @EMPW_USU ORDER BY [EMPW_USU] DESC, [EMPW_EMP] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I8,1,0,true,true )
             ,new CursorDef("T000I9", "SELECT [EMPW_EMP], [EMPW_EMD], [EMPW_USU] AS EMPW_USU FROM [EMPW000] WITH (UPDLOCK) WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I9,1,0,true,false )
             ,new CursorDef("T000I10", "INSERT INTO [EMPW000] ([EMPW_EMP], [EMPW_EMD], [EMPW_USU]) VALUES (@EMPW_EMP, @EMPW_EMD, @EMPW_USU)", GxErrorMask.GX_NOMASK,prmT000I10)
             ,new CursorDef("T000I11", "UPDATE [EMPW000] SET [EMPW_EMD]=@EMPW_EMD  WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP", GxErrorMask.GX_NOMASK,prmT000I11)
             ,new CursorDef("T000I12", "DELETE FROM [EMPW000]  WHERE [EMPW_USU] = @EMPW_USU AND [EMPW_EMP] = @EMPW_EMP", GxErrorMask.GX_NOMASK,prmT000I12)
             ,new CursorDef("T000I13", "SELECT [EMPW_USU] AS EMPW_USU, [EMPW_EMP] FROM [EMPW000] WITH (NOLOCK) WHERE [EMPW_USU] = @EMPW_USU ORDER BY [EMPW_USU], [EMPW_EMP]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I13,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[4])[0] = rslt.getString(4, 16) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                break;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
