/*
               File: THDW_REDES
        Description: Redes de una Ubicación de Hardware
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:33.82
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
   public class thdw_redes : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action14") == 0 )
         {
            A306THDW_UBI_COD_ = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            Gx_mode = GetNextPar( ) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            XC_14_1539( A306THDW_UBI_COD_, Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
         {
            A306THDW_UBI_COD_ = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_34( A306THDW_UBI_COD_) ;
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
            AV7THDW_UBI_COD_ = (long)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7THDW_UBI_COD_), 10, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV10Red_Id = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Red_Id), 10, 0)));
               Gx_mode = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               AV8SISTEMA = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SISTEMA", AV8SISTEMA);
               AV9USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9USUARIO", AV9USUARIO);
            }
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Redes de una Ubicación de Hardware", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtRed_Descripcion_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public thdw_redes( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public thdw_redes( IGxContext context )
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

      public void execute( ref long aP0_THDW_UBI_COD_ ,
                           ref long aP1_Red_Id ,
                           ref String aP2_Gx_mode ,
                           ref String aP3_SISTEMA ,
                           ref String aP4_USUARIO )
      {
         this.AV7THDW_UBI_COD_ = aP0_THDW_UBI_COD_;
         this.AV10Red_Id = aP1_Red_Id;
         this.Gx_mode = aP2_Gx_mode;
         this.AV8SISTEMA = aP3_SISTEMA;
         this.AV9USUARIO = aP4_USUARIO;
         executePrivate();
         aP0_THDW_UBI_COD_=this.AV7THDW_UBI_COD_;
         aP1_Red_Id=this.AV10Red_Id;
         aP2_Gx_mode=this.Gx_mode;
         aP3_SISTEMA=this.AV8SISTEMA;
         aP4_USUARIO=this.AV9USUARIO;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
            wb_table1_2_1539( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1539e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1539( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(270), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(473), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1539( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1539e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Redes de una Ubicación"+"</legend>") ;
            wb_table3_9_1539( true) ;
         }
         return  ;
      }

      protected void wb_table3_9_1539e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1539e( true) ;
         }
         else
         {
            wb_table1_2_1539e( false) ;
         }
      }

      protected void wb_table3_9_1539( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(155), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(457), 10, 0)) + "px" + ";" ;
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
            wb_table4_15_1539( true) ;
         }
         return  ;
      }

      protected void wb_table4_15_1539e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_THDW_REDES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_THDW_REDES.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_9_1539e( true) ;
         }
         else
         {
            wb_table3_9_1539e( false) ;
         }
      }

      protected void wb_table4_15_1539( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockthdw_ubi_cod__Internalname, 1, 1, 0, "Ubicación:", "", "", "", 0, lblTextblockthdw_ubi_cod__Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTHDW_UBI_COD__Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A306THDW_UBI_COD_), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtTHDW_UBI_COD__Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A306THDW_UBI_COD_), "ZZZZZZZZZ9"), "", 0, edtTHDW_UBI_COD__Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_id_Internalname, 1, 1, 0, "Cód. de Red:", "", "", "", 0, lblTextblockred_id_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_Id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ",", "")), "", 10, "chr", 1, "row", 10, 1, edtRed_Id_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A300Red_Id), "ZZZZZZZZZ9"), "", 0, edtRed_Id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_descripcion_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblockred_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_Descripcion_Internalname, StringUtil.RTrim( A301Red_Descripcion), "", 30, "chr", 1, "row", 30, 1, edtRed_Descripcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A301Red_Descripcion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(30);\"", 0, edtRed_Descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direcciondesdeb1_Internalname, 1, 1, 0, "Dir. IP Desde:", "", "", "", 0, lblTextblockred_direcciondesdeb1_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionDesdeB1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A308Red_DireccionDesdeB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionDesdeB1_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A308Red_DireccionDesdeB1), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(35);\"", 0, edtRed_DireccionDesdeB1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionDesdeB2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A309Red_DireccionDesdeB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionDesdeB2_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A309Red_DireccionDesdeB2), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(36);\"", 0, edtRed_DireccionDesdeB2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionDesdeB3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A310Red_DireccionDesdeB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionDesdeB3_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A310Red_DireccionDesdeB3), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(37);\"", 0, edtRed_DireccionDesdeB3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionDesdeB4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A315Red_DireccionDesdeB4), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionDesdeB4_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A315Red_DireccionDesdeB4), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtRed_DireccionDesdeB4_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_direccionhastab1_Internalname, 1, 1, 0, "Dir. IP Hasta:", "", "", "", 0, lblTextblockred_direccionhastab1_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionHastaB1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A316Red_DireccionHastaB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionHastaB1_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A316Red_DireccionHastaB1), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(43);\"", 0, edtRed_DireccionHastaB1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionHastaB2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A317Red_DireccionHastaB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionHastaB2_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A317Red_DireccionHastaB2), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtRed_DireccionHastaB2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionHastaB3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A318Red_DireccionHastaB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionHastaB3_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A318Red_DireccionHastaB3), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(45);\"", 0, edtRed_DireccionHastaB3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_DireccionHastaB4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A319Red_DireccionHastaB4), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_DireccionHastaB4_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A319Red_DireccionHastaB4), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(46);\"", 0, edtRed_DireccionHastaB4_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_mascarab1_Internalname, 1, 1, 0, "Máscara de Red:", "", "", "", 0, lblTextblockred_mascarab1_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_MascaraB1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A320Red_MascaraB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_MascaraB1_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A320Red_MascaraB1), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(51);\"", 0, edtRed_MascaraB1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_MascaraB2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A321Red_MascaraB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_MascaraB2_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A321Red_MascaraB2), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(52);\"", 0, edtRed_MascaraB2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_MascaraB3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A322Red_MascaraB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_MascaraB3_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A322Red_MascaraB3), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(53);\"", 0, edtRed_MascaraB3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_MascaraB4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A323Red_MascaraB4), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_MascaraB4_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A323Red_MascaraB4), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(54);\"", 0, edtRed_MascaraB4_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockred_puertaenlaceb1_Internalname, 1, 1, 0, "Puerta de Enlace:", "", "", "", 0, lblTextblockred_puertaenlaceb1_Jsonclick, "", StyleString, ClassString, "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_PuertaEnlaceB1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A324Red_PuertaEnlaceB1), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_PuertaEnlaceB1_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A324Red_PuertaEnlaceB1), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(59);\"", 0, edtRed_PuertaEnlaceB1_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_PuertaEnlaceB2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A325Red_PuertaEnlaceB2), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_PuertaEnlaceB2_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A325Red_PuertaEnlaceB2), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(60);\"", 0, edtRed_PuertaEnlaceB2_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_PuertaEnlaceB3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A326Red_PuertaEnlaceB3), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_PuertaEnlaceB3_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A326Red_PuertaEnlaceB3), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(61);\"", 0, edtRed_PuertaEnlaceB3_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( ".") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRed_PuertaEnlaceB4_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327Red_PuertaEnlaceB4), 3, 0, ",", "")), "", 3, "chr", 1, "row", 3, 1, edtRed_PuertaEnlaceB4_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A327Red_PuertaEnlaceB4), "ZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(62);\"", 0, edtRed_PuertaEnlaceB4_Jsonclick, "", 0, 1, -1, true, "right", "HLP_THDW_REDES.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_15_1539e( true) ;
         }
         else
         {
            wb_table4_15_1539e( false) ;
         }
      }

      protected void wb_table2_5_1539( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\"/>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_1539e( true) ;
         }
         else
         {
            wb_table2_5_1539e( false) ;
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
               A306THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( edtTHDW_UBI_COD__Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               A300Red_Id = (long)(context.localUtil.CToN( cgiGet( edtRed_Id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
               A301Red_Descripcion = cgiGet( edtRed_Descripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionDesdeB1_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONDESDEB1");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionDesdeB1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A308Red_DireccionDesdeB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
               }
               else
               {
                  A308Red_DireccionDesdeB1 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB1_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionDesdeB2_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONDESDEB2");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionDesdeB2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A309Red_DireccionDesdeB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
               }
               else
               {
                  A309Red_DireccionDesdeB2 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB2_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionDesdeB3_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONDESDEB3");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionDesdeB3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A310Red_DireccionDesdeB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
               }
               else
               {
                  A310Red_DireccionDesdeB3 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB3_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionDesdeB4_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONDESDEB4");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionDesdeB4_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A315Red_DireccionDesdeB4 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
               }
               else
               {
                  A315Red_DireccionDesdeB4 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionDesdeB4_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionHastaB1_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONHASTAB1");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionHastaB1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A316Red_DireccionHastaB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
               }
               else
               {
                  A316Red_DireccionHastaB1 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB1_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionHastaB2_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONHASTAB2");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionHastaB2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A317Red_DireccionHastaB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
               }
               else
               {
                  A317Red_DireccionHastaB2 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB2_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionHastaB3_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONHASTAB3");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionHastaB3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A318Red_DireccionHastaB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A318Red_DireccionHastaB3), 3, 0)));
               }
               else
               {
                  A318Red_DireccionHastaB3 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB3_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A318Red_DireccionHastaB3), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_DireccionHastaB4_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_DIRECCIONHASTAB4");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_DireccionHastaB4_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A319Red_DireccionHastaB4 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A319Red_DireccionHastaB4), 3, 0)));
               }
               else
               {
                  A319Red_DireccionHastaB4 = (short)(context.localUtil.CToN( cgiGet( edtRed_DireccionHastaB4_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A319Red_DireccionHastaB4), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_MascaraB1_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_MascaraB1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_MascaraB1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_MASCARAB1");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_MascaraB1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A320Red_MascaraB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
               }
               else
               {
                  A320Red_MascaraB1 = (short)(context.localUtil.CToN( cgiGet( edtRed_MascaraB1_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_MascaraB2_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_MascaraB2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_MascaraB2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_MASCARAB2");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_MascaraB2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A321Red_MascaraB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
               }
               else
               {
                  A321Red_MascaraB2 = (short)(context.localUtil.CToN( cgiGet( edtRed_MascaraB2_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_MascaraB3_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_MascaraB3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_MascaraB3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_MASCARAB3");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_MascaraB3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A322Red_MascaraB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
               }
               else
               {
                  A322Red_MascaraB3 = (short)(context.localUtil.CToN( cgiGet( edtRed_MascaraB3_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_MascaraB4_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_MascaraB4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_MascaraB4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_MASCARAB4");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_MascaraB4_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A323Red_MascaraB4 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A323Red_MascaraB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A323Red_MascaraB4), 3, 0)));
               }
               else
               {
                  A323Red_MascaraB4 = (short)(context.localUtil.CToN( cgiGet( edtRed_MascaraB4_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A323Red_MascaraB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A323Red_MascaraB4), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_PuertaEnlaceB1_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB1_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_PUERTAENLACEB1");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_PuertaEnlaceB1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A324Red_PuertaEnlaceB1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
               }
               else
               {
                  A324Red_PuertaEnlaceB1 = (short)(context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB1_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_PuertaEnlaceB2_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB2_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_PUERTAENLACEB2");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_PuertaEnlaceB2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A325Red_PuertaEnlaceB2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
               }
               else
               {
                  A325Red_PuertaEnlaceB2 = (short)(context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB2_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_PuertaEnlaceB3_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB3_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_PUERTAENLACEB3");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_PuertaEnlaceB3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A326Red_PuertaEnlaceB3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A326Red_PuertaEnlaceB3), 3, 0)));
               }
               else
               {
                  A326Red_PuertaEnlaceB3 = (short)(context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB3_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A326Red_PuertaEnlaceB3), 3, 0)));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtRed_PuertaEnlaceB4_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB4_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB4_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RED_PUERTAENLACEB4");
                  AnyError = 1 ;
                  GX_FocusControl = edtRed_PuertaEnlaceB4_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A327Red_PuertaEnlaceB4 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A327Red_PuertaEnlaceB4), 3, 0)));
               }
               else
               {
                  A327Red_PuertaEnlaceB4 = (short)(context.localUtil.CToN( cgiGet( edtRed_PuertaEnlaceB4_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A327Red_PuertaEnlaceB4), 3, 0)));
               }
               /* Read saved values. */
               Z306THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( "Z306THDW_UBI_COD_"), ",", ".")) ;
               Z300Red_Id = (long)(context.localUtil.CToN( cgiGet( "Z300Red_Id"), ",", ".")) ;
               Z301Red_Descripcion = cgiGet( "Z301Red_Descripcion") ;
               Z308Red_DireccionDesdeB1 = (short)(context.localUtil.CToN( cgiGet( "Z308Red_DireccionDesdeB1"), ",", ".")) ;
               Z309Red_DireccionDesdeB2 = (short)(context.localUtil.CToN( cgiGet( "Z309Red_DireccionDesdeB2"), ",", ".")) ;
               Z310Red_DireccionDesdeB3 = (short)(context.localUtil.CToN( cgiGet( "Z310Red_DireccionDesdeB3"), ",", ".")) ;
               Z315Red_DireccionDesdeB4 = (short)(context.localUtil.CToN( cgiGet( "Z315Red_DireccionDesdeB4"), ",", ".")) ;
               Z316Red_DireccionHastaB1 = (short)(context.localUtil.CToN( cgiGet( "Z316Red_DireccionHastaB1"), ",", ".")) ;
               Z317Red_DireccionHastaB2 = (short)(context.localUtil.CToN( cgiGet( "Z317Red_DireccionHastaB2"), ",", ".")) ;
               Z318Red_DireccionHastaB3 = (short)(context.localUtil.CToN( cgiGet( "Z318Red_DireccionHastaB3"), ",", ".")) ;
               Z319Red_DireccionHastaB4 = (short)(context.localUtil.CToN( cgiGet( "Z319Red_DireccionHastaB4"), ",", ".")) ;
               Z320Red_MascaraB1 = (short)(context.localUtil.CToN( cgiGet( "Z320Red_MascaraB1"), ",", ".")) ;
               Z321Red_MascaraB2 = (short)(context.localUtil.CToN( cgiGet( "Z321Red_MascaraB2"), ",", ".")) ;
               Z322Red_MascaraB3 = (short)(context.localUtil.CToN( cgiGet( "Z322Red_MascaraB3"), ",", ".")) ;
               Z323Red_MascaraB4 = (short)(context.localUtil.CToN( cgiGet( "Z323Red_MascaraB4"), ",", ".")) ;
               Z324Red_PuertaEnlaceB1 = (short)(context.localUtil.CToN( cgiGet( "Z324Red_PuertaEnlaceB1"), ",", ".")) ;
               Z325Red_PuertaEnlaceB2 = (short)(context.localUtil.CToN( cgiGet( "Z325Red_PuertaEnlaceB2"), ",", ".")) ;
               Z326Red_PuertaEnlaceB3 = (short)(context.localUtil.CToN( cgiGet( "Z326Red_PuertaEnlaceB3"), ",", ".")) ;
               Z327Red_PuertaEnlaceB4 = (short)(context.localUtil.CToN( cgiGet( "Z327Red_PuertaEnlaceB4"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV8SISTEMA = cgiGet( "vSISTEMA") ;
               AV9USUARIO = cgiGet( "vUSUARIO") ;
               AV7THDW_UBI_COD_ = (long)(context.localUtil.CToN( cgiGet( "vTHDW_UBI_COD_"), ",", ".")) ;
               AV10Red_Id = (long)(context.localUtil.CToN( cgiGet( "vRED_ID"), ",", ".")) ;
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ",", ".")) ;
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
                  A306THDW_UBI_COD_ = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
                  A300Red_Id = (long)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
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
                     sMode39 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode39 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound39 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_150( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "THDW_UBI_COD_");
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
                        if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11152 */
                           E11152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            /* Execute user event: E11152 */
            E11152 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1539( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtTHDW_UBI_COD__Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
            edtRed_Id_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_Id_Enabled), 5, 0)));
            edtRed_Descripcion_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_Descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_Descripcion_Enabled), 5, 0)));
            edtRed_DireccionDesdeB1_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionDesdeB1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionDesdeB1_Enabled), 5, 0)));
            edtRed_DireccionDesdeB2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionDesdeB2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionDesdeB2_Enabled), 5, 0)));
            edtRed_DireccionDesdeB3_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionDesdeB3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionDesdeB3_Enabled), 5, 0)));
            edtRed_DireccionDesdeB4_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionDesdeB4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionDesdeB4_Enabled), 5, 0)));
            edtRed_DireccionHastaB1_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionHastaB1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionHastaB1_Enabled), 5, 0)));
            edtRed_DireccionHastaB2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionHastaB2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionHastaB2_Enabled), 5, 0)));
            edtRed_DireccionHastaB3_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionHastaB3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionHastaB3_Enabled), 5, 0)));
            edtRed_DireccionHastaB4_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_DireccionHastaB4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_DireccionHastaB4_Enabled), 5, 0)));
            edtRed_MascaraB1_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_MascaraB1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_MascaraB1_Enabled), 5, 0)));
            edtRed_MascaraB2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_MascaraB2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_MascaraB2_Enabled), 5, 0)));
            edtRed_MascaraB3_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_MascaraB3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_MascaraB3_Enabled), 5, 0)));
            edtRed_MascaraB4_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_MascaraB4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_MascaraB4_Enabled), 5, 0)));
            edtRed_PuertaEnlaceB1_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_PuertaEnlaceB1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_PuertaEnlaceB1_Enabled), 5, 0)));
            edtRed_PuertaEnlaceB2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_PuertaEnlaceB2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_PuertaEnlaceB2_Enabled), 5, 0)));
            edtRed_PuertaEnlaceB3_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_PuertaEnlaceB3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_PuertaEnlaceB3_Enabled), 5, 0)));
            edtRed_PuertaEnlaceB4_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_PuertaEnlaceB4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_PuertaEnlaceB4_Enabled), 5, 0)));
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

      protected void CONFIRM_150( )
      {
         BeforeValidate1539( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1539( ) ;
            }
            else
            {
               CheckExtendedTable1539( ) ;
               CloseExtendedTableCursors1539( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption150( )
      {
      }

      protected void E11152( )
      {
         /* After Trn Routine */
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            new phdw_ip(context ).execute( ref  A306THDW_UBI_COD_) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         }
      }

      protected void ZM1539( short GX_JID )
      {
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z301Red_Descripcion = T00153_A301Red_Descripcion[0] ;
               Z308Red_DireccionDesdeB1 = T00153_A308Red_DireccionDesdeB1[0] ;
               Z309Red_DireccionDesdeB2 = T00153_A309Red_DireccionDesdeB2[0] ;
               Z310Red_DireccionDesdeB3 = T00153_A310Red_DireccionDesdeB3[0] ;
               Z315Red_DireccionDesdeB4 = T00153_A315Red_DireccionDesdeB4[0] ;
               Z316Red_DireccionHastaB1 = T00153_A316Red_DireccionHastaB1[0] ;
               Z317Red_DireccionHastaB2 = T00153_A317Red_DireccionHastaB2[0] ;
               Z318Red_DireccionHastaB3 = T00153_A318Red_DireccionHastaB3[0] ;
               Z319Red_DireccionHastaB4 = T00153_A319Red_DireccionHastaB4[0] ;
               Z320Red_MascaraB1 = T00153_A320Red_MascaraB1[0] ;
               Z321Red_MascaraB2 = T00153_A321Red_MascaraB2[0] ;
               Z322Red_MascaraB3 = T00153_A322Red_MascaraB3[0] ;
               Z323Red_MascaraB4 = T00153_A323Red_MascaraB4[0] ;
               Z324Red_PuertaEnlaceB1 = T00153_A324Red_PuertaEnlaceB1[0] ;
               Z325Red_PuertaEnlaceB2 = T00153_A325Red_PuertaEnlaceB2[0] ;
               Z326Red_PuertaEnlaceB3 = T00153_A326Red_PuertaEnlaceB3[0] ;
               Z327Red_PuertaEnlaceB4 = T00153_A327Red_PuertaEnlaceB4[0] ;
            }
            else
            {
               Z301Red_Descripcion = A301Red_Descripcion ;
               Z308Red_DireccionDesdeB1 = A308Red_DireccionDesdeB1 ;
               Z309Red_DireccionDesdeB2 = A309Red_DireccionDesdeB2 ;
               Z310Red_DireccionDesdeB3 = A310Red_DireccionDesdeB3 ;
               Z315Red_DireccionDesdeB4 = A315Red_DireccionDesdeB4 ;
               Z316Red_DireccionHastaB1 = A316Red_DireccionHastaB1 ;
               Z317Red_DireccionHastaB2 = A317Red_DireccionHastaB2 ;
               Z318Red_DireccionHastaB3 = A318Red_DireccionHastaB3 ;
               Z319Red_DireccionHastaB4 = A319Red_DireccionHastaB4 ;
               Z320Red_MascaraB1 = A320Red_MascaraB1 ;
               Z321Red_MascaraB2 = A321Red_MascaraB2 ;
               Z322Red_MascaraB3 = A322Red_MascaraB3 ;
               Z323Red_MascaraB4 = A323Red_MascaraB4 ;
               Z324Red_PuertaEnlaceB1 = A324Red_PuertaEnlaceB1 ;
               Z325Red_PuertaEnlaceB2 = A325Red_PuertaEnlaceB2 ;
               Z326Red_PuertaEnlaceB3 = A326Red_PuertaEnlaceB3 ;
               Z327Red_PuertaEnlaceB4 = A327Red_PuertaEnlaceB4 ;
            }
         }
         if ( GX_JID == -33 )
         {
            Z300Red_Id = A300Red_Id ;
            Z301Red_Descripcion = A301Red_Descripcion ;
            Z308Red_DireccionDesdeB1 = A308Red_DireccionDesdeB1 ;
            Z309Red_DireccionDesdeB2 = A309Red_DireccionDesdeB2 ;
            Z310Red_DireccionDesdeB3 = A310Red_DireccionDesdeB3 ;
            Z315Red_DireccionDesdeB4 = A315Red_DireccionDesdeB4 ;
            Z316Red_DireccionHastaB1 = A316Red_DireccionHastaB1 ;
            Z317Red_DireccionHastaB2 = A317Red_DireccionHastaB2 ;
            Z318Red_DireccionHastaB3 = A318Red_DireccionHastaB3 ;
            Z319Red_DireccionHastaB4 = A319Red_DireccionHastaB4 ;
            Z320Red_MascaraB1 = A320Red_MascaraB1 ;
            Z321Red_MascaraB2 = A321Red_MascaraB2 ;
            Z322Red_MascaraB3 = A322Red_MascaraB3 ;
            Z323Red_MascaraB4 = A323Red_MascaraB4 ;
            Z324Red_PuertaEnlaceB1 = A324Red_PuertaEnlaceB1 ;
            Z325Red_PuertaEnlaceB2 = A325Red_PuertaEnlaceB2 ;
            Z326Red_PuertaEnlaceB3 = A326Red_PuertaEnlaceB3 ;
            Z327Red_PuertaEnlaceB4 = A327Red_PuertaEnlaceB4 ;
            Z306THDW_UBI_COD_ = A306THDW_UBI_COD_ ;
         }
      }

      protected void standaloneNotModal( )
      {
         edtRed_Id_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_Id_Enabled), 5, 0)));
         edtTHDW_UBI_COD__Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
         Gx_BScreen = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         edtRed_Id_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRed_Id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRed_Id_Enabled), 5, 0)));
         edtTHDW_UBI_COD__Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTHDW_UBI_COD__Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTHDW_UBI_COD__Enabled), 5, 0)));
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         A306THDW_UBI_COD_ = AV7THDW_UBI_COD_ ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A300Red_Id = AV10Red_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         }
      }

      protected void standaloneModal( )
      {
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A320Red_MascaraB1) && ( Gx_BScreen == 0 ) )
         {
            A320Red_MascaraB1 = 255 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A321Red_MascaraB2) && ( Gx_BScreen == 0 ) )
         {
            A321Red_MascaraB2 = 255 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A322Red_MascaraB3) && ( Gx_BScreen == 0 ) )
         {
            A322Red_MascaraB3 = 255 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A308Red_DireccionDesdeB1) && ( Gx_BScreen == 0 ) )
         {
            A308Red_DireccionDesdeB1 = 172 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A309Red_DireccionDesdeB2) && ( Gx_BScreen == 0 ) )
         {
            A309Red_DireccionDesdeB2 = 22 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A316Red_DireccionHastaB1) && ( Gx_BScreen == 0 ) )
         {
            A316Red_DireccionHastaB1 = 172 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A317Red_DireccionHastaB2) && ( Gx_BScreen == 0 ) )
         {
            A317Red_DireccionHastaB2 = 22 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A324Red_PuertaEnlaceB1) && ( Gx_BScreen == 0 ) )
         {
            A324Red_PuertaEnlaceB1 = 172 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A325Red_PuertaEnlaceB2) && ( Gx_BScreen == 0 ) )
         {
            A325Red_PuertaEnlaceB2 = 22 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1539( )
      {
         /* Using cursor T00155 */
         pr_default.execute(3, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound39 = 1 ;
            A301Red_Descripcion = T00155_A301Red_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
            A308Red_DireccionDesdeB1 = T00155_A308Red_DireccionDesdeB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
            A309Red_DireccionDesdeB2 = T00155_A309Red_DireccionDesdeB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
            A310Red_DireccionDesdeB3 = T00155_A310Red_DireccionDesdeB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
            A315Red_DireccionDesdeB4 = T00155_A315Red_DireccionDesdeB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
            A316Red_DireccionHastaB1 = T00155_A316Red_DireccionHastaB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
            A317Red_DireccionHastaB2 = T00155_A317Red_DireccionHastaB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
            A318Red_DireccionHastaB3 = T00155_A318Red_DireccionHastaB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A318Red_DireccionHastaB3), 3, 0)));
            A319Red_DireccionHastaB4 = T00155_A319Red_DireccionHastaB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A319Red_DireccionHastaB4), 3, 0)));
            A320Red_MascaraB1 = T00155_A320Red_MascaraB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
            A321Red_MascaraB2 = T00155_A321Red_MascaraB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
            A322Red_MascaraB3 = T00155_A322Red_MascaraB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
            A323Red_MascaraB4 = T00155_A323Red_MascaraB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A323Red_MascaraB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A323Red_MascaraB4), 3, 0)));
            A324Red_PuertaEnlaceB1 = T00155_A324Red_PuertaEnlaceB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
            A325Red_PuertaEnlaceB2 = T00155_A325Red_PuertaEnlaceB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
            A326Red_PuertaEnlaceB3 = T00155_A326Red_PuertaEnlaceB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A326Red_PuertaEnlaceB3), 3, 0)));
            A327Red_PuertaEnlaceB4 = T00155_A327Red_PuertaEnlaceB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A327Red_PuertaEnlaceB4), 3, 0)));
            ZM1539( -33) ;
         }
         pr_default.close(3);
         OnLoadActions1539( ) ;
      }

      protected void OnLoadActions1539( )
      {
      }

      protected void CheckExtendedTable1539( )
      {
         Gx_BScreen = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T00154 */
         pr_default.execute(2, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No existe 'Ubicaciones de Redes de Hardware'.", "ForeignKeyNotFound", 1, "THDW_UBI_COD_");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(2);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            new phdw_redes(context ).execute(  A306THDW_UBI_COD_, out  A300Red_Id) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         }
         if ( ( StringUtil.StrCmp(StringUtil.Trim( A301Red_Descripcion), "") == 0 ) && true /* After */ )
         {
            GX_msglist.addItem("Debe ingresar una descripción.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A308Red_DireccionDesdeB1 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A309Red_DireccionDesdeB2 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A310Red_DireccionDesdeB3 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A315Red_DireccionDesdeB4 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A316Red_DireccionHastaB1 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A317Red_DireccionHastaB2 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A318Red_DireccionHastaB3 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A319Red_DireccionHastaB4 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( ( A315Red_DireccionDesdeB4 > A319Red_DireccionHastaB4 ) ) && true /* After */ )
         {
            GX_msglist.addItem("La IP Desde debe ser menor que la IP hasta.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A320Red_MascaraB1 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A321Red_MascaraB2 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A322Red_MascaraB3 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A323Red_MascaraB4 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A324Red_PuertaEnlaceB1 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A325Red_PuertaEnlaceB2 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A326Red_PuertaEnlaceB3 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
         if ( ( A327Red_PuertaEnlaceB4 > 255 ) && true /* After */ )
         {
            GX_msglist.addItem("Nº inválido para dirección IP. Debe ser menor o igual a 255.", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1539( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_34( long A306THDW_UBI_COD_ )
      {
         /* Using cursor T00156 */
         pr_default.execute(4, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("No existe 'Ubicaciones de Redes de Hardware'.", "ForeignKeyNotFound", 1, "THDW_UBI_COD_");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(4);
      }

      protected void GetKey1539( )
      {
         /* Using cursor T00157 */
         pr_default.execute(5, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound39 = 1 ;
         }
         else
         {
            RcdFound39 = 0 ;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00153 */
         pr_default.execute(1, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1539( 33) ;
            RcdFound39 = 1 ;
            A300Red_Id = T00153_A300Red_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
            A301Red_Descripcion = T00153_A301Red_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
            A308Red_DireccionDesdeB1 = T00153_A308Red_DireccionDesdeB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
            A309Red_DireccionDesdeB2 = T00153_A309Red_DireccionDesdeB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
            A310Red_DireccionDesdeB3 = T00153_A310Red_DireccionDesdeB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
            A315Red_DireccionDesdeB4 = T00153_A315Red_DireccionDesdeB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
            A316Red_DireccionHastaB1 = T00153_A316Red_DireccionHastaB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
            A317Red_DireccionHastaB2 = T00153_A317Red_DireccionHastaB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
            A318Red_DireccionHastaB3 = T00153_A318Red_DireccionHastaB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A318Red_DireccionHastaB3), 3, 0)));
            A319Red_DireccionHastaB4 = T00153_A319Red_DireccionHastaB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A319Red_DireccionHastaB4), 3, 0)));
            A320Red_MascaraB1 = T00153_A320Red_MascaraB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
            A321Red_MascaraB2 = T00153_A321Red_MascaraB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
            A322Red_MascaraB3 = T00153_A322Red_MascaraB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
            A323Red_MascaraB4 = T00153_A323Red_MascaraB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A323Red_MascaraB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A323Red_MascaraB4), 3, 0)));
            A324Red_PuertaEnlaceB1 = T00153_A324Red_PuertaEnlaceB1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
            A325Red_PuertaEnlaceB2 = T00153_A325Red_PuertaEnlaceB2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
            A326Red_PuertaEnlaceB3 = T00153_A326Red_PuertaEnlaceB3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A326Red_PuertaEnlaceB3), 3, 0)));
            A327Red_PuertaEnlaceB4 = T00153_A327Red_PuertaEnlaceB4[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A327Red_PuertaEnlaceB4), 3, 0)));
            A306THDW_UBI_COD_ = T00153_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            Z306THDW_UBI_COD_ = A306THDW_UBI_COD_ ;
            Z300Red_Id = A300Red_Id ;
            sMode39 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1539( ) ;
            Gx_mode = sMode39 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound39 = 0 ;
            InitializeNonKey1539( ) ;
            sMode39 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode39 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1539( ) ;
         if ( RcdFound39 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound39 = 0 ;
         /* Using cursor T00158 */
         pr_default.execute(6, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00158_A306THDW_UBI_COD_[0] < A306THDW_UBI_COD_ ) || ( T00158_A306THDW_UBI_COD_[0] == A306THDW_UBI_COD_ ) && ( T00158_A300Red_Id[0] < A300Red_Id ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00158_A306THDW_UBI_COD_[0] > A306THDW_UBI_COD_ ) || ( T00158_A306THDW_UBI_COD_[0] == A306THDW_UBI_COD_ ) && ( T00158_A300Red_Id[0] > A300Red_Id ) ) )
            {
               A306THDW_UBI_COD_ = T00158_A306THDW_UBI_COD_[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               A300Red_Id = T00158_A300Red_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
               RcdFound39 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound39 = 0 ;
         /* Using cursor T00159 */
         pr_default.execute(7, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00159_A306THDW_UBI_COD_[0] > A306THDW_UBI_COD_ ) || ( T00159_A306THDW_UBI_COD_[0] == A306THDW_UBI_COD_ ) && ( T00159_A300Red_Id[0] > A300Red_Id ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00159_A306THDW_UBI_COD_[0] < A306THDW_UBI_COD_ ) || ( T00159_A306THDW_UBI_COD_[0] == A306THDW_UBI_COD_ ) && ( T00159_A300Red_Id[0] < A300Red_Id ) ) )
            {
               A306THDW_UBI_COD_ = T00159_A306THDW_UBI_COD_[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               A300Red_Id = T00159_A300Red_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
               RcdFound39 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1539( ) ;
         if ( RcdFound39 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "THDW_UBI_COD_");
               AnyError = 1 ;
            }
            else if ( ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ ) || ( A300Red_Id != Z300Red_Id ) )
            {
               A306THDW_UBI_COD_ = Z306THDW_UBI_COD_ ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
               A300Red_Id = Z300Red_Id ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "THDW_UBI_COD_");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtRed_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update1539( ) ;
               GX_FocusControl = edtRed_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ ) || ( A300Red_Id != Z300Red_Id ) )
            {
               /* Insert record */
               Insert1539( ) ;
               GX_FocusControl = edtRed_Descripcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "THDW_UBI_COD_");
                  AnyError = 1 ;
               }
               else
               {
                  /* Insert record */
                  Insert1539( ) ;
                  GX_FocusControl = edtRed_Descripcion_Internalname ;
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
         if ( ( A306THDW_UBI_COD_ != Z306THDW_UBI_COD_ ) || ( A300Red_Id != Z300Red_Id ) )
         {
            A306THDW_UBI_COD_ = Z306THDW_UBI_COD_ ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            A300Red_Id = Z300Red_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "THDW_UBI_COD_");
            AnyError = 1 ;
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtRed_Descripcion_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1539( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001510 */
            pr_default.execute(8, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
            if ( (pr_default.getStatus(8) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"THDW_REDES"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(8) == 101) || ( StringUtil.StrCmp(Z301Red_Descripcion, T001510_A301Red_Descripcion[0]) != 0 ) || ( Z308Red_DireccionDesdeB1 != T001510_A308Red_DireccionDesdeB1[0] ) || ( Z309Red_DireccionDesdeB2 != T001510_A309Red_DireccionDesdeB2[0] ) || ( Z310Red_DireccionDesdeB3 != T001510_A310Red_DireccionDesdeB3[0] ) || ( Z315Red_DireccionDesdeB4 != T001510_A315Red_DireccionDesdeB4[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z316Red_DireccionHastaB1 != T001510_A316Red_DireccionHastaB1[0] ) || ( Z317Red_DireccionHastaB2 != T001510_A317Red_DireccionHastaB2[0] ) || ( Z318Red_DireccionHastaB3 != T001510_A318Red_DireccionHastaB3[0] ) || ( Z319Red_DireccionHastaB4 != T001510_A319Red_DireccionHastaB4[0] ) || ( Z320Red_MascaraB1 != T001510_A320Red_MascaraB1[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z321Red_MascaraB2 != T001510_A321Red_MascaraB2[0] ) || ( Z322Red_MascaraB3 != T001510_A322Red_MascaraB3[0] ) || ( Z323Red_MascaraB4 != T001510_A323Red_MascaraB4[0] ) || ( Z324Red_PuertaEnlaceB1 != T001510_A324Red_PuertaEnlaceB1[0] ) || ( Z325Red_PuertaEnlaceB2 != T001510_A325Red_PuertaEnlaceB2[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z326Red_PuertaEnlaceB3 != T001510_A326Red_PuertaEnlaceB3[0] ) || ( Z327Red_PuertaEnlaceB4 != T001510_A327Red_PuertaEnlaceB4[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"THDW_REDES"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1539( )
      {
         BeforeValidate1539( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1539( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1539( 0) ;
            CheckOptimisticConcurrency1539( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1539( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1539( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001511 */
                     pr_default.execute(9, new Object[] {A300Red_Id, A301Red_Descripcion, A308Red_DireccionDesdeB1, A309Red_DireccionDesdeB2, A310Red_DireccionDesdeB3, A315Red_DireccionDesdeB4, A316Red_DireccionHastaB1, A317Red_DireccionHastaB2, A318Red_DireccionHastaB3, A319Red_DireccionHastaB4, A320Red_MascaraB1, A321Red_MascaraB2, A322Red_MascaraB3, A323Red_MascaraB4, A324Red_PuertaEnlaceB1, A325Red_PuertaEnlaceB2, A326Red_PuertaEnlaceB3, A327Red_PuertaEnlaceB4, A306THDW_UBI_COD_});
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
                           ResetCaption150( ) ;
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
               Load1539( ) ;
            }
            EndLevel1539( ) ;
         }
         CloseExtendedTableCursors1539( ) ;
      }

      protected void Update1539( )
      {
         BeforeValidate1539( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1539( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1539( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1539( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1539( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001512 */
                     pr_default.execute(10, new Object[] {A301Red_Descripcion, A308Red_DireccionDesdeB1, A309Red_DireccionDesdeB2, A310Red_DireccionDesdeB3, A315Red_DireccionDesdeB4, A316Red_DireccionHastaB1, A317Red_DireccionHastaB2, A318Red_DireccionHastaB3, A319Red_DireccionHastaB4, A320Red_MascaraB1, A321Red_MascaraB2, A322Red_MascaraB3, A323Red_MascaraB4, A324Red_PuertaEnlaceB1, A325Red_PuertaEnlaceB2, A326Red_PuertaEnlaceB3, A327Red_PuertaEnlaceB4, A306THDW_UBI_COD_, A300Red_Id});
                     pr_default.close(10);
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"THDW_REDES"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1539( ) ;
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
            EndLevel1539( ) ;
         }
         CloseExtendedTableCursors1539( ) ;
      }

      protected void DeferredUpdate1539( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1539( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1539( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1539( ) ;
            AfterConfirm1539( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1539( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001513 */
                  pr_default.execute(11, new Object[] {A306THDW_UBI_COD_, A300Red_Id});
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
         sMode39 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1539( ) ;
         Gx_mode = sMode39 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1539( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1539( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(8);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1539( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(7);
            pr_default.close(6);
            context.CommitDataStores("THDW_REDES");
            if ( AnyError == 0 )
            {
               ConfirmValues150( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(7);
            pr_default.close(6);
            context.RollbackDataStores("THDW_REDES");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1539( )
      {
         /* Using cursor T001514 */
         pr_default.execute(12);
         RcdFound39 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound39 = 1 ;
            A306THDW_UBI_COD_ = T001514_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            A300Red_Id = T001514_A300Red_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1539( )
      {
         pr_default.readNext(12);
         RcdFound39 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound39 = 1 ;
            A306THDW_UBI_COD_ = T001514_A306THDW_UBI_COD_[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            A300Red_Id = T001514_A300Red_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         }
      }

      protected void ScanEnd1539( )
      {
      }

      protected void AfterConfirm1539( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1539( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1539( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1539( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1539( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1539( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues150( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("thdw_redes.aspx") + "?" + UrlEncode("" +AV7THDW_UBI_COD_) + "," + UrlEncode("" +AV10Red_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z306THDW_UBI_COD_), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z300Red_Id", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z300Red_Id), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z301Red_Descripcion", StringUtil.RTrim( Z301Red_Descripcion));
         GxWebStd.gx_hidden_field( context, "Z308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z308Red_DireccionDesdeB1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z309Red_DireccionDesdeB2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z310Red_DireccionDesdeB3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z315Red_DireccionDesdeB4), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z316Red_DireccionHastaB1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z317Red_DireccionHastaB2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z318Red_DireccionHastaB3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z319Red_DireccionHastaB4), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z320Red_MascaraB1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z320Red_MascaraB1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z321Red_MascaraB2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z321Red_MascaraB2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z322Red_MascaraB3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z322Red_MascaraB3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z323Red_MascaraB4", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z323Red_MascaraB4), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z324Red_PuertaEnlaceB1), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z325Red_PuertaEnlaceB2), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z326Red_PuertaEnlaceB3), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z327Red_PuertaEnlaceB4), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vTHDW_UBI_COD_", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7THDW_UBI_COD_), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vRED_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Red_Id), 10, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ",", "")));
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
         return "THDW_REDES" ;
      }

      public override String GetPgmdesc( )
      {
         return "Redes de una Ubicación de Hardware" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("thdw_redes.aspx") + "?" + UrlEncode("" +AV7THDW_UBI_COD_) + "," + UrlEncode("" +AV10Red_Id) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void InitializeNonKey1539( )
      {
         A301Red_Descripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301Red_Descripcion", A301Red_Descripcion);
         A310Red_DireccionDesdeB3 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310Red_DireccionDesdeB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A310Red_DireccionDesdeB3), 3, 0)));
         A315Red_DireccionDesdeB4 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315Red_DireccionDesdeB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A315Red_DireccionDesdeB4), 3, 0)));
         A318Red_DireccionHastaB3 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318Red_DireccionHastaB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A318Red_DireccionHastaB3), 3, 0)));
         A319Red_DireccionHastaB4 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319Red_DireccionHastaB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A319Red_DireccionHastaB4), 3, 0)));
         A323Red_MascaraB4 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A323Red_MascaraB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A323Red_MascaraB4), 3, 0)));
         A326Red_PuertaEnlaceB3 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326Red_PuertaEnlaceB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A326Red_PuertaEnlaceB3), 3, 0)));
         A327Red_PuertaEnlaceB4 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327Red_PuertaEnlaceB4", StringUtil.LTrim( StringUtil.Str( (decimal)(A327Red_PuertaEnlaceB4), 3, 0)));
         A308Red_DireccionDesdeB1 = 172 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
         A309Red_DireccionDesdeB2 = 22 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
         A316Red_DireccionHastaB1 = 172 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
         A317Red_DireccionHastaB2 = 22 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
         A320Red_MascaraB1 = 255 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
         A321Red_MascaraB2 = 255 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
         A322Red_MascaraB3 = 255 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
         A324Red_PuertaEnlaceB1 = 172 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
         A325Red_PuertaEnlaceB2 = 22 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
      }

      protected void InitAll1539( )
      {
         A306THDW_UBI_COD_ = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
         A300Red_Id = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         InitializeNonKey1539( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A320Red_MascaraB1 = i320Red_MascaraB1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320Red_MascaraB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A320Red_MascaraB1), 3, 0)));
         A321Red_MascaraB2 = i321Red_MascaraB2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321Red_MascaraB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A321Red_MascaraB2), 3, 0)));
         A322Red_MascaraB3 = i322Red_MascaraB3 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322Red_MascaraB3", StringUtil.LTrim( StringUtil.Str( (decimal)(A322Red_MascaraB3), 3, 0)));
         A308Red_DireccionDesdeB1 = i308Red_DireccionDesdeB1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A308Red_DireccionDesdeB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A308Red_DireccionDesdeB1), 3, 0)));
         A309Red_DireccionDesdeB2 = i309Red_DireccionDesdeB2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A309Red_DireccionDesdeB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A309Red_DireccionDesdeB2), 3, 0)));
         A316Red_DireccionHastaB1 = i316Red_DireccionHastaB1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316Red_DireccionHastaB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A316Red_DireccionHastaB1), 3, 0)));
         A317Red_DireccionHastaB2 = i317Red_DireccionHastaB2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317Red_DireccionHastaB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A317Red_DireccionHastaB2), 3, 0)));
         A324Red_PuertaEnlaceB1 = i324Red_PuertaEnlaceB1 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A324Red_PuertaEnlaceB1", StringUtil.LTrim( StringUtil.Str( (decimal)(A324Red_PuertaEnlaceB1), 3, 0)));
         A325Red_PuertaEnlaceB2 = i325Red_PuertaEnlaceB2 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A325Red_PuertaEnlaceB2", StringUtil.LTrim( StringUtil.Str( (decimal)(A325Red_PuertaEnlaceB2), 3, 0)));
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11193565");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("thdw_redes.js", "?11193566");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockthdw_ubi_cod__Internalname = "TEXTBLOCKTHDW_UBI_COD_" ;
         edtTHDW_UBI_COD__Internalname = "THDW_UBI_COD_" ;
         lblTextblockred_id_Internalname = "TEXTBLOCKRED_ID" ;
         edtRed_Id_Internalname = "RED_ID" ;
         lblTextblockred_descripcion_Internalname = "TEXTBLOCKRED_DESCRIPCION" ;
         edtRed_Descripcion_Internalname = "RED_DESCRIPCION" ;
         lblTextblockred_direcciondesdeb1_Internalname = "TEXTBLOCKRED_DIRECCIONDESDEB1" ;
         edtRed_DireccionDesdeB1_Internalname = "RED_DIRECCIONDESDEB1" ;
         edtRed_DireccionDesdeB2_Internalname = "RED_DIRECCIONDESDEB2" ;
         edtRed_DireccionDesdeB3_Internalname = "RED_DIRECCIONDESDEB3" ;
         edtRed_DireccionDesdeB4_Internalname = "RED_DIRECCIONDESDEB4" ;
         lblTextblockred_direccionhastab1_Internalname = "TEXTBLOCKRED_DIRECCIONHASTAB1" ;
         edtRed_DireccionHastaB1_Internalname = "RED_DIRECCIONHASTAB1" ;
         edtRed_DireccionHastaB2_Internalname = "RED_DIRECCIONHASTAB2" ;
         edtRed_DireccionHastaB3_Internalname = "RED_DIRECCIONHASTAB3" ;
         edtRed_DireccionHastaB4_Internalname = "RED_DIRECCIONHASTAB4" ;
         lblTextblockred_mascarab1_Internalname = "TEXTBLOCKRED_MASCARAB1" ;
         edtRed_MascaraB1_Internalname = "RED_MASCARAB1" ;
         edtRed_MascaraB2_Internalname = "RED_MASCARAB2" ;
         edtRed_MascaraB3_Internalname = "RED_MASCARAB3" ;
         edtRed_MascaraB4_Internalname = "RED_MASCARAB4" ;
         lblTextblockred_puertaenlaceb1_Internalname = "TEXTBLOCKRED_PUERTAENLACEB1" ;
         edtRed_PuertaEnlaceB1_Internalname = "RED_PUERTAENLACEB1" ;
         edtRed_PuertaEnlaceB2_Internalname = "RED_PUERTAENLACEB2" ;
         edtRed_PuertaEnlaceB3_Internalname = "RED_PUERTAENLACEB3" ;
         edtRed_PuertaEnlaceB4_Internalname = "RED_PUERTAENLACEB4" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
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
         Form.Caption = "Redes de una Ubicación de Hardware" ;
         edtRed_PuertaEnlaceB4_Jsonclick = "" ;
         edtRed_PuertaEnlaceB4_Enabled = 1 ;
         edtRed_PuertaEnlaceB3_Jsonclick = "" ;
         edtRed_PuertaEnlaceB3_Enabled = 1 ;
         edtRed_PuertaEnlaceB2_Jsonclick = "" ;
         edtRed_PuertaEnlaceB2_Enabled = 1 ;
         edtRed_PuertaEnlaceB1_Jsonclick = "" ;
         edtRed_PuertaEnlaceB1_Enabled = 1 ;
         edtRed_MascaraB4_Jsonclick = "" ;
         edtRed_MascaraB4_Enabled = 1 ;
         edtRed_MascaraB3_Jsonclick = "" ;
         edtRed_MascaraB3_Enabled = 1 ;
         edtRed_MascaraB2_Jsonclick = "" ;
         edtRed_MascaraB2_Enabled = 1 ;
         edtRed_MascaraB1_Jsonclick = "" ;
         edtRed_MascaraB1_Enabled = 1 ;
         edtRed_DireccionHastaB4_Jsonclick = "" ;
         edtRed_DireccionHastaB4_Enabled = 1 ;
         edtRed_DireccionHastaB3_Jsonclick = "" ;
         edtRed_DireccionHastaB3_Enabled = 1 ;
         edtRed_DireccionHastaB2_Jsonclick = "" ;
         edtRed_DireccionHastaB2_Enabled = 1 ;
         edtRed_DireccionHastaB1_Jsonclick = "" ;
         edtRed_DireccionHastaB1_Enabled = 1 ;
         edtRed_DireccionDesdeB4_Jsonclick = "" ;
         edtRed_DireccionDesdeB4_Enabled = 1 ;
         edtRed_DireccionDesdeB3_Jsonclick = "" ;
         edtRed_DireccionDesdeB3_Enabled = 1 ;
         edtRed_DireccionDesdeB2_Jsonclick = "" ;
         edtRed_DireccionDesdeB2_Enabled = 1 ;
         edtRed_DireccionDesdeB1_Jsonclick = "" ;
         edtRed_DireccionDesdeB1_Enabled = 1 ;
         edtRed_Descripcion_Jsonclick = "" ;
         edtRed_Descripcion_Enabled = 1 ;
         edtRed_Id_Jsonclick = "" ;
         edtRed_Id_Enabled = 0 ;
         edtTHDW_UBI_COD__Jsonclick = "" ;
         edtTHDW_UBI_COD__Enabled = 0 ;
         bttBtn_enter_Enabled = 1 ;
         bttBtn_enter_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void XC_14_1539( long A306THDW_UBI_COD_ ,
                                 String Gx_mode )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            new phdw_redes(context ).execute(  A306THDW_UBI_COD_, out  A300Red_Id) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A306THDW_UBI_COD_", StringUtil.LTrim( StringUtil.Str( (decimal)(A306THDW_UBI_COD_), 10, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A300Red_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A300Red_Id), 10, 0)));
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString(")");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
      }

      public void Valid_Thdw_ubi_cod_( String GX_Parm1 ,
                                       long GX_Parm2 ,
                                       long GX_Parm3 )
      {
         Gx_mode = GX_Parm1 ;
         A306THDW_UBI_COD_ = GX_Parm2 ;
         A300Red_Id = GX_Parm3 ;
         /* Using cursor T001515 */
         pr_default.execute(13, new Object[] {A306THDW_UBI_COD_});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No existe 'Ubicaciones de Redes de Hardware'.", "ForeignKeyNotFound", 1, "THDW_UBI_COD_");
            AnyError = 1 ;
         }
         if ( AnyError == 0 )
         {
         }
         pr_default.close(13);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            new phdw_redes(context ).execute(  A306THDW_UBI_COD_, out  A300Red_Id) ;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A300Red_Id), 10, 0, ".", ""))));
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
         pr_default.close(12);
         pr_default.close(7);
         pr_default.close(6);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         wcpOGx_mode = "" ;
         wcpOAV8SISTEMA = "" ;
         wcpOAV9USUARIO = "" ;
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
         bttBtn_delete_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_enter_Jsonclick = "" ;
         lblTextblockthdw_ubi_cod__Jsonclick = "" ;
         lblTextblockred_id_Jsonclick = "" ;
         lblTextblockred_descripcion_Jsonclick = "" ;
         A301Red_Descripcion = "" ;
         lblTextblockred_direcciondesdeb1_Jsonclick = "" ;
         lblTextblockred_direccionhastab1_Jsonclick = "" ;
         lblTextblockred_mascarab1_Jsonclick = "" ;
         lblTextblockred_puertaenlaceb1_Jsonclick = "" ;
         Z301Red_Descripcion = "" ;
         sMode39 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00155_A300Red_Id = new long[1] ;
         T00155_A301Red_Descripcion = new String[] {""} ;
         T00155_A308Red_DireccionDesdeB1 = new short[1] ;
         T00155_A309Red_DireccionDesdeB2 = new short[1] ;
         T00155_A310Red_DireccionDesdeB3 = new short[1] ;
         T00155_A315Red_DireccionDesdeB4 = new short[1] ;
         T00155_A316Red_DireccionHastaB1 = new short[1] ;
         T00155_A317Red_DireccionHastaB2 = new short[1] ;
         T00155_A318Red_DireccionHastaB3 = new short[1] ;
         T00155_A319Red_DireccionHastaB4 = new short[1] ;
         T00155_A320Red_MascaraB1 = new short[1] ;
         T00155_A321Red_MascaraB2 = new short[1] ;
         T00155_A322Red_MascaraB3 = new short[1] ;
         T00155_A323Red_MascaraB4 = new short[1] ;
         T00155_A324Red_PuertaEnlaceB1 = new short[1] ;
         T00155_A325Red_PuertaEnlaceB2 = new short[1] ;
         T00155_A326Red_PuertaEnlaceB3 = new short[1] ;
         T00155_A327Red_PuertaEnlaceB4 = new short[1] ;
         T00155_A306THDW_UBI_COD_ = new long[1] ;
         T00154_A306THDW_UBI_COD_ = new long[1] ;
         T00156_A306THDW_UBI_COD_ = new long[1] ;
         T00157_A306THDW_UBI_COD_ = new long[1] ;
         T00157_A300Red_Id = new long[1] ;
         T00153_A300Red_Id = new long[1] ;
         T00153_A301Red_Descripcion = new String[] {""} ;
         T00153_A308Red_DireccionDesdeB1 = new short[1] ;
         T00153_A309Red_DireccionDesdeB2 = new short[1] ;
         T00153_A310Red_DireccionDesdeB3 = new short[1] ;
         T00153_A315Red_DireccionDesdeB4 = new short[1] ;
         T00153_A316Red_DireccionHastaB1 = new short[1] ;
         T00153_A317Red_DireccionHastaB2 = new short[1] ;
         T00153_A318Red_DireccionHastaB3 = new short[1] ;
         T00153_A319Red_DireccionHastaB4 = new short[1] ;
         T00153_A320Red_MascaraB1 = new short[1] ;
         T00153_A321Red_MascaraB2 = new short[1] ;
         T00153_A322Red_MascaraB3 = new short[1] ;
         T00153_A323Red_MascaraB4 = new short[1] ;
         T00153_A324Red_PuertaEnlaceB1 = new short[1] ;
         T00153_A325Red_PuertaEnlaceB2 = new short[1] ;
         T00153_A326Red_PuertaEnlaceB3 = new short[1] ;
         T00153_A327Red_PuertaEnlaceB4 = new short[1] ;
         T00153_A306THDW_UBI_COD_ = new long[1] ;
         T00158_A306THDW_UBI_COD_ = new long[1] ;
         T00158_A300Red_Id = new long[1] ;
         T00159_A306THDW_UBI_COD_ = new long[1] ;
         T00159_A300Red_Id = new long[1] ;
         T001510_A300Red_Id = new long[1] ;
         T001510_A301Red_Descripcion = new String[] {""} ;
         T001510_A308Red_DireccionDesdeB1 = new short[1] ;
         T001510_A309Red_DireccionDesdeB2 = new short[1] ;
         T001510_A310Red_DireccionDesdeB3 = new short[1] ;
         T001510_A315Red_DireccionDesdeB4 = new short[1] ;
         T001510_A316Red_DireccionHastaB1 = new short[1] ;
         T001510_A317Red_DireccionHastaB2 = new short[1] ;
         T001510_A318Red_DireccionHastaB3 = new short[1] ;
         T001510_A319Red_DireccionHastaB4 = new short[1] ;
         T001510_A320Red_MascaraB1 = new short[1] ;
         T001510_A321Red_MascaraB2 = new short[1] ;
         T001510_A322Red_MascaraB3 = new short[1] ;
         T001510_A323Red_MascaraB4 = new short[1] ;
         T001510_A324Red_PuertaEnlaceB1 = new short[1] ;
         T001510_A325Red_PuertaEnlaceB2 = new short[1] ;
         T001510_A326Red_PuertaEnlaceB3 = new short[1] ;
         T001510_A327Red_PuertaEnlaceB4 = new short[1] ;
         T001510_A306THDW_UBI_COD_ = new long[1] ;
         T001514_A306THDW_UBI_COD_ = new long[1] ;
         T001514_A300Red_Id = new long[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         T001515_A306THDW_UBI_COD_ = new long[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.thdw_redes__default(),
            new Object[][] {
                new Object[] {
               T00152_A300Red_Id, T00152_A301Red_Descripcion, T00152_A308Red_DireccionDesdeB1, T00152_A309Red_DireccionDesdeB2, T00152_A310Red_DireccionDesdeB3, T00152_A315Red_DireccionDesdeB4, T00152_A316Red_DireccionHastaB1, T00152_A317Red_DireccionHastaB2, T00152_A318Red_DireccionHastaB3, T00152_A319Red_DireccionHastaB4,
               T00152_A320Red_MascaraB1, T00152_A321Red_MascaraB2, T00152_A322Red_MascaraB3, T00152_A323Red_MascaraB4, T00152_A324Red_PuertaEnlaceB1, T00152_A325Red_PuertaEnlaceB2, T00152_A326Red_PuertaEnlaceB3, T00152_A327Red_PuertaEnlaceB4, T00152_A306THDW_UBI_COD_
               }
               , new Object[] {
               T00153_A300Red_Id, T00153_A301Red_Descripcion, T00153_A308Red_DireccionDesdeB1, T00153_A309Red_DireccionDesdeB2, T00153_A310Red_DireccionDesdeB3, T00153_A315Red_DireccionDesdeB4, T00153_A316Red_DireccionHastaB1, T00153_A317Red_DireccionHastaB2, T00153_A318Red_DireccionHastaB3, T00153_A319Red_DireccionHastaB4,
               T00153_A320Red_MascaraB1, T00153_A321Red_MascaraB2, T00153_A322Red_MascaraB3, T00153_A323Red_MascaraB4, T00153_A324Red_PuertaEnlaceB1, T00153_A325Red_PuertaEnlaceB2, T00153_A326Red_PuertaEnlaceB3, T00153_A327Red_PuertaEnlaceB4, T00153_A306THDW_UBI_COD_
               }
               , new Object[] {
               T00154_A306THDW_UBI_COD_
               }
               , new Object[] {
               T00155_A300Red_Id, T00155_A301Red_Descripcion, T00155_A308Red_DireccionDesdeB1, T00155_A309Red_DireccionDesdeB2, T00155_A310Red_DireccionDesdeB3, T00155_A315Red_DireccionDesdeB4, T00155_A316Red_DireccionHastaB1, T00155_A317Red_DireccionHastaB2, T00155_A318Red_DireccionHastaB3, T00155_A319Red_DireccionHastaB4,
               T00155_A320Red_MascaraB1, T00155_A321Red_MascaraB2, T00155_A322Red_MascaraB3, T00155_A323Red_MascaraB4, T00155_A324Red_PuertaEnlaceB1, T00155_A325Red_PuertaEnlaceB2, T00155_A326Red_PuertaEnlaceB3, T00155_A327Red_PuertaEnlaceB4, T00155_A306THDW_UBI_COD_
               }
               , new Object[] {
               T00156_A306THDW_UBI_COD_
               }
               , new Object[] {
               T00157_A306THDW_UBI_COD_, T00157_A300Red_Id
               }
               , new Object[] {
               T00158_A306THDW_UBI_COD_, T00158_A300Red_Id
               }
               , new Object[] {
               T00159_A306THDW_UBI_COD_, T00159_A300Red_Id
               }
               , new Object[] {
               T001510_A300Red_Id, T001510_A301Red_Descripcion, T001510_A308Red_DireccionDesdeB1, T001510_A309Red_DireccionDesdeB2, T001510_A310Red_DireccionDesdeB3, T001510_A315Red_DireccionDesdeB4, T001510_A316Red_DireccionHastaB1, T001510_A317Red_DireccionHastaB2, T001510_A318Red_DireccionHastaB3, T001510_A319Red_DireccionHastaB4,
               T001510_A320Red_MascaraB1, T001510_A321Red_MascaraB2, T001510_A322Red_MascaraB3, T001510_A323Red_MascaraB4, T001510_A324Red_PuertaEnlaceB1, T001510_A325Red_PuertaEnlaceB2, T001510_A326Red_PuertaEnlaceB3, T001510_A327Red_PuertaEnlaceB4, T001510_A306THDW_UBI_COD_
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001514_A306THDW_UBI_COD_, T001514_A300Red_Id
               }
               , new Object[] {
               T001515_A306THDW_UBI_COD_
               }
            }
         );
         A325Red_PuertaEnlaceB2 = 22 ;
         A324Red_PuertaEnlaceB1 = 172 ;
         A317Red_DireccionHastaB2 = 22 ;
         A316Red_DireccionHastaB1 = 172 ;
         A309Red_DireccionDesdeB2 = 22 ;
         A308Red_DireccionDesdeB1 = 172 ;
         A322Red_MascaraB3 = 255 ;
         A321Red_MascaraB2 = 255 ;
         A320Red_MascaraB1 = 255 ;
      }

      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A308Red_DireccionDesdeB1 ;
      private short A309Red_DireccionDesdeB2 ;
      private short A310Red_DireccionDesdeB3 ;
      private short A315Red_DireccionDesdeB4 ;
      private short A316Red_DireccionHastaB1 ;
      private short A317Red_DireccionHastaB2 ;
      private short A318Red_DireccionHastaB3 ;
      private short A319Red_DireccionHastaB4 ;
      private short A320Red_MascaraB1 ;
      private short A321Red_MascaraB2 ;
      private short A322Red_MascaraB3 ;
      private short A323Red_MascaraB4 ;
      private short A324Red_PuertaEnlaceB1 ;
      private short A325Red_PuertaEnlaceB2 ;
      private short A326Red_PuertaEnlaceB3 ;
      private short A327Red_PuertaEnlaceB4 ;
      private short Z308Red_DireccionDesdeB1 ;
      private short Z309Red_DireccionDesdeB2 ;
      private short Z310Red_DireccionDesdeB3 ;
      private short Z315Red_DireccionDesdeB4 ;
      private short Z316Red_DireccionHastaB1 ;
      private short Z317Red_DireccionHastaB2 ;
      private short Z318Red_DireccionHastaB3 ;
      private short Z319Red_DireccionHastaB4 ;
      private short Z320Red_MascaraB1 ;
      private short Z321Red_MascaraB2 ;
      private short Z322Red_MascaraB3 ;
      private short Z323Red_MascaraB4 ;
      private short Z324Red_PuertaEnlaceB1 ;
      private short Z325Red_PuertaEnlaceB2 ;
      private short Z326Red_PuertaEnlaceB3 ;
      private short Z327Red_PuertaEnlaceB4 ;
      private short Gx_BScreen ;
      private short RcdFound39 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private short i320Red_MascaraB1 ;
      private short i321Red_MascaraB2 ;
      private short i322Red_MascaraB3 ;
      private short i308Red_DireccionDesdeB1 ;
      private short i309Red_DireccionDesdeB2 ;
      private short i316Red_DireccionHastaB1 ;
      private short i317Red_DireccionHastaB2 ;
      private short i324Red_PuertaEnlaceB1 ;
      private short i325Red_PuertaEnlaceB2 ;
      private int trnEnded ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int edtTHDW_UBI_COD__Enabled ;
      private int edtRed_Id_Enabled ;
      private int edtRed_Descripcion_Enabled ;
      private int edtRed_DireccionDesdeB1_Enabled ;
      private int edtRed_DireccionDesdeB2_Enabled ;
      private int edtRed_DireccionDesdeB3_Enabled ;
      private int edtRed_DireccionDesdeB4_Enabled ;
      private int edtRed_DireccionHastaB1_Enabled ;
      private int edtRed_DireccionHastaB2_Enabled ;
      private int edtRed_DireccionHastaB3_Enabled ;
      private int edtRed_DireccionHastaB4_Enabled ;
      private int edtRed_MascaraB1_Enabled ;
      private int edtRed_MascaraB2_Enabled ;
      private int edtRed_MascaraB3_Enabled ;
      private int edtRed_MascaraB4_Enabled ;
      private int edtRed_PuertaEnlaceB1_Enabled ;
      private int edtRed_PuertaEnlaceB2_Enabled ;
      private int edtRed_PuertaEnlaceB3_Enabled ;
      private int edtRed_PuertaEnlaceB4_Enabled ;
      private int idxLst ;
      private long wcpOAV7THDW_UBI_COD_ ;
      private long wcpOAV10Red_Id ;
      private long A306THDW_UBI_COD_ ;
      private long AV7THDW_UBI_COD_ ;
      private long AV10Red_Id ;
      private long A300Red_Id ;
      private long Z306THDW_UBI_COD_ ;
      private long Z300Red_Id ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String wcpOAV8SISTEMA ;
      private String wcpOAV9USUARIO ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String AV8SISTEMA ;
      private String AV9USUARIO ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtRed_Descripcion_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockthdw_ubi_cod__Internalname ;
      private String lblTextblockthdw_ubi_cod__Jsonclick ;
      private String edtTHDW_UBI_COD__Internalname ;
      private String edtTHDW_UBI_COD__Jsonclick ;
      private String lblTextblockred_id_Internalname ;
      private String lblTextblockred_id_Jsonclick ;
      private String edtRed_Id_Internalname ;
      private String edtRed_Id_Jsonclick ;
      private String lblTextblockred_descripcion_Internalname ;
      private String lblTextblockred_descripcion_Jsonclick ;
      private String A301Red_Descripcion ;
      private String edtRed_Descripcion_Jsonclick ;
      private String lblTextblockred_direcciondesdeb1_Internalname ;
      private String lblTextblockred_direcciondesdeb1_Jsonclick ;
      private String edtRed_DireccionDesdeB1_Internalname ;
      private String edtRed_DireccionDesdeB1_Jsonclick ;
      private String edtRed_DireccionDesdeB2_Internalname ;
      private String edtRed_DireccionDesdeB2_Jsonclick ;
      private String edtRed_DireccionDesdeB3_Internalname ;
      private String edtRed_DireccionDesdeB3_Jsonclick ;
      private String edtRed_DireccionDesdeB4_Internalname ;
      private String edtRed_DireccionDesdeB4_Jsonclick ;
      private String lblTextblockred_direccionhastab1_Internalname ;
      private String lblTextblockred_direccionhastab1_Jsonclick ;
      private String edtRed_DireccionHastaB1_Internalname ;
      private String edtRed_DireccionHastaB1_Jsonclick ;
      private String edtRed_DireccionHastaB2_Internalname ;
      private String edtRed_DireccionHastaB2_Jsonclick ;
      private String edtRed_DireccionHastaB3_Internalname ;
      private String edtRed_DireccionHastaB3_Jsonclick ;
      private String edtRed_DireccionHastaB4_Internalname ;
      private String edtRed_DireccionHastaB4_Jsonclick ;
      private String lblTextblockred_mascarab1_Internalname ;
      private String lblTextblockred_mascarab1_Jsonclick ;
      private String edtRed_MascaraB1_Internalname ;
      private String edtRed_MascaraB1_Jsonclick ;
      private String edtRed_MascaraB2_Internalname ;
      private String edtRed_MascaraB2_Jsonclick ;
      private String edtRed_MascaraB3_Internalname ;
      private String edtRed_MascaraB3_Jsonclick ;
      private String edtRed_MascaraB4_Internalname ;
      private String edtRed_MascaraB4_Jsonclick ;
      private String lblTextblockred_puertaenlaceb1_Internalname ;
      private String lblTextblockred_puertaenlaceb1_Jsonclick ;
      private String edtRed_PuertaEnlaceB1_Internalname ;
      private String edtRed_PuertaEnlaceB1_Jsonclick ;
      private String edtRed_PuertaEnlaceB2_Internalname ;
      private String edtRed_PuertaEnlaceB2_Jsonclick ;
      private String edtRed_PuertaEnlaceB3_Internalname ;
      private String edtRed_PuertaEnlaceB3_Jsonclick ;
      private String edtRed_PuertaEnlaceB4_Internalname ;
      private String edtRed_PuertaEnlaceB4_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String Z301Red_Descripcion ;
      private String sMode39 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private long aP0_THDW_UBI_COD_ ;
      private long aP1_Red_Id ;
      private String aP2_Gx_mode ;
      private String aP3_SISTEMA ;
      private String aP4_USUARIO ;
      private IDataStoreProvider pr_default ;
      private long[] T00155_A300Red_Id ;
      private String[] T00155_A301Red_Descripcion ;
      private short[] T00155_A308Red_DireccionDesdeB1 ;
      private short[] T00155_A309Red_DireccionDesdeB2 ;
      private short[] T00155_A310Red_DireccionDesdeB3 ;
      private short[] T00155_A315Red_DireccionDesdeB4 ;
      private short[] T00155_A316Red_DireccionHastaB1 ;
      private short[] T00155_A317Red_DireccionHastaB2 ;
      private short[] T00155_A318Red_DireccionHastaB3 ;
      private short[] T00155_A319Red_DireccionHastaB4 ;
      private short[] T00155_A320Red_MascaraB1 ;
      private short[] T00155_A321Red_MascaraB2 ;
      private short[] T00155_A322Red_MascaraB3 ;
      private short[] T00155_A323Red_MascaraB4 ;
      private short[] T00155_A324Red_PuertaEnlaceB1 ;
      private short[] T00155_A325Red_PuertaEnlaceB2 ;
      private short[] T00155_A326Red_PuertaEnlaceB3 ;
      private short[] T00155_A327Red_PuertaEnlaceB4 ;
      private long[] T00155_A306THDW_UBI_COD_ ;
      private long[] T00154_A306THDW_UBI_COD_ ;
      private long[] T00156_A306THDW_UBI_COD_ ;
      private long[] T00157_A306THDW_UBI_COD_ ;
      private long[] T00157_A300Red_Id ;
      private long[] T00153_A300Red_Id ;
      private String[] T00153_A301Red_Descripcion ;
      private short[] T00153_A308Red_DireccionDesdeB1 ;
      private short[] T00153_A309Red_DireccionDesdeB2 ;
      private short[] T00153_A310Red_DireccionDesdeB3 ;
      private short[] T00153_A315Red_DireccionDesdeB4 ;
      private short[] T00153_A316Red_DireccionHastaB1 ;
      private short[] T00153_A317Red_DireccionHastaB2 ;
      private short[] T00153_A318Red_DireccionHastaB3 ;
      private short[] T00153_A319Red_DireccionHastaB4 ;
      private short[] T00153_A320Red_MascaraB1 ;
      private short[] T00153_A321Red_MascaraB2 ;
      private short[] T00153_A322Red_MascaraB3 ;
      private short[] T00153_A323Red_MascaraB4 ;
      private short[] T00153_A324Red_PuertaEnlaceB1 ;
      private short[] T00153_A325Red_PuertaEnlaceB2 ;
      private short[] T00153_A326Red_PuertaEnlaceB3 ;
      private short[] T00153_A327Red_PuertaEnlaceB4 ;
      private long[] T00153_A306THDW_UBI_COD_ ;
      private long[] T00158_A306THDW_UBI_COD_ ;
      private long[] T00158_A300Red_Id ;
      private long[] T00159_A306THDW_UBI_COD_ ;
      private long[] T00159_A300Red_Id ;
      private long[] T001510_A300Red_Id ;
      private String[] T001510_A301Red_Descripcion ;
      private short[] T001510_A308Red_DireccionDesdeB1 ;
      private short[] T001510_A309Red_DireccionDesdeB2 ;
      private short[] T001510_A310Red_DireccionDesdeB3 ;
      private short[] T001510_A315Red_DireccionDesdeB4 ;
      private short[] T001510_A316Red_DireccionHastaB1 ;
      private short[] T001510_A317Red_DireccionHastaB2 ;
      private short[] T001510_A318Red_DireccionHastaB3 ;
      private short[] T001510_A319Red_DireccionHastaB4 ;
      private short[] T001510_A320Red_MascaraB1 ;
      private short[] T001510_A321Red_MascaraB2 ;
      private short[] T001510_A322Red_MascaraB3 ;
      private short[] T001510_A323Red_MascaraB4 ;
      private short[] T001510_A324Red_PuertaEnlaceB1 ;
      private short[] T001510_A325Red_PuertaEnlaceB2 ;
      private short[] T001510_A326Red_PuertaEnlaceB3 ;
      private short[] T001510_A327Red_PuertaEnlaceB4 ;
      private long[] T001510_A306THDW_UBI_COD_ ;
      private long[] T001514_A306THDW_UBI_COD_ ;
      private long[] T001514_A300Red_Id ;
      private long[] T001515_A306THDW_UBI_COD_ ;
      private long[] T00152_A300Red_Id ;
      private String[] T00152_A301Red_Descripcion ;
      private short[] T00152_A308Red_DireccionDesdeB1 ;
      private short[] T00152_A309Red_DireccionDesdeB2 ;
      private short[] T00152_A310Red_DireccionDesdeB3 ;
      private short[] T00152_A315Red_DireccionDesdeB4 ;
      private short[] T00152_A316Red_DireccionHastaB1 ;
      private short[] T00152_A317Red_DireccionHastaB2 ;
      private short[] T00152_A318Red_DireccionHastaB3 ;
      private short[] T00152_A319Red_DireccionHastaB4 ;
      private short[] T00152_A320Red_MascaraB1 ;
      private short[] T00152_A321Red_MascaraB2 ;
      private short[] T00152_A322Red_MascaraB3 ;
      private short[] T00152_A323Red_MascaraB4 ;
      private short[] T00152_A324Red_PuertaEnlaceB1 ;
      private short[] T00152_A325Red_PuertaEnlaceB2 ;
      private short[] T00152_A326Red_PuertaEnlaceB3 ;
      private short[] T00152_A327Red_PuertaEnlaceB4 ;
      private long[] T00152_A306THDW_UBI_COD_ ;
      private GXWebForm Form ;
   }

   public class thdw_redes__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00152 ;
          prmT00152 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00155 ;
          prmT00155 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00154 ;
          prmT00154 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00156 ;
          prmT00156 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00157 ;
          prmT00157 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00153 ;
          prmT00153 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00158 ;
          prmT00158 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT00159 ;
          prmT00159 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT001510 ;
          prmT001510 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT001511 ;
          prmT001511 = new Object[] {
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Descripcion",SqlDbType.Char,30,0} ,
          new Object[] {"@Red_DireccionDesdeB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT001512 ;
          prmT001512 = new Object[] {
          new Object[] {"@Red_Descripcion",SqlDbType.Char,30,0} ,
          new Object[] {"@Red_DireccionDesdeB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionDesdeB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_DireccionHastaB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_MascaraB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB1",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB2",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB3",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@Red_PuertaEnlaceB4",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT001513 ;
          prmT001513 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0} ,
          new Object[] {"@Red_Id",SqlDbType.Decimal,10,0}
          } ;
          Object[] prmT001514 ;
          prmT001514 = new Object[] {
          } ;
          Object[] prmT001515 ;
          prmT001515 = new Object[] {
          new Object[] {"@THDW_UBI_COD_",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00152", "SELECT [Red_Id], [Red_Descripcion], [Red_DireccionDesdeB1], [Red_DireccionDesdeB2], [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionHastaB1], [Red_DireccionHastaB2], [Red_DireccionHastaB3], [Red_DireccionHastaB4], [Red_MascaraB1], [Red_MascaraB2], [Red_MascaraB3], [Red_MascaraB4], [Red_PuertaEnlaceB1], [Red_PuertaEnlaceB2], [Red_PuertaEnlaceB3], [Red_PuertaEnlaceB4], [THDW_UBI_COD_] FROM [THDW_REDES] WITH (UPDLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00152,1,0,true,false )
             ,new CursorDef("T00153", "SELECT [Red_Id], [Red_Descripcion], [Red_DireccionDesdeB1], [Red_DireccionDesdeB2], [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionHastaB1], [Red_DireccionHastaB2], [Red_DireccionHastaB3], [Red_DireccionHastaB4], [Red_MascaraB1], [Red_MascaraB2], [Red_MascaraB3], [Red_MascaraB4], [Red_PuertaEnlaceB1], [Red_PuertaEnlaceB2], [Red_PuertaEnlaceB3], [Red_PuertaEnlaceB4], [THDW_UBI_COD_] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT00153,1,0,true,false )
             ,new CursorDef("T00154", "SELECT [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT00154,1,0,true,false )
             ,new CursorDef("T00155", "SELECT TM1.[Red_Id], TM1.[Red_Descripcion], TM1.[Red_DireccionDesdeB1], TM1.[Red_DireccionDesdeB2], TM1.[Red_DireccionDesdeB3], TM1.[Red_DireccionDesdeB4], TM1.[Red_DireccionHastaB1], TM1.[Red_DireccionHastaB2], TM1.[Red_DireccionHastaB3], TM1.[Red_DireccionHastaB4], TM1.[Red_MascaraB1], TM1.[Red_MascaraB2], TM1.[Red_MascaraB3], TM1.[Red_MascaraB4], TM1.[Red_PuertaEnlaceB1], TM1.[Red_PuertaEnlaceB2], TM1.[Red_PuertaEnlaceB3], TM1.[Red_PuertaEnlaceB4], TM1.[THDW_UBI_COD_] FROM [THDW_REDES] TM1 WITH (NOLOCK) WHERE TM1.[THDW_UBI_COD_] = @THDW_UBI_COD_ and TM1.[Red_Id] = @Red_Id ORDER BY TM1.[THDW_UBI_COD_], TM1.[Red_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00155,100,0,true,false )
             ,new CursorDef("T00156", "SELECT [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT00156,1,0,true,false )
             ,new CursorDef("T00157", "SELECT [THDW_UBI_COD_], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00157,1,0,true,false )
             ,new CursorDef("T00158", "SELECT TOP 1 [THDW_UBI_COD_], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) WHERE ( [THDW_UBI_COD_] > @THDW_UBI_COD_ or [THDW_UBI_COD_] = @THDW_UBI_COD_ and [Red_Id] > @Red_Id) ORDER BY [THDW_UBI_COD_], [Red_Id]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00158,1,0,true,true )
             ,new CursorDef("T00159", "SELECT TOP 1 [THDW_UBI_COD_], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) WHERE ( [THDW_UBI_COD_] < @THDW_UBI_COD_ or [THDW_UBI_COD_] = @THDW_UBI_COD_ and [Red_Id] < @Red_Id) ORDER BY [THDW_UBI_COD_] DESC, [Red_Id] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00159,1,0,true,true )
             ,new CursorDef("T001510", "SELECT [Red_Id], [Red_Descripcion], [Red_DireccionDesdeB1], [Red_DireccionDesdeB2], [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionHastaB1], [Red_DireccionHastaB2], [Red_DireccionHastaB3], [Red_DireccionHastaB4], [Red_MascaraB1], [Red_MascaraB2], [Red_MascaraB3], [Red_MascaraB4], [Red_PuertaEnlaceB1], [Red_PuertaEnlaceB2], [Red_PuertaEnlaceB3], [Red_PuertaEnlaceB4], [THDW_UBI_COD_] FROM [THDW_REDES] WITH (UPDLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id ",true, GxErrorMask.GX_NOMASK, false, this,prmT001510,1,0,true,false )
             ,new CursorDef("T001511", "INSERT INTO [THDW_REDES] ([Red_Id], [Red_Descripcion], [Red_DireccionDesdeB1], [Red_DireccionDesdeB2], [Red_DireccionDesdeB3], [Red_DireccionDesdeB4], [Red_DireccionHastaB1], [Red_DireccionHastaB2], [Red_DireccionHastaB3], [Red_DireccionHastaB4], [Red_MascaraB1], [Red_MascaraB2], [Red_MascaraB3], [Red_MascaraB4], [Red_PuertaEnlaceB1], [Red_PuertaEnlaceB2], [Red_PuertaEnlaceB3], [Red_PuertaEnlaceB4], [THDW_UBI_COD_]) VALUES (@Red_Id, @Red_Descripcion, @Red_DireccionDesdeB1, @Red_DireccionDesdeB2, @Red_DireccionDesdeB3, @Red_DireccionDesdeB4, @Red_DireccionHastaB1, @Red_DireccionHastaB2, @Red_DireccionHastaB3, @Red_DireccionHastaB4, @Red_MascaraB1, @Red_MascaraB2, @Red_MascaraB3, @Red_MascaraB4, @Red_PuertaEnlaceB1, @Red_PuertaEnlaceB2, @Red_PuertaEnlaceB3, @Red_PuertaEnlaceB4, @THDW_UBI_COD_)", GxErrorMask.GX_NOMASK,prmT001511)
             ,new CursorDef("T001512", "UPDATE [THDW_REDES] SET [Red_Descripcion]=@Red_Descripcion, [Red_DireccionDesdeB1]=@Red_DireccionDesdeB1, [Red_DireccionDesdeB2]=@Red_DireccionDesdeB2, [Red_DireccionDesdeB3]=@Red_DireccionDesdeB3, [Red_DireccionDesdeB4]=@Red_DireccionDesdeB4, [Red_DireccionHastaB1]=@Red_DireccionHastaB1, [Red_DireccionHastaB2]=@Red_DireccionHastaB2, [Red_DireccionHastaB3]=@Red_DireccionHastaB3, [Red_DireccionHastaB4]=@Red_DireccionHastaB4, [Red_MascaraB1]=@Red_MascaraB1, [Red_MascaraB2]=@Red_MascaraB2, [Red_MascaraB3]=@Red_MascaraB3, [Red_MascaraB4]=@Red_MascaraB4, [Red_PuertaEnlaceB1]=@Red_PuertaEnlaceB1, [Red_PuertaEnlaceB2]=@Red_PuertaEnlaceB2, [Red_PuertaEnlaceB3]=@Red_PuertaEnlaceB3, [Red_PuertaEnlaceB4]=@Red_PuertaEnlaceB4  WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id", GxErrorMask.GX_NOMASK,prmT001512)
             ,new CursorDef("T001513", "DELETE FROM [THDW_REDES]  WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ AND [Red_Id] = @Red_Id", GxErrorMask.GX_NOMASK,prmT001513)
             ,new CursorDef("T001514", "SELECT [THDW_UBI_COD_], [Red_Id] FROM [THDW_REDES] WITH (NOLOCK) ORDER BY [THDW_UBI_COD_], [Red_Id]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001514,100,0,true,false )
             ,new CursorDef("T001515", "SELECT [THDW_UBI_COD_] FROM [THDW_UBICACIONES_] WITH (NOLOCK) WHERE [THDW_UBI_COD_] = @THDW_UBI_COD_ ",true, GxErrorMask.GX_NOMASK, false, this,prmT001515,1,0,true,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((short[]) buf[17])[0] = rslt.getShort(18) ;
                ((long[]) buf[18])[0] = rslt.getLong(19) ;
                break;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((short[]) buf[17])[0] = rslt.getShort(18) ;
                ((long[]) buf[18])[0] = rslt.getLong(19) ;
                break;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((short[]) buf[17])[0] = rslt.getShort(18) ;
                ((long[]) buf[18])[0] = rslt.getLong(19) ;
                break;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                break;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                break;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                break;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                ((short[]) buf[13])[0] = rslt.getShort(14) ;
                ((short[]) buf[14])[0] = rslt.getShort(15) ;
                ((short[]) buf[15])[0] = rslt.getShort(16) ;
                ((short[]) buf[16])[0] = rslt.getShort(17) ;
                ((short[]) buf[17])[0] = rslt.getShort(18) ;
                ((long[]) buf[18])[0] = rslt.getLong(19) ;
                break;
             case 12 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                break;
             case 13 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                stmt.SetParameter(11, (short)parms[10]);
                stmt.SetParameter(12, (short)parms[11]);
                stmt.SetParameter(13, (short)parms[12]);
                stmt.SetParameter(14, (short)parms[13]);
                stmt.SetParameter(15, (short)parms[14]);
                stmt.SetParameter(16, (short)parms[15]);
                stmt.SetParameter(17, (short)parms[16]);
                stmt.SetParameter(18, (short)parms[17]);
                stmt.SetParameter(19, (long)parms[18]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                stmt.SetParameter(11, (short)parms[10]);
                stmt.SetParameter(12, (short)parms[11]);
                stmt.SetParameter(13, (short)parms[12]);
                stmt.SetParameter(14, (short)parms[13]);
                stmt.SetParameter(15, (short)parms[14]);
                stmt.SetParameter(16, (short)parms[15]);
                stmt.SetParameter(17, (short)parms[16]);
                stmt.SetParameter(18, (long)parms[17]);
                stmt.SetParameter(19, (long)parms[18]);
                break;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (long)parms[1]);
                break;
             case 13 :
                stmt.SetParameter(1, (long)parms[0]);
                break;
       }
    }

 }

}
