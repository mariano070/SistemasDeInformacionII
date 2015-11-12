/*
               File: EMP_GST
        Description: EMP_ GST
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/2/2014 19:17:13.6
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
   public class emp_gst : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
         {
            A297GstEmpCod = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_10( A297GstEmpCod) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A297GstEmpCod = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_11( A297GstEmpCod) ;
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
               AV7EmpGstCod = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7EmpGstCod), 8, 0)));
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "EMP_ GST", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEmpGstCod_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("GeneXusX");
      }

      public emp_gst( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("GeneXusX");
      }

      public emp_gst( IGxContext context )
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
                           int aP1_EmpGstCod )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7EmpGstCod = aP1_EmpGstCod;
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
            wb_table1_2_0M22( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0M22e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0M22( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0M22( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0M22e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"EMP_ GST"+"</legend>") ;
            wb_table3_27_0M22( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0M22e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0M22e( true) ;
         }
         else
         {
            wb_table1_2_0M22e( false) ;
         }
      }

      protected void wb_table3_27_0M22( bool wbgen )
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
            wb_table4_33_0M22( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0M22e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_EMP_GST.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_EMP_GST.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 0, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0M22e( true) ;
         }
         else
         {
            wb_table3_27_0M22e( false) ;
         }
      }

      protected void wb_table4_33_0M22( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:25px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempgstcod_Internalname, 1, 1, 0, "Cod Empresa", "", "", "", 0, lblTextblockempgstcod_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEmpGstCod_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A291EmpGstCod), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtEmpGstCod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A291EmpGstCod), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtEmpGstCod_Jsonclick, "", 0, 1, -1, true, "right", "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockempgstdes_Internalname, 1, 1, 0, "Empresa", "", "", "", 0, lblTextblockempgstdes_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtEmpGstDes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A293EmpGstDes), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtEmpGstDes_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A293EmpGstDes), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtEmpGstDes_Jsonclick, "", 0, 1, -1, true, "right", "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\"  style=\"height:23px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgstempcod_Internalname, 1, 1, 0, "Gestor", "", "", "", 0, lblTextblockgstempcod_Jsonclick, "", StyleString, ClassString, "HLP_EMP_GST.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtGstEmpCod_Internalname, StringUtil.RTrim( A297GstEmpCod), "", 15, "chr", 1, "row", 15, 1, edtGstEmpCod_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A297GstEmpCod, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(48);\"", 0, edtGstEmpCod_Jsonclick, "", 0, 1, -1, true, "left", "HLP_EMP_GST.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_297_Internalname, "", "prompt.gif", "GeneXusX", imgprompt_297_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_297_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_EMP_GST.htm");
            context.WriteHtmlText( "&nbsp;") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0M22e( true) ;
         }
         else
         {
            wb_table4_33_0M22e( false) ;
         }
      }

      protected void wb_table2_5_0M22( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "GeneXusX"), "GeneXusX", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "GeneXusX"), "GeneXusX", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "GeneXusX"), "GeneXusX", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "GeneXusX"), "GeneXusX", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "GeneXusX"), "GeneXusX", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "GeneXusX"), "GeneXusX", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_EMP_GST.htm");
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
            wb_table2_5_0M22e( true) ;
         }
         else
         {
            wb_table2_5_0M22e( false) ;
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
         /* Execute user event: E110M2 */
         E110M2 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtEmpGstCod_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtEmpGstCod_Internalname), ",", ".") < Convert.ToDecimal( -9999999 )) || ( ( context.localUtil.CToN( cgiGet( edtEmpGstCod_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "EMPGSTCOD");
                  AnyError = 1 ;
                  GX_FocusControl = edtEmpGstCod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A291EmpGstCod = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               }
               else
               {
                  A291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( edtEmpGstCod_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtEmpGstDes_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtEmpGstDes_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtEmpGstDes_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "EMPGSTDES");
                  AnyError = 1 ;
                  GX_FocusControl = edtEmpGstDes_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A293EmpGstDes = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
               }
               else
               {
                  A293EmpGstDes = (short)(context.localUtil.CToN( cgiGet( edtEmpGstDes_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
               }
               A297GstEmpCod = StringUtil.Upper( cgiGet( edtGstEmpCod_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
               /* Read saved values. */
               Z291EmpGstCod = (int)(context.localUtil.CToN( cgiGet( "Z291EmpGstCod"), ",", ".")) ;
               Z293EmpGstDes = (short)(context.localUtil.CToN( cgiGet( "Z293EmpGstDes"), ",", ".")) ;
               Z295EmpGstGpoCod = (short)(context.localUtil.CToN( cgiGet( "Z295EmpGstGpoCod"), ",", ".")) ;
               Z297GstEmpCod = cgiGet( "Z297GstEmpCod") ;
               A295EmpGstGpoCod = (short)(context.localUtil.CToN( cgiGet( "Z295EmpGstGpoCod"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               N297GstEmpCod = cgiGet( "N297GstEmpCod") ;
               AV7EmpGstCod = (int)(context.localUtil.CToN( cgiGet( "vEMPGSTCOD"), ",", ".")) ;
               AV12Insert_GstEmpCod = cgiGet( "vINSERT_GSTEMPCOD") ;
               A295EmpGstGpoCod = (short)(context.localUtil.CToN( cgiGet( "EMPGSTGPOCOD"), ",", ".")) ;
               A298GstEmpDes = cgiGet( "GSTEMPDES") ;
               n298GstEmpDes = false ;
               AV15Pgmname = cgiGet( "vPGMNAME") ;
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
                  A291EmpGstCod = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
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
                     sMode22 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode22 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound22 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0M0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "EMPGSTCOD");
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
                           /* Execute user event: E110M2 */
                           E110M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E120M2 */
                           E120M2 ();
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
            /* Execute user event: E120M2 */
            E120M2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0M22( ) ;
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
            edtEmpGstCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpGstCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpGstCod_Enabled), 5, 0)));
            edtEmpGstDes_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpGstDes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpGstDes_Enabled), 5, 0)));
            edtGstEmpCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGstEmpCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGstEmpCod_Enabled), 5, 0)));
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

      protected void CONFIRM_0M0( )
      {
         BeforeValidate0M22( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0M22( ) ;
            }
            else
            {
               CheckExtendedTable0M22( ) ;
               CloseExtendedTableCursors0M22( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption0M0( )
      {
      }

      protected void E110M2( )
      {
         /* Start Routine */
         new isauthorized(context ).execute(  AV15Pgmname, out  AV9IsAuthorized) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", StringUtil.BoolToStr( AV9IsAuthorized));
         if ( ! AV9IsAuthorized )
         {
            context.wjLoc = formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)) ;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), "");
         AV12Insert_GstEmpCod = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_GstEmpCod", AV12Insert_GstEmpCod);
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            while ( AV16GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((SdtTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV16GXV1)) ;
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "GstEmpCod") == 0 )
               {
                  AV12Insert_GstEmpCod = AV13TrnContextAtt.gxTpr_Attributevalue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_GstEmpCod", AV12Insert_GstEmpCod);
               }
               AV16GXV1 = (int)(AV16GXV1+1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
      }

      protected void E120M2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            context.wjLoc = formatLink("wwemp_gst.aspx")  ;
         }
         context.setWebReturnParms(new Object[] {});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0M22( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z293EmpGstDes = T000M3_A293EmpGstDes[0] ;
               Z295EmpGstGpoCod = T000M3_A295EmpGstGpoCod[0] ;
               Z297GstEmpCod = T000M3_A297GstEmpCod[0] ;
            }
            else
            {
               Z293EmpGstDes = A293EmpGstDes ;
               Z295EmpGstGpoCod = A295EmpGstGpoCod ;
               Z297GstEmpCod = A297GstEmpCod ;
            }
         }
         if ( GX_JID == -9 )
         {
            Z291EmpGstCod = A291EmpGstCod ;
            Z293EmpGstDes = A293EmpGstDes ;
            Z295EmpGstGpoCod = A295EmpGstGpoCod ;
            Z297GstEmpCod = A297GstEmpCod ;
            Z298GstEmpDes = A298GstEmpDes ;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_297_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00h0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"GSTEMPCOD"+"'), id:'"+"GSTEMPCOD"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");") ;
         imgBtn_delete2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         if ( ! (0==AV7EmpGstCod) )
         {
            A291EmpGstCod = AV7EmpGstCod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         }
         if ( ! (0==AV7EmpGstCod) )
         {
            edtEmpGstCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpGstCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpGstCod_Enabled), 5, 0)));
         }
         else
         {
            edtEmpGstCod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpGstCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpGstCod_Enabled), 5, 0)));
         }
         if ( ! (0==AV7EmpGstCod) )
         {
            edtEmpGstCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmpGstCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmpGstCod_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV12Insert_GstEmpCod)) )
         {
            edtGstEmpCod_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGstEmpCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGstEmpCod_Enabled), 5, 0)));
         }
         else
         {
            edtGstEmpCod_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGstEmpCod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGstEmpCod_Enabled), 5, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV12Insert_GstEmpCod)) )
         {
            A297GstEmpCod = AV12Insert_GstEmpCod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
         }
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
            AV15Pgmname = "EMP_GST" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000M5 */
            pr_default.execute(3, new Object[] {A297GstEmpCod});
            A298GstEmpDes = T000M5_A298GstEmpDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
            n298GstEmpDes = T000M5_n298GstEmpDes[0] ;
            pr_default.close(3);
         }
      }

      protected void Load0M22( )
      {
         /* Using cursor T000M6 */
         pr_default.execute(4, new Object[] {A291EmpGstCod});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound22 = 1 ;
            A293EmpGstDes = T000M6_A293EmpGstDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
            A295EmpGstGpoCod = T000M6_A295EmpGstGpoCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
            A298GstEmpDes = T000M6_A298GstEmpDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
            n298GstEmpDes = T000M6_n298GstEmpDes[0] ;
            A297GstEmpCod = T000M6_A297GstEmpCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
            ZM0M22( -9) ;
         }
         pr_default.close(4);
         OnLoadActions0M22( ) ;
      }

      protected void OnLoadActions0M22( )
      {
         AV15Pgmname = "EMP_GST" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0M22( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         AV15Pgmname = "EMP_GST" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T000M4 */
         pr_default.execute(2, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(2);
         /* Using cursor T000M5 */
         pr_default.execute(3, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A298GstEmpDes = T000M5_A298GstEmpDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
            n298GstEmpDes = T000M5_n298GstEmpDes[0] ;
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0M22( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_10( String A297GstEmpCod )
      {
         /* Using cursor T000M7 */
         pr_default.execute(5, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(5);
      }

      protected void gxLoad_11( String A297GstEmpCod )
      {
         /* Using cursor T000M8 */
         pr_default.execute(6, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError == 0 )
         {
            A298GstEmpDes = T000M8_A298GstEmpDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
            n298GstEmpDes = T000M8_n298GstEmpDes[0] ;
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A298GstEmpDes))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(6);
      }

      protected void GetKey0M22( )
      {
         /* Using cursor T000M9 */
         pr_default.execute(7, new Object[] {A291EmpGstCod});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound22 = 1 ;
         }
         else
         {
            RcdFound22 = 0 ;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000M3 */
         pr_default.execute(1, new Object[] {A291EmpGstCod});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0M22( 9) ;
            RcdFound22 = 1 ;
            A291EmpGstCod = T000M3_A291EmpGstCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
            A293EmpGstDes = T000M3_A293EmpGstDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
            A295EmpGstGpoCod = T000M3_A295EmpGstGpoCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
            A297GstEmpCod = T000M3_A297GstEmpCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
            Z291EmpGstCod = A291EmpGstCod ;
            sMode22 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load0M22( ) ;
            Gx_mode = sMode22 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound22 = 0 ;
            InitializeNonKey0M22( ) ;
            sMode22 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode22 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0M22( ) ;
         if ( RcdFound22 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound22 = 0 ;
         /* Using cursor T000M10 */
         pr_default.execute(8, new Object[] {A291EmpGstCod});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000M10_A291EmpGstCod[0] < A291EmpGstCod ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000M10_A291EmpGstCod[0] > A291EmpGstCod ) ) )
            {
               A291EmpGstCod = T000M10_A291EmpGstCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               RcdFound22 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound22 = 0 ;
         /* Using cursor T000M11 */
         pr_default.execute(9, new Object[] {A291EmpGstCod});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000M11_A291EmpGstCod[0] > A291EmpGstCod ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000M11_A291EmpGstCod[0] < A291EmpGstCod ) ) )
            {
               A291EmpGstCod = T000M11_A291EmpGstCod[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               RcdFound22 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0M22( ) ;
         if ( RcdFound22 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "EMPGSTCOD");
               AnyError = 1 ;
               GX_FocusControl = edtEmpGstCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A291EmpGstCod != Z291EmpGstCod )
            {
               A291EmpGstCod = Z291EmpGstCod ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "EMPGSTCOD");
               AnyError = 1 ;
               GX_FocusControl = edtEmpGstCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtEmpGstCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update0M22( ) ;
               GX_FocusControl = edtEmpGstCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A291EmpGstCod != Z291EmpGstCod )
            {
               /* Insert record */
               Insert0M22( ) ;
               GX_FocusControl = edtEmpGstCod_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "EMPGSTCOD");
                  AnyError = 1 ;
                  GX_FocusControl = edtEmpGstCod_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert0M22( ) ;
                  GX_FocusControl = edtEmpGstCod_Internalname ;
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
         if ( A291EmpGstCod != Z291EmpGstCod )
         {
            A291EmpGstCod = Z291EmpGstCod ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "EMPGSTCOD");
            AnyError = 1 ;
            GX_FocusControl = edtEmpGstCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEmpGstCod_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0M22( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000M12 */
            pr_default.execute(10, new Object[] {A291EmpGstCod});
            if ( (pr_default.getStatus(10) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMP_GST"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(10) == 101) || ( Z293EmpGstDes != T000M12_A293EmpGstDes[0] ) || ( Z295EmpGstGpoCod != T000M12_A295EmpGstGpoCod[0] ) || ( StringUtil.StrCmp(Z297GstEmpCod, T000M12_A297GstEmpCod[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EMP_GST"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0M22( )
      {
         BeforeValidate0M22( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M22( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0M22( 0) ;
            CheckOptimisticConcurrency0M22( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M22( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0M22( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M13 */
                     pr_default.execute(11, new Object[] {A291EmpGstCod, A293EmpGstDes, A295EmpGstGpoCod, A297GstEmpCod});
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
                           ResetCaption0M0( ) ;
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
               Load0M22( ) ;
            }
            EndLevel0M22( ) ;
         }
         CloseExtendedTableCursors0M22( ) ;
      }

      protected void Update0M22( )
      {
         BeforeValidate0M22( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M22( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M22( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M22( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0M22( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M14 */
                     pr_default.execute(12, new Object[] {A293EmpGstDes, A295EmpGstGpoCod, A297GstEmpCod, A291EmpGstCod});
                     pr_default.close(12);
                     if ( (pr_default.getStatus(12) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EMP_GST"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0M22( ) ;
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
            EndLevel0M22( ) ;
         }
         CloseExtendedTableCursors0M22( ) ;
      }

      protected void DeferredUpdate0M22( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0M22( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M22( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0M22( ) ;
            AfterConfirm0M22( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0M22( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000M15 */
                  pr_default.execute(13, new Object[] {A291EmpGstCod});
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
         sMode22 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0M22( ) ;
         Gx_mode = sMode22 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0M22( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "EMP_GST" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000M16 */
            pr_default.execute(14, new Object[] {A297GstEmpCod});
            A298GstEmpDes = T000M16_A298GstEmpDes[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
            n298GstEmpDes = T000M16_n298GstEmpDes[0] ;
            pr_default.close(14);
         }
      }

      protected void EndLevel0M22( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0M22( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(9);
            pr_default.close(8);
            pr_default.close(14);
            context.CommitDataStores("EMP_GST");
            if ( AnyError == 0 )
            {
               ConfirmValues0M0( ) ;
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
            context.RollbackDataStores("EMP_GST");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0M22( )
      {
         /* Using cursor T000M17 */
         pr_default.execute(15);
         RcdFound22 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound22 = 1 ;
            A291EmpGstCod = T000M17_A291EmpGstCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0M22( )
      {
         pr_default.readNext(15);
         RcdFound22 = 0 ;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound22 = 1 ;
            A291EmpGstCod = T000M17_A291EmpGstCod[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         }
      }

      protected void ScanEnd0M22( )
      {
      }

      protected void AfterConfirm0M22( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0M22( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0M22( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0M22( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0M22( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0M22( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0M0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpGstCod)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z291EmpGstCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z291EmpGstCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z293EmpGstDes", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z293EmpGstDes), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z295EmpGstGpoCod", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z295EmpGstGpoCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z297GstEmpCod", StringUtil.RTrim( Z297GstEmpCod));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "N297GstEmpCod", StringUtil.RTrim( A297GstEmpCod));
         GxWebStd.gx_hidden_field( context, "vEMPGSTCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7EmpGstCod), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_GSTEMPCOD", StringUtil.RTrim( AV12Insert_GstEmpCod));
         GxWebStd.gx_hidden_field( context, "EMPGSTGPOCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A295EmpGstGpoCod), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GSTEMPDES", StringUtil.RTrim( A298GstEmpDes));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
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
         return "EMP_GST" ;
      }

      public override String GetPgmdesc( )
      {
         return "EMP_ GST" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("emp_gst.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7EmpGstCod) ;
      }

      protected void InitializeNonKey0M22( )
      {
         A297GstEmpCod = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A297GstEmpCod", A297GstEmpCod);
         A293EmpGstDes = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293EmpGstDes", StringUtil.LTrim( StringUtil.Str( (decimal)(A293EmpGstDes), 4, 0)));
         A295EmpGstGpoCod = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295EmpGstGpoCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A295EmpGstGpoCod), 4, 0)));
         A298GstEmpDes = "" ;
         n298GstEmpDes = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A298GstEmpDes", A298GstEmpDes);
      }

      protected void InitAll0M22( )
      {
         A291EmpGstCod = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291EmpGstCod", StringUtil.LTrim( StringUtil.Str( (decimal)(A291EmpGstCod), 8, 0)));
         InitializeNonKey0M22( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "GeneXusX.css", "?191514");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19171424");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("emp_gst.js", "?19171424");
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
         lblTextblockempgstcod_Internalname = "TEXTBLOCKEMPGSTCOD" ;
         edtEmpGstCod_Internalname = "EMPGSTCOD" ;
         lblTextblockempgstdes_Internalname = "TEXTBLOCKEMPGSTDES" ;
         edtEmpGstDes_Internalname = "EMPGSTDES" ;
         lblTextblockgstempcod_Internalname = "TEXTBLOCKGSTEMPCOD" ;
         edtGstEmpCod_Internalname = "GSTEMPCOD" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         imgprompt_297_Internalname = "PROMPT_297" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "EMP_ GST" ;
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
         imgprompt_297_Visible = 1 ;
         imgprompt_297_Link = "" ;
         edtGstEmpCod_Jsonclick = "" ;
         edtGstEmpCod_Enabled = 1 ;
         edtEmpGstDes_Jsonclick = "" ;
         edtEmpGstDes_Enabled = 1 ;
         edtEmpGstCod_Jsonclick = "" ;
         edtEmpGstCod_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      public void Valid_Gstempcod( String GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A297GstEmpCod = GX_Parm1 ;
         A298GstEmpDes = GX_Parm2 ;
         n298GstEmpDes = false ;
         /* Using cursor T000M18 */
         pr_default.execute(16, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(16);
         /* Using cursor T000M16 */
         pr_default.execute(14, new Object[] {A297GstEmpCod});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No existe 'GST_ EMP'.", "ForeignKeyNotFound", 1, "GSTEMPCOD");
            AnyError = 1 ;
            GX_FocusControl = edtGstEmpCod_Internalname ;
         }
         if ( AnyError == 0 )
         {
            A298GstEmpDes = T000M16_A298GstEmpDes[0] ;
            n298GstEmpDes = T000M16_n298GstEmpDes[0] ;
         }
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A298GstEmpDes = "" ;
            n298GstEmpDes = false ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A298GstEmpDes)));
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
         pr_default.close(15);
         pr_default.close(9);
         pr_default.close(8);
         pr_default.close(16);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A297GstEmpCod = "" ;
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
         lblTextblockempgstcod_Jsonclick = "" ;
         lblTextblockempgstdes_Jsonclick = "" ;
         lblTextblockgstempcod_Jsonclick = "" ;
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
         Z297GstEmpCod = "" ;
         N297GstEmpCod = "" ;
         AV12Insert_GstEmpCod = "" ;
         A298GstEmpDes = "" ;
         AV15Pgmname = "" ;
         sMode22 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV10TrnContext = new SdtTransactionContext(context);
         AV11WebSession = new GxWebSession( context);
         AV13TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z298GstEmpDes = "" ;
         T000M5_A298GstEmpDes = new String[] {""} ;
         T000M5_n298GstEmpDes = new bool[] {false} ;
         T000M6_A291EmpGstCod = new int[1] ;
         T000M6_A293EmpGstDes = new short[1] ;
         T000M6_A295EmpGstGpoCod = new short[1] ;
         T000M6_A298GstEmpDes = new String[] {""} ;
         T000M6_n298GstEmpDes = new bool[] {false} ;
         T000M6_A297GstEmpCod = new String[] {""} ;
         T000M4_A297GstEmpCod = new String[] {""} ;
         T000M7_A297GstEmpCod = new String[] {""} ;
         T000M8_A298GstEmpDes = new String[] {""} ;
         T000M8_n298GstEmpDes = new bool[] {false} ;
         T000M9_A291EmpGstCod = new int[1] ;
         T000M3_A291EmpGstCod = new int[1] ;
         T000M3_A293EmpGstDes = new short[1] ;
         T000M3_A295EmpGstGpoCod = new short[1] ;
         T000M3_A297GstEmpCod = new String[] {""} ;
         T000M10_A291EmpGstCod = new int[1] ;
         T000M11_A291EmpGstCod = new int[1] ;
         T000M12_A291EmpGstCod = new int[1] ;
         T000M12_A293EmpGstDes = new short[1] ;
         T000M12_A295EmpGstGpoCod = new short[1] ;
         T000M12_A297GstEmpCod = new String[] {""} ;
         T000M16_A298GstEmpDes = new String[] {""} ;
         T000M16_n298GstEmpDes = new bool[] {false} ;
         T000M17_A291EmpGstCod = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T000M18_A297GstEmpCod = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.emp_gst__default(),
            new Object[][] {
                new Object[] {
               T000M2_A291EmpGstCod, T000M2_A293EmpGstDes, T000M2_A295EmpGstGpoCod, T000M2_A297GstEmpCod
               }
               , new Object[] {
               T000M3_A291EmpGstCod, T000M3_A293EmpGstDes, T000M3_A295EmpGstGpoCod, T000M3_A297GstEmpCod
               }
               , new Object[] {
               T000M4_A297GstEmpCod
               }
               , new Object[] {
               T000M5_A298GstEmpDes, T000M5_n298GstEmpDes
               }
               , new Object[] {
               T000M6_A291EmpGstCod, T000M6_A293EmpGstDes, T000M6_A295EmpGstGpoCod, T000M6_A298GstEmpDes, T000M6_n298GstEmpDes, T000M6_A297GstEmpCod
               }
               , new Object[] {
               T000M7_A297GstEmpCod
               }
               , new Object[] {
               T000M8_A298GstEmpDes, T000M8_n298GstEmpDes
               }
               , new Object[] {
               T000M9_A291EmpGstCod
               }
               , new Object[] {
               T000M10_A291EmpGstCod
               }
               , new Object[] {
               T000M11_A291EmpGstCod
               }
               , new Object[] {
               T000M12_A291EmpGstCod, T000M12_A293EmpGstDes, T000M12_A295EmpGstGpoCod, T000M12_A297GstEmpCod
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000M16_A298GstEmpDes, T000M16_n298GstEmpDes
               }
               , new Object[] {
               T000M17_A291EmpGstCod
               }
               , new Object[] {
               T000M18_A297GstEmpCod
               }
            }
         );
         AV15Pgmname = "EMP_GST" ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A293EmpGstDes ;
      private short Z293EmpGstDes ;
      private short Z295EmpGstGpoCod ;
      private short A295EmpGstGpoCod ;
      private short RcdFound22 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int wcpOAV7EmpGstCod ;
      private int AV7EmpGstCod ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int A291EmpGstCod ;
      private int edtEmpGstCod_Enabled ;
      private int edtEmpGstDes_Enabled ;
      private int edtGstEmpCod_Enabled ;
      private int imgprompt_297_Visible ;
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
      private int Z291EmpGstCod ;
      private int AV16GXV1 ;
      private int idxLst ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String A297GstEmpCod ;
      private String Gx_mode ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEmpGstCod_Internalname ;
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
      private String lblTextblockempgstcod_Internalname ;
      private String lblTextblockempgstcod_Jsonclick ;
      private String edtEmpGstCod_Jsonclick ;
      private String lblTextblockempgstdes_Internalname ;
      private String lblTextblockempgstdes_Jsonclick ;
      private String edtEmpGstDes_Internalname ;
      private String edtEmpGstDes_Jsonclick ;
      private String lblTextblockgstempcod_Internalname ;
      private String lblTextblockgstempcod_Jsonclick ;
      private String edtGstEmpCod_Internalname ;
      private String edtGstEmpCod_Jsonclick ;
      private String imgprompt_297_Internalname ;
      private String imgprompt_297_Link ;
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
      private String Z297GstEmpCod ;
      private String N297GstEmpCod ;
      private String AV12Insert_GstEmpCod ;
      private String A298GstEmpDes ;
      private String AV15Pgmname ;
      private String sMode22 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Z298GstEmpDes ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n298GstEmpDes ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private GxWebSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000M5_A298GstEmpDes ;
      private bool[] T000M5_n298GstEmpDes ;
      private int[] T000M6_A291EmpGstCod ;
      private short[] T000M6_A293EmpGstDes ;
      private short[] T000M6_A295EmpGstGpoCod ;
      private String[] T000M6_A298GstEmpDes ;
      private bool[] T000M6_n298GstEmpDes ;
      private String[] T000M6_A297GstEmpCod ;
      private String[] T000M4_A297GstEmpCod ;
      private String[] T000M7_A297GstEmpCod ;
      private String[] T000M8_A298GstEmpDes ;
      private bool[] T000M8_n298GstEmpDes ;
      private int[] T000M9_A291EmpGstCod ;
      private int[] T000M3_A291EmpGstCod ;
      private short[] T000M3_A293EmpGstDes ;
      private short[] T000M3_A295EmpGstGpoCod ;
      private String[] T000M3_A297GstEmpCod ;
      private int[] T000M10_A291EmpGstCod ;
      private int[] T000M11_A291EmpGstCod ;
      private int[] T000M12_A291EmpGstCod ;
      private short[] T000M12_A293EmpGstDes ;
      private short[] T000M12_A295EmpGstGpoCod ;
      private String[] T000M12_A297GstEmpCod ;
      private String[] T000M16_A298GstEmpDes ;
      private bool[] T000M16_n298GstEmpDes ;
      private int[] T000M17_A291EmpGstCod ;
      private String[] T000M18_A297GstEmpCod ;
      private int[] T000M2_A291EmpGstCod ;
      private short[] T000M2_A293EmpGstDes ;
      private short[] T000M2_A295EmpGstGpoCod ;
      private String[] T000M2_A297GstEmpCod ;
      private GXWebForm Form ;
      private SdtTransactionContext AV10TrnContext ;
      private SdtTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class emp_gst__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000M2 ;
          prmT000M2 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M6 ;
          prmT000M6 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M4 ;
          prmT000M4 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M5 ;
          prmT000M5 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M7 ;
          prmT000M7 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M8 ;
          prmT000M8 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M9 ;
          prmT000M9 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M3 ;
          prmT000M3 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M10 ;
          prmT000M10 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M11 ;
          prmT000M11 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M12 ;
          prmT000M12 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M13 ;
          prmT000M13 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0} ,
          new Object[] {"@EmpGstDes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpGstGpoCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M14 ;
          prmT000M14 = new Object[] {
          new Object[] {"@EmpGstDes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EmpGstGpoCod",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0} ,
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M15 ;
          prmT000M15 = new Object[] {
          new Object[] {"@EmpGstCod",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000M17 ;
          prmT000M17 = new Object[] {
          } ;
          Object[] prmT000M18 ;
          prmT000M18 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          Object[] prmT000M16 ;
          prmT000M16 = new Object[] {
          new Object[] {"@GstEmpCod",SqlDbType.Char,15,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000M2", "SELECT [EmpGstCod], [EmpGstDes], [EmpGstGpoCod], [GstEmpCod] AS GstEmpCod FROM [EMP_GST] WITH (UPDLOCK) WHERE [EmpGstCod] = @EmpGstCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M2,1,0,true,false )
             ,new CursorDef("T000M3", "SELECT [EmpGstCod], [EmpGstDes], [EmpGstGpoCod], [GstEmpCod] AS GstEmpCod FROM [EMP_GST] WITH (NOLOCK) WHERE [EmpGstCod] = @EmpGstCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M3,1,0,true,false )
             ,new CursorDef("T000M4", "SELECT [GestorCod] AS GstEmpCod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M4,1,0,true,false )
             ,new CursorDef("T000M5", "SELECT [USU_DES] AS GstEmpDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M5,1,0,true,false )
             ,new CursorDef("T000M6", "SELECT TM1.[EmpGstCod], TM1.[EmpGstDes], TM1.[EmpGstGpoCod], T3.[USU_DES] AS GstEmpDes, TM1.[GstEmpCod] AS GstEmpCod FROM (([EMP_GST] TM1 WITH (NOLOCK) INNER JOIN [GESTORES] T2 WITH (NOLOCK) ON T2.[GestorCod] = TM1.[GstEmpCod]) INNER JOIN [SEG002] T3 WITH (NOLOCK) ON T3.[USU_COD] = T2.[GestorCod]) WHERE TM1.[EmpGstCod] = @EmpGstCod ORDER BY TM1.[EmpGstCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M6,100,0,true,false )
             ,new CursorDef("T000M7", "SELECT [GestorCod] AS GstEmpCod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M7,1,0,true,false )
             ,new CursorDef("T000M8", "SELECT [USU_DES] AS GstEmpDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M8,1,0,true,false )
             ,new CursorDef("T000M9", "SELECT [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) WHERE [EmpGstCod] = @EmpGstCod  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M9,1,0,true,false )
             ,new CursorDef("T000M10", "SELECT TOP 1 [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) WHERE ( [EmpGstCod] > @EmpGstCod) ORDER BY [EmpGstCod]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M10,1,0,true,true )
             ,new CursorDef("T000M11", "SELECT TOP 1 [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) WHERE ( [EmpGstCod] < @EmpGstCod) ORDER BY [EmpGstCod] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M11,1,0,true,true )
             ,new CursorDef("T000M12", "SELECT [EmpGstCod], [EmpGstDes], [EmpGstGpoCod], [GstEmpCod] AS GstEmpCod FROM [EMP_GST] WITH (UPDLOCK) WHERE [EmpGstCod] = @EmpGstCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M12,1,0,true,false )
             ,new CursorDef("T000M13", "INSERT INTO [EMP_GST] ([EmpGstCod], [EmpGstDes], [EmpGstGpoCod], [GstEmpCod]) VALUES (@EmpGstCod, @EmpGstDes, @EmpGstGpoCod, @GstEmpCod)", GxErrorMask.GX_NOMASK,prmT000M13)
             ,new CursorDef("T000M14", "UPDATE [EMP_GST] SET [EmpGstDes]=@EmpGstDes, [EmpGstGpoCod]=@EmpGstGpoCod, [GstEmpCod]=@GstEmpCod  WHERE [EmpGstCod] = @EmpGstCod", GxErrorMask.GX_NOMASK,prmT000M14)
             ,new CursorDef("T000M15", "DELETE FROM [EMP_GST]  WHERE [EmpGstCod] = @EmpGstCod", GxErrorMask.GX_NOMASK,prmT000M15)
             ,new CursorDef("T000M16", "SELECT [USU_DES] AS GstEmpDes FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M16,1,0,true,false )
             ,new CursorDef("T000M17", "SELECT [EmpGstCod] FROM [EMP_GST] WITH (NOLOCK) ORDER BY [EmpGstCod]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M17,100,0,true,false )
             ,new CursorDef("T000M18", "SELECT [GestorCod] AS GstEmpCod FROM [GESTORES] WITH (NOLOCK) WHERE [GestorCod] = @GstEmpCod ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M18,1,0,true,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getString(5, 15) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 9 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                break;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 50) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 15 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 13 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
