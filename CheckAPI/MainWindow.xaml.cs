using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RestSharp;

namespace CheckAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //template
            XmlContentRequest.Text = @"<CreateDeliveryNote>
            <User>
                <ChainID>1</ChainID>
                <Username>ATZTEST</Username>
                <Password>ATZTEST</Password>
            </User>
            <Request>
                <DeliveryNote>
                    <DeliveryType>3</DeliveryType>
                    <SourceGroup>3</SourceGroup>
                    <SourceCard>13</SourceCard>
                    <SourceName>קופה 13</SourceName>
                    <DestinationGroup>1</DestinationGroup>
                    <DestinationCard>1000</DestinationCard>
                    <DestinatioName>לקוח אינטרנט</DestinatioName>
                    <CreationStoreNo>20</CreationStoreNo>
                    <PriceList>4</PriceList>
                    <OrderStore>20</OrderStore>
                    <OrderType>3</OrderType>
                    <OrderNo>2878</OrderNo>
                    <DeliveryConfirm>true</DeliveryConfirm>
                    <Reference>18037</Reference>
                    <Published>true</Published>
                    <Comments></Comments>
                    <TotalBeforeDiscount>263.25</TotalBeforeDiscount>
                    <Discount>0</Discount>
                    <TotalBeforeVat>263.25</TotalBeforeVat>
                    <DiscountPercent>0</DiscountPercent>
                    <TotalBeforeVat></TotalBeforeVat>
                    <Vat>44.7521270962623</Vat>
                    <VatPercent>1.16999995708466</VatPercent>
                    <TotalIncludeVat>308</TotalIncludeVat>
                    <TotalItems>26</TotalItems>
                    <TotalLines>6</TotalLines>
                    <DeliveryLines>
                        <DeliveryLines>
                            <LineNo>1</LineNo>
                            <ItemDesc>פאזל ספוג צבעוני 10 קוביות - מספרים </ItemDesc>
                            <UnitPrice>11.58</UnitPrice>
                            <ItemId>1112226069001</ItemId>
                            <Qty>6</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>69.48</TotalPrice>
                            <OrderQty>6</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                        <DeliveryLines>
                            <LineNo>2</LineNo>
                            <ItemDesc>פאזל ספוג צבעוני 10 קוביות - כלי תחבורה </ItemDesc>
                            <UnitPrice>11.58</UnitPrice>
                            <ItemId>1112226069004</ItemId>
                            <Qty>6</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>69.48</TotalPrice>
                            <OrderQty>6</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                        <DeliveryLines>
                            <LineNo>3</LineNo>
                            <ItemDesc>פאזל ספוג צבעוני 10 קוביות - חיות </ItemDesc>
                            <UnitPrice>11.58</UnitPrice>
                            <ItemId>1112226069003</ItemId>
                            <Qty>6</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>69.48</TotalPrice>
                            <OrderQty>6</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                        <DeliveryLines>
                            <LineNo>4</LineNo>
                            <ItemDesc>פאזל ספוג צבעוני 10 קוביות - פירות וירק </ItemDesc>
                            <UnitPrice>11.58</UnitPrice>
                            <ItemId>1112226069002</ItemId>
                            <Qty>6</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>69.48</TotalPrice>
                            <OrderQty>6</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                        <DeliveryLines>
                            <LineNo>5</LineNo>
                            <ItemDesc>משלוח לפתח החנות לכל חלקי הארץ </ItemDesc>
                            <UnitPrice>30</UnitPrice>
                            <ItemId>1001002</ItemId>
                            <Qty>1</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>30</TotalPrice>
                            <OrderQty>1</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                        <DeliveryLines>
                            <LineNo>6</LineNo>
                            <ItemDesc>מחיר משלוח</ItemDesc>
                            <UnitPrice>0.01</UnitPrice>
                            <ItemId></ItemId>
                            <Qty>1</Qty>
                            <DiscountPercent>0</DiscountPercent>
                            <TotalPrice>0.01</TotalPrice>
                            <OrderQty>1</OrderQty>
                            <VatPercent>0</VatPercent>
                            <CreditPointsAccumPrecent>0</CreditPointsAccumPrecent>
                            <RemarkCode>0</RemarkCode>
                            <CampaignId>0</CampaignId>
                        </DeliveryLines>
                    </DeliveryLines>
                    <ExtDeliveryNoteID></ExtDeliveryNoteID>
                </DeliveryNote>
            </Request>
        </CreateDeliveryNote>";
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            XmlResponse.Text = "loading...";
            BtnSend.IsEnabled = false;
            LblRunTime.Content = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var client = new RestClient(ServerUrl.Text);
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("soapaction", "\"http://tempuri.org/"+MethodAPI.Text+"\"");
            request.AddHeader("content-type", "text/xml; charset=utf-8");
            request.AddParameter("text/xml; charset=utf-8", "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\">\r\n   <soapenv:Body xmlns=\"http://tempuri.org/\">\r\n "+ XmlContentRequest.Text  +"</soapenv:Body>\r\n</soapenv:Envelope>", ParameterType.RequestBody);
            var cancellationTokenSource = new CancellationTokenSource();
            IRestResponse response = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            XmlResponse.Text = response.StatusCode.ToString() + response.Content.ToString();
            stopwatch.Stop();
            var timePassed = stopwatch.ElapsedMilliseconds / 1000;
            LblRunTime.Content = "Time:"+ timePassed.ToString()+"s";
            BtnSend.IsEnabled = true;
        }

        private void MethodAPI_LostFocus(object sender, RoutedEventArgs e)
        {
            if (File.Exists(MethodAPI.Text + ".txt"))
            {
                string text = "";
                try
                {
                    text = File.ReadAllText(MethodAPI.Text + ".txt");
                    XmlContentRequest.Text = text;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
