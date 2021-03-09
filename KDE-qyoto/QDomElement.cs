//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDomElement")]
    public class QDomElement : QDomNode, IDisposable {
        protected QDomElement(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDomElement), this);
        }
        public QDomElement() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDomElement", "QDomElement()", typeof(void));
        }
        public QDomElement(QDomElement x) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDomElement#", "QDomElement(const QDomElement&)", typeof(void), typeof(QDomElement), x);
        }
        public string Attribute(string name, string defValue) {
            return (string) interceptor.Invoke("attribute$$", "attribute(const QString&, const QString&) const", typeof(string), typeof(string), name, typeof(string), defValue);
        }
        public string Attribute(string name) {
            return (string) interceptor.Invoke("attribute$", "attribute(const QString&) const", typeof(string), typeof(string), name);
        }
        public void SetAttribute(string name, string value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, const QString&)", typeof(void), typeof(string), name, typeof(string), value);
        }
        public void SetAttribute(string name, long value) {
            interceptor.Invoke("setAttribute$?", "setAttribute(const QString&, qlonglong)", typeof(void), typeof(string), name, typeof(long), value);
        }
        public void SetAttribute(string name, ulong value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, qulonglong)", typeof(void), typeof(string), name, typeof(ulong), value);
        }
        public void SetAttribute(string name, int value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, int)", typeof(void), typeof(string), name, typeof(int), value);
        }
        public void SetAttribute(string name, uint value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, uint)", typeof(void), typeof(string), name, typeof(uint), value);
        }
        public void SetAttribute(string name, float value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, float)", typeof(void), typeof(string), name, typeof(float), value);
        }
        public void SetAttribute(string name, double value) {
            interceptor.Invoke("setAttribute$$", "setAttribute(const QString&, double)", typeof(void), typeof(string), name, typeof(double), value);
        }
        public void RemoveAttribute(string name) {
            interceptor.Invoke("removeAttribute$", "removeAttribute(const QString&)", typeof(void), typeof(string), name);
        }
        public QDomAttr AttributeNode(string name) {
            return (QDomAttr) interceptor.Invoke("attributeNode$", "attributeNode(const QString&)", typeof(QDomAttr), typeof(string), name);
        }
        public QDomAttr SetAttributeNode(QDomAttr newAttr) {
            return (QDomAttr) interceptor.Invoke("setAttributeNode#", "setAttributeNode(const QDomAttr&)", typeof(QDomAttr), typeof(QDomAttr), newAttr);
        }
        public QDomAttr RemoveAttributeNode(QDomAttr oldAttr) {
            return (QDomAttr) interceptor.Invoke("removeAttributeNode#", "removeAttributeNode(const QDomAttr&)", typeof(QDomAttr), typeof(QDomAttr), oldAttr);
        }
        public QDomNodeList ElementsByTagName(string tagname) {
            return (QDomNodeList) interceptor.Invoke("elementsByTagName$", "elementsByTagName(const QString&) const", typeof(QDomNodeList), typeof(string), tagname);
        }
        public bool HasAttribute(string name) {
            return (bool) interceptor.Invoke("hasAttribute$", "hasAttribute(const QString&) const", typeof(bool), typeof(string), name);
        }
        public string AttributeNS(string nsURI, string localName, string defValue) {
            return (string) interceptor.Invoke("attributeNS$$$", "attributeNS(const QString, const QString&, const QString&) const", typeof(string), typeof(string), nsURI, typeof(string), localName, typeof(string), defValue);
        }
        public string AttributeNS(string nsURI, string localName) {
            return (string) interceptor.Invoke("attributeNS$$", "attributeNS(const QString, const QString&) const", typeof(string), typeof(string), nsURI, typeof(string), localName);
        }
        public void SetAttributeNS(string nsURI, string qName, string value) {
            interceptor.Invoke("setAttributeNS$$$", "setAttributeNS(const QString, const QString&, const QString&)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(string), value);
        }
        public void SetAttributeNS(string nsURI, string qName, int value) {
            interceptor.Invoke("setAttributeNS$$$", "setAttributeNS(const QString, const QString&, int)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(int), value);
        }
        public void SetAttributeNS(string nsURI, string qName, uint value) {
            interceptor.Invoke("setAttributeNS$$$", "setAttributeNS(const QString, const QString&, uint)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(uint), value);
        }
        public void SetAttributeNS(string nsURI, string qName, long value) {
            interceptor.Invoke("setAttributeNS$$?", "setAttributeNS(const QString, const QString&, qlonglong)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(long), value);
        }
        public void SetAttributeNS(string nsURI, string qName, ulong value) {
            interceptor.Invoke("setAttributeNS$$$", "setAttributeNS(const QString, const QString&, qulonglong)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(ulong), value);
        }
        public void SetAttributeNS(string nsURI, string qName, double value) {
            interceptor.Invoke("setAttributeNS$$$", "setAttributeNS(const QString, const QString&, double)", typeof(void), typeof(string), nsURI, typeof(string), qName, typeof(double), value);
        }
        public void RemoveAttributeNS(string nsURI, string localName) {
            interceptor.Invoke("removeAttributeNS$$", "removeAttributeNS(const QString&, const QString&)", typeof(void), typeof(string), nsURI, typeof(string), localName);
        }
        public QDomAttr AttributeNodeNS(string nsURI, string localName) {
            return (QDomAttr) interceptor.Invoke("attributeNodeNS$$", "attributeNodeNS(const QString&, const QString&)", typeof(QDomAttr), typeof(string), nsURI, typeof(string), localName);
        }
        public QDomAttr SetAttributeNodeNS(QDomAttr newAttr) {
            return (QDomAttr) interceptor.Invoke("setAttributeNodeNS#", "setAttributeNodeNS(const QDomAttr&)", typeof(QDomAttr), typeof(QDomAttr), newAttr);
        }
        public QDomNodeList ElementsByTagNameNS(string nsURI, string localName) {
            return (QDomNodeList) interceptor.Invoke("elementsByTagNameNS$$", "elementsByTagNameNS(const QString&, const QString&) const", typeof(QDomNodeList), typeof(string), nsURI, typeof(string), localName);
        }
        public bool HasAttributeNS(string nsURI, string localName) {
            return (bool) interceptor.Invoke("hasAttributeNS$$", "hasAttributeNS(const QString&, const QString&) const", typeof(bool), typeof(string), nsURI, typeof(string), localName);
        }
        public string TagName() {
            return (string) interceptor.Invoke("tagName", "tagName() const", typeof(string));
        }
        public void SetTagName(string name) {
            interceptor.Invoke("setTagName$", "setTagName(const QString&)", typeof(void), typeof(string), name);
        }
        public new QDomNamedNodeMap Attributes() {
            return (QDomNamedNodeMap) interceptor.Invoke("attributes", "attributes() const", typeof(QDomNamedNodeMap));
        }
        public new QDomNode.NodeType NodeType() {
            return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
        }
        public string Text() {
            return (string) interceptor.Invoke("text", "text() const", typeof(string));
        }
        ~QDomElement() {
            interceptor.Invoke("~QDomElement", "~QDomElement()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDomElement", "~QDomElement()", typeof(void));
        }
    }
}