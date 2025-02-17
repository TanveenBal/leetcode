def subdomainVisits(cpdomains: list[str]) -> list[str]:
    domains = {}

    def visitChild(c, dom):
        if dom in domains:
            domains[dom] += c
        else:
            domains[dom] = c

        if "." in dom:
            _, new_dom = dom.split(".", 1)
            visitChild(c, new_dom)

    for cpdom in cpdomains:
        c, dom =  cpdom.split(" ")
        visitChild(int(c), dom)

    ans = []
    for dom, count in domains.items():
        ans.append(str(count) + " " + dom)

    return ans
