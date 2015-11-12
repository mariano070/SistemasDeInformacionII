/*
               File: TBUS002
        Description: ACTUALIZ. DE RUBROS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:58.94
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
   public class tbus002 : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            AV7RBRCOD = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7RBRCOD", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7RBRCOD), 4, 0)));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
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
         Form.Meta.addItem("Description", "ACTUALIZ. DE RUBROS", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtRBR_COD_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public tbus002( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public tbus002( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_RBRCOD ,
                           ref String aP1_Gx_mode ,
                           ref String aP2_SISTEMA ,
                           ref String aP3_USUARIO )
      {
         this.AV7RBRCOD = aP0_RBRCOD;
         this.Gx_mode = aP1_Gx_mode;
         this.AV8SISTEMA = aP2_SISTEMA;
         this.AV9USUARIO = aP3_USUARIO;
         executePrivate();
         aP0_RBRCOD=this.AV7RBRCOD;
         aP1_Gx_mode=this.Gx_mode;
         aP2_SISTEMA=this.AV8SISTEMA;
         aP3_USUARIO=this.AV9USUARIO;
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
            wb_table1_2_1337( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_1337e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_1337( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_1337( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_1337e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+""+"</legend>") ;
            wb_table3_11_1337( true) ;
         }
         return  ;
      }

      protected void wb_table3_11_1337e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1337e( true) ;
         }
         else
         {
            wb_table1_2_1337e( false) ;
         }
      }

      protected void wb_table3_11_1337( bool wbgen )
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
            wb_table4_17_1337( true) ;
         }
         return  ;
      }

      protected void wb_table4_17_1337e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_enter_Internalname, "Confirmar", "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "rounded", 5, bttBtn_enter_Jsonclick, "EENTER.", TempTags, "", "", "HLP_TBUS002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "", "", "HLP_TBUS002.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_delete_Internalname, "Eliminar", "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "rounded", 5, bttBtn_delete_Jsonclick, "EDELETE.", TempTags, "", "", "HLP_TBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_11_1337e( true) ;
         }
         else
         {
            wb_table3_11_1337e( false) ;
         }
      }

      protected void wb_table4_17_1337( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockrbr_cod_Internalname, 1, 1, 0, "CODIGO DE RUBRO", "", "", "", 0, lblTextblockrbr_cod_Jsonclick, "", StyleString, ClassString, "HLP_TBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBR_COD_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2RBR_COD), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, edtRBR_COD_Enabled, 1, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(A2RBR_COD), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(22);\"", 0, edtRBR_COD_Jsonclick, "", 0, 1, -1, true, "right", "HLP_TBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockrbr_des_Internalname, 1, 1, 0, "DESCRIPCION DEL RUBRO", "", "", "", 0, lblTextblockrbr_des_Jsonclick, "", StyleString, ClassString, "HLP_TBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtRBR_DES_Internalname, StringUtil.RTrim( A19RBR_DES), "", 30, "chr", 1, "row", 30, 1, edtRBR_DES_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A19RBR_DES, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", 0, edtRBR_DES_Jsonclick, "", 0, 1, -1, true, "left", "HLP_TBUS002.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_17_1337e( true) ;
         }
         else
         {
            wb_table4_17_1337e( false) ;
         }
      }

      protected void wb_table2_5_1337( bool wbgen )
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
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_TBUS002.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, "", context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0110.aspx"+"',["+"{Ctrl:gx.dom.el('"+"RBR_COD"+"'), id:'"+"RBR_COD"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+","+"false"+");"+"return false;", "HLP_TBUS002.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_1337e( true) ;
         }
         else
         {
            wb_table2_5_1337e( false) ;
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
         /* Execute user event: E11132 */
         E11132 ();
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ! context.localUtil.VCNumber( cgiGet( edtRBR_COD_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtRBR_COD_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtRBR_COD_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "RBR_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBR_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A2RBR_COD = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               }
               else
               {
                  A2RBR_COD = (short)(context.localUtil.CToN( cgiGet( edtRBR_COD_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               }
               A19RBR_DES = cgiGet( edtRBR_DES_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
               /* Read saved values. */
               Z2RBR_COD = (short)(context.localUtil.CToN( cgiGet( "Z2RBR_COD"), ",", ".")) ;
               Z19RBR_DES = cgiGet( "Z19RBR_DES") ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               AV8SISTEMA = cgiGet( "vSISTEMA") ;
               AV9USUARIO = cgiGet( "vUSUARIO") ;
               AV7RBRCOD = (short)(context.localUtil.CToN( cgiGet( "vRBRCOD"), ",", ".")) ;
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
                  A2RBR_COD = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
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
                     sMode37 = Gx_mode ;
                     Gx_mode = "UPD" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Gx_mode = sMode37 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound37 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_130( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert"), 1, "RBR_COD");
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
                           /* Execute user event: E11132 */
                           E11132 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12132 */
                           E12132 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
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
            /* Execute user event: E12132 */
            E12132 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1337( ) ;
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
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtn_delete_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtn_enter_Visible = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
            }
            edtRBR_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBR_COD_Enabled), 5, 0)));
            edtRBR_DES_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_DES_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBR_DES_Enabled), 5, 0)));
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

      protected void CONFIRM_130( )
      {
         BeforeValidate1337( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1337( ) ;
            }
            else
            {
               CheckExtendedTable1337( ) ;
               CloseExtendedTableCursors1337( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void ResetCaption130( )
      {
      }

      protected void E11132( )
      {
         /* Start Routine */
      }

      protected void E12132( )
      {
         /* After Trn Routine */
      }

      protected void ZM1337( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z19RBR_DES = T00133_A19RBR_DES[0] ;
            }
            else
            {
               Z19RBR_DES = A19RBR_DES ;
            }
         }
         if ( GX_JID == -6 )
         {
            Z2RBR_COD = A2RBR_COD ;
            Z19RBR_DES = A19RBR_DES ;
         }
      }

      protected void standaloneNotModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtRBR_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBR_COD_Enabled), 5, 0)));
         }
         else
         {
            edtRBR_COD_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBR_COD_Enabled), 5, 0)));
         }
         bttBtn_delete_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            A2RBR_COD = AV7RBRCOD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtRBR_COD_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRBR_COD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRBR_COD_Enabled), 5, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1337( )
      {
         /* Using cursor T00134 */
         pr_default.execute(2, new Object[] {A2RBR_COD});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound37 = 1 ;
            A19RBR_DES = T00134_A19RBR_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
            ZM1337( -6) ;
         }
         pr_default.close(2);
         OnLoadActions1337( ) ;
      }

      protected void OnLoadActions1337( )
      {
      }

      protected void CheckExtendedTable1337( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( (0==A2RBR_COD) )
         {
            GX_msglist.addItem("El rubro debe tener una código", 1, "");
            AnyError = 1 ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A19RBR_DES)) )
         {
            GX_msglist.addItem("El rubro debe tener una descripción", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1337( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1337( )
      {
         /* Using cursor T00135 */
         pr_default.execute(3, new Object[] {A2RBR_COD});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound37 = 1 ;
         }
         else
         {
            RcdFound37 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00133 */
         pr_default.execute(1, new Object[] {A2RBR_COD});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1337( 6) ;
            RcdFound37 = 1 ;
            A2RBR_COD = T00133_A2RBR_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
            A19RBR_DES = T00133_A19RBR_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
            Z2RBR_COD = A2RBR_COD ;
            sMode37 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            Load1337( ) ;
            Gx_mode = sMode37 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound37 = 0 ;
            InitializeNonKey1337( ) ;
            sMode37 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode37 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1337( ) ;
         if ( RcdFound37 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound37 = 0 ;
         /* Using cursor T00136 */
         pr_default.execute(4, new Object[] {A2RBR_COD});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00136_A2RBR_COD[0] < A2RBR_COD ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00136_A2RBR_COD[0] > A2RBR_COD ) ) )
            {
               A2RBR_COD = T00136_A2RBR_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               RcdFound37 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound37 = 0 ;
         /* Using cursor T00137 */
         pr_default.execute(5, new Object[] {A2RBR_COD});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00137_A2RBR_COD[0] > A2RBR_COD ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00137_A2RBR_COD[0] < A2RBR_COD ) ) )
            {
               A2RBR_COD = T00137_A2RBR_COD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               RcdFound37 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey1337( ) ;
         if ( RcdFound37 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "RBR_COD");
               AnyError = 1 ;
               GX_FocusControl = edtRBR_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A2RBR_COD != Z2RBR_COD )
            {
               A2RBR_COD = Z2RBR_COD ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "RBR_COD");
               AnyError = 1 ;
               GX_FocusControl = edtRBR_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtRBR_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               /* Update record */
               Update1337( ) ;
               GX_FocusControl = edtRBR_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A2RBR_COD != Z2RBR_COD )
            {
               /* Insert record */
               Insert1337( ) ;
               GX_FocusControl = edtRBR_COD_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "RBR_COD");
                  AnyError = 1 ;
                  GX_FocusControl = edtRBR_COD_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Insert record */
                  Insert1337( ) ;
                  GX_FocusControl = edtRBR_COD_Internalname ;
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
         if ( A2RBR_COD != Z2RBR_COD )
         {
            A2RBR_COD = Z2RBR_COD ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "RBR_COD");
            AnyError = 1 ;
            GX_FocusControl = edtRBR_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtRBR_COD_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1337( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00138 */
            pr_default.execute(6, new Object[] {A2RBR_COD});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BUS002"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z19RBR_DES, T00138_A19RBR_DES[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BUS002"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1337( )
      {
         BeforeValidate1337( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1337( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1337( 0) ;
            CheckOptimisticConcurrency1337( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1337( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1337( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00139 */
                     pr_default.execute(7, new Object[] {A2RBR_COD, A19RBR_DES});
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
                           ResetCaption130( ) ;
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
               Load1337( ) ;
            }
            EndLevel1337( ) ;
         }
         CloseExtendedTableCursors1337( ) ;
      }

      protected void Update1337( )
      {
         BeforeValidate1337( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1337( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1337( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1337( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1337( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001310 */
                     pr_default.execute(8, new Object[] {A19RBR_DES, A2RBR_COD});
                     pr_default.close(8);
                     if ( (pr_default.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BUS002"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1337( ) ;
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
            EndLevel1337( ) ;
         }
         CloseExtendedTableCursors1337( ) ;
      }

      protected void DeferredUpdate1337( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1337( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1337( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1337( ) ;
            AfterConfirm1337( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1337( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001311 */
                  pr_default.execute(9, new Object[] {A2RBR_COD});
                  pr_default.close(9);
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
         sMode37 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1337( ) ;
         Gx_mode = sMode37 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1337( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001312 */
            pr_default.execute(10, new Object[] {A2RBR_COD});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Maestro de Bienes de Uso Trazabilizados"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel1337( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1337( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("TBUS002");
            if ( AnyError == 0 )
            {
               ConfirmValues130( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("TBUS002");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart1337( )
      {
         /* Using cursor T001313 */
         pr_default.execute(11);
         RcdFound37 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound37 = 1 ;
            A2RBR_COD = T001313_A2RBR_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1337( )
      {
         pr_default.readNext(11);
         RcdFound37 = 0 ;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound37 = 1 ;
            A2RBR_COD = T001313_A2RBR_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
         }
      }

      protected void ScanEnd1337( )
      {
      }

      protected void AfterConfirm1337( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1337( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1337( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1337( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1337( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1337( )
      {
         /* Before Validate Rules */
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues130( )
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tbus002.aspx") + "?" + UrlEncode("" +AV7RBRCOD) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z2RBR_COD", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2RBR_COD), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z19RBR_DES", StringUtil.RTrim( Z19RBR_DES));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV8SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV9USUARIO));
         GxWebStd.gx_hidden_field( context, "vRBRCOD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7RBRCOD), 4, 0, ",", "")));
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
         return "TBUS002" ;
      }

      public override String GetPgmdesc( )
      {
         return "ACTUALIZ. DE RUBROS" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("tbus002.aspx") + "?" + UrlEncode("" +AV7RBRCOD) + "," + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV9USUARIO)) ;
      }

      protected void InitializeNonKey1337( )
      {
         A19RBR_DES = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19RBR_DES", A19RBR_DES);
      }

      protected void InitAll1337( )
      {
         A2RBR_COD = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2RBR_COD", StringUtil.LTrim( StringUtil.Str( (decimal)(A2RBR_COD), 4, 0)));
         InitializeNonKey1337( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19295937");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("tbus002.js", "?19295937");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockrbr_cod_Internalname = "TEXTBLOCKRBR_COD" ;
         edtRBR_COD_Internalname = "RBR_COD" ;
         lblTextblockrbr_des_Internalname = "TEXTBLOCKRBR_DES" ;
         edtRBR_DES_Internalname = "RBR_DES" ;
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
         Form.Caption = "ACTUALIZ. DE RUBROS" ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         edtRBR_DES_Jsonclick = "" ;
         edtRBR_DES_Enabled = 1 ;
         edtRBR_COD_Jsonclick = "" ;
         edtRBR_COD_Enabled = 1 ;
         bttBtn_delete_Enabled = 0 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Enabled = 1 ;
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
         pr_default.close(5);
         pr_default.close(4);
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
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockrbr_cod_Jsonclick = "" ;
         lblTextblockrbr_des_Jsonclick = "" ;
         A19RBR_DES = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         Z19RBR_DES = "" ;
         sMode37 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00134_A2RBR_COD = new short[1] ;
         T00134_A19RBR_DES = new String[] {""} ;
         T00135_A2RBR_COD = new short[1] ;
         T00133_A2RBR_COD = new short[1] ;
         T00133_A19RBR_DES = new String[] {""} ;
         T00136_A2RBR_COD = new short[1] ;
         T00137_A2RBR_COD = new short[1] ;
         T00138_A2RBR_COD = new short[1] ;
         T00138_A19RBR_DES = new String[] {""} ;
         T001312_A11TTBUS_Id = new int[1] ;
         T001313_A2RBR_COD = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tbus002__default(),
            new Object[][] {
                new Object[] {
               T00132_A2RBR_COD, T00132_A19RBR_DES
               }
               , new Object[] {
               T00133_A2RBR_COD, T00133_A19RBR_DES
               }
               , new Object[] {
               T00134_A2RBR_COD, T00134_A19RBR_DES
               }
               , new Object[] {
               T00135_A2RBR_COD
               }
               , new Object[] {
               T00136_A2RBR_COD
               }
               , new Object[] {
               T00137_A2RBR_COD
               }
               , new Object[] {
               T00138_A2RBR_COD, T00138_A19RBR_DES
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001312_A11TTBUS_Id
               }
               , new Object[] {
               T001313_A2RBR_COD
               }
            }
         );
      }

      private short wcpOAV7RBRCOD ;
      private short GxWebError ;
      private short AV7RBRCOD ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A2RBR_COD ;
      private short Z2RBR_COD ;
      private short RcdFound37 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtRBR_COD_Enabled ;
      private int edtRBR_DES_Enabled ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int idxLst ;
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
      private String edtRBR_COD_Internalname ;
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
      private String lblTextblockrbr_cod_Internalname ;
      private String lblTextblockrbr_cod_Jsonclick ;
      private String edtRBR_COD_Jsonclick ;
      private String lblTextblockrbr_des_Internalname ;
      private String lblTextblockrbr_des_Jsonclick ;
      private String edtRBR_DES_Internalname ;
      private String A19RBR_DES ;
      private String edtRBR_DES_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String Z19RBR_DES ;
      private String sMode37 ;
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
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private short aP0_RBRCOD ;
      private String aP1_Gx_mode ;
      private String aP2_SISTEMA ;
      private String aP3_USUARIO ;
      private IDataStoreProvider pr_default ;
      private short[] T00134_A2RBR_COD ;
      private String[] T00134_A19RBR_DES ;
      private short[] T00135_A2RBR_COD ;
      private short[] T00133_A2RBR_COD ;
      private String[] T00133_A19RBR_DES ;
      private short[] T00136_A2RBR_COD ;
      private short[] T00137_A2RBR_COD ;
      private short[] T00138_A2RBR_COD ;
      private String[] T00138_A19RBR_DES ;
      private int[] T001312_A11TTBUS_Id ;
      private short[] T001313_A2RBR_COD ;
      private short[] T00132_A2RBR_COD ;
      private String[] T00132_A19RBR_DES ;
      private GXWebForm Form ;
   }

   public class tbus002__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00132 ;
          prmT00132 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00134 ;
          prmT00134 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00135 ;
          prmT00135 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00133 ;
          prmT00133 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00136 ;
          prmT00136 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00137 ;
          prmT00137 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00138 ;
          prmT00138 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00139 ;
          prmT00139 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@RBR_DES",SqlDbType.Char,30,0}
          } ;
          Object[] prmT001310 ;
          prmT001310 = new Object[] {
          new Object[] {"@RBR_DES",SqlDbType.Char,30,0} ,
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001311 ;
          prmT001311 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001312 ;
          prmT001312 = new Object[] {
          new Object[] {"@RBR_COD",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT001313 ;
          prmT001313 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00132", "SELECT [RBR_COD], [RBR_DES] FROM [BUS002] WITH (UPDLOCK) WHERE [RBR_COD] = @RBR_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00132,1,0,true,false )
             ,new CursorDef("T00133", "SELECT [RBR_COD], [RBR_DES] FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @RBR_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00133,1,0,true,false )
             ,new CursorDef("T00134", "SELECT TM1.[RBR_COD], TM1.[RBR_DES] FROM [BUS002] TM1 WITH (NOLOCK) WHERE TM1.[RBR_COD] = @RBR_COD ORDER BY TM1.[RBR_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00134,100,0,true,false )
             ,new CursorDef("T00135", "SELECT [RBR_COD] FROM [BUS002] WITH (NOLOCK) WHERE [RBR_COD] = @RBR_COD  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00135,1,0,true,false )
             ,new CursorDef("T00136", "SELECT TOP 1 [RBR_COD] FROM [BUS002] WITH (NOLOCK) WHERE ( [RBR_COD] > @RBR_COD) ORDER BY [RBR_COD]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00136,1,0,true,true )
             ,new CursorDef("T00137", "SELECT TOP 1 [RBR_COD] FROM [BUS002] WITH (NOLOCK) WHERE ( [RBR_COD] < @RBR_COD) ORDER BY [RBR_COD] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00137,1,0,true,true )
             ,new CursorDef("T00138", "SELECT [RBR_COD], [RBR_DES] FROM [BUS002] WITH (UPDLOCK) WHERE [RBR_COD] = @RBR_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT00138,1,0,true,false )
             ,new CursorDef("T00139", "INSERT INTO [BUS002] ([RBR_COD], [RBR_DES]) VALUES (@RBR_COD, @RBR_DES)", GxErrorMask.GX_NOMASK,prmT00139)
             ,new CursorDef("T001310", "UPDATE [BUS002] SET [RBR_DES]=@RBR_DES  WHERE [RBR_COD] = @RBR_COD", GxErrorMask.GX_NOMASK,prmT001310)
             ,new CursorDef("T001311", "DELETE FROM [BUS002]  WHERE [RBR_COD] = @RBR_COD", GxErrorMask.GX_NOMASK,prmT001311)
             ,new CursorDef("T001312", "SELECT TOP 1 [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE [TTBUS_RubroBien] = @RBR_COD ",true, GxErrorMask.GX_NOMASK, false, this,prmT001312,1,0,true,true )
             ,new CursorDef("T001313", "SELECT [RBR_COD] FROM [BUS002] WITH (NOLOCK) ORDER BY [RBR_COD]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001313,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
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
                ((String[]) buf[1])[0] = rslt.getString(2, 30) ;
                break;
             case 10 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                break;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
