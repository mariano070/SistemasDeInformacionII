/*
               File: TTBUS014_1
        Description: Auxiliar para informe de bienes de uso por responsable
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:47:21.97
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
   public class ttbus014_1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         cmbTTBUS14_Estado.Name = "TTBUS14_ESTADO" ;
         cmbTTBUS14_Estado.WebTags = "" ;
         cmbTTBUS14_Estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
         cmbTTBUS14_Estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
         if ( ( cmbTTBUS14_Estado.ItemCount > 0 ) && (0==A208TTBUS14_Estado) )
         {
            A208TTBUS14_Estado = (short)(NumberUtil.Val( cmbTTBUS14_Estado.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208TTBUS14_Estado", StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0));
         }
         cmbTTBUS14_MarcaEnvio.Name = "TTBUS14_MARCAENVIO" ;
         cmbTTBUS14_MarcaEnvio.WebTags = "" ;
         cmbTTBUS14_MarcaEnvio.addItem("1", "Envía", 0);
         cmbTTBUS14_MarcaEnvio.addItem("2", "Recibe", 0);
         cmbTTBUS14_MarcaEnvio.addItem("3", "Tiene Asignado", 0);
         if ( ( cmbTTBUS14_MarcaEnvio.ItemCount > 0 ) && (0==A212TTBUS14_MarcaEnvio) )
         {
            A212TTBUS14_MarcaEnvio = (short)(NumberUtil.Val( cmbTTBUS14_MarcaEnvio.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212TTBUS14_MarcaEnvio", StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0));
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Auxiliar para informe de bienes de uso por responsable", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public ttbus014_1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ttbus014_1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
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
         cmbTTBUS14_Estado = new GXCombobox();
         cmbTTBUS14_MarcaEnvio = new GXCombobox();
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
            wb_table1_2_0C12( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0C12e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0C12( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0C12( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0C12e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Auxiliar para informe de bienes de uso por responsable"+"</legend>") ;
            wb_table3_27_0C12( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0C12e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0C12e( true) ;
         }
         else
         {
            wb_table1_2_0C12e( false) ;
         }
      }

      protected void wb_table3_27_0C12( bool wbgen )
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
            wb_table4_33_0C12( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0C12e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TTBUS014_1.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TTBUS014_1.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0C12e( true) ;
         }
         else
         {
            wb_table3_27_0C12e( false) ;
         }
      }

      protected void wb_table4_33_0C12( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_codresponsable_Internalname, 1, 1, 0, "Código de Responsable", "", "", "", 0, lblTextblockttbus14_codresponsable_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_CodResponsable_Internalname, StringUtil.RTrim( A213TTBUS14_CodResponsable), "", 15, "chr", 1, "row", 15, 1, edtTTBUS14_CodResponsable_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A213TTBUS14_CodResponsable, "XXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", 0, edtTTBUS14_CodResponsable_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_responsable_Internalname, 1, 1, 0, "Responsable", "", "", "", 0, lblTextblockttbus14_responsable_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_Responsable_Internalname, StringUtil.RTrim( A209TTBUS14_Responsable), "", 50, "chr", 1, "row", 50, 1, edtTTBUS14_Responsable_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A209TTBUS14_Responsable, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, edtTTBUS14_Responsable_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_idbien_Internalname, 1, 1, 0, "Id bien de uso", "", "", "", 0, lblTextblockttbus14_idbien_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_IdBien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TTBUS14_IdBien), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, edtTTBUS14_IdBien_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A201TTBUS14_IdBien), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", 0, edtTTBUS14_IdBien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_descripcion_Internalname, 1, 1, 0, "Descripción del bien", "", "", "", 0, lblTextblockttbus14_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_Descripcion_Internalname, StringUtil.RTrim( A202TTBUS14_Descripcion), "", 50, "chr", 1, "row", 50, 1, edtTTBUS14_Descripcion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A202TTBUS14_Descripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(53);\"", 0, edtTTBUS14_Descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_codrubro_Internalname, 1, 1, 0, "Rubro", "", "", "", 0, lblTextblockttbus14_codrubro_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_CodRubro_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A214TTBUS14_CodRubro), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtTTBUS14_CodRubro_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A214TTBUS14_CodRubro), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(58);\"", 0, edtTTBUS14_CodRubro_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_rubro_Internalname, 1, 1, 0, "Rubro del bien", "", "", "", 0, lblTextblockttbus14_rubro_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_Rubro_Internalname, StringUtil.RTrim( A203TTBUS14_Rubro), "", 30, "chr", 1, "row", 30, 1, edtTTBUS14_Rubro_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A203TTBUS14_Rubro, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", 0, edtTTBUS14_Rubro_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_proveedor_Internalname, 1, 1, 0, "Proveedor", "", "", "", 0, lblTextblockttbus14_proveedor_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_Proveedor_Internalname, StringUtil.RTrim( A204TTBUS14_Proveedor), "", 30, "chr", 1, "row", 30, 1, edtTTBUS14_Proveedor_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A204TTBUS14_Proveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", 0, edtTTBUS14_Proveedor_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_fechacarga_Internalname, 1, 1, 0, "Fecha de carga", "", "", "", 0, lblTextblockttbus14_fechacarga_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS14_FechaCarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_FechaCarga_Internalname, context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS14_FechaCarga_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A205TTBUS14_FechaCarga, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(73);\"", 0, edtTTBUS14_FechaCarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS14_FechaCarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS14_FechaCarga_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS014_1.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_fechaadquisicion_Internalname, 1, 1, 0, "Fecha de adquisición", "", "", "", 0, lblTextblockttbus14_fechaadquisicion_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS14_FechaAdquisicion_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_FechaAdquisicion_Internalname, context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS14_FechaAdquisicion_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A206TTBUS14_FechaAdquisicion, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(78);\"", 0, edtTTBUS14_FechaAdquisicion_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS14_FechaAdquisicion_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS14_FechaAdquisicion_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS014_1.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_fechaenvio_Internalname, 1, 1, 0, "Fecha de envío", "", "", "", 0, lblTextblockttbus14_fechaenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtTTBUS14_FechaEnvio_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_FechaEnvio_Internalname, context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, edtTTBUS14_FechaEnvio_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( A207TTBUS14_FechaEnvio, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(83);\"", 0, edtTTBUS14_FechaEnvio_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            GxWebStd.gx_bitmap( context, edtTTBUS14_FechaEnvio_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(edtTTBUS14_FechaEnvio_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_TTBUS014_1.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_estado_Internalname, 1, 1, 0, "Estado", "", "", "", 0, lblTextblockttbus14_estado_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTTBUS14_Estado, cmbTTBUS14_Estado_Internalname, StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0), "", "int", 1, cmbTTBUS14_Estado.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbTTBUS14_Estado_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(88);\"", true, "HLP_TTBUS014_1.htm");
            cmbTTBUS14_Estado.CurrentValue = StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS14_Estado_Internalname, "Values", (String)(cmbTTBUS14_Estado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_posdesde_Internalname, 1, 1, 0, "Posición Desde", "", "", "", 0, lblTextblockttbus14_posdesde_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_PosDesde_Internalname, StringUtil.RTrim( A210TTBUS14_PosDesde), "", 50, "chr", 1, "row", 50, 1, edtTTBUS14_PosDesde_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A210TTBUS14_PosDesde, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", 0, edtTTBUS14_PosDesde_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_poshacia_Internalname, 1, 1, 0, "Posición Desde", "", "", "", 0, lblTextblockttbus14_poshacia_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_PosHacia_Internalname, StringUtil.RTrim( A211TTBUS14_PosHacia), "", 50, "chr", 1, "row", 50, 1, edtTTBUS14_PosHacia_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A211TTBUS14_PosHacia, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(98);\"", 0, edtTTBUS14_PosHacia_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_marcaenvio_Internalname, 1, 1, 0, "Marca de Envio", "", "", "", 0, lblTextblockttbus14_marcaenvio_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbTTBUS14_MarcaEnvio, cmbTTBUS14_MarcaEnvio_Internalname, StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0), "", "int", 1, cmbTTBUS14_MarcaEnvio.Enabled, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbTTBUS14_MarcaEnvio_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(103);\"", true, "HLP_TTBUS014_1.htm");
            cmbTTBUS14_MarcaEnvio.CurrentValue = StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS14_MarcaEnvio_Internalname, "Values", (String)(cmbTTBUS14_MarcaEnvio.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_empresa_Internalname, 1, 1, 0, "Empresa", "", "", "", 0, lblTextblockttbus14_empresa_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_Empresa_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A217TTBUS14_Empresa), 1, 0, ",", "")), "", 1, "chr", 1, "row", 1, 1, edtTTBUS14_Empresa_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A217TTBUS14_Empresa), "9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(108);\"", 0, edtTTBUS14_Empresa_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_codetiqueta_Internalname, 1, 1, 0, "Etiqueta", "", "", "", 0, lblTextblockttbus14_codetiqueta_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_CodEtiqueta_Internalname, StringUtil.RTrim( A215TTBUS14_CodEtiqueta), "", 80, "chr", 1, "row", 80, 1, edtTTBUS14_CodEtiqueta_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A215TTBUS14_CodEtiqueta, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(113);\"", 0, edtTTBUS14_CodEtiqueta_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockttbus14_nroserie_Internalname, 1, 1, 0, "de serie", "", "", "", 0, lblTextblockttbus14_nroserie_Jsonclick, "", StyleString, ClassString, "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtTTBUS14_NroSerie_Internalname, StringUtil.RTrim( A216TTBUS14_NroSerie), "", 20, "chr", 1, "row", 20, 1, edtTTBUS14_NroSerie_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A216TTBUS14_NroSerie, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(118);\"", 0, edtTTBUS14_NroSerie_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TTBUS014_1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0C12e( true) ;
         }
         else
         {
            wb_table4_33_0C12e( false) ;
         }
      }

      protected void wb_table2_5_0C12( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, "", context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, "", context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, "", context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, "", context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, "", context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS14_CODRESPONSABLE"+"'), id:'"+"TTBUS14_CODRESPONSABLE"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS14_IDBIEN"+"'), id:'"+"TTBUS14_IDBIEN"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TTBUS14_CODRESPONSABLE"+"'), id:'"+"TTBUS14_CODRESPONSABLE"+"'"+",isOut:true,isKey:false,isLastKey:false}"+","+"{Ctrl:gx.dom.el('"+"TTBUS14_IDBIEN"+"'), id:'"+"TTBUS14_IDBIEN"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, "", context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, "", context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, "", context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TTBUS014_1.htm");
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
            wb_table2_5_0C12e( true) ;
         }
         else
         {
            wb_table2_5_0C12e( false) ;
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
               A213TTBUS14_CodResponsable = cgiGet( edtTTBUS14_CodResponsable_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
               A209TTBUS14_Responsable = cgiGet( edtTTBUS14_Responsable_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS14_IdBien_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS14_IdBien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS14_IdBien_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS14_IDBIEN");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_IdBien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A201TTBUS14_IdBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               }
               else
               {
                  A201TTBUS14_IdBien = (int)(context.localUtil.CToN( cgiGet( edtTTBUS14_IdBien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               }
               A202TTBUS14_Descripcion = cgiGet( edtTTBUS14_Descripcion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TTBUS14_Descripcion", A202TTBUS14_Descripcion);
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS14_CodRubro_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtTTBUS14_CodRubro_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS14_CodRubro_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS14_CODRUBRO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_CodRubro_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A214TTBUS14_CodRubro = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
               }
               else
               {
                  A214TTBUS14_CodRubro = (short)(context.localUtil.CToN( cgiGet( edtTTBUS14_CodRubro_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
               }
               A203TTBUS14_Rubro = cgiGet( edtTTBUS14_Rubro_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
               A204TTBUS14_Proveedor = cgiGet( edtTTBUS14_Proveedor_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204TTBUS14_Proveedor", A204TTBUS14_Proveedor);
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS14_FechaCarga_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha de carga"}), 1, "TTBUS14_FECHACARGA");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_FechaCarga_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A205TTBUS14_FechaCarga = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205TTBUS14_FechaCarga", context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"));
               }
               else
               {
                  A205TTBUS14_FechaCarga = context.localUtil.CToD( cgiGet( edtTTBUS14_FechaCarga_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205TTBUS14_FechaCarga", context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS14_FechaAdquisicion_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha de adquisición"}), 1, "TTBUS14_FECHAADQUISICION");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_FechaAdquisicion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206TTBUS14_FechaAdquisicion", context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"));
               }
               else
               {
                  A206TTBUS14_FechaAdquisicion = context.localUtil.CToD( cgiGet( edtTTBUS14_FechaAdquisicion_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206TTBUS14_FechaAdquisicion", context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"));
               }
               if ( context.localUtil.VCDate( cgiGet( edtTTBUS14_FechaEnvio_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha de envío"}), 1, "TTBUS14_FECHAENVIO");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_FechaEnvio_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A207TTBUS14_FechaEnvio = DateTime.MinValue ;
                  n207TTBUS14_FechaEnvio = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207TTBUS14_FechaEnvio", context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"));
               }
               else
               {
                  A207TTBUS14_FechaEnvio = context.localUtil.CToD( cgiGet( edtTTBUS14_FechaEnvio_Internalname), 4) ;
                  n207TTBUS14_FechaEnvio = false ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207TTBUS14_FechaEnvio", context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"));
               }
               n207TTBUS14_FechaEnvio = ((DateTime.MinValue==A207TTBUS14_FechaEnvio) ? true : false) ;
               cmbTTBUS14_Estado.CurrentValue = cgiGet( cmbTTBUS14_Estado_Internalname) ;
               A208TTBUS14_Estado = (short)(NumberUtil.Val( cgiGet( cmbTTBUS14_Estado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208TTBUS14_Estado", StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0));
               A210TTBUS14_PosDesde = cgiGet( edtTTBUS14_PosDesde_Internalname) ;
               n210TTBUS14_PosDesde = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210TTBUS14_PosDesde", A210TTBUS14_PosDesde);
               n210TTBUS14_PosDesde = (String.IsNullOrEmpty(StringUtil.RTrim( A210TTBUS14_PosDesde)) ? true : false) ;
               A211TTBUS14_PosHacia = cgiGet( edtTTBUS14_PosHacia_Internalname) ;
               n211TTBUS14_PosHacia = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211TTBUS14_PosHacia", A211TTBUS14_PosHacia);
               n211TTBUS14_PosHacia = (String.IsNullOrEmpty(StringUtil.RTrim( A211TTBUS14_PosHacia)) ? true : false) ;
               cmbTTBUS14_MarcaEnvio.CurrentValue = cgiGet( cmbTTBUS14_MarcaEnvio_Internalname) ;
               A212TTBUS14_MarcaEnvio = (short)(NumberUtil.Val( cgiGet( cmbTTBUS14_MarcaEnvio_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212TTBUS14_MarcaEnvio", StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0));
               if ( ! context.localUtil.VCNumber( cgiGet( edtTTBUS14_Empresa_Internalname), "9") || ( context.localUtil.CToN( cgiGet( edtTTBUS14_Empresa_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtTTBUS14_Empresa_Internalname), ",", ".") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TTBUS14_EMPRESA");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_Empresa_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A217TTBUS14_Empresa = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217TTBUS14_Empresa", StringUtil.Str( (decimal)(A217TTBUS14_Empresa), 1, 0));
               }
               else
               {
                  A217TTBUS14_Empresa = (short)(context.localUtil.CToN( cgiGet( edtTTBUS14_Empresa_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217TTBUS14_Empresa", StringUtil.Str( (decimal)(A217TTBUS14_Empresa), 1, 0));
               }
               A215TTBUS14_CodEtiqueta = cgiGet( edtTTBUS14_CodEtiqueta_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215TTBUS14_CodEtiqueta", A215TTBUS14_CodEtiqueta);
               A216TTBUS14_NroSerie = cgiGet( edtTTBUS14_NroSerie_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216TTBUS14_NroSerie", A216TTBUS14_NroSerie);
               /* Read saved values. */
               Z213TTBUS14_CodResponsable = cgiGet( "Z213TTBUS14_CodResponsable") ;
               Z201TTBUS14_IdBien = (int)(context.localUtil.CToN( cgiGet( "Z201TTBUS14_IdBien"), ",", ".")) ;
               Z209TTBUS14_Responsable = cgiGet( "Z209TTBUS14_Responsable") ;
               Z202TTBUS14_Descripcion = cgiGet( "Z202TTBUS14_Descripcion") ;
               Z214TTBUS14_CodRubro = (short)(context.localUtil.CToN( cgiGet( "Z214TTBUS14_CodRubro"), ",", ".")) ;
               Z203TTBUS14_Rubro = cgiGet( "Z203TTBUS14_Rubro") ;
               Z204TTBUS14_Proveedor = cgiGet( "Z204TTBUS14_Proveedor") ;
               Z205TTBUS14_FechaCarga = context.localUtil.CToD( cgiGet( "Z205TTBUS14_FechaCarga"), 0) ;
               Z206TTBUS14_FechaAdquisicion = context.localUtil.CToD( cgiGet( "Z206TTBUS14_FechaAdquisicion"), 0) ;
               Z207TTBUS14_FechaEnvio = context.localUtil.CToD( cgiGet( "Z207TTBUS14_FechaEnvio"), 0) ;
               Z208TTBUS14_Estado = (short)(context.localUtil.CToN( cgiGet( "Z208TTBUS14_Estado"), ",", ".")) ;
               Z210TTBUS14_PosDesde = cgiGet( "Z210TTBUS14_PosDesde") ;
               Z211TTBUS14_PosHacia = cgiGet( "Z211TTBUS14_PosHacia") ;
               Z212TTBUS14_MarcaEnvio = (short)(context.localUtil.CToN( cgiGet( "Z212TTBUS14_MarcaEnvio"), ",", ".")) ;
               Z217TTBUS14_Empresa = (short)(context.localUtil.CToN( cgiGet( "Z217TTBUS14_Empresa"), ",", ".")) ;
               Z215TTBUS14_CodEtiqueta = cgiGet( "Z215TTBUS14_CodEtiqueta") ;
               Z216TTBUS14_NroSerie = cgiGet( "Z216TTBUS14_NroSerie") ;
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
                  A213TTBUS14_CodResponsable = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
                  A201TTBUS14_IdBien = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
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
               InitAll0C12( ) ;
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
         edtTTBUS14_CodResponsable_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_CodResponsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_CodResponsable_Enabled), 5, 0)));
         edtTTBUS14_Responsable_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Responsable_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_Responsable_Enabled), 5, 0)));
         edtTTBUS14_IdBien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_IdBien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_IdBien_Enabled), 5, 0)));
         edtTTBUS14_Descripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_Descripcion_Enabled), 5, 0)));
         edtTTBUS14_CodRubro_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_CodRubro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_CodRubro_Enabled), 5, 0)));
         edtTTBUS14_Rubro_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Rubro_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_Rubro_Enabled), 5, 0)));
         edtTTBUS14_Proveedor_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Proveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_Proveedor_Enabled), 5, 0)));
         edtTTBUS14_FechaCarga_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_FechaCarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_FechaCarga_Enabled), 5, 0)));
         edtTTBUS14_FechaAdquisicion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_FechaAdquisicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_FechaAdquisicion_Enabled), 5, 0)));
         edtTTBUS14_FechaEnvio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_FechaEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_FechaEnvio_Enabled), 5, 0)));
         cmbTTBUS14_Estado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS14_Estado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTTBUS14_Estado.Enabled), 5, 0)));
         edtTTBUS14_PosDesde_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_PosDesde_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_PosDesde_Enabled), 5, 0)));
         edtTTBUS14_PosHacia_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_PosHacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_PosHacia_Enabled), 5, 0)));
         cmbTTBUS14_MarcaEnvio.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTTBUS14_MarcaEnvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbTTBUS14_MarcaEnvio.Enabled), 5, 0)));
         edtTTBUS14_Empresa_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_Empresa_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_Empresa_Enabled), 5, 0)));
         edtTTBUS14_CodEtiqueta_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_CodEtiqueta_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_CodEtiqueta_Enabled), 5, 0)));
         edtTTBUS14_NroSerie_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTTBUS14_NroSerie_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTTBUS14_NroSerie_Enabled), 5, 0)));
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

      protected void ResetCaption0C0( )
      {
      }

      protected void ZM0C12( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z209TTBUS14_Responsable = T000C3_A209TTBUS14_Responsable[0] ;
               Z202TTBUS14_Descripcion = T000C3_A202TTBUS14_Descripcion[0] ;
               Z214TTBUS14_CodRubro = T000C3_A214TTBUS14_CodRubro[0] ;
               Z203TTBUS14_Rubro = T000C3_A203TTBUS14_Rubro[0] ;
               Z204TTBUS14_Proveedor = T000C3_A204TTBUS14_Proveedor[0] ;
               Z205TTBUS14_FechaCarga = T000C3_A205TTBUS14_FechaCarga[0] ;
               Z206TTBUS14_FechaAdquisicion = T000C3_A206TTBUS14_FechaAdquisicion[0] ;
               Z207TTBUS14_FechaEnvio = T000C3_A207TTBUS14_FechaEnvio[0] ;
               Z208TTBUS14_Estado = T000C3_A208TTBUS14_Estado[0] ;
               Z210TTBUS14_PosDesde = T000C3_A210TTBUS14_PosDesde[0] ;
               Z211TTBUS14_PosHacia = T000C3_A211TTBUS14_PosHacia[0] ;
               Z212TTBUS14_MarcaEnvio = T000C3_A212TTBUS14_MarcaEnvio[0] ;
               Z217TTBUS14_Empresa = T000C3_A217TTBUS14_Empresa[0] ;
               Z215TTBUS14_CodEtiqueta = T000C3_A215TTBUS14_CodEtiqueta[0] ;
               Z216TTBUS14_NroSerie = T000C3_A216TTBUS14_NroSerie[0] ;
            }
            else
            {
               Z209TTBUS14_Responsable = A209TTBUS14_Responsable ;
               Z202TTBUS14_Descripcion = A202TTBUS14_Descripcion ;
               Z214TTBUS14_CodRubro = A214TTBUS14_CodRubro ;
               Z203TTBUS14_Rubro = A203TTBUS14_Rubro ;
               Z204TTBUS14_Proveedor = A204TTBUS14_Proveedor ;
               Z205TTBUS14_FechaCarga = A205TTBUS14_FechaCarga ;
               Z206TTBUS14_FechaAdquisicion = A206TTBUS14_FechaAdquisicion ;
               Z207TTBUS14_FechaEnvio = A207TTBUS14_FechaEnvio ;
               Z208TTBUS14_Estado = A208TTBUS14_Estado ;
               Z210TTBUS14_PosDesde = A210TTBUS14_PosDesde ;
               Z211TTBUS14_PosHacia = A211TTBUS14_PosHacia ;
               Z212TTBUS14_MarcaEnvio = A212TTBUS14_MarcaEnvio ;
               Z217TTBUS14_Empresa = A217TTBUS14_Empresa ;
               Z215TTBUS14_CodEtiqueta = A215TTBUS14_CodEtiqueta ;
               Z216TTBUS14_NroSerie = A216TTBUS14_NroSerie ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z213TTBUS14_CodResponsable = A213TTBUS14_CodResponsable ;
            Z201TTBUS14_IdBien = A201TTBUS14_IdBien ;
            Z209TTBUS14_Responsable = A209TTBUS14_Responsable ;
            Z202TTBUS14_Descripcion = A202TTBUS14_Descripcion ;
            Z214TTBUS14_CodRubro = A214TTBUS14_CodRubro ;
            Z203TTBUS14_Rubro = A203TTBUS14_Rubro ;
            Z204TTBUS14_Proveedor = A204TTBUS14_Proveedor ;
            Z205TTBUS14_FechaCarga = A205TTBUS14_FechaCarga ;
            Z206TTBUS14_FechaAdquisicion = A206TTBUS14_FechaAdquisicion ;
            Z207TTBUS14_FechaEnvio = A207TTBUS14_FechaEnvio ;
            Z208TTBUS14_Estado = A208TTBUS14_Estado ;
            Z210TTBUS14_PosDesde = A210TTBUS14_PosDesde ;
            Z211TTBUS14_PosHacia = A211TTBUS14_PosHacia ;
            Z212TTBUS14_MarcaEnvio = A212TTBUS14_MarcaEnvio ;
            Z217TTBUS14_Empresa = A217TTBUS14_Empresa ;
            Z215TTBUS14_CodEtiqueta = A215TTBUS14_CodEtiqueta ;
            Z216TTBUS14_NroSerie = A216TTBUS14_NroSerie ;
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

      protected void Load0C12( )
      {
         /* Using cursor T000C4 */
         pr_default.execute(2, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound12 = 1 ;
            A209TTBUS14_Responsable = T000C4_A209TTBUS14_Responsable[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
            A202TTBUS14_Descripcion = T000C4_A202TTBUS14_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TTBUS14_Descripcion", A202TTBUS14_Descripcion);
            A214TTBUS14_CodRubro = T000C4_A214TTBUS14_CodRubro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
            A203TTBUS14_Rubro = T000C4_A203TTBUS14_Rubro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
            A204TTBUS14_Proveedor = T000C4_A204TTBUS14_Proveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204TTBUS14_Proveedor", A204TTBUS14_Proveedor);
            A205TTBUS14_FechaCarga = T000C4_A205TTBUS14_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205TTBUS14_FechaCarga", context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"));
            A206TTBUS14_FechaAdquisicion = T000C4_A206TTBUS14_FechaAdquisicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206TTBUS14_FechaAdquisicion", context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"));
            A207TTBUS14_FechaEnvio = T000C4_A207TTBUS14_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207TTBUS14_FechaEnvio", context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"));
            n207TTBUS14_FechaEnvio = T000C4_n207TTBUS14_FechaEnvio[0] ;
            A208TTBUS14_Estado = T000C4_A208TTBUS14_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208TTBUS14_Estado", StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0));
            A210TTBUS14_PosDesde = T000C4_A210TTBUS14_PosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210TTBUS14_PosDesde", A210TTBUS14_PosDesde);
            n210TTBUS14_PosDesde = T000C4_n210TTBUS14_PosDesde[0] ;
            A211TTBUS14_PosHacia = T000C4_A211TTBUS14_PosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211TTBUS14_PosHacia", A211TTBUS14_PosHacia);
            n211TTBUS14_PosHacia = T000C4_n211TTBUS14_PosHacia[0] ;
            A212TTBUS14_MarcaEnvio = T000C4_A212TTBUS14_MarcaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212TTBUS14_MarcaEnvio", StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0));
            A217TTBUS14_Empresa = T000C4_A217TTBUS14_Empresa[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217TTBUS14_Empresa", StringUtil.Str( (decimal)(A217TTBUS14_Empresa), 1, 0));
            A215TTBUS14_CodEtiqueta = T000C4_A215TTBUS14_CodEtiqueta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215TTBUS14_CodEtiqueta", A215TTBUS14_CodEtiqueta);
            A216TTBUS14_NroSerie = T000C4_A216TTBUS14_NroSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216TTBUS14_NroSerie", A216TTBUS14_NroSerie);
            ZM0C12( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0C12( ) ;
      }

      protected void OnLoadActions0C12( )
      {
      }

      protected void CheckExtendedTable0C12( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A205TTBUS14_FechaCarga) || ( A205TTBUS14_FechaCarga >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de carga fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A206TTBUS14_FechaAdquisicion) || ( A206TTBUS14_FechaAdquisicion >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de adquisición fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A207TTBUS14_FechaEnvio) || ( A207TTBUS14_FechaEnvio >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha de envío fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors0C12( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound12 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey0C12( )
      {
         /* Using cursor T000C5 */
         pr_default.execute(3, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound12 = 1 ;
         }
         else
         {
            RcdFound12 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000C3 */
         pr_default.execute(1, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C12( 4) ;
            RcdFound12 = 1 ;
            A213TTBUS14_CodResponsable = T000C3_A213TTBUS14_CodResponsable[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
            A201TTBUS14_IdBien = T000C3_A201TTBUS14_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
            A209TTBUS14_Responsable = T000C3_A209TTBUS14_Responsable[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
            A202TTBUS14_Descripcion = T000C3_A202TTBUS14_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TTBUS14_Descripcion", A202TTBUS14_Descripcion);
            A214TTBUS14_CodRubro = T000C3_A214TTBUS14_CodRubro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
            A203TTBUS14_Rubro = T000C3_A203TTBUS14_Rubro[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
            A204TTBUS14_Proveedor = T000C3_A204TTBUS14_Proveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204TTBUS14_Proveedor", A204TTBUS14_Proveedor);
            A205TTBUS14_FechaCarga = T000C3_A205TTBUS14_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205TTBUS14_FechaCarga", context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"));
            A206TTBUS14_FechaAdquisicion = T000C3_A206TTBUS14_FechaAdquisicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206TTBUS14_FechaAdquisicion", context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"));
            A207TTBUS14_FechaEnvio = T000C3_A207TTBUS14_FechaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207TTBUS14_FechaEnvio", context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"));
            n207TTBUS14_FechaEnvio = T000C3_n207TTBUS14_FechaEnvio[0] ;
            A208TTBUS14_Estado = T000C3_A208TTBUS14_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208TTBUS14_Estado", StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0));
            A210TTBUS14_PosDesde = T000C3_A210TTBUS14_PosDesde[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210TTBUS14_PosDesde", A210TTBUS14_PosDesde);
            n210TTBUS14_PosDesde = T000C3_n210TTBUS14_PosDesde[0] ;
            A211TTBUS14_PosHacia = T000C3_A211TTBUS14_PosHacia[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211TTBUS14_PosHacia", A211TTBUS14_PosHacia);
            n211TTBUS14_PosHacia = T000C3_n211TTBUS14_PosHacia[0] ;
            A212TTBUS14_MarcaEnvio = T000C3_A212TTBUS14_MarcaEnvio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212TTBUS14_MarcaEnvio", StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0));
            A217TTBUS14_Empresa = T000C3_A217TTBUS14_Empresa[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217TTBUS14_Empresa", StringUtil.Str( (decimal)(A217TTBUS14_Empresa), 1, 0));
            A215TTBUS14_CodEtiqueta = T000C3_A215TTBUS14_CodEtiqueta[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215TTBUS14_CodEtiqueta", A215TTBUS14_CodEtiqueta);
            A216TTBUS14_NroSerie = T000C3_A216TTBUS14_NroSerie[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216TTBUS14_NroSerie", A216TTBUS14_NroSerie);
            Z213TTBUS14_CodResponsable = A213TTBUS14_CodResponsable ;
            Z201TTBUS14_IdBien = A201TTBUS14_IdBien ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0C12( ) ;
            Gx_mode = sMode12 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound12 = 0 ;
            InitializeNonKey0C12( ) ;
            sMode12 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode12 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C12( ) ;
         if ( RcdFound12 == 0 )
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
         RcdFound12 = 0 ;
         /* Using cursor T000C6 */
         pr_default.execute(4, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000C6_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) < 0 ) || ( StringUtil.StrCmp(T000C6_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( T000C6_A201TTBUS14_IdBien[0] < A201TTBUS14_IdBien ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T000C6_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) > 0 ) || ( StringUtil.StrCmp(T000C6_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( T000C6_A201TTBUS14_IdBien[0] > A201TTBUS14_IdBien ) ) )
            {
               A213TTBUS14_CodResponsable = T000C6_A213TTBUS14_CodResponsable[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
               A201TTBUS14_IdBien = T000C6_A201TTBUS14_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0 ;
         /* Using cursor T000C7 */
         pr_default.execute(5, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000C7_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) > 0 ) || ( StringUtil.StrCmp(T000C7_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( T000C7_A201TTBUS14_IdBien[0] > A201TTBUS14_IdBien ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T000C7_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) < 0 ) || ( StringUtil.StrCmp(T000C7_A213TTBUS14_CodResponsable[0], A213TTBUS14_CodResponsable) == 0 ) && ( T000C7_A201TTBUS14_IdBien[0] < A201TTBUS14_IdBien ) ) )
            {
               A213TTBUS14_CodResponsable = T000C7_A213TTBUS14_CodResponsable[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
               A201TTBUS14_IdBien = T000C7_A201TTBUS14_IdBien[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               RcdFound12 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0C12( ) ;
         if ( RcdFound12 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "TTBUS14_CODRESPONSABLE");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( ( StringUtil.StrCmp(A213TTBUS14_CodResponsable, Z213TTBUS14_CodResponsable) != 0 ) || ( A201TTBUS14_IdBien != Z201TTBUS14_IdBien ) )
            {
               A213TTBUS14_CodResponsable = Z213TTBUS14_CodResponsable ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
               A201TTBUS14_IdBien = Z201TTBUS14_IdBien ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "TTBUS14_CODRESPONSABLE");
               AnyError = 1 ;
               GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0C12( ) ;
               GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( ( StringUtil.StrCmp(A213TTBUS14_CodResponsable, Z213TTBUS14_CodResponsable) != 0 ) || ( A201TTBUS14_IdBien != Z201TTBUS14_IdBien ) )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               Insert0C12( ) ;
               GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "TTBUS14_CODRESPONSABLE");
                  AnyError = 1 ;
                  GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  Insert0C12( ) ;
                  GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( ( StringUtil.StrCmp(A213TTBUS14_CodResponsable, Z213TTBUS14_CodResponsable) != 0 ) || ( A201TTBUS14_IdBien != Z201TTBUS14_IdBien ) )
         {
            A213TTBUS14_CodResponsable = Z213TTBUS14_CodResponsable ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
            A201TTBUS14_IdBien = Z201TTBUS14_IdBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "TTBUS14_CODRESPONSABLE");
            AnyError = 1 ;
            GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtTTBUS14_CodResponsable_Internalname ;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "TTBUS14_CODRESPONSABLE");
            AnyError = 1 ;
         }
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0C12( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0C12( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
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
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0C12( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound12 != 0 )
            {
               ScanNext0C12( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0C12( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0C12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C8 */
            pr_default.execute(6, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS014_1"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z209TTBUS14_Responsable, T000C8_A209TTBUS14_Responsable[0]) != 0 ) || ( StringUtil.StrCmp(Z202TTBUS14_Descripcion, T000C8_A202TTBUS14_Descripcion[0]) != 0 ) || ( Z214TTBUS14_CodRubro != T000C8_A214TTBUS14_CodRubro[0] ) || ( StringUtil.StrCmp(Z203TTBUS14_Rubro, T000C8_A203TTBUS14_Rubro[0]) != 0 ) || ( StringUtil.StrCmp(Z204TTBUS14_Proveedor, T000C8_A204TTBUS14_Proveedor[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z205TTBUS14_FechaCarga != T000C8_A205TTBUS14_FechaCarga[0] ) || ( Z206TTBUS14_FechaAdquisicion != T000C8_A206TTBUS14_FechaAdquisicion[0] ) || ( Z207TTBUS14_FechaEnvio != T000C8_A207TTBUS14_FechaEnvio[0] ) || ( Z208TTBUS14_Estado != T000C8_A208TTBUS14_Estado[0] ) || ( StringUtil.StrCmp(Z210TTBUS14_PosDesde, T000C8_A210TTBUS14_PosDesde[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z211TTBUS14_PosHacia, T000C8_A211TTBUS14_PosHacia[0]) != 0 ) || ( Z212TTBUS14_MarcaEnvio != T000C8_A212TTBUS14_MarcaEnvio[0] ) || ( Z217TTBUS14_Empresa != T000C8_A217TTBUS14_Empresa[0] ) || ( StringUtil.StrCmp(Z215TTBUS14_CodEtiqueta, T000C8_A215TTBUS14_CodEtiqueta[0]) != 0 ) || ( StringUtil.StrCmp(Z216TTBUS14_NroSerie, T000C8_A216TTBUS14_NroSerie[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"TTBUS014_1"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0C12( )
      {
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C12( 0) ;
            CheckOptimisticConcurrency0C12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C9 */
                     pr_default.execute(7, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien, A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, A206TTBUS14_FechaAdquisicion, n207TTBUS14_FechaEnvio, A207TTBUS14_FechaEnvio, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, n211TTBUS14_PosHacia, A211TTBUS14_PosHacia, A212TTBUS14_MarcaEnvio, A217TTBUS14_Empresa, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie});
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
                           ResetCaption0C0( ) ;
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
               Load0C12( ) ;
            }
            EndLevel0C12( ) ;
         }
         CloseExtendedTableCursors0C12( ) ;
      }

      protected void Update0C12( )
      {
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000C10 */
                     pr_default.execute(8, new Object[] {A209TTBUS14_Responsable, A202TTBUS14_Descripcion, A214TTBUS14_CodRubro, A203TTBUS14_Rubro, A204TTBUS14_Proveedor, A205TTBUS14_FechaCarga, A206TTBUS14_FechaAdquisicion, n207TTBUS14_FechaEnvio, A207TTBUS14_FechaEnvio, A208TTBUS14_Estado, n210TTBUS14_PosDesde, A210TTBUS14_PosDesde, n211TTBUS14_PosHacia, A211TTBUS14_PosHacia, A212TTBUS14_MarcaEnvio, A217TTBUS14_Empresa, A215TTBUS14_CodEtiqueta, A216TTBUS14_NroSerie, A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"TTBUS014_1"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0C12( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption0C0( ) ;
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
            EndLevel0C12( ) ;
         }
         CloseExtendedTableCursors0C12( ) ;
      }

      protected void DeferredUpdate0C12( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0C12( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C12( ) ;
            AfterConfirm0C12( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C12( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000C11 */
                  pr_default.execute(9, new Object[] {A213TTBUS14_CodResponsable, A201TTBUS14_IdBien});
                  pr_default.close(9);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound12 == 0 )
                        {
                           InitAll0C12( ) ;
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
                        ResetCaption0C0( ) ;
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
         sMode12 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0C12( ) ;
         Gx_mode = sMode12 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0C12( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0C12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0C12( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TTBUS014_1");
            if ( AnyError == 0 )
            {
               ConfirmValues0C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TTBUS014_1");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0C12( )
      {
         /* Using cursor T000C12 */
         pr_default.execute(10);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1 ;
            A213TTBUS14_CodResponsable = T000C12_A213TTBUS14_CodResponsable[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
            A201TTBUS14_IdBien = T000C12_A201TTBUS14_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C12( )
      {
         pr_default.readNext(10);
         RcdFound12 = 0 ;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound12 = 1 ;
            A213TTBUS14_CodResponsable = T000C12_A213TTBUS14_CodResponsable[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
            A201TTBUS14_IdBien = T000C12_A201TTBUS14_IdBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
         }
      }

      protected void ScanEnd0C12( )
      {
      }

      protected void AfterConfirm0C12( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C12( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0C12( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0C12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C12( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0C0( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("ttbus014_1.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z213TTBUS14_CodResponsable", StringUtil.RTrim( Z213TTBUS14_CodResponsable));
         GxWebStd.gx_hidden_field( context, "Z201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z201TTBUS14_IdBien), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z209TTBUS14_Responsable", StringUtil.RTrim( Z209TTBUS14_Responsable));
         GxWebStd.gx_hidden_field( context, "Z202TTBUS14_Descripcion", StringUtil.RTrim( Z202TTBUS14_Descripcion));
         GxWebStd.gx_hidden_field( context, "Z214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214TTBUS14_CodRubro), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z203TTBUS14_Rubro", StringUtil.RTrim( Z203TTBUS14_Rubro));
         GxWebStd.gx_hidden_field( context, "Z204TTBUS14_Proveedor", StringUtil.RTrim( Z204TTBUS14_Proveedor));
         GxWebStd.gx_hidden_field( context, "Z205TTBUS14_FechaCarga", context.localUtil.DToC( Z205TTBUS14_FechaCarga, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z206TTBUS14_FechaAdquisicion", context.localUtil.DToC( Z206TTBUS14_FechaAdquisicion, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z207TTBUS14_FechaEnvio", context.localUtil.DToC( Z207TTBUS14_FechaEnvio, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z208TTBUS14_Estado", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z208TTBUS14_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z210TTBUS14_PosDesde", StringUtil.RTrim( Z210TTBUS14_PosDesde));
         GxWebStd.gx_hidden_field( context, "Z211TTBUS14_PosHacia", StringUtil.RTrim( Z211TTBUS14_PosHacia));
         GxWebStd.gx_hidden_field( context, "Z212TTBUS14_MarcaEnvio", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z212TTBUS14_MarcaEnvio), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z217TTBUS14_Empresa", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z217TTBUS14_Empresa), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z215TTBUS14_CodEtiqueta", StringUtil.RTrim( Z215TTBUS14_CodEtiqueta));
         GxWebStd.gx_hidden_field( context, "Z216TTBUS14_NroSerie", StringUtil.RTrim( Z216TTBUS14_NroSerie));
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
         return "TTBUS014_1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Auxiliar para informe de bienes de uso por responsable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("ttbus014_1.aspx")  ;
      }

      protected void InitializeNonKey0C12( )
      {
         A209TTBUS14_Responsable = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209TTBUS14_Responsable", A209TTBUS14_Responsable);
         A202TTBUS14_Descripcion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202TTBUS14_Descripcion", A202TTBUS14_Descripcion);
         A214TTBUS14_CodRubro = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214TTBUS14_CodRubro", StringUtil.LTrim( StringUtil.Str( (decimal)(A214TTBUS14_CodRubro), 4, 0)));
         A203TTBUS14_Rubro = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203TTBUS14_Rubro", A203TTBUS14_Rubro);
         A204TTBUS14_Proveedor = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204TTBUS14_Proveedor", A204TTBUS14_Proveedor);
         A205TTBUS14_FechaCarga = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205TTBUS14_FechaCarga", context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999"));
         A206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206TTBUS14_FechaAdquisicion", context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999"));
         A207TTBUS14_FechaEnvio = DateTime.MinValue ;
         n207TTBUS14_FechaEnvio = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207TTBUS14_FechaEnvio", context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999"));
         n207TTBUS14_FechaEnvio = ((DateTime.MinValue==A207TTBUS14_FechaEnvio) ? true : false) ;
         A208TTBUS14_Estado = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208TTBUS14_Estado", StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0));
         A210TTBUS14_PosDesde = "" ;
         n210TTBUS14_PosDesde = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210TTBUS14_PosDesde", A210TTBUS14_PosDesde);
         n210TTBUS14_PosDesde = (String.IsNullOrEmpty(StringUtil.RTrim( A210TTBUS14_PosDesde)) ? true : false) ;
         A211TTBUS14_PosHacia = "" ;
         n211TTBUS14_PosHacia = false ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A211TTBUS14_PosHacia", A211TTBUS14_PosHacia);
         n211TTBUS14_PosHacia = (String.IsNullOrEmpty(StringUtil.RTrim( A211TTBUS14_PosHacia)) ? true : false) ;
         A212TTBUS14_MarcaEnvio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A212TTBUS14_MarcaEnvio", StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0));
         A217TTBUS14_Empresa = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217TTBUS14_Empresa", StringUtil.Str( (decimal)(A217TTBUS14_Empresa), 1, 0));
         A215TTBUS14_CodEtiqueta = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215TTBUS14_CodEtiqueta", A215TTBUS14_CodEtiqueta);
         A216TTBUS14_NroSerie = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216TTBUS14_NroSerie", A216TTBUS14_NroSerie);
      }

      protected void InitAll0C12( )
      {
         A213TTBUS14_CodResponsable = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213TTBUS14_CodResponsable", A213TTBUS14_CodResponsable);
         A201TTBUS14_IdBien = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201TTBUS14_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A201TTBUS14_IdBien), 8, 0)));
         InitializeNonKey0C12( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11472342");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("ttbus014_1.js", "?11472342");
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
         lblTextblockttbus14_codresponsable_Internalname = "TEXTBLOCKTTBUS14_CODRESPONSABLE" ;
         edtTTBUS14_CodResponsable_Internalname = "TTBUS14_CODRESPONSABLE" ;
         lblTextblockttbus14_responsable_Internalname = "TEXTBLOCKTTBUS14_RESPONSABLE" ;
         edtTTBUS14_Responsable_Internalname = "TTBUS14_RESPONSABLE" ;
         lblTextblockttbus14_idbien_Internalname = "TEXTBLOCKTTBUS14_IDBIEN" ;
         edtTTBUS14_IdBien_Internalname = "TTBUS14_IDBIEN" ;
         lblTextblockttbus14_descripcion_Internalname = "TEXTBLOCKTTBUS14_DESCRIPCION" ;
         edtTTBUS14_Descripcion_Internalname = "TTBUS14_DESCRIPCION" ;
         lblTextblockttbus14_codrubro_Internalname = "TEXTBLOCKTTBUS14_CODRUBRO" ;
         edtTTBUS14_CodRubro_Internalname = "TTBUS14_CODRUBRO" ;
         lblTextblockttbus14_rubro_Internalname = "TEXTBLOCKTTBUS14_RUBRO" ;
         edtTTBUS14_Rubro_Internalname = "TTBUS14_RUBRO" ;
         lblTextblockttbus14_proveedor_Internalname = "TEXTBLOCKTTBUS14_PROVEEDOR" ;
         edtTTBUS14_Proveedor_Internalname = "TTBUS14_PROVEEDOR" ;
         lblTextblockttbus14_fechacarga_Internalname = "TEXTBLOCKTTBUS14_FECHACARGA" ;
         edtTTBUS14_FechaCarga_Internalname = "TTBUS14_FECHACARGA" ;
         lblTextblockttbus14_fechaadquisicion_Internalname = "TEXTBLOCKTTBUS14_FECHAADQUISICION" ;
         edtTTBUS14_FechaAdquisicion_Internalname = "TTBUS14_FECHAADQUISICION" ;
         lblTextblockttbus14_fechaenvio_Internalname = "TEXTBLOCKTTBUS14_FECHAENVIO" ;
         edtTTBUS14_FechaEnvio_Internalname = "TTBUS14_FECHAENVIO" ;
         lblTextblockttbus14_estado_Internalname = "TEXTBLOCKTTBUS14_ESTADO" ;
         cmbTTBUS14_Estado_Internalname = "TTBUS14_ESTADO" ;
         lblTextblockttbus14_posdesde_Internalname = "TEXTBLOCKTTBUS14_POSDESDE" ;
         edtTTBUS14_PosDesde_Internalname = "TTBUS14_POSDESDE" ;
         lblTextblockttbus14_poshacia_Internalname = "TEXTBLOCKTTBUS14_POSHACIA" ;
         edtTTBUS14_PosHacia_Internalname = "TTBUS14_POSHACIA" ;
         lblTextblockttbus14_marcaenvio_Internalname = "TEXTBLOCKTTBUS14_MARCAENVIO" ;
         cmbTTBUS14_MarcaEnvio_Internalname = "TTBUS14_MARCAENVIO" ;
         lblTextblockttbus14_empresa_Internalname = "TEXTBLOCKTTBUS14_EMPRESA" ;
         edtTTBUS14_Empresa_Internalname = "TTBUS14_EMPRESA" ;
         lblTextblockttbus14_codetiqueta_Internalname = "TEXTBLOCKTTBUS14_CODETIQUETA" ;
         edtTTBUS14_CodEtiqueta_Internalname = "TTBUS14_CODETIQUETA" ;
         lblTextblockttbus14_nroserie_Internalname = "TEXTBLOCKTTBUS14_NROSERIE" ;
         edtTTBUS14_NroSerie_Internalname = "TTBUS14_NROSERIE" ;
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
         Form.Caption = "Auxiliar para informe de bienes de uso por responsable" ;
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
         edtTTBUS14_NroSerie_Jsonclick = "" ;
         edtTTBUS14_NroSerie_Enabled = 1 ;
         edtTTBUS14_CodEtiqueta_Jsonclick = "" ;
         edtTTBUS14_CodEtiqueta_Enabled = 1 ;
         edtTTBUS14_Empresa_Jsonclick = "" ;
         edtTTBUS14_Empresa_Enabled = 1 ;
         cmbTTBUS14_MarcaEnvio_Jsonclick = "" ;
         cmbTTBUS14_MarcaEnvio.Enabled = 1 ;
         edtTTBUS14_PosHacia_Jsonclick = "" ;
         edtTTBUS14_PosHacia_Enabled = 1 ;
         edtTTBUS14_PosDesde_Jsonclick = "" ;
         edtTTBUS14_PosDesde_Enabled = 1 ;
         cmbTTBUS14_Estado_Jsonclick = "" ;
         cmbTTBUS14_Estado.Enabled = 1 ;
         edtTTBUS14_FechaEnvio_Jsonclick = "" ;
         edtTTBUS14_FechaEnvio_Enabled = 1 ;
         edtTTBUS14_FechaAdquisicion_Jsonclick = "" ;
         edtTTBUS14_FechaAdquisicion_Enabled = 1 ;
         edtTTBUS14_FechaCarga_Jsonclick = "" ;
         edtTTBUS14_FechaCarga_Enabled = 1 ;
         edtTTBUS14_Proveedor_Jsonclick = "" ;
         edtTTBUS14_Proveedor_Enabled = 1 ;
         edtTTBUS14_Rubro_Jsonclick = "" ;
         edtTTBUS14_Rubro_Enabled = 1 ;
         edtTTBUS14_CodRubro_Jsonclick = "" ;
         edtTTBUS14_CodRubro_Enabled = 1 ;
         edtTTBUS14_Descripcion_Jsonclick = "" ;
         edtTTBUS14_Descripcion_Enabled = 1 ;
         edtTTBUS14_IdBien_Jsonclick = "" ;
         edtTTBUS14_IdBien_Enabled = 1 ;
         edtTTBUS14_Responsable_Jsonclick = "" ;
         edtTTBUS14_Responsable_Enabled = 1 ;
         edtTTBUS14_CodResponsable_Jsonclick = "" ;
         edtTTBUS14_CodResponsable_Enabled = 1 ;
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
         GX_FocusControl = edtTTBUS14_Responsable_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Ttbus14_idbien( String GX_Parm1 ,
                                        int GX_Parm2 ,
                                        String GX_Parm3 ,
                                        String GX_Parm4 ,
                                        short GX_Parm5 ,
                                        String GX_Parm6 ,
                                        String GX_Parm7 ,
                                        DateTime GX_Parm8 ,
                                        DateTime GX_Parm9 ,
                                        DateTime GX_Parm10 ,
                                        GXCombobox cmbGX_Parm11 ,
                                        String GX_Parm12 ,
                                        String GX_Parm13 ,
                                        GXCombobox cmbGX_Parm14 ,
                                        short GX_Parm15 ,
                                        String GX_Parm16 ,
                                        String GX_Parm17 )
      {
         A213TTBUS14_CodResponsable = GX_Parm1 ;
         A201TTBUS14_IdBien = GX_Parm2 ;
         A209TTBUS14_Responsable = GX_Parm3 ;
         A202TTBUS14_Descripcion = GX_Parm4 ;
         A214TTBUS14_CodRubro = GX_Parm5 ;
         A203TTBUS14_Rubro = GX_Parm6 ;
         A204TTBUS14_Proveedor = GX_Parm7 ;
         A205TTBUS14_FechaCarga = GX_Parm8 ;
         A206TTBUS14_FechaAdquisicion = GX_Parm9 ;
         A207TTBUS14_FechaEnvio = GX_Parm10 ;
         n207TTBUS14_FechaEnvio = false ;
         cmbTTBUS14_Estado = cmbGX_Parm11 ;
         A208TTBUS14_Estado = (short)(NumberUtil.Val( cmbTTBUS14_Estado.CurrentValue, ".")) ;
         cmbTTBUS14_Estado.CurrentValue = StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0) ;
         A210TTBUS14_PosDesde = GX_Parm12 ;
         n210TTBUS14_PosDesde = false ;
         A211TTBUS14_PosHacia = GX_Parm13 ;
         n211TTBUS14_PosHacia = false ;
         cmbTTBUS14_MarcaEnvio = cmbGX_Parm14 ;
         A212TTBUS14_MarcaEnvio = (short)(NumberUtil.Val( cmbTTBUS14_MarcaEnvio.CurrentValue, ".")) ;
         cmbTTBUS14_MarcaEnvio.CurrentValue = StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0) ;
         A217TTBUS14_Empresa = GX_Parm15 ;
         A215TTBUS14_CodEtiqueta = GX_Parm16 ;
         A216TTBUS14_NroSerie = GX_Parm17 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A209TTBUS14_Responsable)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A202TTBUS14_Descripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A214TTBUS14_CodRubro), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A203TTBUS14_Rubro)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A204TTBUS14_Proveedor)));
         isValidOutput.Add((Object)(context.localUtil.Format(A205TTBUS14_FechaCarga, "99/99/9999")));
         isValidOutput.Add((Object)(context.localUtil.Format(A206TTBUS14_FechaAdquisicion, "99/99/9999")));
         isValidOutput.Add((Object)(context.localUtil.Format(A207TTBUS14_FechaEnvio, "99/99/9999")));
         cmbTTBUS14_Estado.CurrentValue = StringUtil.Str( (decimal)(A208TTBUS14_Estado), 1, 0) ;
         isValidOutput.Add((Object)(cmbTTBUS14_Estado));
         isValidOutput.Add((Object)(StringUtil.RTrim( A210TTBUS14_PosDesde)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A211TTBUS14_PosHacia)));
         cmbTTBUS14_MarcaEnvio.CurrentValue = StringUtil.Str( (decimal)(A212TTBUS14_MarcaEnvio), 1, 0) ;
         isValidOutput.Add((Object)(cmbTTBUS14_MarcaEnvio));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A217TTBUS14_Empresa), 1, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( A215TTBUS14_CodEtiqueta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( A216TTBUS14_NroSerie)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z213TTBUS14_CodResponsable)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z201TTBUS14_IdBien), 8, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z209TTBUS14_Responsable)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z202TTBUS14_Descripcion)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214TTBUS14_CodRubro), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z203TTBUS14_Rubro)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z204TTBUS14_Proveedor)));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z205TTBUS14_FechaCarga, 0, "/")));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z206TTBUS14_FechaAdquisicion, 0, "/")));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z207TTBUS14_FechaEnvio, 0, "/")));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z208TTBUS14_Estado), 1, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z210TTBUS14_PosDesde)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z211TTBUS14_PosHacia)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z212TTBUS14_MarcaEnvio), 1, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z217TTBUS14_Empresa), 1, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z215TTBUS14_CodEtiqueta)));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z216TTBUS14_NroSerie)));
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
         lblTextblockttbus14_codresponsable_Jsonclick = "" ;
         A213TTBUS14_CodResponsable = "" ;
         lblTextblockttbus14_responsable_Jsonclick = "" ;
         A209TTBUS14_Responsable = "" ;
         lblTextblockttbus14_idbien_Jsonclick = "" ;
         lblTextblockttbus14_descripcion_Jsonclick = "" ;
         A202TTBUS14_Descripcion = "" ;
         lblTextblockttbus14_codrubro_Jsonclick = "" ;
         lblTextblockttbus14_rubro_Jsonclick = "" ;
         A203TTBUS14_Rubro = "" ;
         lblTextblockttbus14_proveedor_Jsonclick = "" ;
         A204TTBUS14_Proveedor = "" ;
         lblTextblockttbus14_fechacarga_Jsonclick = "" ;
         A205TTBUS14_FechaCarga = DateTime.MinValue ;
         lblTextblockttbus14_fechaadquisicion_Jsonclick = "" ;
         A206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
         lblTextblockttbus14_fechaenvio_Jsonclick = "" ;
         A207TTBUS14_FechaEnvio = DateTime.MinValue ;
         lblTextblockttbus14_estado_Jsonclick = "" ;
         lblTextblockttbus14_posdesde_Jsonclick = "" ;
         A210TTBUS14_PosDesde = "" ;
         lblTextblockttbus14_poshacia_Jsonclick = "" ;
         A211TTBUS14_PosHacia = "" ;
         lblTextblockttbus14_marcaenvio_Jsonclick = "" ;
         lblTextblockttbus14_empresa_Jsonclick = "" ;
         lblTextblockttbus14_codetiqueta_Jsonclick = "" ;
         A215TTBUS14_CodEtiqueta = "" ;
         lblTextblockttbus14_nroserie_Jsonclick = "" ;
         A216TTBUS14_NroSerie = "" ;
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
         Z213TTBUS14_CodResponsable = "" ;
         Z209TTBUS14_Responsable = "" ;
         Z202TTBUS14_Descripcion = "" ;
         Z203TTBUS14_Rubro = "" ;
         Z204TTBUS14_Proveedor = "" ;
         Z205TTBUS14_FechaCarga = DateTime.MinValue ;
         Z206TTBUS14_FechaAdquisicion = DateTime.MinValue ;
         Z207TTBUS14_FechaEnvio = DateTime.MinValue ;
         Z210TTBUS14_PosDesde = "" ;
         Z211TTBUS14_PosHacia = "" ;
         Z215TTBUS14_CodEtiqueta = "" ;
         Z216TTBUS14_NroSerie = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T000C4_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C4_A201TTBUS14_IdBien = new int[1] ;
         T000C4_A209TTBUS14_Responsable = new String[] {""} ;
         T000C4_A202TTBUS14_Descripcion = new String[] {""} ;
         T000C4_A214TTBUS14_CodRubro = new short[1] ;
         T000C4_A203TTBUS14_Rubro = new String[] {""} ;
         T000C4_A204TTBUS14_Proveedor = new String[] {""} ;
         T000C4_A205TTBUS14_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T000C4_A206TTBUS14_FechaAdquisicion = new DateTime[] {DateTime.MinValue} ;
         T000C4_A207TTBUS14_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T000C4_n207TTBUS14_FechaEnvio = new bool[] {false} ;
         T000C4_A208TTBUS14_Estado = new short[1] ;
         T000C4_A210TTBUS14_PosDesde = new String[] {""} ;
         T000C4_n210TTBUS14_PosDesde = new bool[] {false} ;
         T000C4_A211TTBUS14_PosHacia = new String[] {""} ;
         T000C4_n211TTBUS14_PosHacia = new bool[] {false} ;
         T000C4_A212TTBUS14_MarcaEnvio = new short[1] ;
         T000C4_A217TTBUS14_Empresa = new short[1] ;
         T000C4_A215TTBUS14_CodEtiqueta = new String[] {""} ;
         T000C4_A216TTBUS14_NroSerie = new String[] {""} ;
         T000C5_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C5_A201TTBUS14_IdBien = new int[1] ;
         T000C3_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C3_A201TTBUS14_IdBien = new int[1] ;
         T000C3_A209TTBUS14_Responsable = new String[] {""} ;
         T000C3_A202TTBUS14_Descripcion = new String[] {""} ;
         T000C3_A214TTBUS14_CodRubro = new short[1] ;
         T000C3_A203TTBUS14_Rubro = new String[] {""} ;
         T000C3_A204TTBUS14_Proveedor = new String[] {""} ;
         T000C3_A205TTBUS14_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T000C3_A206TTBUS14_FechaAdquisicion = new DateTime[] {DateTime.MinValue} ;
         T000C3_A207TTBUS14_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T000C3_n207TTBUS14_FechaEnvio = new bool[] {false} ;
         T000C3_A208TTBUS14_Estado = new short[1] ;
         T000C3_A210TTBUS14_PosDesde = new String[] {""} ;
         T000C3_n210TTBUS14_PosDesde = new bool[] {false} ;
         T000C3_A211TTBUS14_PosHacia = new String[] {""} ;
         T000C3_n211TTBUS14_PosHacia = new bool[] {false} ;
         T000C3_A212TTBUS14_MarcaEnvio = new short[1] ;
         T000C3_A217TTBUS14_Empresa = new short[1] ;
         T000C3_A215TTBUS14_CodEtiqueta = new String[] {""} ;
         T000C3_A216TTBUS14_NroSerie = new String[] {""} ;
         sMode12 = "" ;
         T000C6_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C6_A201TTBUS14_IdBien = new int[1] ;
         T000C7_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C7_A201TTBUS14_IdBien = new int[1] ;
         T000C8_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C8_A201TTBUS14_IdBien = new int[1] ;
         T000C8_A209TTBUS14_Responsable = new String[] {""} ;
         T000C8_A202TTBUS14_Descripcion = new String[] {""} ;
         T000C8_A214TTBUS14_CodRubro = new short[1] ;
         T000C8_A203TTBUS14_Rubro = new String[] {""} ;
         T000C8_A204TTBUS14_Proveedor = new String[] {""} ;
         T000C8_A205TTBUS14_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         T000C8_A206TTBUS14_FechaAdquisicion = new DateTime[] {DateTime.MinValue} ;
         T000C8_A207TTBUS14_FechaEnvio = new DateTime[] {DateTime.MinValue} ;
         T000C8_n207TTBUS14_FechaEnvio = new bool[] {false} ;
         T000C8_A208TTBUS14_Estado = new short[1] ;
         T000C8_A210TTBUS14_PosDesde = new String[] {""} ;
         T000C8_n210TTBUS14_PosDesde = new bool[] {false} ;
         T000C8_A211TTBUS14_PosHacia = new String[] {""} ;
         T000C8_n211TTBUS14_PosHacia = new bool[] {false} ;
         T000C8_A212TTBUS14_MarcaEnvio = new short[1] ;
         T000C8_A217TTBUS14_Empresa = new short[1] ;
         T000C8_A215TTBUS14_CodEtiqueta = new String[] {""} ;
         T000C8_A216TTBUS14_NroSerie = new String[] {""} ;
         T000C12_A213TTBUS14_CodResponsable = new String[] {""} ;
         T000C12_A201TTBUS14_IdBien = new int[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ttbus014_1__default(),
            new Object[][] {
                new Object[] {
               T000C2_A213TTBUS14_CodResponsable, T000C2_A201TTBUS14_IdBien, T000C2_A209TTBUS14_Responsable, T000C2_A202TTBUS14_Descripcion, T000C2_A214TTBUS14_CodRubro, T000C2_A203TTBUS14_Rubro, T000C2_A204TTBUS14_Proveedor, T000C2_A205TTBUS14_FechaCarga, T000C2_A206TTBUS14_FechaAdquisicion, T000C2_A207TTBUS14_FechaEnvio,
               T000C2_n207TTBUS14_FechaEnvio, T000C2_A208TTBUS14_Estado, T000C2_A210TTBUS14_PosDesde, T000C2_n210TTBUS14_PosDesde, T000C2_A211TTBUS14_PosHacia, T000C2_n211TTBUS14_PosHacia, T000C2_A212TTBUS14_MarcaEnvio, T000C2_A217TTBUS14_Empresa, T000C2_A215TTBUS14_CodEtiqueta, T000C2_A216TTBUS14_NroSerie
               }
               , new Object[] {
               T000C3_A213TTBUS14_CodResponsable, T000C3_A201TTBUS14_IdBien, T000C3_A209TTBUS14_Responsable, T000C3_A202TTBUS14_Descripcion, T000C3_A214TTBUS14_CodRubro, T000C3_A203TTBUS14_Rubro, T000C3_A204TTBUS14_Proveedor, T000C3_A205TTBUS14_FechaCarga, T000C3_A206TTBUS14_FechaAdquisicion, T000C3_A207TTBUS14_FechaEnvio,
               T000C3_n207TTBUS14_FechaEnvio, T000C3_A208TTBUS14_Estado, T000C3_A210TTBUS14_PosDesde, T000C3_n210TTBUS14_PosDesde, T000C3_A211TTBUS14_PosHacia, T000C3_n211TTBUS14_PosHacia, T000C3_A212TTBUS14_MarcaEnvio, T000C3_A217TTBUS14_Empresa, T000C3_A215TTBUS14_CodEtiqueta, T000C3_A216TTBUS14_NroSerie
               }
               , new Object[] {
               T000C4_A213TTBUS14_CodResponsable, T000C4_A201TTBUS14_IdBien, T000C4_A209TTBUS14_Responsable, T000C4_A202TTBUS14_Descripcion, T000C4_A214TTBUS14_CodRubro, T000C4_A203TTBUS14_Rubro, T000C4_A204TTBUS14_Proveedor, T000C4_A205TTBUS14_FechaCarga, T000C4_A206TTBUS14_FechaAdquisicion, T000C4_A207TTBUS14_FechaEnvio,
               T000C4_n207TTBUS14_FechaEnvio, T000C4_A208TTBUS14_Estado, T000C4_A210TTBUS14_PosDesde, T000C4_n210TTBUS14_PosDesde, T000C4_A211TTBUS14_PosHacia, T000C4_n211TTBUS14_PosHacia, T000C4_A212TTBUS14_MarcaEnvio, T000C4_A217TTBUS14_Empresa, T000C4_A215TTBUS14_CodEtiqueta, T000C4_A216TTBUS14_NroSerie
               }
               , new Object[] {
               T000C5_A213TTBUS14_CodResponsable, T000C5_A201TTBUS14_IdBien
               }
               , new Object[] {
               T000C6_A213TTBUS14_CodResponsable, T000C6_A201TTBUS14_IdBien
               }
               , new Object[] {
               T000C7_A213TTBUS14_CodResponsable, T000C7_A201TTBUS14_IdBien
               }
               , new Object[] {
               T000C8_A213TTBUS14_CodResponsable, T000C8_A201TTBUS14_IdBien, T000C8_A209TTBUS14_Responsable, T000C8_A202TTBUS14_Descripcion, T000C8_A214TTBUS14_CodRubro, T000C8_A203TTBUS14_Rubro, T000C8_A204TTBUS14_Proveedor, T000C8_A205TTBUS14_FechaCarga, T000C8_A206TTBUS14_FechaAdquisicion, T000C8_A207TTBUS14_FechaEnvio,
               T000C8_n207TTBUS14_FechaEnvio, T000C8_A208TTBUS14_Estado, T000C8_A210TTBUS14_PosDesde, T000C8_n210TTBUS14_PosDesde, T000C8_A211TTBUS14_PosHacia, T000C8_n211TTBUS14_PosHacia, T000C8_A212TTBUS14_MarcaEnvio, T000C8_A217TTBUS14_Empresa, T000C8_A215TTBUS14_CodEtiqueta, T000C8_A216TTBUS14_NroSerie
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C12_A213TTBUS14_CodResponsable, T000C12_A201TTBUS14_IdBien
               }
            }
         );
      }

      private short RcdFound12 ;
      private short GxWebError ;
      private short A208TTBUS14_Estado ;
      private short A212TTBUS14_MarcaEnvio ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A214TTBUS14_CodRubro ;
      private short A217TTBUS14_Empresa ;
      private short Z214TTBUS14_CodRubro ;
      private short Z208TTBUS14_Estado ;
      private short Z212TTBUS14_MarcaEnvio ;
      private short Z217TTBUS14_Empresa ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtTTBUS14_CodResponsable_Enabled ;
      private int edtTTBUS14_Responsable_Enabled ;
      private int A201TTBUS14_IdBien ;
      private int edtTTBUS14_IdBien_Enabled ;
      private int edtTTBUS14_Descripcion_Enabled ;
      private int edtTTBUS14_CodRubro_Enabled ;
      private int edtTTBUS14_Rubro_Enabled ;
      private int edtTTBUS14_Proveedor_Enabled ;
      private int edtTTBUS14_FechaCarga_Enabled ;
      private int edtTTBUS14_FechaAdquisicion_Enabled ;
      private int edtTTBUS14_FechaEnvio_Enabled ;
      private int edtTTBUS14_PosDesde_Enabled ;
      private int edtTTBUS14_PosHacia_Enabled ;
      private int edtTTBUS14_Empresa_Enabled ;
      private int edtTTBUS14_CodEtiqueta_Enabled ;
      private int edtTTBUS14_NroSerie_Enabled ;
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
      private int Z201TTBUS14_IdBien ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtTTBUS14_CodResponsable_Internalname ;
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
      private String lblTextblockttbus14_codresponsable_Internalname ;
      private String lblTextblockttbus14_codresponsable_Jsonclick ;
      private String A213TTBUS14_CodResponsable ;
      private String edtTTBUS14_CodResponsable_Jsonclick ;
      private String lblTextblockttbus14_responsable_Internalname ;
      private String lblTextblockttbus14_responsable_Jsonclick ;
      private String edtTTBUS14_Responsable_Internalname ;
      private String A209TTBUS14_Responsable ;
      private String edtTTBUS14_Responsable_Jsonclick ;
      private String lblTextblockttbus14_idbien_Internalname ;
      private String lblTextblockttbus14_idbien_Jsonclick ;
      private String edtTTBUS14_IdBien_Internalname ;
      private String edtTTBUS14_IdBien_Jsonclick ;
      private String lblTextblockttbus14_descripcion_Internalname ;
      private String lblTextblockttbus14_descripcion_Jsonclick ;
      private String edtTTBUS14_Descripcion_Internalname ;
      private String edtTTBUS14_Descripcion_Jsonclick ;
      private String lblTextblockttbus14_codrubro_Internalname ;
      private String lblTextblockttbus14_codrubro_Jsonclick ;
      private String edtTTBUS14_CodRubro_Internalname ;
      private String edtTTBUS14_CodRubro_Jsonclick ;
      private String lblTextblockttbus14_rubro_Internalname ;
      private String lblTextblockttbus14_rubro_Jsonclick ;
      private String edtTTBUS14_Rubro_Internalname ;
      private String A203TTBUS14_Rubro ;
      private String edtTTBUS14_Rubro_Jsonclick ;
      private String lblTextblockttbus14_proveedor_Internalname ;
      private String lblTextblockttbus14_proveedor_Jsonclick ;
      private String edtTTBUS14_Proveedor_Internalname ;
      private String A204TTBUS14_Proveedor ;
      private String edtTTBUS14_Proveedor_Jsonclick ;
      private String lblTextblockttbus14_fechacarga_Internalname ;
      private String lblTextblockttbus14_fechacarga_Jsonclick ;
      private String edtTTBUS14_FechaCarga_Internalname ;
      private String edtTTBUS14_FechaCarga_Jsonclick ;
      private String lblTextblockttbus14_fechaadquisicion_Internalname ;
      private String lblTextblockttbus14_fechaadquisicion_Jsonclick ;
      private String edtTTBUS14_FechaAdquisicion_Internalname ;
      private String edtTTBUS14_FechaAdquisicion_Jsonclick ;
      private String lblTextblockttbus14_fechaenvio_Internalname ;
      private String lblTextblockttbus14_fechaenvio_Jsonclick ;
      private String edtTTBUS14_FechaEnvio_Internalname ;
      private String edtTTBUS14_FechaEnvio_Jsonclick ;
      private String lblTextblockttbus14_estado_Internalname ;
      private String lblTextblockttbus14_estado_Jsonclick ;
      private String cmbTTBUS14_Estado_Internalname ;
      private String cmbTTBUS14_Estado_Jsonclick ;
      private String lblTextblockttbus14_posdesde_Internalname ;
      private String lblTextblockttbus14_posdesde_Jsonclick ;
      private String edtTTBUS14_PosDesde_Internalname ;
      private String A210TTBUS14_PosDesde ;
      private String edtTTBUS14_PosDesde_Jsonclick ;
      private String lblTextblockttbus14_poshacia_Internalname ;
      private String lblTextblockttbus14_poshacia_Jsonclick ;
      private String edtTTBUS14_PosHacia_Internalname ;
      private String A211TTBUS14_PosHacia ;
      private String edtTTBUS14_PosHacia_Jsonclick ;
      private String lblTextblockttbus14_marcaenvio_Internalname ;
      private String lblTextblockttbus14_marcaenvio_Jsonclick ;
      private String cmbTTBUS14_MarcaEnvio_Internalname ;
      private String cmbTTBUS14_MarcaEnvio_Jsonclick ;
      private String lblTextblockttbus14_empresa_Internalname ;
      private String lblTextblockttbus14_empresa_Jsonclick ;
      private String edtTTBUS14_Empresa_Internalname ;
      private String edtTTBUS14_Empresa_Jsonclick ;
      private String lblTextblockttbus14_codetiqueta_Internalname ;
      private String lblTextblockttbus14_codetiqueta_Jsonclick ;
      private String edtTTBUS14_CodEtiqueta_Internalname ;
      private String edtTTBUS14_CodEtiqueta_Jsonclick ;
      private String lblTextblockttbus14_nroserie_Internalname ;
      private String lblTextblockttbus14_nroserie_Jsonclick ;
      private String edtTTBUS14_NroSerie_Internalname ;
      private String edtTTBUS14_NroSerie_Jsonclick ;
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
      private String Z213TTBUS14_CodResponsable ;
      private String Z209TTBUS14_Responsable ;
      private String Z203TTBUS14_Rubro ;
      private String Z204TTBUS14_Proveedor ;
      private String Z210TTBUS14_PosDesde ;
      private String Z211TTBUS14_PosHacia ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode12 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private DateTime A205TTBUS14_FechaCarga ;
      private DateTime A206TTBUS14_FechaAdquisicion ;
      private DateTime A207TTBUS14_FechaEnvio ;
      private DateTime Z205TTBUS14_FechaCarga ;
      private DateTime Z206TTBUS14_FechaAdquisicion ;
      private DateTime Z207TTBUS14_FechaEnvio ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool n207TTBUS14_FechaEnvio ;
      private bool n210TTBUS14_PosDesde ;
      private bool n211TTBUS14_PosHacia ;
      private bool Gx_longc ;
      private String A202TTBUS14_Descripcion ;
      private String A215TTBUS14_CodEtiqueta ;
      private String A216TTBUS14_NroSerie ;
      private String Z202TTBUS14_Descripcion ;
      private String Z215TTBUS14_CodEtiqueta ;
      private String Z216TTBUS14_NroSerie ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbTTBUS14_Estado ;
      private GXCombobox cmbTTBUS14_MarcaEnvio ;
      private IDataStoreProvider pr_default ;
      private String[] T000C4_A213TTBUS14_CodResponsable ;
      private int[] T000C4_A201TTBUS14_IdBien ;
      private String[] T000C4_A209TTBUS14_Responsable ;
      private String[] T000C4_A202TTBUS14_Descripcion ;
      private short[] T000C4_A214TTBUS14_CodRubro ;
      private String[] T000C4_A203TTBUS14_Rubro ;
      private String[] T000C4_A204TTBUS14_Proveedor ;
      private DateTime[] T000C4_A205TTBUS14_FechaCarga ;
      private DateTime[] T000C4_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] T000C4_A207TTBUS14_FechaEnvio ;
      private bool[] T000C4_n207TTBUS14_FechaEnvio ;
      private short[] T000C4_A208TTBUS14_Estado ;
      private String[] T000C4_A210TTBUS14_PosDesde ;
      private bool[] T000C4_n210TTBUS14_PosDesde ;
      private String[] T000C4_A211TTBUS14_PosHacia ;
      private bool[] T000C4_n211TTBUS14_PosHacia ;
      private short[] T000C4_A212TTBUS14_MarcaEnvio ;
      private short[] T000C4_A217TTBUS14_Empresa ;
      private String[] T000C4_A215TTBUS14_CodEtiqueta ;
      private String[] T000C4_A216TTBUS14_NroSerie ;
      private String[] T000C5_A213TTBUS14_CodResponsable ;
      private int[] T000C5_A201TTBUS14_IdBien ;
      private String[] T000C3_A213TTBUS14_CodResponsable ;
      private int[] T000C3_A201TTBUS14_IdBien ;
      private String[] T000C3_A209TTBUS14_Responsable ;
      private String[] T000C3_A202TTBUS14_Descripcion ;
      private short[] T000C3_A214TTBUS14_CodRubro ;
      private String[] T000C3_A203TTBUS14_Rubro ;
      private String[] T000C3_A204TTBUS14_Proveedor ;
      private DateTime[] T000C3_A205TTBUS14_FechaCarga ;
      private DateTime[] T000C3_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] T000C3_A207TTBUS14_FechaEnvio ;
      private bool[] T000C3_n207TTBUS14_FechaEnvio ;
      private short[] T000C3_A208TTBUS14_Estado ;
      private String[] T000C3_A210TTBUS14_PosDesde ;
      private bool[] T000C3_n210TTBUS14_PosDesde ;
      private String[] T000C3_A211TTBUS14_PosHacia ;
      private bool[] T000C3_n211TTBUS14_PosHacia ;
      private short[] T000C3_A212TTBUS14_MarcaEnvio ;
      private short[] T000C3_A217TTBUS14_Empresa ;
      private String[] T000C3_A215TTBUS14_CodEtiqueta ;
      private String[] T000C3_A216TTBUS14_NroSerie ;
      private String[] T000C6_A213TTBUS14_CodResponsable ;
      private int[] T000C6_A201TTBUS14_IdBien ;
      private String[] T000C7_A213TTBUS14_CodResponsable ;
      private int[] T000C7_A201TTBUS14_IdBien ;
      private String[] T000C8_A213TTBUS14_CodResponsable ;
      private int[] T000C8_A201TTBUS14_IdBien ;
      private String[] T000C8_A209TTBUS14_Responsable ;
      private String[] T000C8_A202TTBUS14_Descripcion ;
      private short[] T000C8_A214TTBUS14_CodRubro ;
      private String[] T000C8_A203TTBUS14_Rubro ;
      private String[] T000C8_A204TTBUS14_Proveedor ;
      private DateTime[] T000C8_A205TTBUS14_FechaCarga ;
      private DateTime[] T000C8_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] T000C8_A207TTBUS14_FechaEnvio ;
      private bool[] T000C8_n207TTBUS14_FechaEnvio ;
      private short[] T000C8_A208TTBUS14_Estado ;
      private String[] T000C8_A210TTBUS14_PosDesde ;
      private bool[] T000C8_n210TTBUS14_PosDesde ;
      private String[] T000C8_A211TTBUS14_PosHacia ;
      private bool[] T000C8_n211TTBUS14_PosHacia ;
      private short[] T000C8_A212TTBUS14_MarcaEnvio ;
      private short[] T000C8_A217TTBUS14_Empresa ;
      private String[] T000C8_A215TTBUS14_CodEtiqueta ;
      private String[] T000C8_A216TTBUS14_NroSerie ;
      private String[] T000C12_A213TTBUS14_CodResponsable ;
      private int[] T000C12_A201TTBUS14_IdBien ;
      private String[] T000C2_A213TTBUS14_CodResponsable ;
      private int[] T000C2_A201TTBUS14_IdBien ;
      private String[] T000C2_A209TTBUS14_Responsable ;
      private String[] T000C2_A202TTBUS14_Descripcion ;
      private short[] T000C2_A214TTBUS14_CodRubro ;
      private String[] T000C2_A203TTBUS14_Rubro ;
      private String[] T000C2_A204TTBUS14_Proveedor ;
      private DateTime[] T000C2_A205TTBUS14_FechaCarga ;
      private DateTime[] T000C2_A206TTBUS14_FechaAdquisicion ;
      private DateTime[] T000C2_A207TTBUS14_FechaEnvio ;
      private short[] T000C2_A208TTBUS14_Estado ;
      private String[] T000C2_A210TTBUS14_PosDesde ;
      private String[] T000C2_A211TTBUS14_PosHacia ;
      private short[] T000C2_A212TTBUS14_MarcaEnvio ;
      private short[] T000C2_A217TTBUS14_Empresa ;
      private String[] T000C2_A215TTBUS14_CodEtiqueta ;
      private String[] T000C2_A216TTBUS14_NroSerie ;
      private bool[] T000C2_n207TTBUS14_FechaEnvio ;
      private bool[] T000C2_n210TTBUS14_PosDesde ;
      private bool[] T000C2_n211TTBUS14_PosHacia ;
      private GXWebForm Form ;
   }

   public class ttbus014_1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT000C2 ;
          prmT000C2 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C4 ;
          prmT000C4 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C5 ;
          prmT000C5 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C3 ;
          prmT000C3 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C6 ;
          prmT000C6 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C7 ;
          prmT000C7 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C8 ;
          prmT000C8 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C9 ;
          prmT000C9 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaAdquisicion",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaEnvio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_PosHacia",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_Empresa",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0}
          } ;
          Object[] prmT000C10 ;
          prmT000C10 = new Object[] {
          new Object[] {"@TTBUS14_Responsable",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@TTBUS14_CodRubro",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TTBUS14_Rubro",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_Proveedor",SqlDbType.Char,30,0} ,
          new Object[] {"@TTBUS14_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaAdquisicion",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_FechaEnvio",SqlDbType.DateTime,8,0} ,
          new Object[] {"@TTBUS14_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_PosDesde",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_PosHacia",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS14_MarcaEnvio",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_Empresa",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@TTBUS14_CodEtiqueta",SqlDbType.VarChar,80,0} ,
          new Object[] {"@TTBUS14_NroSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C11 ;
          prmT000C11 = new Object[] {
          new Object[] {"@TTBUS14_CodResponsable",SqlDbType.Char,15,0} ,
          new Object[] {"@TTBUS14_IdBien",SqlDbType.Int,8,0}
          } ;
          Object[] prmT000C12 ;
          prmT000C12 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T000C2", "SELECT [TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_Empresa], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie] FROM [TTBUS014_1] WITH (UPDLOCK) WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C2,1,0,true,false )
             ,new CursorDef("T000C3", "SELECT [TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_Empresa], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie] FROM [TTBUS014_1] WITH (NOLOCK) WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C3,1,0,true,false )
             ,new CursorDef("T000C4", "SELECT TM1.[TTBUS14_CodResponsable], TM1.[TTBUS14_IdBien], TM1.[TTBUS14_Responsable], TM1.[TTBUS14_Descripcion], TM1.[TTBUS14_CodRubro], TM1.[TTBUS14_Rubro], TM1.[TTBUS14_Proveedor], TM1.[TTBUS14_FechaCarga], TM1.[TTBUS14_FechaAdquisicion], TM1.[TTBUS14_FechaEnvio], TM1.[TTBUS14_Estado], TM1.[TTBUS14_PosDesde], TM1.[TTBUS14_PosHacia], TM1.[TTBUS14_MarcaEnvio], TM1.[TTBUS14_Empresa], TM1.[TTBUS14_CodEtiqueta], TM1.[TTBUS14_NroSerie] FROM [TTBUS014_1] TM1 WITH (NOLOCK) WHERE TM1.[TTBUS14_CodResponsable] = @TTBUS14_CodResponsable and TM1.[TTBUS14_IdBien] = @TTBUS14_IdBien ORDER BY TM1.[TTBUS14_CodResponsable], TM1.[TTBUS14_IdBien]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C4,100,0,true,false )
             ,new CursorDef("T000C5", "SELECT [TTBUS14_CodResponsable], [TTBUS14_IdBien] FROM [TTBUS014_1] WITH (NOLOCK) WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C5,1,0,true,false )
             ,new CursorDef("T000C6", "SELECT TOP 1 [TTBUS14_CodResponsable], [TTBUS14_IdBien] FROM [TTBUS014_1] WITH (NOLOCK) WHERE ( [TTBUS14_CodResponsable] > @TTBUS14_CodResponsable or [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable and [TTBUS14_IdBien] > @TTBUS14_IdBien) ORDER BY [TTBUS14_CodResponsable], [TTBUS14_IdBien]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C6,1,0,true,true )
             ,new CursorDef("T000C7", "SELECT TOP 1 [TTBUS14_CodResponsable], [TTBUS14_IdBien] FROM [TTBUS014_1] WITH (NOLOCK) WHERE ( [TTBUS14_CodResponsable] < @TTBUS14_CodResponsable or [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable and [TTBUS14_IdBien] < @TTBUS14_IdBien) ORDER BY [TTBUS14_CodResponsable] DESC, [TTBUS14_IdBien] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C7,1,0,true,true )
             ,new CursorDef("T000C8", "SELECT [TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_Empresa], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie] FROM [TTBUS014_1] WITH (UPDLOCK) WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C8,1,0,true,false )
             ,new CursorDef("T000C9", "INSERT INTO [TTBUS014_1] ([TTBUS14_CodResponsable], [TTBUS14_IdBien], [TTBUS14_Responsable], [TTBUS14_Descripcion], [TTBUS14_CodRubro], [TTBUS14_Rubro], [TTBUS14_Proveedor], [TTBUS14_FechaCarga], [TTBUS14_FechaAdquisicion], [TTBUS14_FechaEnvio], [TTBUS14_Estado], [TTBUS14_PosDesde], [TTBUS14_PosHacia], [TTBUS14_MarcaEnvio], [TTBUS14_Empresa], [TTBUS14_CodEtiqueta], [TTBUS14_NroSerie]) VALUES (@TTBUS14_CodResponsable, @TTBUS14_IdBien, @TTBUS14_Responsable, @TTBUS14_Descripcion, @TTBUS14_CodRubro, @TTBUS14_Rubro, @TTBUS14_Proveedor, @TTBUS14_FechaCarga, @TTBUS14_FechaAdquisicion, @TTBUS14_FechaEnvio, @TTBUS14_Estado, @TTBUS14_PosDesde, @TTBUS14_PosHacia, @TTBUS14_MarcaEnvio, @TTBUS14_Empresa, @TTBUS14_CodEtiqueta, @TTBUS14_NroSerie)", GxErrorMask.GX_NOMASK,prmT000C9)
             ,new CursorDef("T000C10", "UPDATE [TTBUS014_1] SET [TTBUS14_Responsable]=@TTBUS14_Responsable, [TTBUS14_Descripcion]=@TTBUS14_Descripcion, [TTBUS14_CodRubro]=@TTBUS14_CodRubro, [TTBUS14_Rubro]=@TTBUS14_Rubro, [TTBUS14_Proveedor]=@TTBUS14_Proveedor, [TTBUS14_FechaCarga]=@TTBUS14_FechaCarga, [TTBUS14_FechaAdquisicion]=@TTBUS14_FechaAdquisicion, [TTBUS14_FechaEnvio]=@TTBUS14_FechaEnvio, [TTBUS14_Estado]=@TTBUS14_Estado, [TTBUS14_PosDesde]=@TTBUS14_PosDesde, [TTBUS14_PosHacia]=@TTBUS14_PosHacia, [TTBUS14_MarcaEnvio]=@TTBUS14_MarcaEnvio, [TTBUS14_Empresa]=@TTBUS14_Empresa, [TTBUS14_CodEtiqueta]=@TTBUS14_CodEtiqueta, [TTBUS14_NroSerie]=@TTBUS14_NroSerie  WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien", GxErrorMask.GX_NOMASK,prmT000C10)
             ,new CursorDef("T000C11", "DELETE FROM [TTBUS014_1]  WHERE [TTBUS14_CodResponsable] = @TTBUS14_CodResponsable AND [TTBUS14_IdBien] = @TTBUS14_IdBien", GxErrorMask.GX_NOMASK,prmT000C11)
             ,new CursorDef("T000C12", "SELECT [TTBUS14_CodResponsable], [TTBUS14_IdBien] FROM [TTBUS014_1] WITH (NOLOCK) ORDER BY [TTBUS14_CodResponsable], [TTBUS14_IdBien]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C12,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(13);
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((short[]) buf[17])[0] = rslt.getShort(15) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(17) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(13);
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((short[]) buf[17])[0] = rslt.getShort(15) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(17) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(13);
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((short[]) buf[17])[0] = rslt.getShort(15) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(17) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                break;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 30) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 30) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(10);
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                ((String[]) buf[12])[0] = rslt.getString(12, 50) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(12);
                ((String[]) buf[14])[0] = rslt.getString(13, 50) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(13);
                ((short[]) buf[16])[0] = rslt.getShort(14) ;
                ((short[]) buf[17])[0] = rslt.getShort(15) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(17) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 15) ;
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
                stmt.SetParameter(2, (int)parms[1]);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (DateTime)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(10, (DateTime)parms[10]);
                }
                stmt.SetParameter(11, (short)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 12 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 13 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[15]);
                }
                stmt.SetParameter(14, (short)parms[16]);
                stmt.SetParameter(15, (short)parms[17]);
                stmt.SetParameter(16, (String)parms[18]);
                stmt.SetParameter(17, (String)parms[19]);
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (DateTime)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[8]);
                }
                stmt.SetParameter(9, (short)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 10 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 11 , SqlDbType.Char );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[13]);
                }
                stmt.SetParameter(12, (short)parms[14]);
                stmt.SetParameter(13, (short)parms[15]);
                stmt.SetParameter(14, (String)parms[16]);
                stmt.SetParameter(15, (String)parms[17]);
                stmt.SetParameter(16, (String)parms[18]);
                stmt.SetParameter(17, (int)parms[19]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
